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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnInputData_Click(object sender, EventArgs e)
        {
            InputUserLogin inputUserLogin = new InputUserLogin();
            inputUserLogin.ShowDialog();
        }

        private void btnMixerControl_Click(object sender, EventArgs e)
        {
            ControlSubChooseSpecification controlSubChoose = new ControlSubChooseSpecification();
            //ControlSubMixerControlAuto controlSubChoose = new ControlSubMixerControlAuto();
            controlSubChoose.ShowDialog();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            btnInputData.ButtonText = "INPUT DATA" + Environment.NewLine + "输入";
            btnMixerControl.ButtonText = "MIXER CONTROL" + Environment.NewLine + "混频器控制";
        }
    }
}
