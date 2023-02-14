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
        }

        private void txbInputLotNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbInputLotNo.Text))
            {
                e.Cancel = true;
                txbInputLotNo.Focus();
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
            if (SaveVariables.MaterialList.Rows.Count == 0)
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
            }
        }
        private void materialInputCRUDFormClosing(object sender, FormClosingEventArgs e)
        {
            ((Form)sender).FormClosing -= materialInputCRUDFormClosing;
            LoadMaterialData();
        }
    }
}
