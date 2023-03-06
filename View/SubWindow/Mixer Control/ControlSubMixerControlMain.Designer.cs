namespace htv5_mixer_control
{
    partial class ControlSubMixerControlMain
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnManualMode = new XanderUI.XUIButton();
            this.btnAutoMode = new XanderUI.XUIButton();
            this.xuiWidgetPanel1 = new XanderUI.XUIWidgetPanel();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelHeader.Controls.Add(this.btnManualMode);
            this.panelHeader.Controls.Add(this.btnAutoMode);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1006, 86);
            this.panelHeader.TabIndex = 0;
            // 
            // btnManualMode
            // 
            this.btnManualMode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnManualMode.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnManualMode.ButtonImage = global::htv5_mixer_control.Properties.Resources.edit;
            this.btnManualMode.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnManualMode.ButtonText = "MANUAL";
            this.btnManualMode.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnManualMode.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnManualMode.CornerRadius = 5;
            this.btnManualMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManualMode.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnManualMode.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnManualMode.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnManualMode.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnManualMode.Location = new System.Drawing.Point(759, 12);
            this.btnManualMode.Name = "btnManualMode";
            this.btnManualMode.Size = new System.Drawing.Size(235, 68);
            this.btnManualMode.TabIndex = 1;
            this.btnManualMode.TextColor = System.Drawing.Color.Black;
            this.btnManualMode.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnManualMode.Click += new System.EventHandler(this.btnManualMode_Click);
            // 
            // btnAutoMode
            // 
            this.btnAutoMode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAutoMode.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAutoMode.ButtonImage = global::htv5_mixer_control.Properties.Resources.control;
            this.btnAutoMode.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnAutoMode.ButtonText = "AUTO";
            this.btnAutoMode.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnAutoMode.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnAutoMode.CornerRadius = 5;
            this.btnAutoMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoMode.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAutoMode.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnAutoMode.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnAutoMode.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnAutoMode.Location = new System.Drawing.Point(509, 12);
            this.btnAutoMode.Name = "btnAutoMode";
            this.btnAutoMode.Size = new System.Drawing.Size(235, 68);
            this.btnAutoMode.TabIndex = 0;
            this.btnAutoMode.TextColor = System.Drawing.Color.Black;
            this.btnAutoMode.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAutoMode.Click += new System.EventHandler(this.btnAutoMode_Click);
            // 
            // xuiWidgetPanel1
            // 
            this.xuiWidgetPanel1.ControlsAsWidgets = false;
            this.xuiWidgetPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiWidgetPanel1.Location = new System.Drawing.Point(0, 86);
            this.xuiWidgetPanel1.Name = "xuiWidgetPanel1";
            this.xuiWidgetPanel1.Size = new System.Drawing.Size(1006, 635);
            this.xuiWidgetPanel1.TabIndex = 1;
            // 
            // ControlSubMixerControlMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.xuiWidgetPanel1);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ControlSubMixerControlMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlSubMixerControlMain";
            this.Load += new System.EventHandler(this.ControlSubMixerControlMain_Load);
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private XanderUI.XUIWidgetPanel xuiWidgetPanel1;
        private XanderUI.XUIButton btnAutoMode;
        private XanderUI.XUIButton btnManualMode;
    }
}