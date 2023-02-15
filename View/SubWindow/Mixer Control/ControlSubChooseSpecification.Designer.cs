namespace htv5_mixer_control
{
    partial class ControlSubChooseSpecification
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvShowCreatedSpec = new System.Windows.Forms.DataGridView();
            this.txbSearchSpec = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvMaterialsInfo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvProcessInfo = new System.Windows.Forms.DataGridView();
            this.btnConfirm = new XanderUI.XUIButton();
            this.btnSearchSpec = new XanderUI.XUIButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowCreatedSpec)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMaterialsInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProcessInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvShowCreatedSpec);
            this.panel1.Controls.Add(this.btnSearchSpec);
            this.panel1.Controls.Add(this.txbSearchSpec);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 721);
            this.panel1.TabIndex = 0;
            // 
            // dtgvShowCreatedSpec
            // 
            this.dtgvShowCreatedSpec.AllowUserToAddRows = false;
            this.dtgvShowCreatedSpec.AllowUserToDeleteRows = false;
            this.dtgvShowCreatedSpec.AllowUserToResizeColumns = false;
            this.dtgvShowCreatedSpec.AllowUserToResizeRows = false;
            this.dtgvShowCreatedSpec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvShowCreatedSpec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvShowCreatedSpec.ColumnHeadersHeight = 40;
            this.dtgvShowCreatedSpec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvShowCreatedSpec.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvShowCreatedSpec.Location = new System.Drawing.Point(0, 74);
            this.dtgvShowCreatedSpec.MultiSelect = false;
            this.dtgvShowCreatedSpec.Name = "dtgvShowCreatedSpec";
            this.dtgvShowCreatedSpec.ReadOnly = true;
            this.dtgvShowCreatedSpec.RowHeadersVisible = false;
            this.dtgvShowCreatedSpec.RowHeadersWidth = 51;
            this.dtgvShowCreatedSpec.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvShowCreatedSpec.RowTemplate.Height = 35;
            this.dtgvShowCreatedSpec.Size = new System.Drawing.Size(469, 647);
            this.dtgvShowCreatedSpec.TabIndex = 7;
            this.dtgvShowCreatedSpec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvShowCreatedSpec_CellClick);
            // 
            // txbSearchSpec
            // 
            this.txbSearchSpec.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txbSearchSpec.Location = new System.Drawing.Point(30, 27);
            this.txbSearchSpec.Name = "txbSearchSpec";
            this.txbSearchSpec.Size = new System.Drawing.Size(253, 27);
            this.txbSearchSpec.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvProcessInfo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtgvMaterialsInfo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnConfirm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(469, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 721);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thông tin nguyên liệu:";
            // 
            // dtgvMaterialsInfo
            // 
            this.dtgvMaterialsInfo.AllowUserToAddRows = false;
            this.dtgvMaterialsInfo.AllowUserToDeleteRows = false;
            this.dtgvMaterialsInfo.AllowUserToResizeColumns = false;
            this.dtgvMaterialsInfo.AllowUserToResizeRows = false;
            this.dtgvMaterialsInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMaterialsInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvMaterialsInfo.ColumnHeadersHeight = 40;
            this.dtgvMaterialsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvMaterialsInfo.Location = new System.Drawing.Point(11, 37);
            this.dtgvMaterialsInfo.MultiSelect = false;
            this.dtgvMaterialsInfo.Name = "dtgvMaterialsInfo";
            this.dtgvMaterialsInfo.ReadOnly = true;
            this.dtgvMaterialsInfo.RowHeadersVisible = false;
            this.dtgvMaterialsInfo.RowHeadersWidth = 51;
            this.dtgvMaterialsInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvMaterialsInfo.RowTemplate.Height = 35;
            this.dtgvMaterialsInfo.Size = new System.Drawing.Size(514, 241);
            this.dtgvMaterialsInfo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Thông tin thao tác:";
            // 
            // dtgvProcessInfo
            // 
            this.dtgvProcessInfo.AllowUserToAddRows = false;
            this.dtgvProcessInfo.AllowUserToDeleteRows = false;
            this.dtgvProcessInfo.AllowUserToResizeColumns = false;
            this.dtgvProcessInfo.AllowUserToResizeRows = false;
            this.dtgvProcessInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvProcessInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvProcessInfo.ColumnHeadersHeight = 40;
            this.dtgvProcessInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvProcessInfo.Location = new System.Drawing.Point(11, 309);
            this.dtgvProcessInfo.MultiSelect = false;
            this.dtgvProcessInfo.Name = "dtgvProcessInfo";
            this.dtgvProcessInfo.ReadOnly = true;
            this.dtgvProcessInfo.RowHeadersVisible = false;
            this.dtgvProcessInfo.RowHeadersWidth = 51;
            this.dtgvProcessInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvProcessInfo.RowTemplate.Height = 35;
            this.dtgvProcessInfo.Size = new System.Drawing.Size(514, 329);
            this.dtgvProcessInfo.TabIndex = 12;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnConfirm.ButtonImage = global::htv5_mixer_control.Properties.Resources.save;
            this.btnConfirm.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnConfirm.ButtonText = "Button";
            this.btnConfirm.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnConfirm.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnConfirm.CornerRadius = 10;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnConfirm.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnConfirm.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnConfirm.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnConfirm.Location = new System.Drawing.Point(290, 644);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(235, 65);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.TextColor = System.Drawing.Color.Black;
            this.btnConfirm.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnSearchSpec
            // 
            this.btnSearchSpec.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearchSpec.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSearchSpec.ButtonImage = global::htv5_mixer_control.Properties.Resources.search_flat;
            this.btnSearchSpec.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSearchSpec.ButtonText = "Button";
            this.btnSearchSpec.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSearchSpec.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSearchSpec.CornerRadius = 10;
            this.btnSearchSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSpec.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSearchSpec.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSearchSpec.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSearchSpec.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSearchSpec.Location = new System.Drawing.Point(289, 3);
            this.btnSearchSpec.Name = "btnSearchSpec";
            this.btnSearchSpec.Size = new System.Drawing.Size(174, 65);
            this.btnSearchSpec.TabIndex = 6;
            this.btnSearchSpec.TextColor = System.Drawing.Color.Black;
            this.btnSearchSpec.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // ControlSubChooseSpecification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ControlSubChooseSpecification";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlSubChooseSpecification";
            this.Load += new System.EventHandler(this.ControlSubChooseSpecification_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowCreatedSpec)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMaterialsInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProcessInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvShowCreatedSpec;
        private XanderUI.XUIButton btnSearchSpec;
        private System.Windows.Forms.TextBox txbSearchSpec;
        private System.Windows.Forms.Panel panel2;
        private XanderUI.XUIButton btnConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvMaterialsInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvProcessInfo;
    }
}