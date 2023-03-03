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
        bool isContinue = false;
        public static int ConnectionPLC;
        public static ReadVariablesPLC pLC = new ReadVariablesPLC("172.16.100.200", 0, 0, out ConnectionPLC);
        Timer runTimer, processTimer;
        CountDownTimer timer;
        string tempSpeed;
        private bool isComplete = false;

        public ControlSubMixerControlAuto()
        {
            InitializeComponent();
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
            lbRollSpeed.Text = Math.Round(speed, 2).ToString();
            double tempRT = Convert.ToDouble(pLC.ReadRealToString(1, 10));
            double maxTemp = Convert.ToDouble(lbProcessTemperature.Text.Trim());
            if (tempRT > maxTemp)
            {
                if (!pLC.ReadBitToBool(1, 0, 5, 1))
                {
                    pLC.WritebittoPLC(true, 1, 0, 5, 1);
                    panelShowTemperature.BackColor = Color.Red;

                    //Thêm phần ghi log
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


        private void ControlSubMixerControlAuto_Load(object sender, EventArgs e)
        {
            if (pLC.ReadBitToBool(1, 0, 3, 1))
            {
                GetNextProcess(SaveVariables.ControlSelectedSpecUUID);

                runTimer = new Timer();
                runTimer.Tick += runTimer_Tick;
                runTimer.Interval = 1000;
                runTimer.Enabled = true;

                btnStartProcess.Enabled = true;

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

                if (!pLC.ReadBitToBool(1, 14, 4, 1) && !pLC.ReadBitToBool(1, 14, 5, 1))
                {
                    btnResetRoll.BackColor = Color.Yellow;
                }
                else
                {
                    btnResetRoll.BackColor = Color.White;
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
                if (!isContinue)
                    btnContinueMix.Visible = false;
            }
            else
            {
                MessageBox.Show("Vui lòng kích hoạt chế độ chạy tự động!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void btnActivateSpeedControl_Click(object sender, EventArgs e)
        {
            if (pLC.ReadBitToBool(1, 20, 0, 1))
            {
                CustomDialog d = new CustomDialog("Tắt điều khiển TỐC ĐỘ tự động?");
                d.ShowDialog();
                if (d.DialogResult.Equals(DialogResult.OK))
                {
                    pLC.WritebittoPLC(false, 1, 20, 0, 1);

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
                    btnResetRoll.BackColor = Color.Yellow;
                    btnActivateSpeedControl.BackColor = Color.White;

                    btnActivateSpeedControl.Text = "ĐANG ĐIỀU KHIỂN BẰNG NÚT";
                    btnNormalRoll.Visible = false;
                    btnReverseRoll.Visible = false;
                    label12.Visible = false;
                }
            }
            else
            {
                CustomDialog d = new CustomDialog("Bật điều khiển TỐC ĐỘ tự động?");
                d.ShowDialog();
                if (d.DialogResult.Equals(DialogResult.OK))
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
                    btnResetRoll.BackColor = Color.White;

                    btnActivateSpeedControl.BackColor = Color.Yellow;
                    btnActivateSpeedControl.Text = "ĐANG ĐIỀU KHIỂN TỰ ĐỘNG";
                    btnNormalRoll.Visible = true;
                    btnNormalRoll.BackColor = Color.Yellow;
                    btnReverseRoll.BackColor = Color.White;
                    btnResetRoll.BackColor = Color.White;
                    btnReverseRoll.Visible = true;
                    label12.Visible = true;
                }
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
                        lbProcessNo.Text = "Thực hiện bước số : " + dt.Rows[i]["process_no"].ToString() + "\n步骤编号: " + dt.Rows[i]["process_no"].ToString();
                        lbProcessTime.Text = dt.Rows[i]["set_time"].ToString();
                        lbProcessTemperature.Text = dt.Rows[i]["set_temperature"].ToString();
                        lbProcessSpeed.Text = dt.Rows[i]["set_speed"].ToString();
                        lbTimeChange.Text = dt.Rows[i]["set_time_2"].ToString();
                        lbSpeedChange.Text = dt.Rows[i]["set_speed_2"].ToString();
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

        private void FinishProcess(string specUUID, string processUUID, DataTable processList)
        {
            if (timer.IsRunnign)
                timer.Disable();

            if (!isComplete)
            {
                isComplete = true;
                int i = processList.Rows.Count;

                if (processUUID != processList.Rows[i - 1]["uuid"].ToString())
                {
                    //Ngừng quay
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

                    CustomDialog d = new CustomDialog("Đã kết thúc quy trình chạy, bấm 'OK' để dừng quay và mở nắp, 'CANCEL' để dừng máy và giữ nắp đóng!");
                    d.ShowDialog();
                    if (d.DialogResult.Equals(DialogResult.OK))
                    {
                        isComplete = false;

                        if (pLC.ReadBitToBool(1, 0, 5, 1))
                            pLC.WritebittoPLC(false, 1, 0, 5, 1);

                        if (!pLC.ReadBitToBool(1, 1, 0, 1))
                        {
                            pLC.WritebittoPLC(true, 1, 1, 0, 1);
                        }
                    }
                    else
                    {
                        if (pLC.ReadBitToBool(1, 0, 5, 1))
                            pLC.WritebittoPLC(false, 1, 0, 5, 1);
                    }

                    tempSpeed = lbSpeedChange.Text;
                    sqlHTV5ControlCon sqlHTV5 = new sqlHTV5ControlCon();
                    StringBuilder updateStatus = new StringBuilder();
                    updateStatus.Append("update specification_process set is_completed = 0, is_running = 0 where uuid = '" + processUUID + "' and specification_uuid = '" + specUUID + "'");
                    sqlHTV5.sqlExecuteNonQuery(updateStatus.ToString(), false);

                    GetNextProcess(SaveVariables.ControlSelectedSpecUUID);
                }
                else
                {
                    if (processUUID == processList.Rows[i - 1]["uuid"].ToString())
                    {
                        CustomDialog d = new CustomDialog("Đã kết thúc quy trình chạy, bấm 'OK' để dừng quay!");
                        d.ShowDialog();
                        if (d.DialogResult.Equals(DialogResult.OK))
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
                            //pLC.WritebittoPLC(true, 1, 0, 1, 1);

                            if (pLC.ReadBitToBool(1, 0, 0, 1))
                                pLC.WritebittoPLC(false, 1, 0, 0, 1);
                        }

                        sqlHTV5ControlCon sqlHTV5 = new sqlHTV5ControlCon();
                        StringBuilder updateStatus = new StringBuilder();
                        updateStatus.Append("update specification_process set is_completed = 0, is_running = 0 where uuid = '" + processUUID + "' and specification_uuid = '" + specUUID + "'");
                        sqlHTV5.sqlExecuteNonQuery(updateStatus.ToString(), false);
                    }else
                    {
                        MessageBox.Show("Kết thúc");
                    }
                }
                

                btnStartProcess.Enabled = true;
                btnContinueMix.Visible = true;
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
            btnResetRoll.BackColor = Color.White;
            timer.Start();
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
            btnResetRoll.BackColor = Color.White;
            timer.Start();
        }

        private void ControlSubMixerControlAuto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timer != null)
            {
                timer.Disable();
                timer.Dispose();
            }
            if (runTimer != null)
            {
                runTimer.Enabled = false;
                runTimer.Dispose();
            }
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            if (!pLC.ReadBitToBool(1, 20, 0, 1))
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
            btnResetRoll.BackColor = Color.White;

            pLC.WriteRealtoPLC(Convert.ToSingle(lbProcessSpeed.Text.Trim()), 1, 2, 2);

            int time = Convert.ToInt32(lbProcessTime.Text.Trim()) + Convert.ToInt32(lbTimeChange.Text.Trim());
            timer = new CountDownTimer();
            timer.SetTime(time, 0);
            string timeChange = SetTimeChange(Convert.ToInt32(lbTimeChange.Text.Trim()), 0); //Thay thời gian lần chuyển đổi tốc độ tiếp theo
            timer.Start();
            timer.TimeChanged += () => TimerProcessTrigger(timeChange);
            timer.CountDownFinished += () => FinishProcess(SaveVariables.ControlSelectedSpecUUID, SaveVariables.ControlSelectedProcessUUID, GetAllProcess(SaveVariables.ControlSelectedSpecUUID));//Replace with finish event
            timer.StepMs = 77;

            btnStartTimer.Enabled = false;
        }
        private string SetTimeChange(int min, int sec = 0)
        {
            if (min > 0)
            {
                TimeSpan timeSpan = TimeSpan.FromSeconds(min * 60 + sec);
                return timeSpan.ToString(@"hh\:mm\:ss");
            }
            else
            {
                return null;
            }

        }

        private void TimerProcessTrigger(string time)
        {
            lbCountDown.Text = timer.TimeLeftStr;
            if (time != null)
            {
                if (lbCountDown.Text == time)
                {
                    pLC.WriteRealtoPLC(Convert.ToSingle(lbSpeedChange.Text.Trim()), 1, 2, 2);
                }
            }
            if(lbCountDown.Text == "00:00:02")
            {
                    pLC.WritebittoPLC(true, 1, 0, 5, 1);
            }
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

            if (!isContinue)
            {
                timer.Pause();
            }
            else
            {
                isContinue = false;
            }
        }

        private void btnContinueMix_Click(object sender, EventArgs e)
        {
            if (!isContinue)
            {
                CustomDialog d = new CustomDialog("Tiếp tục trộn liệu với tốc độ cũ: " + tempSpeed + " (vòng/ phút)??");
                d.ShowDialog();
                if (d.DialogResult.Equals(DialogResult.OK))
                {
                    isContinue = true;
                    if (!pLC.ReadBitToBool(1, 20, 0, 1))
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
                    pLC.WriteRealtoPLC(Convert.ToSingle(tempSpeed), 1, 2, 2);
                    tempSpeed = null;

                    btnContinueMix.Visible = false;
                }
            }
        }

        private void btnStartProcess_Click(object sender, EventArgs e)
        {
            if (btnContinueMix.Visible)
                btnContinueMix.Visible = false;

            CustomDialog dialog = new CustomDialog("Phải cho nguyên liệu vào máy trước khi cho chạy, bạn có chắc chắn muốn chạy ?");
            dialog.ShowDialog();
            if (dialog.DialogResult.Equals(DialogResult.OK))
            {
                tempSpeed = null;
                pLC.WriteRealtoPLC(Convert.ToSingle("0"), 1, 2, 2); // Nên truyền tốc độ = 0 xuống.

                //enable
                pLC.WritebittoPLC(true, 1, 0, 0, 1);
                if (pLC.ReadBitToBool(1, 0, 1, 1))
                    pLC.WritebittoPLC(false, 1, 0, 1, 1);

                btnStartProcess.Enabled = false;
                btnStartTimer.Enabled = true;
            }

        }
    }
}
