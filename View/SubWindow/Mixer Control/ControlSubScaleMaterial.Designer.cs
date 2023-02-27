﻿namespace htv5_mixer_control
{
    partial class ControlSubScaleMaterial
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
            this.components = new System.ComponentModel.Container();
            this.flpMaterialList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.btnConnectScale = new XanderUI.XUIButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lbUpTolerance = new System.Windows.Forms.Label();
            this.lbDownTolerance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelWeight = new System.Windows.Forms.Panel();
            this.lbScaleRT = new System.Windows.Forms.Label();
            this.lbAnnounce = new System.Windows.Forms.Label();
            this.btnNextStep = new XanderUI.XUIButton();
            this.btnConfirmScale = new XanderUI.XUIButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnHold = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelWeight.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpMaterialList
            // 
            this.flpMaterialList.AutoScroll = true;
            this.flpMaterialList.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpMaterialList.Location = new System.Drawing.Point(0, 0);
            this.flpMaterialList.Name = "flpMaterialList";
            this.flpMaterialList.Size = new System.Drawing.Size(589, 721);
            this.flpMaterialList.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHold);
            this.panel1.Controls.Add(this.cbComPort);
            this.panel1.Controls.Add(this.btnConnectScale);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbUpTolerance);
            this.panel1.Controls.Add(this.lbDownTolerance);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panelWeight);
            this.panel1.Controls.Add(this.lbAnnounce);
            this.panel1.Controls.Add(this.btnNextStep);
            this.panel1.Controls.Add(this.btnConfirmScale);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(589, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 721);
            this.panel1.TabIndex = 1;
            // 
            // cbComPort
            // 
            this.cbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(70, 23);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(131, 28);
            this.cbComPort.TabIndex = 9;
            // 
            // btnConnectScale
            // 
            this.btnConnectScale.BackgroundColor = System.Drawing.Color.White;
            this.btnConnectScale.ButtonImage = global::htv5_mixer_control.Properties.Resources.control;
            this.btnConnectScale.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnConnectScale.ButtonText = "Button";
            this.btnConnectScale.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnConnectScale.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnConnectScale.CornerRadius = 5;
            this.btnConnectScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectScale.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnConnectScale.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnConnectScale.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnConnectScale.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnConnectScale.Location = new System.Drawing.Point(220, 12);
            this.btnConnectScale.Name = "btnConnectScale";
            this.btnConnectScale.Size = new System.Drawing.Size(185, 53);
            this.btnConnectScale.TabIndex = 8;
            this.btnConnectScale.TextColor = System.Drawing.Color.Black;
            this.btnConnectScale.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnConnectScale.Click += new System.EventHandler(this.btnConnectScale_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "-->";
            // 
            // lbUpTolerance
            // 
            this.lbUpTolerance.AutoSize = true;
            this.lbUpTolerance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUpTolerance.Location = new System.Drawing.Point(291, 365);
            this.lbUpTolerance.Name = "lbUpTolerance";
            this.lbUpTolerance.Size = new System.Drawing.Size(85, 29);
            this.lbUpTolerance.TabIndex = 6;
            this.lbUpTolerance.Text = "label4";
            this.lbUpTolerance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDownTolerance
            // 
            this.lbDownTolerance.AutoSize = true;
            this.lbDownTolerance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDownTolerance.Location = new System.Drawing.Point(66, 365);
            this.lbDownTolerance.Name = "lbDownTolerance";
            this.lbDownTolerance.Size = new System.Drawing.Size(85, 29);
            this.lbDownTolerance.TabIndex = 5;
            this.lbDownTolerance.Text = "label3";
            this.lbDownTolerance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Khoảng trọng lượng đạt yêu cầu:";
            // 
            // panelWeight
            // 
            this.panelWeight.BackColor = System.Drawing.Color.Black;
            this.panelWeight.Controls.Add(this.lbScaleRT);
            this.panelWeight.Location = new System.Drawing.Point(10, 149);
            this.panelWeight.Name = "panelWeight";
            this.panelWeight.Size = new System.Drawing.Size(395, 150);
            this.panelWeight.TabIndex = 3;
            // 
            // lbScaleRT
            // 
            this.lbScaleRT.AutoSize = true;
            this.lbScaleRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScaleRT.ForeColor = System.Drawing.Color.White;
            this.lbScaleRT.Location = new System.Drawing.Point(121, 45);
            this.lbScaleRT.Name = "lbScaleRT";
            this.lbScaleRT.Size = new System.Drawing.Size(146, 69);
            this.lbScaleRT.TabIndex = 0;
            this.lbScaleRT.Text = "0.00";
            this.lbScaleRT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAnnounce
            // 
            this.lbAnnounce.AutoSize = true;
            this.lbAnnounce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnnounce.Location = new System.Drawing.Point(9, 107);
            this.lbAnnounce.Name = "lbAnnounce";
            this.lbAnnounce.Size = new System.Drawing.Size(125, 25);
            this.lbAnnounce.TabIndex = 2;
            this.lbAnnounce.Text = "đang cân ...";
            // 
            // btnNextStep
            // 
            this.btnNextStep.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNextStep.ButtonImage = global::htv5_mixer_control.Properties.Resources.next;
            this.btnNextStep.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnNextStep.ButtonText = "Button";
            this.btnNextStep.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnNextStep.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnNextStep.CornerRadius = 5;
            this.btnNextStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextStep.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNextStep.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnNextStep.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnNextStep.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnNextStep.Location = new System.Drawing.Point(201, 584);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(204, 88);
            this.btnNextStep.TabIndex = 1;
            this.btnNextStep.TextColor = System.Drawing.Color.Black;
            this.btnNextStep.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);
            // 
            // btnConfirmScale
            // 
            this.btnConfirmScale.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnConfirmScale.ButtonImage = global::htv5_mixer_control.Properties.Resources.save;
            this.btnConfirmScale.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnConfirmScale.ButtonText = "Button";
            this.btnConfirmScale.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnConfirmScale.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnConfirmScale.CornerRadius = 5;
            this.btnConfirmScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmScale.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnConfirmScale.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnConfirmScale.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnConfirmScale.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnConfirmScale.Location = new System.Drawing.Point(201, 437);
            this.btnConfirmScale.Name = "btnConfirmScale";
            this.btnConfirmScale.Size = new System.Drawing.Size(204, 77);
            this.btnConfirmScale.TabIndex = 0;
            this.btnConfirmScale.TextColor = System.Drawing.Color.Black;
            this.btnConfirmScale.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnConfirmScale.Click += new System.EventHandler(this.btnConfirmScale_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btnHold
            // 
            this.btnHold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHold.Location = new System.Drawing.Point(25, 437);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(126, 77);
            this.btnHold.TabIndex = 10;
            this.btnHold.Text = "GIỮ KL";
            this.btnHold.UseVisualStyleBackColor = true;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // ControlSubScaleMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpMaterialList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ControlSubScaleMaterial";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlSubScaleMaterial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlSubScaleMaterial_FormClosing);
            this.Load += new System.EventHandler(this.ControlSubScaleMaterial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelWeight.ResumeLayout(false);
            this.panelWeight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMaterialList;
        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIButton btnConfirmScale;
        private XanderUI.XUIButton btnNextStep;
        private System.Windows.Forms.Label lbAnnounce;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbUpTolerance;
        private System.Windows.Forms.Label lbDownTolerance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelWeight;
        private System.Windows.Forms.Label lbScaleRT;
        private XanderUI.XUIButton btnConnectScale;
        private System.Windows.Forms.ComboBox cbComPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnHold;
    }
}