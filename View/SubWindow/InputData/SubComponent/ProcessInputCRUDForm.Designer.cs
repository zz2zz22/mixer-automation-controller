namespace htv5_mixer_control
{
    partial class ProcessInputCRUDForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.rtbRemark = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSetSpeed = new System.Windows.Forms.TextBox();
            this.txbSetTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSetTime2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbSetSpeed2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbSetTemp = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbProcessNo = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mô tả:\r\n描摹:";
            // 
            // rtbRemark
            // 
            this.rtbRemark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbRemark.Location = new System.Drawing.Point(97, 65);
            this.rtbRemark.Name = "rtbRemark";
            this.rtbRemark.Size = new System.Drawing.Size(839, 126);
            this.rtbRemark.TabIndex = 1;
            this.rtbRemark.Text = "";
            this.rtbRemark.Validating += new System.ComponentModel.CancelEventHandler(this.rtbRemark_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tốc độ ban đầu:\r\n初始速度:";
            // 
            // txbSetSpeed
            // 
            this.txbSetSpeed.Location = new System.Drawing.Point(178, 215);
            this.txbSetSpeed.Name = "txbSetSpeed";
            this.txbSetSpeed.Size = new System.Drawing.Size(201, 27);
            this.txbSetSpeed.TabIndex = 3;
            this.txbSetSpeed.TextChanged += new System.EventHandler(this.txbSetSpeed_TextChanged);
            this.txbSetSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSetSpeed_KeyPress);
            this.txbSetSpeed.Validating += new System.ComponentModel.CancelEventHandler(this.txbSetSpeed_Validating);
            // 
            // txbSetTime
            // 
            this.txbSetTime.Location = new System.Drawing.Point(178, 264);
            this.txbSetTime.Name = "txbSetTime";
            this.txbSetTime.Size = new System.Drawing.Size(201, 27);
            this.txbSetTime.TabIndex = 5;
            this.txbSetTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSetTime_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 267);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thời gian ban đầu:\r\n初始时间:";
            // 
            // txbSetTime2
            // 
            this.txbSetTime2.Location = new System.Drawing.Point(658, 264);
            this.txbSetTime2.Name = "txbSetTime2";
            this.txbSetTime2.Size = new System.Drawing.Size(225, 27);
            this.txbSetTime2.TabIndex = 9;
            this.txbSetTime2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSetTime2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 267);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 40);
            this.label4.TabIndex = 8;
            this.label4.Text = "Thời gian sau:\r\n晚点:";
            // 
            // txbSetSpeed2
            // 
            this.txbSetSpeed2.Location = new System.Drawing.Point(658, 215);
            this.txbSetSpeed2.Name = "txbSetSpeed2";
            this.txbSetSpeed2.Size = new System.Drawing.Size(225, 27);
            this.txbSetSpeed2.TabIndex = 7;
            this.txbSetSpeed2.TextChanged += new System.EventHandler(this.txbSetSpeed2_TextChanged);
            this.txbSetSpeed2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSetSpeed2_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 40);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tốc độ sau:\r\n后速:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 347);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 40);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nhiệt độ tối đa:\r\n最高温度:";
            // 
            // txbSetTemp
            // 
            this.txbSetTemp.Location = new System.Drawing.Point(151, 344);
            this.txbSetTemp.Name = "txbSetTemp";
            this.txbSetTemp.Size = new System.Drawing.Size(209, 27);
            this.txbSetTemp.TabIndex = 11;
            this.txbSetTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSetTemp_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(533, 344);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(403, 93);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "button1";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbProcessNo
            // 
            this.lbProcessNo.AutoSize = true;
            this.lbProcessNo.Location = new System.Drawing.Point(16, 9);
            this.lbProcessNo.Name = "lbProcessNo";
            this.lbProcessNo.Size = new System.Drawing.Size(53, 20);
            this.lbProcessNo.TabIndex = 13;
            this.lbProcessNo.Text = "label7";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ProcessInputCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 454);
            this.Controls.Add(this.lbProcessNo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbSetTemp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbSetTime2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbSetSpeed2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbSetTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbSetSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbRemark);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProcessInputCRUDForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProcessInputCRUDForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbRemark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSetSpeed;
        private System.Windows.Forms.TextBox txbSetTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSetTime2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbSetSpeed2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbSetTemp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbProcessNo;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}