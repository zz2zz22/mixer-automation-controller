﻿namespace htv5_mixer_control
{
    partial class ControlSubMixerControlAuto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStartProcess = new System.Windows.Forms.Button();
            this.lbProcessTemperature = new System.Windows.Forms.Label();
            this.lbProcessSpeed = new System.Windows.Forms.Label();
            this.lbProcessTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbRemark = new System.Windows.Forms.RichTextBox();
            this.lbProcessNo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnActivateSpeedControl = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnReverseRoll = new System.Windows.Forms.Button();
            this.btnNormalRoll = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lbCountDown = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelShowTemperature = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTemperature = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelShowSpeed = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lbRollSpeed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.btnResetRoll = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelShowTemperature.SuspendLayout();
            this.panelShowSpeed.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnStartProcess);
            this.panel1.Controls.Add(this.lbProcessTemperature);
            this.panel1.Controls.Add(this.lbProcessSpeed);
            this.panel1.Controls.Add(this.lbProcessTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rtbRemark);
            this.panel1.Controls.Add(this.lbProcessNo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 635);
            this.panel1.TabIndex = 0;
            // 
            // btnStartProcess
            // 
            this.btnStartProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStartProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartProcess.Location = new System.Drawing.Point(33, 530);
            this.btnStartProcess.Name = "btnStartProcess";
            this.btnStartProcess.Size = new System.Drawing.Size(333, 86);
            this.btnStartProcess.TabIndex = 8;
            this.btnStartProcess.Text = "BẮT ĐẦU THỰC HIỆN BƯỚC";
            this.btnStartProcess.UseVisualStyleBackColor = false;
            this.btnStartProcess.Click += new System.EventHandler(this.btnStartProcess_Click);
            // 
            // lbProcessTemperature
            // 
            this.lbProcessTemperature.AutoSize = true;
            this.lbProcessTemperature.Location = new System.Drawing.Point(240, 432);
            this.lbProcessTemperature.Name = "lbProcessTemperature";
            this.lbProcessTemperature.Size = new System.Drawing.Size(62, 20);
            this.lbProcessTemperature.TabIndex = 7;
            this.lbProcessTemperature.Text = "label11";
            // 
            // lbProcessSpeed
            // 
            this.lbProcessSpeed.AutoSize = true;
            this.lbProcessSpeed.Location = new System.Drawing.Point(240, 353);
            this.lbProcessSpeed.Name = "lbProcessSpeed";
            this.lbProcessSpeed.Size = new System.Drawing.Size(53, 20);
            this.lbProcessSpeed.TabIndex = 6;
            this.lbProcessSpeed.Text = "label7";
            // 
            // lbProcessTime
            // 
            this.lbProcessTime.AutoSize = true;
            this.lbProcessTime.Location = new System.Drawing.Point(240, 287);
            this.lbProcessTime.Name = "lbProcessTime";
            this.lbProcessTime.Size = new System.Drawing.Size(53, 20);
            this.lbProcessTime.TabIndex = 5;
            this.lbProcessTime.Text = "label6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhiệt độ tối đa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tốc độ (vòng / phút):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thời gian:";
            // 
            // rtbRemark
            // 
            this.rtbRemark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbRemark.Location = new System.Drawing.Point(11, 52);
            this.rtbRemark.Name = "rtbRemark";
            this.rtbRemark.ReadOnly = true;
            this.rtbRemark.Size = new System.Drawing.Size(422, 220);
            this.rtbRemark.TabIndex = 1;
            this.rtbRemark.Text = "";
            // 
            // lbProcessNo
            // 
            this.lbProcessNo.AutoSize = true;
            this.lbProcessNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcessNo.Location = new System.Drawing.Point(12, 12);
            this.lbProcessNo.Name = "lbProcessNo";
            this.lbProcessNo.Size = new System.Drawing.Size(59, 20);
            this.lbProcessNo.TabIndex = 0;
            this.lbProcessNo.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnResetRoll);
            this.panel2.Controls.Add(this.btnStartTimer);
            this.panel2.Controls.Add(this.btnActivateSpeedControl);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.btnReverseRoll);
            this.panel2.Controls.Add(this.btnNormalRoll);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lbCountDown);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.panelShowTemperature);
            this.panel2.Controls.Add(this.panelShowSpeed);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(440, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 635);
            this.panel2.TabIndex = 1;
            // 
            // btnActivateSpeedControl
            // 
            this.btnActivateSpeedControl.BackColor = System.Drawing.Color.Yellow;
            this.btnActivateSpeedControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivateSpeedControl.Location = new System.Drawing.Point(354, 561);
            this.btnActivateSpeedControl.Name = "btnActivateSpeedControl";
            this.btnActivateSpeedControl.Size = new System.Drawing.Size(199, 69);
            this.btnActivateSpeedControl.TabIndex = 8;
            this.btnActivateSpeedControl.Text = "ĐANG ĐIỀU KHIỂN \r\nTỰ ĐỘNG\r\n";
            this.btnActivateSpeedControl.UseVisualStyleBackColor = false;
            this.btnActivateSpeedControl.Click += new System.EventHandler(this.btnActivateSpeedControl_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 576);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(291, 40);
            this.label13.TabIndex = 7;
            this.label13.Text = "Điều khiển tốc độ/chiều xoay bằng nút\r\ntrên bảng điều khiển\r\n";
            // 
            // btnReverseRoll
            // 
            this.btnReverseRoll.BackColor = System.Drawing.Color.White;
            this.btnReverseRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReverseRoll.Location = new System.Drawing.Point(187, 438);
            this.btnReverseRoll.Name = "btnReverseRoll";
            this.btnReverseRoll.Size = new System.Drawing.Size(174, 69);
            this.btnReverseRoll.TabIndex = 6;
            this.btnReverseRoll.Text = "QUAY NGƯỢC";
            this.btnReverseRoll.UseVisualStyleBackColor = false;
            this.btnReverseRoll.Click += new System.EventHandler(this.btnReverseRoll_Click);
            // 
            // btnNormalRoll
            // 
            this.btnNormalRoll.BackColor = System.Drawing.Color.White;
            this.btnNormalRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormalRoll.Location = new System.Drawing.Point(9, 438);
            this.btnNormalRoll.Name = "btnNormalRoll";
            this.btnNormalRoll.Size = new System.Drawing.Size(172, 69);
            this.btnNormalRoll.TabIndex = 5;
            this.btnNormalRoll.Text = "QUAY THUẬN";
            this.btnNormalRoll.UseVisualStyleBackColor = false;
            this.btnNormalRoll.Click += new System.EventHandler(this.btnNormalRoll_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 415);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Chọn chiều xoay:";
            // 
            // lbCountDown
            // 
            this.lbCountDown.AutoSize = true;
            this.lbCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountDown.Location = new System.Drawing.Point(125, 332);
            this.lbCountDown.Name = "lbCountDown";
            this.lbCountDown.Size = new System.Drawing.Size(182, 46);
            this.lbCountDown.TabIndex = 3;
            this.lbCountDown.Text = "00:00:00";
            this.lbCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(299, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Thời gian còn lại đến khi kết thúc bước:";
            // 
            // panelShowTemperature
            // 
            this.panelShowTemperature.BackColor = System.Drawing.Color.Black;
            this.panelShowTemperature.Controls.Add(this.label9);
            this.panelShowTemperature.Controls.Add(this.lbTemperature);
            this.panelShowTemperature.Controls.Add(this.label5);
            this.panelShowTemperature.Location = new System.Drawing.Point(287, 12);
            this.panelShowTemperature.Name = "panelShowTemperature";
            this.panelShowTemperature.Size = new System.Drawing.Size(266, 260);
            this.panelShowTemperature.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(146, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Celsius (độ C)";
            // 
            // lbTemperature
            // 
            this.lbTemperature.AutoSize = true;
            this.lbTemperature.BackColor = System.Drawing.Color.Black;
            this.lbTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemperature.ForeColor = System.Drawing.Color.White;
            this.lbTemperature.Location = new System.Drawing.Point(87, 103);
            this.lbTemperature.Name = "lbTemperature";
            this.lbTemperature.Size = new System.Drawing.Size(85, 51);
            this.lbTemperature.TabIndex = 2;
            this.lbTemperature.Text = "0.0";
            this.lbTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "NHIỆT ĐỘ HIỆN TẠI:";
            // 
            // panelShowSpeed
            // 
            this.panelShowSpeed.BackColor = System.Drawing.Color.Black;
            this.panelShowSpeed.Controls.Add(this.label8);
            this.panelShowSpeed.Controls.Add(this.lbRollSpeed);
            this.panelShowSpeed.Controls.Add(this.label4);
            this.panelShowSpeed.Location = new System.Drawing.Point(5, 11);
            this.panelShowSpeed.Name = "panelShowSpeed";
            this.panelShowSpeed.Size = new System.Drawing.Size(276, 261);
            this.panelShowSpeed.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(141, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "rpm (vòng/ phút)";
            // 
            // lbRollSpeed
            // 
            this.lbRollSpeed.AutoSize = true;
            this.lbRollSpeed.BackColor = System.Drawing.Color.Black;
            this.lbRollSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRollSpeed.ForeColor = System.Drawing.Color.White;
            this.lbRollSpeed.Location = new System.Drawing.Point(91, 104);
            this.lbRollSpeed.Name = "lbRollSpeed";
            this.lbRollSpeed.Size = new System.Drawing.Size(85, 51);
            this.lbRollSpeed.TabIndex = 1;
            this.lbRollSpeed.Text = "0.0";
            this.lbRollSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "TỐC ĐỘ HIỆN TẠI:";
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.BackColor = System.Drawing.Color.White;
            this.btnStartTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTimer.Location = new System.Drawing.Point(414, 287);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(136, 61);
            this.btnStartTimer.TabIndex = 9;
            this.btnStartTimer.Text = "BẮT ĐẦU TRỘN";
            this.btnStartTimer.UseVisualStyleBackColor = false;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // btnResetRoll
            // 
            this.btnResetRoll.BackColor = System.Drawing.Color.White;
            this.btnResetRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetRoll.Location = new System.Drawing.Point(383, 438);
            this.btnResetRoll.Name = "btnResetRoll";
            this.btnResetRoll.Size = new System.Drawing.Size(174, 69);
            this.btnResetRoll.TabIndex = 10;
            this.btnResetRoll.Text = "NGỪNG QUAY";
            this.btnResetRoll.UseVisualStyleBackColor = false;
            this.btnResetRoll.Click += new System.EventHandler(this.btnResetRoll_Click);
            // 
            // ControlSubMixerControlAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 635);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ControlSubMixerControlAuto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlSubMixerControlAuto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlSubMixerControlAuto_FormClosing);
            this.Load += new System.EventHandler(this.ControlSubMixerControlAuto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelShowTemperature.ResumeLayout(false);
            this.panelShowTemperature.PerformLayout();
            this.panelShowSpeed.ResumeLayout(false);
            this.panelShowSpeed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtbRemark;
        private System.Windows.Forms.Label lbProcessNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelShowTemperature;
        private System.Windows.Forms.Label lbTemperature;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelShowSpeed;
        private System.Windows.Forms.Label lbRollSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReverseRoll;
        private System.Windows.Forms.Button btnNormalRoll;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbCountDown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnActivateSpeedControl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbProcessTemperature;
        private System.Windows.Forms.Label lbProcessSpeed;
        private System.Windows.Forms.Label lbProcessTime;
        private System.Windows.Forms.Button btnStartProcess;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.Button btnResetRoll;
    }
}