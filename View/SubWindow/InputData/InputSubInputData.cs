using htv5_mixer_control.Model.SQL_Class;
using javax.xml.bind.helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static com.sun.tools.javac.util.Name;

namespace htv5_mixer_control
{
    public partial class InputSubInputData : Form
    {
        public InputSubInputData()
        {
            InitializeComponent();
        }

        private void txbInputCode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbInputCode.Text))
            {
                e.Cancel = true;
                txbInputCode.Focus();
                errorProvider.SetError(txbInputCode, "Mã quy cách không được để trống!" + Environment.NewLine + "规格代码不能为空!");
            }
            else
            {

                e.Cancel = false;
                errorProvider.SetError(txbInputCode, null);
            }
        }

        private void InputSubInputData_Load(object sender, EventArgs e)
        {
            btnAddMaterial.ButtonText = "Thêm mới" + Environment.NewLine + "添新";
            btnEditMaterial.ButtonText = "Chỉnh sửa" + Environment.NewLine + "编辑信息";
            btnDeleteMaterial.ButtonText = "Xóa bỏ" + Environment.NewLine + "删除";
            if (SaveVariables.ProcessList == null || SaveVariables.ProcessList.Rows.Count == 0)
                lbProcessNumber.Text = "1";
            btnProcessSave.ButtonText = "Thêm mới" + Environment.NewLine + "添新";
            btnProcessEdit.ButtonText = "Chỉnh sửa" + Environment.NewLine + "编辑信息";
            btnProcessDelete.ButtonText = "Xóa bỏ" + Environment.NewLine + "删除";
            btnCreateSpecification.ButtonText = "Hoàn tất tạo quy cách" + Environment.NewLine + "完成型号";
        }

        private void txbInputLotNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbInputLotNo.Text))
            {
                e.Cancel = true;
                txbInputCode.Focus();
                errorProvider.SetError(txbInputLotNo, "Số lô không được để trống!" + Environment.NewLine + "批号不能为空！");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txbInputLotNo, null);
            }
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            if (SaveVariables.MaterialList == null || SaveVariables.MaterialList.Rows.Count == 0)
                SaveVariables.addMatColumn();
            MaterialInputCRUDForm materialInputCRUDForm = new MaterialInputCRUDForm(null, 0);
            materialInputCRUDForm.FormClosing += materialInputCRUDFormClosing;
            materialInputCRUDForm.ShowDialog();
        }
        private void LoadMaterialData()
        {
            if (SaveVariables.MaterialList.Rows.Count > 0)
            {
                dtgvMaterialInfos.DataSource = null;
                dtgvMaterialInfos.DataSource = SaveVariables.MaterialList;
                dtgvMaterialInfos.Columns["uuid"].Visible = false;
                dtgvMaterialInfos.Columns["mat_name"].HeaderText = "Tên nguyên liệu" + Environment.NewLine + "材料名称";
                dtgvMaterialInfos.Columns["lot_no"].HeaderText = "Số lô" + Environment.NewLine + "批號";
                dtgvMaterialInfos.Columns["weight"].HeaderText = "Trọng lượng" + Environment.NewLine + "分量";
                dtgvMaterialInfos.Columns["tolerance"].HeaderText = "Dung sai" + Environment.NewLine + "公差";
                dtgvMaterialInfos.Columns["is_packed"].Visible = false;
            }
        }
        private void LoadProcessData()
        {
            if (SaveVariables.ProcessList.Rows.Count > 0)
            {
                for (int i = 0; i < SaveVariables.ProcessList.Rows.Count; i ++)
                {
                    SaveVariables.ProcessList.Rows[i]["process_no"] = (i + 1).ToString();
                }
                dtgvProcess.DataSource = null;
                SaveVariables.ProcessList.DefaultView.Sort = "process_no ASC";
                dtgvProcess.DataSource = SaveVariables.ProcessList.DefaultView.ToTable();
                dtgvProcess.Columns["uuid"].Visible = false;
                dtgvProcess.Columns["process_no"].HeaderText = "STT" + Environment.NewLine + "序列号";
                dtgvProcess.Columns["speed"].HeaderText = "Tốc độ" + Environment.NewLine + "航速";
                dtgvProcess.Columns["temperature"].HeaderText = "Nhiệt độ" + Environment.NewLine + "热度";
                dtgvProcess.Columns["time"].HeaderText = "Thời gian ban đầu" + Environment.NewLine + "初始时间";
                dtgvProcess.Columns["remark"].HeaderText = "Mô tả" + Environment.NewLine + "描摹";
                dtgvProcess.Columns["speed2"].HeaderText = "Tốc độ sau" + Environment.NewLine + "后速";
                dtgvProcess.Columns["time2"].HeaderText = "Thời gian sau" + Environment.NewLine + "晚点";
            }


        }
        private void materialInputCRUDFormClosing(object sender, FormClosingEventArgs e)
        {
            ((Form)sender).FormClosing -= materialInputCRUDFormClosing;
            LoadMaterialData();
        }

        private void btnEditMaterial_Click(object sender, EventArgs e)
        {
            if (SaveVariables.SelectedMatUUID == null)
            {
                MessageBox.Show("Vui lòng chọn mã liệu để chỉnh sửa!" + Environment.NewLine + "请选择要编辑的原始代码！", "Cảnh báo / 警报", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MaterialInputCRUDForm materialInputCRUDForm = new MaterialInputCRUDForm(SaveVariables.SelectedMatUUID, 1);
                materialInputCRUDForm.FormClosing += materialInputCRUDFormClosing;
                materialInputCRUDForm.ShowDialog();
            }
        }

        private void btnDeleteMaterial_Click(object sender, EventArgs e)
        {
            if (SaveVariables.SelectedMatUUID == null)
            {
                MessageBox.Show("Vui lòng chọn mã liệu để xóa!" + Environment.NewLine + "请选择要删除的原始码！", "Cảnh báo / 警报", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                for (int i = 0; i < SaveVariables.MaterialList.Rows.Count; i++)
                {
                    if (SaveVariables.MaterialList.Rows[i]["uuid"].ToString() == SaveVariables.SelectedMatUUID)
                    {
                        DialogResult dialogResult = MessageBox.Show("Xóa mã liệu " + SaveVariables.MaterialList.Rows[i]["mat_name"].ToString() + "?" + Environment.NewLine + "删码是否" + SaveVariables.MaterialList.Rows[i]["mat_name"].ToString() + "？", "Cảnh báo / 警报", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.OK)
                        {
                            SaveVariables.MaterialList.Rows[i].Delete();
                            SaveVariables.MaterialList.AcceptChanges();
                            SaveVariables.SelectedMatUUID = null;
                            LoadMaterialData();
                            break;
                        }
                    }
                }
            }
        }

        private void dtgvMaterialInfos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvMaterialInfos.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgvMaterialInfos.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgvMaterialInfos.Rows[selectedrowindex];
                SaveVariables.SelectedMatUUID = Convert.ToString(selectedRow.Cells["uuid"].Value);
            }
        }

        private void btnProcessSave_Click(object sender, EventArgs e)
        {
            if (SaveVariables.ProcessList == null || SaveVariables.ProcessList.Rows.Count == 0)
                SaveVariables.addProcessColumn();
            ProcessInputCRUDForm processInputCRUDForm = new ProcessInputCRUDForm(null, 0);
            processInputCRUDForm.FormClosing += processInputCRUDFormClosing;
            processInputCRUDForm.ShowDialog();
        }
        private void processInputCRUDFormClosing(object sender, FormClosingEventArgs e)
        {
            ((Form)sender).FormClosing -= processInputCRUDFormClosing;
            LoadProcessData();
        }

        private void dtgvProcess_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvProcess.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgvProcess.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgvProcess.Rows[selectedrowindex];
                SaveVariables.SelectedProcessUUID = Convert.ToString(selectedRow.Cells["uuid"].Value);

            }
        }

        private void btnProcessEdit_Click(object sender, EventArgs e)
        {
            if (SaveVariables.SelectedProcessUUID == null)
            {
                MessageBox.Show("Vui lòng chọn bước để chỉnh sửa!" + Environment.NewLine + "请选择要编辑的步骤！", "Cảnh báo / 警报", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ProcessInputCRUDForm processInputCRUDForm = new ProcessInputCRUDForm(SaveVariables.SelectedProcessUUID, 1);
                processInputCRUDForm.FormClosing += processInputCRUDFormClosing;
                processInputCRUDForm.ShowDialog();
                SaveVariables.SelectedProcessUUID = null;
            }
        }

        private void btnProcessDelete_Click(object sender, EventArgs e)
        {
            if (SaveVariables.SelectedProcessUUID == null)
            {
                MessageBox.Show("Vui lòng chọn mã liệu để xóa!" + Environment.NewLine + "请选择要删除的原始码！", "Cảnh báo / 警报", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                for (int i = 0; i < SaveVariables.ProcessList.Rows.Count; i++)
                {
                    if (SaveVariables.ProcessList.Rows[i]["uuid"].ToString() == SaveVariables.SelectedProcessUUID)
                    {
                        DialogResult dialogResult = MessageBox.Show("Xác nhận xóa công đoạn đã chọn?" + Environment.NewLine + "确认删除所选阶段？", "Cảnh báo / 警报", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.OK)
                        {
                            SaveVariables.ProcessList.Rows[i].Delete();
                            SaveVariables.ProcessList.AcceptChanges();
                            SaveVariables.SelectedProcessUUID = null;
                            LoadProcessData();
                            break;
                        }
                    }
                }
            }
        }

        private void btnCreateSpecification_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (SaveVariables.MaterialList.Rows.Count > 0 && SaveVariables.ProcessList.Rows.Count > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Lưu dữ liệu thao tác?" + Environment.NewLine + "保存操作数据？", "Thông tin / 空中", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        UploadMain.transactionSupportUploadData(SaveVariables.MaterialList, SaveVariables.ProcessList, txbInputCode.Text.Trim(), txbInputLotNo.Text.Trim(), SaveVariables.OperatorUUID);
                    }
                    dtgvMaterialInfos.DataSource = null;
                    txbInputCode.Clear();
                    txbInputLotNo.Clear();
                    dtgvProcess.DataSource = null;

                    SaveVariables.SelectedProcessUUID = null;
                    SaveVariables.ProcessList.Clear();
                }
                else
                {
                    MessageBox.Show("Chưa nhập thông tin nguyên liệu hoặc thông tin công đoạn!!!" + Environment.NewLine + "没有输入材料信息或工艺信息！！！", "Cảnh báo / 警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
