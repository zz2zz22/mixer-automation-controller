using htv5_mixer_control.Model.SQL_Class;
using javax.tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XanderUI;

namespace htv5_mixer_control.View.SubWindow.InputData
{
    public partial class InputMainForm : Form
    {
        bool isError;
        public InputMainForm()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            xuiPanelInputComponent.Controls.Add(childForm);
            xuiPanelInputComponent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        

        private void btnInputData_Click(object sender, EventArgs e)
        {
            openChildForm(new InputSubInputData());
        }
        private void InputMainForm_Load(object sender, EventArgs e)
        {
            isError = false;
            if (SaveVariables.OperatorUUID != null)
            {
                if (ToolSupport.checkAdmin(SaveVariables.OperatorUUID))
                {
                   
                    btnUserConfig.Visible = true;
                }
                else
                {
                    btnUserConfig.Visible = false;
                }
                openChildForm(new InputSubInputData());
            }
            else
            {
                isError = true;
                MessageBox.Show("Lỗi đăng nhập ! Vui lòng đăng nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }         
        }

        private void btnCheckData_Click(object sender, EventArgs e)
        {
            openChildForm(new InputSubCheckData());
        }

        private void InputMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isError)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn đăng xuất ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    SaveVariables.OperatorUUID = null;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
