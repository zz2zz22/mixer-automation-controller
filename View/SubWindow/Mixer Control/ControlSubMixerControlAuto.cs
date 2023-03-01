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
    public partial class ControlSubMixerControlAuto : Form
    {
        public static int ConnectionPLC;
        public static ReadVariablesPLC pLC = new ReadVariablesPLC("172.16.100.200", 0, 0, out ConnectionPLC);
        Timer runTimer, processTimer;
        CountDownTimer timer;
        private bool isComplete = false;

        public ControlSubMixerControlAuto()
        {
            InitializeComponent();
            runTimer = new Timer();
            runTimer.Tick += runTimer_Tick;
            runTimer.Interval = 1000;
            processTimer = new Timer();
            processTimer.Tick += processTimer_Tick;
            processTimer.Interval = 1000;
        }
        private void runTimer_Tick(object sender, EventArgs e)
        {
            //Timer in textbox to annouce to user
            lbTemperature.Text = pLC.ReadRealToString(1, 10);
            double speed = Convert.ToDouble(pLC.ReadRealToString(1, 6));
            if (speed < 0)
            {
                speed = speed * (-1);
            }
            lbRollSpeed.Text = speed.ToString();
            double tempRT = Convert.ToDouble(pLC.ReadRealToString(1, 10));
            double maxTemp = Convert.ToDouble(lbProcessTemperature.Text.Trim());
            if (tempRT > maxTemp)
            {
                if (!pLC.ReadBitToBool(1, 0, 5, 1))
                {
                    pLC.WritebittoPLC(true, 1, 0, 5, 1);
                    panelShowTemperature.BackColor = Color.Red;
                    //MessageBox.Show("Nhiệt độ máy vượt qua nhiệt độ cho phép!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (pLC.ReadBitToBool(1, 0, 5, 1))
                {
                    pLC.WritebittoPLC(false, 1, 0, 5, 1);
                    panelShowTemperature.BackColor = Color.Black;
                }
            }
        }
        private void processTimer_Tick(object sender, EventArgs e)
        {

        }


        private void ControlSubMixerControlAuto_Load(object sender, EventArgs e)
        {
            GetNextProcess(SaveVariables.ControlSelectedSpecUUID);
            if (!pLC.ReadBitToBool(1, 20, 0, 1))
            {
                pLC.WritebittoPLC(true, 1, 20, 0, 1);
            }
            if (pLC.ReadBitToBool(1, 14, 4, 1))
            {
                pLC.WritebittoPLC(false, 1, 14, 4, 1);
                btnNormalRoll.BackColor = Color.White;
            }

            if (pLC.ReadBitToBool(1, 14, 5, 1))
            {
                pLC.WritebittoPLC(false, 1, 14, 5, 1);
                btnReverseRoll.BackColor = Color.White;
            }

            if (pLC.ReadBitToBool(1, 20, 0, 1))
            {
                btnActivateSpeedControl.BackColor = Color.Yellow;
                btnActivateSpeedControl.Text = "ĐANG ĐIỀU KHIỂN TỰ ĐỘNG";
                btnNormalRoll.Visible = true;
                btnReverseRoll.Visible = true;
                label12.Visible = true;
            }
            else
            {
                btnActivateSpeedControl.BackColor = Color.White;
                btnActivateSpeedControl.Text = "ĐANG ĐIỀU KHIỂN BẰNG NÚT";
                btnNormalRoll.Visible = false;
                btnReverseRoll.Visible = false;
                label12.Visible = false;
            }
        }

        private void btnActivateSpeedControl_Click(object sender, EventArgs e)
        {
            if (pLC.ReadBitToBool(1, 20, 0, 1))
            {
                pLC.WritebittoPLC(false, 1, 20, 0, 1);

                if (pLC.ReadBitToBool(1, 1, 3, 1))
                    pLC.WritebittoPLC(false, 1, 1, 3, 1);

                if (pLC.ReadBitToBool(1, 1, 4, 1))
                    pLC.WritebittoPLC(false, 1, 1, 4, 1);
                btnActivateSpeedControl.BackColor = Color.White;
                btnActivateSpeedControl.Text = "ĐANG ĐIỀU KHIỂN BẰNG NÚT";
                btnNormalRoll.Visible = false;
                btnReverseRoll.Visible = false;
                label12.Visible = false;
            }
            else
            {
                pLC.WritebittoPLC(true, 1, 20, 0, 1);

                btnActivateSpeedControl.BackColor = Color.Yellow;
                btnActivateSpeedControl.Text = "ĐANG ĐIỀU KHIỂN TỰ ĐỘNG";
                btnNormalRoll.Visible = true;
                btnReverseRoll.Visible = true;
                label12.Visible = true;
            }
        }
        private DataTable GetAllProcess(string specUUID)
        {
            DataTable dt = new DataTable();
            sqlHTV5ControlCon sqlHTV5 = new sqlHTV5ControlCon();
            sqlHTV5.sqlDataAdapterFillDatatable("select * from specification_process where specification_uuid = '" + specUUID + "' order by process_no asc", ref dt);
            return dt;
        }
        private void GetNextProcess(string specUUID)
        {
            DataTable dt = GetAllProcess(specUUID);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["is_completed"].ToString() == "1")
                    {
                        SaveVariables.ControlSelectedProcessUUID = dt.Rows[i]["uuid"].ToString();
                        lbProcessNo.Text = "Thực hiện bước số : " + dt.Rows[i]["process_no"].ToString();
                        lbProcessTime.Text = dt.Rows[i]["set_time"].ToString();
                        lbProcessTemperature.Text = dt.Rows[i]["set_temperature"].ToString();
                        lbProcessSpeed.Text = dt.Rows[i]["set_speed"].ToString();
                        rtbRemark.Text = dt.Rows[i]["material_remark"].ToString();
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Quy cách không có bước thực hiện nào !!!");
                this.Close();
            }
        }
        //private bool CheckStartProcess()
        //{
        //    //if (pLC.ReadBitToBool(1, 14, 1, 1) || !pLC.ReadBitToBool(1, 14, 2, 1))
        //    //{
        //    //    return false;
        //    //}
        //    //else
        //    //{
        //    //    return true;
        //    //}
        //}
        private void FinishProcess(string specUUID, string processUUID, DataTable processList)
        {
            lbCountDown.Text = "Finish!";

            runTimer.Enabled = false;
            if (!pLC.ReadBitToBool(1, 0, 5, 1))
                pLC.WritebittoPLC(true, 1, 0, 5, 1);
            if (!isComplete)
            {
                isComplete = true;
                int i = processList.Rows.Count;

                if (processUUID != processList.Rows[i - 1]["uuid"].ToString())
                {
                    DialogResult dialog = MessageBox.Show("Đã hoàn thành công đoạn, mở nắp và kết thúc ?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    if (dialog == DialogResult.OK)
                    {
                        isComplete = false;

                        if (pLC.ReadBitToBool(1, 0, 5, 1))
                            pLC.WritebittoPLC(false, 1, 0, 5, 1);

                        //Khong phai buoc cuoi
                        if (!pLC.ReadBitToBool(1, 1, 0, 1))
                        {
                            pLC.WritebittoPLC(true, 1, 1, 0, 1);
                        }
                        //pLC.WritebittoPLC(true, 1, 0, 0, 1);
                        //if (pLC.ReadBitToBool(1, 0, 1, 1))
                        //    pLC.WritebittoPLC(false, 1, 0, 1, 1);
                    }
                    sqlHTV5ControlCon sqlHTV5 = new sqlHTV5ControlCon();
                    StringBuilder updateStatus = new StringBuilder();
                    updateStatus.Append("update specification_process set is_completed = 0, is_running = 0 where uuid = '" + processUUID + "' and specification_uuid = '" + specUUID + "'");
                    sqlHTV5.sqlExecuteNonQuery(updateStatus.ToString(), false);

                    GetNextProcess(SaveVariables.ControlSelectedSpecUUID);
                }
                else
                {
                    MessageBox.Show("Đã kết thúc quy trình");
                    pLC.WritebittoPLC(true, 1, 0, 1, 1);
                    if (pLC.ReadBitToBool(1, 0, 0, 1))
                        pLC.WritebittoPLC(false, 1, 0, 0, 1);

                    sqlHTV5ControlCon sqlHTV5 = new sqlHTV5ControlCon();
                    StringBuilder updateStatus = new StringBuilder();
                    updateStatus.Append("update specification_process set is_completed = 0, is_running = 0 where uuid = '" + processUUID + "' and specification_uuid = '" + specUUID + "'");
                    sqlHTV5.sqlExecuteNonQuery(updateStatus.ToString(), false);

                }
            }

        }

        private void btnNormalRoll_Click(object sender, EventArgs e)
        {
            if (pLC.ReadBitToBool(1, 20, 0, 1))
            {
                pLC.WritebittoPLC(true, 1, 14, 4, 1);
                if (pLC.ReadBitToBool(1, 14, 5, 1))
                    pLC.WritebittoPLC(false, 1, 14, 5, 1);
            }
            btnNormalRoll.BackColor = Color.Yellow;
            btnReverseRoll.BackColor = Color.White;
        }

        private void btnReverseRoll_Click(object sender, EventArgs e)
        {
            if (pLC.ReadBitToBool(1, 20, 0, 1))
            {
                pLC.WritebittoPLC(true, 1, 14, 5, 1);
                if (pLC.ReadBitToBool(1, 14, 4, 1))
                    pLC.WritebittoPLC(false, 1, 14, 4, 1);
            }
            btnReverseRoll.BackColor = Color.Yellow;
            btnNormalRoll.BackColor = Color.White;
        }

        private void ControlSubMixerControlAuto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Reset();
            }

            runTimer.Stop();
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {

            pLC.WritebittoPLC(true, 1, 20, 0, 1);

            if (!pLC.ReadBitToBool(1, 14, 4, 1))
            {
                pLC.WritebittoPLC(true, 1, 14, 4, 1);
                btnNormalRoll.BackColor = Color.Yellow;
            }

            if (pLC.ReadBitToBool(1, 14, 5, 1))
            {
                pLC.WritebittoPLC(false, 1, 14, 5, 1);
                btnReverseRoll.BackColor = Color.White;
            }

            runTimer.Enabled = true;

            timer = new CountDownTimer();
            timer.SetTime(Convert.ToInt32(lbProcessTime.Text.Trim()), 0);
            timer.Start();
            timer.TimeChanged += () => lbCountDown.Text = timer.TimeLeftStr;
            timer.CountDownFinished += () => FinishProcess(SaveVariables.ControlSelectedSpecUUID, SaveVariables.ControlSelectedProcessUUID, GetAllProcess(SaveVariables.ControlSelectedSpecUUID));//Replace with finish event
            timer.StepMs = 77;
        }

        private void btnResetRoll_Click(object sender, EventArgs e)
        {
            btnResetRoll.BackColor = Color.Yellow;
            if (pLC.ReadBitToBool(1, 20, 0, 1))
            {
                if (pLC.ReadBitToBool(1, 14, 4, 1))
                    pLC.WritebittoPLC(false, 1, 14, 4, 1);
                if (pLC.ReadBitToBool(1, 14, 5, 1))
                    pLC.WritebittoPLC(false, 1, 14, 5, 1);
            }
            btnNormalRoll.BackColor = Color.White;
            btnReverseRoll.BackColor = Color.White;
        }

        private void btnStartProcess_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Phải cho nguyên liệu vào máy trước khi cho chạy, bạn có chắc chắn muốn chạy ?", "CẢNH BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {

                //!runTimer.Enabled;
                //processTimer.Enabled = !processTimer.Enabled;


                pLC.WriteRealtoPLC(Convert.ToSingle(lbProcessSpeed.Text.Trim()), 1, 2, 2);


                //enable + on off speed

                pLC.WritebittoPLC(true, 1, 0, 0, 1);
                if (pLC.ReadBitToBool(1, 0, 1, 1))
                    pLC.WritebittoPLC(false, 1, 0, 1, 1);
            }
            else
            {
                string msg = "Vui lòng cho máy về trạng thái mở nắp, lật thùng trước \nkhi bắt đầu!";
                CustomMessageBox customMessage = new CustomMessageBox(msg);
                customMessage.ShowDialog();
            }

        }


    }
}
