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
    public partial class ControlSubMixerControlManual : Form
    {
        public static int ConnectionPLC;
        public static ReadVariablesPLC pLC = new ReadVariablesPLC("172.16.100.200", 0, 0, out ConnectionPLC);
        Timer timer1;
        public ControlSubMixerControlManual()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
        }

        private void btnCloseCase_MouseUp(object sender, MouseEventArgs e)
        {
            pLC.WritebittoPLC(false, 1, 1, 1, 1);
        }

        private void btnCloseCase_MouseDown(object sender, MouseEventArgs e)
        {
            pLC.WritebittoPLC(true, 1, 1, 1, 1);
        }

        private void btnEnableRun_Click(object sender, EventArgs e)
        {
            pLC.WritebittoPLC(true, 1, 0, 0, 1);
            if (pLC.ReadBitToBool(1, 0, 1, 1))
                pLC.WritebittoPLC(false, 1, 0, 1, 1);
        }

        private void btnRollDown_MouseDown(object sender, MouseEventArgs e)
        {
            pLC.WritebittoPLC(true, 1, 0, 6, 1);
        }

        private void btnRollDown_MouseUp(object sender, MouseEventArgs e)
        {
            pLC.WritebittoPLC(false, 1, 0, 6, 1);
        }

        private void btnRollUp_MouseDown(object sender, MouseEventArgs e)
        {
            pLC.WritebittoPLC(true, 1, 0, 7, 1);
        }

        private void btnRollUp_MouseUp(object sender, MouseEventArgs e)
        {
            pLC.WritebittoPLC(false, 1, 0, 7, 1);
        }

        private void btnOpenCase_MouseDown(object sender, MouseEventArgs e)
        {
            pLC.WritebittoPLC(true, 1, 1, 0, 1);
        }

        private void btnOpenCase_MouseUp(object sender, MouseEventArgs e)
        {
            pLC.WritebittoPLC(false, 1, 1, 0, 1);
        }

        private void btnSetSpeed_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
                if (pLC.ReadBitToBool(1, 1, 2, 1))
                    pLC.WriteRealtoPLC(Convert.ToSingle(textBox1.Text.Trim()), 1, 2, 2);
        }

        private void readTemp_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            readTemp.Text = readTemp.Text == "Stop" ? "Doc nhiet do" : "Stop";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTemperature.Text = pLC.ReadRealToString(1, 10);
            lbSpeed.Text = pLC.ReadRealToString(1, 6);
            double temp = Convert.ToDouble(pLC.ReadRealToString(1, 10));
            //if (temp > 60)
            //{
            //    pLC.WritebittoPLC(true, 1, 0, 5, 1);
            //}
            //else
            //{
            //    pLC.WritebittoPLC(false, 1, 0, 5, 1);
            //}
        }

        private void btnLight_MouseDown(object sender, MouseEventArgs e)
        {
            pLC.WritebittoPLC(true, 1, 0, 5, 1);
        }

        private void btnLight_MouseUp(object sender, MouseEventArgs e)
        {
            pLC.WritebittoPLC(false, 1, 0, 5, 1);
        }

        private void btnONOFFSpeed_Click(object sender, EventArgs e)
        {
            if (pLC.ReadBitToBool(1, 14, 6, 1))
            {
                pLC.WritebittoPLC(false, 1, 14, 6, 1);

                if(pLC.ReadBitToBool(1, 14, 4, 1))
                    pLC.WritebittoPLC(false, 1, 14, 4, 1);

                if (pLC.ReadBitToBool(1, 14, 5, 1))
                    pLC.WritebittoPLC(false, 1, 14, 5, 1);
                btnONOFFSpeed.BackgroundColor = Color.White;
                btnONOFFSpeed.ButtonText = "OFF speed";
            }
            else
            {
                pLC.WritebittoPLC(true, 1, 14, 6, 1);
                btnONOFFSpeed.BackgroundColor = Color.Yellow;
                btnONOFFSpeed.ButtonText = "ON speed";
            }
        }

        private void ControlSubMixerControl_Load(object sender, EventArgs e)
        {
            if (pLC.ReadBitToBool(1, 1, 2, 1))
            {
                btnONOFFSpeed.BackgroundColor = Color.Yellow;
                btnONOFFSpeed.ButtonText = "ON speed";
            }
            else
            {
                btnONOFFSpeed.BackgroundColor = Color.White;
                btnONOFFSpeed.ButtonText = "OFF speed";
            }
        }

        private void btnRollDirection_Click(object sender, EventArgs e)
        {
            if (pLC.ReadBitToBool(1, 1, 2, 1))
            {
                pLC.WritebittoPLC(true, 1, 14, 4, 1);
                if (pLC.ReadBitToBool(1, 14, 5, 1))
                    pLC.WritebittoPLC(false, 1, 1, 4, 1);
            }
        }

        private void btnReverseDirection_Click(object sender, EventArgs e)
        {
            if (pLC.ReadBitToBool(1, 1, 2, 1))
            {
                pLC.WritebittoPLC(true, 1, 14, 5, 1);
                if (pLC.ReadBitToBool(1, 14, 4, 1))
                    pLC.WritebittoPLC(false, 1, 14, 4, 1);
            }
        }

        private void btnReset_MouseDown(object sender, MouseEventArgs e)
        {
            pLC.WritebittoPLC(true, 1, 0, 4, 1);
        }

        private void btnReset_MouseUp(object sender, MouseEventArgs e)
        {
            pLC.WritebittoPLC(false, 1, 0, 4, 1);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (pLC.ReadBitToBool(1, 0, 0, 1))
                pLC.WritebittoPLC(false, 1, 0, 0, 1);
            pLC.WritebittoPLC(true, 1, 0, 1, 1);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
