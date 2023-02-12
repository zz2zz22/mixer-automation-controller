namespace htv5_mixer_control
{
    partial class MainWindow
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
            this.lbHeader = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInputData = new XanderUI.XUIButton();
            this.btnMixerControl = new XanderUI.XUIButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.lbHeader);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 85);
            this.panel1.TabIndex = 0;
            // 
            // lbHeader
            // 
            this.lbHeader.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.Location = new System.Drawing.Point(375, 26);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(243, 36);
            this.lbHeader.TabIndex = 1;
            this.lbHeader.Text = "HTV5 - MIXER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::htv5_mixer_control.Properties.Resources.logoTechlinkFix;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.btnInputData);
            this.panel2.Controls.Add(this.btnMixerControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(630, 267);
            this.panel2.TabIndex = 1;
            // 
            // btnInputData
            // 
            this.btnInputData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInputData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInputData.ButtonImage = global::htv5_mixer_control.Properties.Resources.data_entry;
            this.btnInputData.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnInputData.ButtonText = "DATA INPUT";
            this.btnInputData.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnInputData.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnInputData.CornerRadius = 10;
            this.btnInputData.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputData.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnInputData.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnInputData.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnInputData.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnInputData.Location = new System.Drawing.Point(74, 137);
            this.btnInputData.Name = "btnInputData";
            this.btnInputData.Size = new System.Drawing.Size(482, 125);
            this.btnInputData.TabIndex = 1;
            this.btnInputData.TextColor = System.Drawing.Color.Black;
            this.btnInputData.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnInputData.Click += new System.EventHandler(this.btnInputData_Click);
            // 
            // btnMixerControl
            // 
            this.btnMixerControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMixerControl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMixerControl.ButtonImage = global::htv5_mixer_control.Properties.Resources.control_panel;
            this.btnMixerControl.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnMixerControl.ButtonText = "MIXER CONTROL";
            this.btnMixerControl.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnMixerControl.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnMixerControl.CornerRadius = 10;
            this.btnMixerControl.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMixerControl.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnMixerControl.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnMixerControl.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnMixerControl.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnMixerControl.Location = new System.Drawing.Point(74, 6);
            this.btnMixerControl.Name = "btnMixerControl";
            this.btnMixerControl.Size = new System.Drawing.Size(482, 125);
            this.btnMixerControl.TabIndex = 0;
            this.btnMixerControl.TextColor = System.Drawing.Color.Black;
            this.btnMixerControl.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnMixerControl.Click += new System.EventHandler(this.btnMixerControl_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 352);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTV5 - Mixer control";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private XanderUI.XUIButton btnMixerControl;
        private XanderUI.XUIButton btnInputData;
    }
}

