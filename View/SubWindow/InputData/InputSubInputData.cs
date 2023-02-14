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
                errorProvider.SetError(txbInputCode, "Mã quy cách không được để trống!");
            }
            else
            {
                if (!checkSpecificationCode(txbInputCode.Text.Trim()))
                {
                    e.Cancel = true;
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
            btnAddMaterial.ButtonText = "Thêm mới" + Environment.NewLine + "";
            btnEditMaterial.ButtonText = "Chỉnh sửa" + Environment.NewLine + "";
            btnDeleteMaterial.ButtonText = "Xóa bỏ" + Environment.NewLine + "";
            if (SaveVariables.ProcessList == null || SaveVariables.ProcessList.Rows.Count == 0)
                lbProcessNumber.Text = "1";
        }

        private void txbInputLotNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbInputLotNo.Text))
            {
                e.Cancel = true;
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
            if (ValidateChildren(ValidationConstraints.Enabled))
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
            if (SaveVariables.ProcessList.Rows.Count >0)
            {
                lbProcessNumber.Text = SaveVariables.ProcessList.Rows.Count.ToString();
                rtbRemark.Clear();
                txbSpeed.Clear();
                txbTemperature.Clear();
                txbTime.Clear();
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
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (SaveVariables.SelectedMatUUID == null)
                {
                    MessageBox.Show("Vui lòng chọn mã liệu để chỉnh sửa!");
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
            if (ValidateChildren(ValidationConstraints.Enabled))
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

        private void rtbRemark_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(rtbRemark.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(rtbRemark, "Mô tả thao tác không được trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(rtbRemark, null);
            }
        }

        private void btnProcessSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (SaveVariables.ProcessList == null || SaveVariables.ProcessList.Rows.Count == 0)
                    SaveVariables.addProcessColumn();
                DialogResult dialogResult = MessageBox.Show("Thêm mới dữ liệu ?", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                    SaveVariables.ProcessList.Rows.Add(UUIDGenerator.getAscId(), lbProcessNumber.Text, rtbRemark.Text.ToString().Trim(), txbSpeed.Text.Trim(), txbTemperature.Text.Trim(), txbTime.Text.Trim());
                LoadProcessData();
            }
        }

        private void dtgvProcess_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvProcess.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgvProcess.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgvProcess.Rows[selectedrowindex];
                SaveVariables.SelectedProcessUUID = Convert.ToString(selectedRow.Cells["uuid"].Value);
                rtbRemark.Text = Convert.ToString(selectedRow.Cells["remark"].Value);
                txbSpeed.Text = Convert.ToString(selectedRow.Cells["speed"].Value);
                txbTemperature.Text = Convert.ToString(selectedRow.Cells["temperature"].Value);
                txbTime.Text = Convert.ToString(selectedRow.Cells["time"].Value);
            }
        }

        private void btnProcessEdit_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                DialogResult dialogResult = MessageBox.Show("Cập nhật dữ liệu ?", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = 0; i < SaveVariables.ProcessList.Rows.Count; i++)
                    {
                        if (SaveVariables.ProcessList.Rows[i]["uuid"].ToString() == SaveVariables.SelectedProcessUUID)
                        {
                            SaveVariables.ProcessList.Rows[i]["remark"] = rtbRemark.Text.Trim();
                            SaveVariables.ProcessList.Rows[i]["speed"] = txbSpeed.Text.Trim();
                            SaveVariables.ProcessList.Rows[i]["temperature"] = txbTemperature.Text.Trim();
                            SaveVariables.ProcessList.Rows[i]["time"] = txbTime.Text.Trim();
                        }
                    }
                }
                SaveVariables.SelectedProcessUUID= null;
                LoadProcessData();
            }
        }

        private void btnProcessDelete_Click(object sender, EventArgs e)
        {
            if (SaveVariables.SelectedProcessUUID == null)
            {
                MessageBox.Show("Vui lòng chọn thao tác để xóa!");
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
                LoadMaterialData();
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
    }
}
