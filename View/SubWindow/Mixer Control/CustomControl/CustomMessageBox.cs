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
    public partial class CustomMessageBox : Form
    {
        public static int ConnectionPLC;
        public static ReadVariablesPLC pLC = new ReadVariablesPLC("172.16.100.200", 0, 0, out ConnectionPLC);
        public CustomMessageBox(string textAnnouce)
        {
            InitializeComponent();
            label1.Text = textAnnouce;
            if (!pLC.ReadBitToBool(1, 0, 5, 1))
                pLC.WritebittoPLC(true, 1, 0, 5, 1);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (pLC.ReadBitToBool(1, 0, 5, 1))
                pLC.WritebittoPLC(false, 1, 0, 5, 1);
            this.Close();
        }

        private void CustomMessageBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pLC.ReadBitToBool(1, 0, 5, 1))
                pLC.WritebittoPLC(false, 1, 0, 5, 1);
        }
    }
}
