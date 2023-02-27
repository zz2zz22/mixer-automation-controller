using htv5_mixer_control.Model.SQL_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace htv5_mixer_control
{
    public partial class ControlSubScaleMaterial : Form
    {
        int flag;
        bool isFinished;
        DataTable matList;
        string scaleMatName, scaleMatUUID, dataIn;
        double matWeight, matTolerance, weightRT, tempWeightRT;
        public ControlSubScaleMaterial()
        {
            InitializeComponent();
        }
        private DataTable GetMaterialData(string specUUID)
        {
            sqlHTV5ControlCon sqlHTV5 = new sqlHTV5ControlCon();
            DataTable dt = new DataTable();
            sqlHTV5.sqlDataAdapterFillDatatable("select * from specification_material_info where specification_uuid = '" + specUUID + "'", ref dt);
            return dt;
        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            if(isFinished)
            {
                this.Hide();
                ControlSubMixerControlMain controlSubMixer = new ControlSubMixerControlMain();
                controlSubMixer.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("CHƯA HOÀN THÀNH CÂN LIỆU");
            }
        }

        private void btnConnectScale_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                btnConnectScale.ButtonText = "Kết nối cân";
            }
            else
            {
                try
                {
                    serialPort1.PortName = cbComPort.Text;
                    serialPort1.BaudRate = Convert.ToInt32("9600");
                    serialPort1.DataBits = Convert.ToInt32("8");
                    serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One");
                    serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), "None");
                    serialPort1.Open();
                    btnConnectScale.ButtonText = "Ngắt kết nối";
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ControlSubScaleMaterial_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void btnConfirmScale_Click(object sender, EventArgs e)
        {

            if (CheckWeight(weightRT))
            {
                sqlHTV5ControlCon sqlHTV5 = new sqlHTV5ControlCon();
                sqlHTV5.sqlExecuteNonQuery("update specification_material_info set actual_weight = '" + weightRT.ToString() + "' where uuid = '" + scaleMatUUID + "'", false);

            }
            else
            {
                MessageBox.Show("Chưa đạt trọng lượng yêu cầu!");
            }


            LoadFlowLayoutMat(GetMaterialData(SaveVariables.ControlSelectedSpecUUID));
            NextMatScale(matList, flag);
            tempWeightRT = 0;
        }
        private bool CheckWeight(double w)
        {
            if (w <= (matWeight + matTolerance) && w >= (matWeight - matTolerance))
            {
                return true;
            }
            else { return false; }
        }
        private void showData(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(dataIn))
            {
                if (Double.TryParse(dataIn, out weightRT))
                {
                    weightRT += tempWeightRT;
                    lbScaleRT.Text = weightRT.ToString();
                    if (CheckWeight(weightRT))
                    {
                        panelWeight.BackColor = Color.Green;
                        lbScaleRT.ForeColor = Color.Black;
                    }
                    else
                    {
                        panelWeight.BackColor = Color.Black;
                        lbScaleRT.ForeColor = Color.White;
                    }

                }
            }
        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            tempWeightRT = Convert.ToDouble(lbScaleRT.Text.Trim());
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIn = serialPort1.ReadExisting().Replace("\r\n", "").Replace("kg", "").Trim();
            this.Invoke(new EventHandler(showData));
        }

        private void NextMatScale(DataTable dt, int i)
        {
            if (i < dt.Rows.Count)
            {
                lbAnnounce.Text = "Tiến hành cân liệu : " + dt.Rows[i]["material_code"].ToString();
                scaleMatName = dt.Rows[i]["material_code"].ToString();
                scaleMatUUID = dt.Rows[i]["uuid"].ToString();
                matWeight = Convert.ToDouble(matList.Rows[i]["weight"].ToString());
                matTolerance = Convert.ToDouble(matList.Rows[i]["tolerance"].ToString());
                lbDownTolerance.Text = Convert.ToString(matWeight - matTolerance);
                lbUpTolerance.Text = Convert.ToString(matWeight + matTolerance);
            }
            else
            {
                lbAnnounce.Text = "Đã HOÀN THÀNH cân liệu !!!";
                lbDownTolerance.Text = "0";
                lbUpTolerance.Text = "0";
                scaleMatName = null;
                scaleMatUUID = null;
                matWeight = 0;
                matTolerance = 0;
                isFinished = true;
                lbScaleRT.Text = "0.00";
                panelWeight.BackColor = Color.Black;
                lbScaleRT.ForeColor = Color.White;
            }
        }
        private void LoadFlowLayoutMat(DataTable dt)
        {
            flag = 0;
            flpMaterialList.Controls.Clear();
            CustomDataRow customData;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!String.IsNullOrEmpty(dt.Rows[i]["actual_weight"].ToString()))
                {
                    customData = new CustomDataRow(dt.Rows[i]["uuid"].ToString(), dt.Rows[i]["material_code"].ToString(), dt.Rows[i]["weight"].ToString(), dt.Rows[i]["tolerance"].ToString(), "OK");
                    flag++;
                }
                else
                    customData = new CustomDataRow(dt.Rows[i]["uuid"].ToString(), dt.Rows[i]["material_code"].ToString(), dt.Rows[i]["weight"].ToString(), dt.Rows[i]["tolerance"].ToString(), "N/A");
                flpMaterialList.Controls.Add(customData);
            }
        }
        private void ControlSubScaleMaterial_Load(object sender, EventArgs e)
        {
            isFinished = false;
            btnConfirmScale.ButtonText = "Xác nhận KL";
            btnNextStep.ButtonText = "Bắt đầu thực hiện";
            matList = GetMaterialData(SaveVariables.ControlSelectedSpecUUID);
            LoadFlowLayoutMat(matList);
            NextMatScale(matList, flag);
            
            btnHold.BackColor = Color.White;
            string[] ports = SerialPort.GetPortNames();
            cbComPort.Items.AddRange(ports);
            if (!serialPort1.IsOpen)
            {
                cbComPort.Enabled = true;
                btnConnectScale.ButtonText = "Kết nối cân";
            }
            else
            {
                cbComPort.Enabled = false;
                btnConnectScale.ButtonText = "Ngắt kết nối";
            }
        }
    }
}
