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
    public partial class ProcessInputCRUDForm : Form
    {
        string procID;
        int t;
        public ProcessInputCRUDForm(string procUUID, int type)
        {
            InitializeComponent();

            procID = procUUID;
            if (type == 0)
            {
                t = 0;                
                lbProcessNo.Text = (SaveVariables.ProcessList.Rows.Count + 1).ToString();
                btnSave.Text = "Thêm thông tin bước";
            }
            else if (type == 1)
            {
                t = 1;
                for (int i = 0; i < SaveVariables.MaterialList.Rows.Count; i++)
                {
                    if (SaveVariables.ProcessList.Rows[i]["uuid"].ToString() == procUUID)
                    {
                        txbSetSpeed.Text = SaveVariables.MaterialList.Rows[i]["speed"].ToString();
                        txbSetSpeed2.Text = SaveVariables.MaterialList.Rows[i]["speed2"].ToString();
                        txbSetTemp.Text = SaveVariables.MaterialList.Rows[i]["temperature"].ToString();
                        txbSetTime.Text = SaveVariables.MaterialList.Rows[i]["time"].ToString();
                        txbSetTime2.Text = SaveVariables.MaterialList.Rows[i]["time2"].ToString();
                        rtbRemark.Text = SaveVariables.MaterialList.Rows[i]["remark"].ToString();
                        
                        lbProcessNo.Text = SaveVariables.MaterialList.Rows[i]["process_no"].ToString();
                    }
                }
                btnSave.Text = "Lưu thông tin liệu" ;
            }
        }

        private void txbSetSpeed_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txbSetTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbSetTime_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txbSetSpeed2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txbSetTime2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txbSetTemp_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            if (t == 0)
            {
                dialogResult = MessageBox.Show("Thêm mới dữ liệu ?", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    SaveVariables.ProcessList.Rows.Add(UUIDGenerator.getAscId(), lbProcessNo.Text, txbSetSpeed.Text.Trim(), txbSetTemp.Text.Trim(), txbSetTime.Text.Trim(), txbSetTime2.Text.Trim(), txbSetSpeed2.Text.Trim(), rtbRemark.Text.ToString().Trim());
                    lbProcessNo.Text = (SaveVariables.ProcessList.Rows.Count + 1).ToString();
                }
                    
            }
            else if (t == 1)
            {
                dialogResult = MessageBox.Show("Sửa liệu ?", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = 0; i < SaveVariables.ProcessList.Rows.Count; i++)
                    {
                        if (SaveVariables.ProcessList.Rows[i]["uuid"].ToString() == procID)
                        {
                            SaveVariables.MaterialList.Rows[i]["speed"] = txbSetSpeed.Text;
                            SaveVariables.MaterialList.Rows[i]["speed2"] = txbSetSpeed2.Text;
                            SaveVariables.MaterialList.Rows[i]["temperature"] = txbSetTemp.Text;
                            SaveVariables.MaterialList.Rows[i]["time"] = txbSetTime.Text;
                            SaveVariables.MaterialList.Rows[i]["time2"] = txbSetTime2.Text;
                            SaveVariables.MaterialList.Rows[i]["remark"] = rtbRemark.Text;
                        }
                    }
                }

            }
            SaveVariables.SelectedProcessUUID = null;
            this.Close();
        }
    }
}
