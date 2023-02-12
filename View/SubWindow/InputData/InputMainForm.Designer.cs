namespace htv5_mixer_control.View.SubWindow.InputData
{
    partial class InputMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputMainForm));
            this.panelInputMainHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelInputMainSideMenu = new System.Windows.Forms.Panel();
            this.btnUserConfig = new XanderUI.XUIButton();
            this.btnCheckData = new XanderUI.XUIButton();
            this.btnInputData = new XanderUI.XUIButton();
            this.xuiPanelInputComponent = new XanderUI.XUIWidgetPanel();
            this.panelInputMainHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelInputMainSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInputMainHeader
            // 
            this.panelInputMainHeader.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelInputMainHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInputMainHeader.Controls.Add(this.pictureBox1);
            this.panelInputMainHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInputMainHeader.Location = new System.Drawing.Point(0, 0);
            this.panelInputMainHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelInputMainHeader.Name = "panelInputMainHeader";
            this.panelInputMainHeader.Size = new System.Drawing.Size(1160, 74);
            this.panelInputMainHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::htv5_mixer_control.Properties.Resources.logoTechlinkFix;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelInputMainSideMenu
            // 
            this.panelInputMainSideMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInputMainSideMenu.Controls.Add(this.btnUserConfig);
            this.panelInputMainSideMenu.Controls.Add(this.btnCheckData);
            this.panelInputMainSideMenu.Controls.Add(this.btnInputData);
            this.panelInputMainSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInputMainSideMenu.Location = new System.Drawing.Point(0, 74);
            this.panelInputMainSideMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelInputMainSideMenu.Name = "panelInputMainSideMenu";
            this.panelInputMainSideMenu.Size = new System.Drawing.Size(242, 577);
            this.panelInputMainSideMenu.TabIndex = 0;
            // 
            // btnUserConfig
            // 
            this.btnUserConfig.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUserConfig.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnUserConfig.ButtonImage")));
            this.btnUserConfig.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnUserConfig.ButtonText = "Button";
            this.btnUserConfig.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnUserConfig.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnUserConfig.CornerRadius = 5;
            this.btnUserConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserConfig.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUserConfig.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnUserConfig.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnUserConfig.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnUserConfig.Location = new System.Drawing.Point(0, 184);
            this.btnUserConfig.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserConfig.Name = "btnUserConfig";
            this.btnUserConfig.Size = new System.Drawing.Size(240, 92);
            this.btnUserConfig.TabIndex = 2;
            this.btnUserConfig.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnUserConfig.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnCheckData
            // 
            this.btnCheckData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCheckData.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnCheckData.ButtonImage")));
            this.btnCheckData.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnCheckData.ButtonText = "Button";
            this.btnCheckData.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnCheckData.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnCheckData.CornerRadius = 5;
            this.btnCheckData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheckData.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCheckData.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnCheckData.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnCheckData.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnCheckData.Location = new System.Drawing.Point(0, 92);
            this.btnCheckData.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckData.Name = "btnCheckData";
            this.btnCheckData.Size = new System.Drawing.Size(240, 92);
            this.btnCheckData.TabIndex = 1;
            this.btnCheckData.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnCheckData.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCheckData.Click += new System.EventHandler(this.btnCheckData_Click);
            // 
            // btnInputData
            // 
            this.btnInputData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInputData.ButtonImage = global::htv5_mixer_control.Properties.Resources.data_entry;
            this.btnInputData.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnInputData.ButtonText = "Input Main";
            this.btnInputData.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnInputData.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnInputData.CornerRadius = 5;
            this.btnInputData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInputData.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnInputData.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnInputData.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnInputData.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnInputData.Location = new System.Drawing.Point(0, 0);
            this.btnInputData.Margin = new System.Windows.Forms.Padding(4);
            this.btnInputData.Name = "btnInputData";
            this.btnInputData.Size = new System.Drawing.Size(240, 92);
            this.btnInputData.TabIndex = 0;
            this.btnInputData.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnInputData.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnInputData.Click += new System.EventHandler(this.btnInputData_Click);
            // 
            // xuiPanelInputComponent
            // 
            this.xuiPanelInputComponent.ControlsAsWidgets = false;
            this.xuiPanelInputComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiPanelInputComponent.Location = new System.Drawing.Point(242, 74);
            this.xuiPanelInputComponent.Name = "xuiPanelInputComponent";
            this.xuiPanelInputComponent.Size = new System.Drawing.Size(918, 577);
            this.xuiPanelInputComponent.TabIndex = 1;
            // 
            // InputMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 651);
            this.Controls.Add(this.xuiPanelInputComponent);
            this.Controls.Add(this.panelInputMainSideMenu);
            this.Controls.Add(this.panelInputMainHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InputMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputMainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InputMainForm_FormClosing);
            this.Load += new System.EventHandler(this.InputMainForm_Load);
            this.panelInputMainHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelInputMainSideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInputMainHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelInputMainSideMenu;
        private XanderUI.XUIButton btnUserConfig;
        private XanderUI.XUIButton btnCheckData;
        private XanderUI.XUIButton btnInputData;
        private XanderUI.XUIWidgetPanel xuiPanelInputComponent;
    }
}