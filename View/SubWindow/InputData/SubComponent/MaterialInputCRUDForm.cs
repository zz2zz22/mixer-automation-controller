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
    public partial class MaterialInputCRUDForm : Form
    {
        string specID;
        int t;
        public MaterialInputCRUDForm(string specUUID, int type)
        {
            InitializeComponent();
            
            specID = specUUID;
            if (type == 0)
            {
                t = 0;
                btnSaveMaterial.ButtonText = "Thêm thông tin liệu" + Environment.NewLine + "更多信息是否";
            }
            else if (type == 1)
            {
                t = 1;
                for (int i = 0; i < SaveVariables.MaterialList.Rows.Count; i++)
                {
                    if (SaveVariables.MaterialList.Rows[i]["uuid"].ToString() == specID)
                    {
                        txbInputMaterialName.Text = SaveVariables.MaterialList.Rows[i]["mat_name"].ToString();
                        txbInputMaterialLot.Text = SaveVariables.MaterialList.Rows[i]["lot_no"].ToString();
                        txbInputMaterialWeight.Text = SaveVariables.MaterialList.Rows[i]["weight"].ToString();
                        txbInputMaterialTolerance.Text = SaveVariables.MaterialList.Rows[i]["tolerance"].ToString();
                        if(SaveVariables.MaterialList.Rows[i]["is_packed"].ToString() == "1")
                            cbxCheckPacked.Checked = true;
                        else
                            cbxCheckPacked.Checked = false;
                    }
                }
                btnSaveMaterial.ButtonText = "Lưu thông tin liệu" + Environment.NewLine + "保存数据信息";
            }
        }

        private void txbInputMaterialWeight_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txbInputMaterialTolerance_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txbInputMaterialName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbInputMaterialName.Text))
            {
                e.Cancel = true;
                txbInputMaterialName.Focus();
                errorProvider.SetError(txbInputMaterialName, "Tên nguyên liệu không được trống!" + Environment.NewLine + "材料名称不能为空！");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txbInputMaterialName, null);
            }
        }

        private void txbInputMaterialWeight_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbInputMaterialWeight.Text))
            {
                e.Cancel = true;
                txbInputMaterialWeight.Focus();
                errorProvider.SetError(txbInputMaterialWeight, "Khối lượng không được trống!" + Environment.NewLine + "卷不能为空！");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txbInputMaterialWeight, null);
            }
        }

        private void txbInputMaterialTolerance_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbInputMaterialTolerance.Text))
            {
                e.Cancel = true;
                txbInputMaterialTolerance.Focus();
                errorProvider.SetError(txbInputMaterialTolerance, "Dung sai không được trống!" + Environment.NewLine + "容不得空！");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txbInputMaterialTolerance, null);
            }
        }

        private void btnSaveMaterial_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string isPacked;
                DialogResult dialogResult;
                if (cbxCheckPacked.Checked)
                    isPacked = "1";
                else
                    isPacked = "0";
                if (t == 0)
                {
                    dialogResult = MessageBox.Show("Thêm mới dữ liệu ?", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        
                        SaveVariables.MaterialList.Rows.Add(UUIDGenerator.getAscId(), txbInputMaterialName.Text.Trim(), txbInputMaterialLot.Text.Trim(), txbInputMaterialWeight.Text.Trim(), txbInputMaterialTolerance.Text.Trim(), isPacked);
                    }
                }
                else if (t == 1)
                {
                    dialogResult = MessageBox.Show("Sửa liệu " + txbInputMaterialName.Text.Trim() + " ?", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        for (int i = 0; i < SaveVariables.MaterialList.Rows.Count; i++)
                        {
                            if (SaveVariables.MaterialList.Rows[i]["uuid"].ToString() == specID)
                            {
                                SaveVariables.MaterialList.Rows[i]["mat_name"] = txbInputMaterialName.Text.Trim();
                                SaveVariables.MaterialList.Rows[i]["lot_no"] = txbInputMaterialLot.Text.Trim();
                                SaveVariables.MaterialList.Rows[i]["weight"] = txbInputMaterialWeight.Text.Trim();
                                SaveVariables.MaterialList.Rows[i]["tolerance"] = txbInputMaterialTolerance.Text.Trim();
                                SaveVariables.MaterialList.Rows[i]["is_packed"] = isPacked;
                            }
                        }
                    }

                }
                SaveVariables.SelectedMatUUID = null;
                this.Close();
            }
        }

        private void txbInputMaterialTolerance_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    string isPacked;
                    DialogResult dialogResult;
                    if (cbxCheckPacked.Checked)
                        isPacked = "1";
                    else
                        isPacked = "0";
                    if (t == 0)
                    {
                        dialogResult = MessageBox.Show("Thêm mới dữ liệu ?", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.Yes)
                        {

                            SaveVariables.MaterialList.Rows.Add(UUIDGenerator.getAscId(), txbInputMaterialName.Text.Trim(), txbInputMaterialLot.Text.Trim(), txbInputMaterialWeight.Text.Trim(), txbInputMaterialTolerance.Text.Trim(), isPacked);
                        }
                    }
                    else if (t == 1)
                    {
                        dialogResult = MessageBox.Show("Sửa liệu " + txbInputMaterialName.Text.Trim() + " ?", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.Yes)
                        {
                            for (int i = 0; i < SaveVariables.MaterialList.Rows.Count; i++)
                            {
                                if (SaveVariables.MaterialList.Rows[i]["uuid"].ToString() == specID)
                                {
                                    SaveVariables.MaterialList.Rows[i]["mat_name"] = txbInputMaterialName.Text.Trim();
                                    SaveVariables.MaterialList.Rows[i]["lot_no"] = txbInputMaterialLot.Text.Trim();
                                    SaveVariables.MaterialList.Rows[i]["weight"] = txbInputMaterialWeight.Text.Trim();
                                    SaveVariables.MaterialList.Rows[i]["tolerance"] = txbInputMaterialTolerance.Text.Trim();
                                    SaveVariables.MaterialList.Rows[i]["is_packed"] = isPacked;
                                }
                            }
                        }

                    }
                    SaveVariables.SelectedMatUUID = null;
                    this.Close();
                }
            }
        }
    }
}
