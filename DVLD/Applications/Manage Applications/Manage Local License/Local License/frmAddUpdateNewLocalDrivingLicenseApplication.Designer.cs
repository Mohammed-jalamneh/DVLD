namespace DVLD.Applications.Driving_Licenses_Services
{
    partial class frmAddUpdateLocalDrivingLicenseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateLocalDrivingLicenseApplication));
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.TabPersonInfo = new System.Windows.Forms.TabPage();
            this.ctrlPersonCardWithFilter1 = new DVLD.ctrlPersonCardWithFilter();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.TabApplicationInfo = new System.Windows.Forms.TabPage();
            this.cbLicenseClasses = new System.Windows.Forms.ComboBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.guna2PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.lblProcessState = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TabControl1.SuspendLayout();
            this.TabPersonInfo.SuspendLayout();
            this.TabApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.TabPersonInfo);
            this.guna2TabControl1.Controls.Add(this.TabApplicationInfo);
            this.guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(855, 412);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 1;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            this.guna2TabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.guna2TabControl1_Selecting);
            // 
            // TabPersonInfo
            // 
            this.TabPersonInfo.BackColor = System.Drawing.Color.Transparent;
            this.TabPersonInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.TabPersonInfo.Controls.Add(this.btnNext);
            this.TabPersonInfo.Location = new System.Drawing.Point(4, 44);
            this.TabPersonInfo.Name = "TabPersonInfo";
            this.TabPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TabPersonInfo.Size = new System.Drawing.Size(847, 364);
            this.TabPersonInfo.TabIndex = 0;
            this.TabPersonInfo.Text = "PersonInfo";
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(-4, -1);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(856, 320);
            this.ctrlPersonCardWithFilter1.TabIndex = 2;
            // 
            // btnNext
            // 
            this.btnNext.BorderRadius = 7;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(729, 325);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 34);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // TabApplicationInfo
            // 
            this.TabApplicationInfo.Controls.Add(this.cbLicenseClasses);
            this.TabApplicationInfo.Controls.Add(this.lblCreatedBy);
            this.TabApplicationInfo.Controls.Add(this.lblApplicationFees);
            this.TabApplicationInfo.Controls.Add(this.lblApplicationDate);
            this.TabApplicationInfo.Controls.Add(this.lblApplicationID);
            this.TabApplicationInfo.Controls.Add(this.guna2PictureBox5);
            this.TabApplicationInfo.Controls.Add(this.guna2PictureBox4);
            this.TabApplicationInfo.Controls.Add(this.guna2PictureBox3);
            this.TabApplicationInfo.Controls.Add(this.guna2PictureBox2);
            this.TabApplicationInfo.Controls.Add(this.label5);
            this.TabApplicationInfo.Controls.Add(this.label4);
            this.TabApplicationInfo.Controls.Add(this.btnBack);
            this.TabApplicationInfo.Controls.Add(this.lblProcessState);
            this.TabApplicationInfo.Controls.Add(this.label1);
            this.TabApplicationInfo.Controls.Add(this.label3);
            this.TabApplicationInfo.Controls.Add(this.guna2PictureBox1);
            this.TabApplicationInfo.Controls.Add(this.label2);
            this.TabApplicationInfo.Controls.Add(this.btnClose);
            this.TabApplicationInfo.Controls.Add(this.btnSave);
            this.TabApplicationInfo.Location = new System.Drawing.Point(4, 44);
            this.TabApplicationInfo.Name = "TabApplicationInfo";
            this.TabApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TabApplicationInfo.Size = new System.Drawing.Size(847, 364);
            this.TabApplicationInfo.TabIndex = 1;
            this.TabApplicationInfo.Text = "Application Information";
            this.TabApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // cbLicenseClasses
            // 
            this.cbLicenseClasses.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbLicenseClasses.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbLicenseClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLicenseClasses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLicenseClasses.FormattingEnabled = true;
            this.cbLicenseClasses.Location = new System.Drawing.Point(225, 174);
            this.cbLicenseClasses.Name = "cbLicenseClasses";
            this.cbLicenseClasses.Size = new System.Drawing.Size(173, 23);
            this.cbLicenseClasses.TabIndex = 75;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lblCreatedBy.Location = new System.Drawing.Point(221, 249);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(99, 21);
            this.lblCreatedBy.TabIndex = 74;
            this.lblCreatedBy.Text = "CreatedBy...";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationFees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lblApplicationFees.Location = new System.Drawing.Point(221, 211);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(144, 21);
            this.lblApplicationFees.TabIndex = 73;
            this.lblApplicationFees.Text = "ApplicationFees...";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lblApplicationDate.Location = new System.Drawing.Point(221, 135);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(147, 21);
            this.lblApplicationDate.TabIndex = 71;
            this.lblApplicationDate.Text = "ApplicationDate...";
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lblApplicationID.Location = new System.Drawing.Point(221, 97);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(38, 21);
            this.lblApplicationID.TabIndex = 70;
            this.lblApplicationID.Text = "ID...";
            // 
            // guna2PictureBox5
            // 
            this.guna2PictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox5.Image")));
            this.guna2PictureBox5.ImageRotate = 0F;
            this.guna2PictureBox5.Location = new System.Drawing.Point(185, 96);
            this.guna2PictureBox5.Name = "guna2PictureBox5";
            this.guna2PictureBox5.Size = new System.Drawing.Size(20, 22);
            this.guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox5.TabIndex = 69;
            this.guna2PictureBox5.TabStop = false;
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.Image")));
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(185, 248);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(20, 22);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox4.TabIndex = 68;
            this.guna2PictureBox4.TabStop = false;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(185, 210);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(20, 22);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 67;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(185, 172);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(20, 22);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 66;
            this.guna2PictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(23, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 65;
            this.label5.Text = "Created By";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(23, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 25);
            this.label4.TabIndex = 64;
            this.label4.Text = "Application Fees";
            // 
            // btnBack
            // 
            this.btnBack.BorderRadius = 7;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(6, 315);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 34);
            this.btnBack.TabIndex = 63;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblProcessState
            // 
            this.lblProcessState.AutoSize = true;
            this.lblProcessState.BackColor = System.Drawing.Color.Transparent;
            this.lblProcessState.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lblProcessState.Location = new System.Drawing.Point(200, 3);
            this.lblProcessState.Name = "lblProcessState";
            this.lblProcessState.Size = new System.Drawing.Size(437, 30);
            this.lblProcessState.TabIndex = 62;
            this.lblProcessState.Text = "Add New Local Driving License Application";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(22, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "License Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(23, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 54;
            this.label3.Text = "Application Date";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(185, 134);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(20, 22);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 52;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(22, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "D.L.Application ID";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 7;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnClose.FocusedColor = System.Drawing.Color.PapayaWhip;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(596, 312);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 34);
            this.btnClose.TabIndex = 47;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 7;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(696, 312);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 34);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddUpdateLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 412);
            this.Controls.Add(this.guna2TabControl1);
            this.Name = "frmAddUpdateLocalDrivingLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUpdateLocalDrivingLicenseApplication";
            this.Load += new System.EventHandler(this.frmNewLocalDrivingLicenseApplication_Load);
            this.guna2TabControl1.ResumeLayout(false);
            this.TabPersonInfo.ResumeLayout(false);
            this.TabApplicationInfo.ResumeLayout(false);
            this.TabApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage TabPersonInfo;
        private ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.TabPage TabApplicationInfo;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox5;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.Label lblProcessState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.ComboBox cbLicenseClasses;
    }
}