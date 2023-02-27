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
    public partial class ControlSubMixerControlMain : Form
    {
        public ControlSubMixerControlMain()
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
            xuiWidgetPanel1.Controls.Add(childForm);
            xuiWidgetPanel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnManualMode_Click(object sender, EventArgs e)
        {
            openChildForm(new ControlSubMixerControlManual());
        }

        private void btnAutoMode_Click(object sender, EventArgs e)
        {
            openChildForm(new ControlSubMixerControlAuto());
        }

        private void ControlSubMixerControlMain_Load(object sender, EventArgs e)
        {
            openChildForm(new ControlSubMixerControlAuto());
        }
    }
}
