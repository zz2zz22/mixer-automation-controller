namespace htv5_mixer_control
{
    partial class InputSubInputData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxInputData = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditMaterial = new XanderUI.XUIButton();
            this.btnDeleteMaterial = new XanderUI.XUIButton();
            this.btnAddMaterial = new XanderUI.XUIButton();
            this.dtgvMaterialInfos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txbInputLotNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbInputCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.rtbRemark = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbProcessNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbTemperature = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbSpeed = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgvProcess = new System.Windows.Forms.DataGridView();
            this.btnProcessSave = new XanderUI.XUIButton();
            this.btnProcessDelete = new XanderUI.XUIButton();
            this.btnProcessEdit = new XanderUI.XUIButton();
            this.gbxInputData.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMaterialInfos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxInputData
            // 
            this.gbxInputData.BackColor = System.Drawing.Color.Aquamarine;
            this.gbxInputData.Controls.Add(this.panel2);
            this.gbxInputData.Controls.Add(this.panel1);
            this.gbxInputData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxInputData.Location = new System.Drawing.Point(0, 0);
            this.gbxInputData.Margin = new System.Windows.Forms.Padding(5);
            this.gbxInputData.Name = "gbxInputData";
            this.gbxInputData.Padding = new System.Windows.Forms.Padding(5);
            this.gbxInputData.Size = new System.Drawing.Size(1292, 692);
            this.gbxInputData.TabIndex = 2;
            this.gbxInputData.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnProcessEdit);
            this.panel2.Controls.Add(this.btnProcessDelete);
            this.panel2.Controls.Add(this.btnProcessSave);
            this.panel2.Controls.Add(this.dtgvProcess);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txbSpeed);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txbTemperature);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txbTime);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbProcessNumber);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.rtbRemark);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(526, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 662);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEditMaterial);
            this.panel1.Controls.Add(this.btnDeleteMaterial);
            this.panel1.Controls.Add(this.btnAddMaterial);
            this.panel1.Controls.Add(this.dtgvMaterialInfos);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txbInputLotNo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbInputCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(5, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 662);
            this.panel1.TabIndex = 0;
            // 
            // btnEditMaterial
            // 
            this.btnEditMaterial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditMaterial.ButtonImage = global::htv5_mixer_control.Properties.Resources.edit;
            this.btnEditMaterial.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnEditMaterial.ButtonText = "Button";
            this.btnEditMaterial.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnEditMaterial.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnEditMaterial.CornerRadius = 5;
            this.btnEditMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMaterial.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEditMaterial.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnEditMaterial.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnEditMaterial.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnEditMaterial.Location = new System.Drawing.Point(179, 143);
            this.btnEditMaterial.Name = "btnEditMaterial";
            this.btnEditMaterial.Size = new System.Drawing.Size(157, 61);
            this.btnEditMaterial.TabIndex = 18;
            this.btnEditMaterial.TextColor = System.Drawing.Color.Black;
            this.btnEditMaterial.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEditMaterial.Click += new System.EventHandler(this.btnEditMaterial_Click);
            // 
            // btnDeleteMaterial
            // 
            this.btnDeleteMaterial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDeleteMaterial.ButtonImage = global::htv5_mixer_control.Properties.Resources.delete;
            this.btnDeleteMaterial.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnDeleteMaterial.ButtonText = "Button";
            this.btnDeleteMaterial.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnDeleteMaterial.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteMaterial.CornerRadius = 5;
            this.btnDeleteMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMaterial.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDeleteMaterial.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnDeleteMaterial.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteMaterial.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnDeleteMaterial.Location = new System.Drawing.Point(342, 143);
            this.btnDeleteMaterial.Name = "btnDeleteMaterial";
            this.btnDeleteMaterial.Size = new System.Drawing.Size(157, 61);
            this.btnDeleteMaterial.TabIndex = 17;
            this.btnDeleteMaterial.TextColor = System.Drawing.Color.Black;
            this.btnDeleteMaterial.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDeleteMaterial.Click += new System.EventHandler(this.btnDeleteMaterial_Click);
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddMaterial.ButtonImage = global::htv5_mixer_control.Properties.Resources.ADD;
            this.btnAddMaterial.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnAddMaterial.ButtonText = "Button";
            this.btnAddMaterial.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnAddMaterial.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnAddMaterial.CornerRadius = 5;
            this.btnAddMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMaterial.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddMaterial.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnAddMaterial.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnAddMaterial.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnAddMaterial.Location = new System.Drawing.Point(11, 143);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(157, 61);
            this.btnAddMaterial.TabIndex = 16;
            this.btnAddMaterial.TextColor = System.Drawing.Color.Black;
            this.btnAddMaterial.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // dtgvMaterialInfos
            // 
            this.dtgvMaterialInfos.AllowUserToAddRows = false;
            this.dtgvMaterialInfos.AllowUserToDeleteRows = false;
            this.dtgvMaterialInfos.AllowUserToResizeColumns = false;
            this.dtgvMaterialInfos.AllowUserToResizeRows = false;
            this.dtgvMaterialInfos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMaterialInfos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgvMaterialInfos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMaterialInfos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvMaterialInfos.Location = new System.Drawing.Point(0, 208);
            this.dtgvMaterialInfos.MultiSelect = false;
            this.dtgvMaterialInfos.Name = "dtgvMaterialInfos";
            this.dtgvMaterialInfos.ReadOnly = true;
            this.dtgvMaterialInfos.RowHeadersVisible = false;
            this.dtgvMaterialInfos.RowHeadersWidth = 51;
            this.dtgvMaterialInfos.RowTemplate.Height = 24;
            this.dtgvMaterialInfos.Size = new System.Drawing.Size(519, 452);
            this.dtgvMaterialInfos.TabIndex = 15;
            this.dtgvMaterialInfos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMaterialInfos_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Bảng phối liệu / 配料:";
            // 
            // txbInputLotNo
            // 
            this.txbInputLotNo.Location = new System.Drawing.Point(114, 49);
            this.txbInputLotNo.Name = "txbInputLotNo";
            this.txbInputLotNo.Size = new System.Drawing.Size(272, 27);
            this.txbInputLotNo.TabIndex = 12;
            this.txbInputLotNo.Validating += new System.ComponentModel.CancelEventHandler(this.txbInputLotNo_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Số lô / 批號:";
            // 
            // txbInputCode
            // 
            this.txbInputCode.Location = new System.Drawing.Point(147, 8);
            this.txbInputCode.Name = "txbInputCode";
            this.txbInputCode.Size = new System.Drawing.Size(239, 27);
            this.txbInputCode.TabIndex = 8;
            this.txbInputCode.Validating += new System.ComponentModel.CancelEventHandler(this.txbInputCode_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quy cách / 型號:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // rtbRemark
            // 
            this.rtbRemark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbRemark.Location = new System.Drawing.Point(5, 54);
            this.rtbRemark.Name = "rtbRemark";
            this.rtbRemark.Size = new System.Drawing.Size(712, 97);
            this.rtbRemark.TabIndex = 0;
            this.rtbRemark.Text = "";
            this.rtbRemark.Validating += new System.ComponentModel.CancelEventHandler(this.rtbRemark_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mô tả thao tác nguyên liệu:\r\n材料处理说明";
            // 
            // lbProcessNumber
            // 
            this.lbProcessNumber.AutoSize = true;
            this.lbProcessNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcessNumber.Location = new System.Drawing.Point(301, 15);
            this.lbProcessNumber.Name = "lbProcessNumber";
            this.lbProcessNumber.Size = new System.Drawing.Size(0, 20);
            this.lbProcessNumber.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 40);
            this.label5.TabIndex = 3;
            this.label5.Text = "Thời gian trộn (phút):\r\n混合时间（分钟）";
            // 
            // txbTime
            // 
            this.txbTime.Location = new System.Drawing.Point(185, 167);
            this.txbTime.Name = "txbTime";
            this.txbTime.Size = new System.Drawing.Size(132, 27);
            this.txbTime.TabIndex = 4;
            this.txbTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTime_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 40);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nhiệt độ tối đa (độ C):\r\n最高温度（摄氏度）";
            // 
            // txbTemperature
            // 
            this.txbTemperature.Location = new System.Drawing.Point(185, 231);
            this.txbTemperature.Name = "txbTemperature";
            this.txbTemperature.Size = new System.Drawing.Size(132, 27);
            this.txbTemperature.TabIndex = 6;
            this.txbTemperature.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTemperature_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 40);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tốc độ quay (RPM):\r\n转数 (RPM)";
            // 
            // txbSpeed
            // 
            this.txbSpeed.Location = new System.Drawing.Point(185, 297);
            this.txbSpeed.Name = "txbSpeed";
            this.txbSpeed.Size = new System.Drawing.Size(132, 27);
            this.txbSpeed.TabIndex = 8;
            this.txbSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSpeed_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(5, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(350, 80);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nhập thông tin khi thao tác có thời gian, \r\nnhiệt độ, tốc độ nếu không thì bỏ trố" +
    "ng.\r\n当操作有时间、温度、速度时填写信息，\r\n否则留空。\r\n";
            // 
            // dtgvProcess
            // 
            this.dtgvProcess.AllowUserToAddRows = false;
            this.dtgvProcess.AllowUserToDeleteRows = false;
            this.dtgvProcess.AllowUserToResizeColumns = false;
            this.dtgvProcess.AllowUserToResizeRows = false;
            this.dtgvProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvProcess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProcess.Location = new System.Drawing.Point(364, 167);
            this.dtgvProcess.MultiSelect = false;
            this.dtgvProcess.Name = "dtgvProcess";
            this.dtgvProcess.ReadOnly = true;
            this.dtgvProcess.RowHeadersVisible = false;
            this.dtgvProcess.RowHeadersWidth = 51;
            this.dtgvProcess.RowTemplate.Height = 24;
            this.dtgvProcess.Size = new System.Drawing.Size(389, 267);
            this.dtgvProcess.TabIndex = 10;
            this.dtgvProcess.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvProcess_CellClick);
            // 
            // btnProcessSave
            // 
            this.btnProcessSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnProcessSave.ButtonImage = global::htv5_mixer_control.Properties.Resources.ADD;
            this.btnProcessSave.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnProcessSave.ButtonText = "Button";
            this.btnProcessSave.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnProcessSave.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnProcessSave.CornerRadius = 5;
            this.btnProcessSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessSave.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnProcessSave.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnProcessSave.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnProcessSave.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnProcessSave.Location = new System.Drawing.Point(22, 440);
            this.btnProcessSave.Name = "btnProcessSave";
            this.btnProcessSave.Size = new System.Drawing.Size(157, 61);
            this.btnProcessSave.TabIndex = 18;
            this.btnProcessSave.TextColor = System.Drawing.Color.Black;
            this.btnProcessSave.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnProcessSave.Click += new System.EventHandler(this.btnProcessSave_Click);
            // 
            // btnProcessDelete
            // 
            this.btnProcessDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnProcessDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnProcessDelete.ButtonImage = global::htv5_mixer_control.Properties.Resources.delete;
            this.btnProcessDelete.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnProcessDelete.ButtonText = "Button";
            this.btnProcessDelete.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnProcessDelete.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnProcessDelete.CornerRadius = 5;
            this.btnProcessDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessDelete.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnProcessDelete.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnProcessDelete.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnProcessDelete.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnProcessDelete.Location = new System.Drawing.Point(599, 440);
            this.btnProcessDelete.Name = "btnProcessDelete";
            this.btnProcessDelete.Size = new System.Drawing.Size(157, 61);
            this.btnProcessDelete.TabIndex = 19;
            this.btnProcessDelete.TextColor = System.Drawing.Color.Black;
            this.btnProcessDelete.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnProcessDelete.Click += new System.EventHandler(this.btnProcessDelete_Click);
            // 
            // btnProcessEdit
            // 
            this.btnProcessEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnProcessEdit.ButtonImage = global::htv5_mixer_control.Properties.Resources.edit;
            this.btnProcessEdit.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnProcessEdit.ButtonText = "Button";
            this.btnProcessEdit.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnProcessEdit.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnProcessEdit.CornerRadius = 5;
            this.btnProcessEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessEdit.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnProcessEdit.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnProcessEdit.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnProcessEdit.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnProcessEdit.Location = new System.Drawing.Point(198, 440);
            this.btnProcessEdit.Name = "btnProcessEdit";
            this.btnProcessEdit.Size = new System.Drawing.Size(157, 61);
            this.btnProcessEdit.TabIndex = 19;
            this.btnProcessEdit.TextColor = System.Drawing.Color.Black;
            this.btnProcessEdit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnProcessEdit.Click += new System.EventHandler(this.btnProcessEdit_Click);
            // 
            // InputSubInputData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1292, 692);
            this.Controls.Add(this.gbxInputData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InputSubInputData";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputSubInputData";
            this.Load += new System.EventHandler(this.InputSubInputData_Load);
            this.gbxInputData.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMaterialInfos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProcess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInputData;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbInputLotNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbInputCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private XanderUI.XUIButton btnAddMaterial;
        private System.Windows.Forms.DataGridView dtgvMaterialInfos;
        private XanderUI.XUIButton btnEditMaterial;
        private XanderUI.XUIButton btnDeleteMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbRemark;
        private System.Windows.Forms.Label lbProcessNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbSpeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbTemperature;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbTime;
        private System.Windows.Forms.DataGridView dtgvProcess;
        private XanderUI.XUIButton btnProcessDelete;
        private XanderUI.XUIButton btnProcessSave;
        private XanderUI.XUIButton btnProcessEdit;
    }
}