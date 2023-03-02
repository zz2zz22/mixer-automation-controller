using htv5_mixer_control.Model.SQL_Class;
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

        private bool checkSpecificationCode(string specCode)
        {
            sqlHTV5ControlCon sqlHTV5 = new sqlHTV5ControlCon();
            string cmd = sqlHTV5.sqlExecuteScalarString("select distinct specification_code from specification_info where specification_code = '" + specCode + "' and delete_flag = 0");
            if (cmd != String.Empty) { return false; }
            else
            {
                return true;
            }
        }

        private void txbInputCode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbInputCode.Text))
            {
                e.Cancel = true;
                txbInputCode.Focus();
                errorProvider.SetError(txbInputCode, "Mã quy cách không được để trống!");
            }
            else
            {
                if (!checkSpecificationCode(txbInputCode.Text.Trim()))
                {
                    e.Cancel = true;
                    txbInputCode.Focus();
                    errorProvider.SetError(txbInputCode, "Mã quy cách đã tồn tại trên hệ thống!");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(txbInputCode, null);
                }
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
                errorProvider.SetError(txbInputLotNo, "Số lô không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txbInputLotNo, null);
            }
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            if (!checkSpecificationCode(txbInputCode.Text.Trim()))
            {
                txbInputCode.Focus();
                errorProvider.SetError(txbInputCode, "Mã quy cách đã tồn tại trên hệ thống!");
            }
            else
            {
                if (SaveVariables.MaterialList == null || SaveVariables.MaterialList.Rows.Count == 0)
                    SaveVariables.addMatColumn();
                MaterialInputCRUDForm materialInputCRUDForm = new MaterialInputCRUDForm(null, 0);
                materialInputCRUDForm.FormClosing += materialInputCRUDFormClosing;
                materialInputCRUDForm.ShowDialog();
            }

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
            }
        }
        private void LoadProcessData()
        {
            if (SaveVariables.ProcessList.Rows.Count > 0)
            {
                lbProcessNumber.Text = (SaveVariables.ProcessList.Rows.Count + 1).ToString();


                dtgvProcess.DataSource = null;
                SaveVariables.ProcessList.DefaultView.Sort = "process_no ASC";
                dtgvProcess.DataSource = SaveVariables.ProcessList.DefaultView.ToTable();
                dtgvProcess.Columns["uuid"].Visible = false;
                dtgvProcess.Columns["process_no"].HeaderText = "STT";
                dtgvProcess.Columns["speed"].HeaderText = "Tốc độ";
                dtgvProcess.Columns["temperature"].HeaderText = "Nhiệt độ";
                dtgvProcess.Columns["time"].HeaderText = "Thời gian";
                dtgvProcess.Columns["remark"].HeaderText = "Mô tả";

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
                MessageBox.Show("Vui lòng chọn mã liệu để chỉnh sửa!");
            }
            else
            {
                if (!checkSpecificationCode(txbInputCode.Text.Trim()))
                {
                    txbInputCode.Focus();
                    errorProvider.SetError(txbInputCode, "Mã quy cách đã tồn tại trên hệ thống!");
                }
                else
                {
                    MaterialInputCRUDForm materialInputCRUDForm = new MaterialInputCRUDForm(SaveVariables.SelectedMatUUID, 1);
                    materialInputCRUDForm.FormClosing += materialInputCRUDFormClosing;
                    materialInputCRUDForm.ShowDialog();
                }

            }
        }

        private void btnDeleteMaterial_Click(object sender, EventArgs e)
        {
            if (SaveVariables.SelectedMatUUID == null)
            {
                MessageBox.Show("Vui lòng chọn mã liệu để xóa!");
            }
            else
            {
                for (int i = 0; i < SaveVariables.MaterialList.Rows.Count; i++)
                {
                    if (SaveVariables.MaterialList.Rows[i]["uuid"].ToString() == SaveVariables.SelectedMatUUID)
                    {
                        SaveVariables.MaterialList.Rows[i].Delete();
                        SaveVariables.MaterialList.AcceptChanges();
                    }
                }
                SaveVariables.SelectedMatUUID = null;
                LoadMaterialData();
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
                MessageBox.Show("Vui lòng chọn bước để chỉnh sửa!");
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
                MessageBox.Show("Vui lòng chọn mã liệu để xóa!");
            }
            else
            {
                for (int i = 0; i < SaveVariables.ProcessList.Rows.Count; i++)
                {
                    if (SaveVariables.ProcessList.Rows[i]["uuid"].ToString() == SaveVariables.SelectedProcessUUID)
                    {
                        SaveVariables.ProcessList.Rows[i].Delete();
                        SaveVariables.ProcessList.AcceptChanges();
                    }
                }
                SaveVariables.SelectedProcessUUID = null;
                LoadProcessData();
            }
        }

        private void txbTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txbTemperature_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txbSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnCreateSpecification_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Lưu dữ liệu thao tác?", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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

        //private void txbSpeed_TextChanged(object sender, EventArgs e)
        //{
        //    int value;
        //    if (int.TryParse(txbSpeed.Text, out value))
        //    {
        //        if (value > 30)
        //            txbSpeed.Text = "30";
        //        else if (value < 1)
        //            txbSpeed.Text = "1";

        //    }
        //}
    }
}
