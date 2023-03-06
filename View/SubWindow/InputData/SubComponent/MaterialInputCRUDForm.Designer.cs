namespace htv5_mixer_control
{
    partial class MaterialInputCRUDForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveMaterial = new XanderUI.XUIButton();
            this.txbInputMaterialTolerance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbInputMaterialWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbInputMaterialLot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbInputMaterialName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbxCheckPacked = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxCheckPacked);
            this.panel1.Controls.Add(this.btnSaveMaterial);
            this.panel1.Controls.Add(this.txbInputMaterialTolerance);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txbInputMaterialWeight);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbInputMaterialLot);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbInputMaterialName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 355);
            this.panel1.TabIndex = 0;
            // 
            // btnSaveMaterial
            // 
            this.btnSaveMaterial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSaveMaterial.ButtonImage = global::htv5_mixer_control.Properties.Resources.save;
            this.btnSaveMaterial.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSaveMaterial.ButtonText = "text";
            this.btnSaveMaterial.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSaveMaterial.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveMaterial.CornerRadius = 5;
            this.btnSaveMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMaterial.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSaveMaterial.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSaveMaterial.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveMaterial.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSaveMaterial.Location = new System.Drawing.Point(363, 274);
            this.btnSaveMaterial.Name = "btnSaveMaterial";
            this.btnSaveMaterial.Size = new System.Drawing.Size(269, 62);
            this.btnSaveMaterial.TabIndex = 8;
            this.btnSaveMaterial.TextColor = System.Drawing.Color.Black;
            this.btnSaveMaterial.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSaveMaterial.Click += new System.EventHandler(this.btnSaveMaterial_Click);
            // 
            // txbInputMaterialTolerance
            // 
            this.txbInputMaterialTolerance.Location = new System.Drawing.Point(403, 124);
            this.txbInputMaterialTolerance.Name = "txbInputMaterialTolerance";
            this.txbInputMaterialTolerance.Size = new System.Drawing.Size(129, 27);
            this.txbInputMaterialTolerance.TabIndex = 7;
            this.txbInputMaterialTolerance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbInputMaterialTolerance_KeyDown);
            this.txbInputMaterialTolerance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbInputMaterialTolerance_KeyPress);
            this.txbInputMaterialTolerance.Validating += new System.ComponentModel.CancelEventHandler(this.txbInputMaterialTolerance_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 40);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dung sai:\r\n公差";
            // 
            // txbInputMaterialWeight
            // 
            this.txbInputMaterialWeight.Location = new System.Drawing.Point(120, 124);
            this.txbInputMaterialWeight.Name = "txbInputMaterialWeight";
            this.txbInputMaterialWeight.Size = new System.Drawing.Size(146, 27);
            this.txbInputMaterialWeight.TabIndex = 5;
            this.txbInputMaterialWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbInputMaterialWeight_KeyPress);
            this.txbInputMaterialWeight.Validating += new System.ComponentModel.CancelEventHandler(this.txbInputMaterialWeight_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trọng lượng:\r\n分量\r\n";
            // 
            // txbInputMaterialLot
            // 
            this.txbInputMaterialLot.Location = new System.Drawing.Point(192, 63);
            this.txbInputMaterialLot.Name = "txbInputMaterialLot";
            this.txbInputMaterialLot.Size = new System.Drawing.Size(290, 27);
            this.txbInputMaterialLot.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lô:\r\n批號\r\n";
            // 
            // txbInputMaterialName
            // 
            this.txbInputMaterialName.Location = new System.Drawing.Point(188, 6);
            this.txbInputMaterialName.Name = "txbInputMaterialName";
            this.txbInputMaterialName.Size = new System.Drawing.Size(294, 27);
            this.txbInputMaterialName.TabIndex = 1;
            this.txbInputMaterialName.Validating += new System.ComponentModel.CancelEventHandler(this.txbInputMaterialName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên nguyên liệu:\r\n输入成分名称\r\n";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cbxCheckPacked
            // 
            this.cbxCheckPacked.AutoSize = true;
            this.cbxCheckPacked.Location = new System.Drawing.Point(188, 201);
            this.cbxCheckPacked.Name = "cbxCheckPacked";
            this.cbxCheckPacked.Size = new System.Drawing.Size(442, 44);
            this.cbxCheckPacked.TabIndex = 9;
            this.cbxCheckPacked.Text = "Nguyên liệu được tính theo dạng gói hoặc thùng có sẵn.\r\n原材料按可提供的包装或盒的形式计算。";
            this.cbxCheckPacked.UseVisualStyleBackColor = true;
            // 
            // MaterialInputCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 355);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaterialInputCRUDForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputCRUDForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbInputMaterialLot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbInputMaterialName;
        private System.Windows.Forms.TextBox txbInputMaterialWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private XanderUI.XUIButton btnSaveMaterial;
        private System.Windows.Forms.TextBox txbInputMaterialTolerance;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox cbxCheckPacked;
    }
}