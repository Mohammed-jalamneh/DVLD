namespace DVLD.People
{
    partial class frmAddNewPeople
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewPeople));
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.llSetImage = new System.Windows.Forms.LinkLabel();
            this.llRemoveImage = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSecondName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtThirdName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNationalID = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox6 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox7 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.guna2PictureBox8 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.guna2PictureBox9 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbCountries = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.labelHeadLine = new System.Windows.Forms.Label();
            this.pnlContainer = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2PictureBox10 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox11 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox12 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox9)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(575, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // llSetImage
            // 
            this.llSetImage.AutoSize = true;
            this.llSetImage.BackColor = System.Drawing.Color.Transparent;
            this.llSetImage.Location = new System.Drawing.Point(572, 148);
            this.llSetImage.Name = "llSetImage";
            this.llSetImage.Size = new System.Drawing.Size(55, 13);
            this.llSetImage.TabIndex = 74;
            this.llSetImage.TabStop = true;
            this.llSetImage.Text = "Set Image";
            this.llSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSetImage_LinkClicked);
            // 
            // llRemoveImage
            // 
            this.llRemoveImage.AutoSize = true;
            this.llRemoveImage.BackColor = System.Drawing.Color.Transparent;
            this.llRemoveImage.Location = new System.Drawing.Point(654, 148);
            this.llRemoveImage.Name = "llRemoveImage";
            this.llRemoveImage.Size = new System.Drawing.Size(47, 13);
            this.llRemoveImage.TabIndex = 73;
            this.llRemoveImage.TabStop = true;
            this.llRemoveImage.Text = "Remove";
            this.llRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRemoveImage_LinkClicked);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.btnClose.Location = new System.Drawing.Point(294, 530);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 34);
            this.btnClose.TabIndex = 85;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.btnSave.Location = new System.Drawing.Point(394, 530);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 34);
            this.btnSave.TabIndex = 84;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderRadius = 10;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.DefaultText = "";
            this.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Location = new System.Drawing.Point(181, 53);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(131, 26);
            this.txtFirstName.TabIndex = 88;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(155, 57);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(20, 22);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 87;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.label13.Location = new System.Drawing.Point(26, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 25);
            this.label13.TabIndex = 86;
            this.label13.Text = "First Name";
            // 
            // txtSecondName
            // 
            this.txtSecondName.BorderRadius = 10;
            this.txtSecondName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSecondName.DefaultText = "";
            this.txtSecondName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSecondName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSecondName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSecondName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSecondName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSecondName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSecondName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSecondName.Location = new System.Drawing.Point(181, 97);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.PlaceholderText = "";
            this.txtSecondName.SelectedText = "";
            this.txtSecondName.Size = new System.Drawing.Size(131, 26);
            this.txtSecondName.TabIndex = 91;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(155, 101);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(20, 22);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 90;
            this.guna2PictureBox2.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(25, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 25);
            this.label14.TabIndex = 89;
            this.label14.Text = "Second Name";
            // 
            // txtThirdName
            // 
            this.txtThirdName.BorderRadius = 10;
            this.txtThirdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThirdName.DefaultText = "";
            this.txtThirdName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtThirdName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtThirdName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThirdName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThirdName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThirdName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtThirdName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThirdName.Location = new System.Drawing.Point(181, 141);
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.PlaceholderText = "";
            this.txtThirdName.SelectedText = "";
            this.txtThirdName.Size = new System.Drawing.Size(131, 26);
            this.txtThirdName.TabIndex = 94;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(155, 145);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(20, 22);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 93;
            this.guna2PictureBox3.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(26, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 25);
            this.label15.TabIndex = 92;
            this.label15.Text = "Third Name";
            // 
            // txtLastName
            // 
            this.txtLastName.BorderRadius = 10;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.DefaultText = "";
            this.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Location = new System.Drawing.Point(181, 185);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "";
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(131, 26);
            this.txtLastName.TabIndex = 97;
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.Image")));
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(155, 189);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(20, 22);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox4.TabIndex = 96;
            this.guna2PictureBox4.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(26, 185);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 25);
            this.label16.TabIndex = 95;
            this.label16.Text = "Last Name";
            // 
            // cbGender
            // 
            this.cbGender.BackColor = System.Drawing.Color.Transparent;
            this.cbGender.BorderRadius = 10;
            this.cbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbGender.ForeColor = System.Drawing.Color.Black;
            this.cbGender.ItemHeight = 30;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(181, 228);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(131, 36);
            this.cbGender.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbGender.TabIndex = 98;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(26, 234);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 25);
            this.label17.TabIndex = 99;
            this.label17.Text = "Gender";
            // 
            // txtNationalID
            // 
            this.txtNationalID.BorderRadius = 10;
            this.txtNationalID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationalID.DefaultText = "";
            this.txtNationalID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNationalID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNationalID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationalID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationalID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationalID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNationalID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationalID.Location = new System.Drawing.Point(343, 296);
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.PlaceholderText = "";
            this.txtNationalID.SelectedText = "";
            this.txtNationalID.Size = new System.Drawing.Size(131, 26);
            this.txtNationalID.TabIndex = 102;
            // 
            // guna2PictureBox5
            // 
            this.guna2PictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox5.Image")));
            this.guna2PictureBox5.ImageRotate = 0F;
            this.guna2PictureBox5.Location = new System.Drawing.Point(317, 300);
            this.guna2PictureBox5.Name = "guna2PictureBox5";
            this.guna2PictureBox5.Size = new System.Drawing.Size(20, 22);
            this.guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox5.TabIndex = 101;
            this.guna2PictureBox5.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(189, 296);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(122, 25);
            this.label18.TabIndex = 100;
            this.label18.Text = "National No.";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(116, 339);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(177, 26);
            this.txtEmail.TabIndex = 105;
            // 
            // guna2PictureBox6
            // 
            this.guna2PictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox6.Image")));
            this.guna2PictureBox6.ImageRotate = 0F;
            this.guna2PictureBox6.Location = new System.Drawing.Point(90, 339);
            this.guna2PictureBox6.Name = "guna2PictureBox6";
            this.guna2PictureBox6.Size = new System.Drawing.Size(20, 22);
            this.guna2PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox6.TabIndex = 104;
            this.guna2PictureBox6.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(26, 337);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 25);
            this.label19.TabIndex = 103;
            this.label19.Text = "Email";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderRadius = 10;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Location = new System.Drawing.Point(116, 386);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(177, 26);
            this.txtPhone.TabIndex = 108;
            // 
            // guna2PictureBox7
            // 
            this.guna2PictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox7.Image")));
            this.guna2PictureBox7.ImageRotate = 0F;
            this.guna2PictureBox7.Location = new System.Drawing.Point(90, 390);
            this.guna2PictureBox7.Name = "guna2PictureBox7";
            this.guna2PictureBox7.Size = new System.Drawing.Size(20, 22);
            this.guna2PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox7.TabIndex = 107;
            this.guna2PictureBox7.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(26, 386);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 25);
            this.label20.TabIndex = 106;
            this.label20.Text = "Phone";
            // 
            // guna2PictureBox8
            // 
            this.guna2PictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox8.Image")));
            this.guna2PictureBox8.ImageRotate = 0F;
            this.guna2PictureBox8.Location = new System.Drawing.Point(471, 340);
            this.guna2PictureBox8.Name = "guna2PictureBox8";
            this.guna2PictureBox8.Size = new System.Drawing.Size(20, 22);
            this.guna2PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox8.TabIndex = 110;
            this.guna2PictureBox8.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(351, 337);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(116, 25);
            this.label21.TabIndex = 109;
            this.label21.Text = "DateOfBirth";
            // 
            // guna2PictureBox9
            // 
            this.guna2PictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox9.Image")));
            this.guna2PictureBox9.ImageRotate = 0F;
            this.guna2PictureBox9.Location = new System.Drawing.Point(471, 391);
            this.guna2PictureBox9.Name = "guna2PictureBox9";
            this.guna2PictureBox9.Size = new System.Drawing.Size(20, 22);
            this.guna2PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox9.TabIndex = 113;
            this.guna2PictureBox9.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(351, 386);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(82, 25);
            this.label22.TabIndex = 112;
            this.label22.Text = "Country";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(180, 432);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(80, 25);
            this.label23.TabIndex = 115;
            this.label23.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(288, 445);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(200, 74);
            this.txtAddress.TabIndex = 116;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(622, 6);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 21);
            this.labelID.TabIndex = 117;
            this.labelID.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(569, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 25);
            this.label9.TabIndex = 118;
            this.label9.Text = "ID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = true;
            this.dateTimePicker1.FillColor = System.Drawing.Color.Transparent;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker1.Location = new System.Drawing.Point(497, 337);
            this.dateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 36);
            this.dateTimePicker1.TabIndex = 119;
            this.dateTimePicker1.Value = new System.DateTime(2026, 10, 1, 15, 50, 35, 224);
            // 
            // cbCountries
            // 
            this.cbCountries.BackColor = System.Drawing.Color.Transparent;
            this.cbCountries.BorderRadius = 10;
            this.cbCountries.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountries.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCountries.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCountries.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCountries.ForeColor = System.Drawing.Color.Black;
            this.cbCountries.ItemHeight = 30;
            this.cbCountries.Items.AddRange(new object[] {
            "User ID",
            "Person ID",
            "User Name",
            "None"});
            this.cbCountries.Location = new System.Drawing.Point(497, 391);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(131, 36);
            this.cbCountries.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbCountries.TabIndex = 120;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.guna2Panel1.Controls.Add(this.labelHeadLine);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(755, 53);
            this.guna2Panel1.TabIndex = 121;
            // 
            // labelHeadLine
            // 
            this.labelHeadLine.AutoSize = true;
            this.labelHeadLine.BackColor = System.Drawing.Color.Transparent;
            this.labelHeadLine.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeadLine.ForeColor = System.Drawing.Color.White;
            this.labelHeadLine.Location = new System.Drawing.Point(6, 9);
            this.labelHeadLine.Name = "labelHeadLine";
            this.labelHeadLine.Size = new System.Drawing.Size(237, 32);
            this.labelHeadLine.TabIndex = 47;
            this.labelHeadLine.Text = "Add-Update People";
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlContainer.Controls.Add(this.guna2PictureBox12);
            this.pnlContainer.Controls.Add(this.guna2PictureBox11);
            this.pnlContainer.Controls.Add(this.guna2PictureBox10);
            this.pnlContainer.Controls.Add(this.pictureBox1);
            this.pnlContainer.Controls.Add(this.llRemoveImage);
            this.pnlContainer.Controls.Add(this.cbCountries);
            this.pnlContainer.Controls.Add(this.llSetImage);
            this.pnlContainer.Controls.Add(this.dateTimePicker1);
            this.pnlContainer.Controls.Add(this.btnSave);
            this.pnlContainer.Controls.Add(this.label9);
            this.pnlContainer.Controls.Add(this.btnClose);
            this.pnlContainer.Controls.Add(this.labelID);
            this.pnlContainer.Controls.Add(this.label13);
            this.pnlContainer.Controls.Add(this.txtAddress);
            this.pnlContainer.Controls.Add(this.guna2PictureBox1);
            this.pnlContainer.Controls.Add(this.label23);
            this.pnlContainer.Controls.Add(this.txtFirstName);
            this.pnlContainer.Controls.Add(this.guna2PictureBox9);
            this.pnlContainer.Controls.Add(this.label14);
            this.pnlContainer.Controls.Add(this.label22);
            this.pnlContainer.Controls.Add(this.guna2PictureBox2);
            this.pnlContainer.Controls.Add(this.guna2PictureBox8);
            this.pnlContainer.Controls.Add(this.txtSecondName);
            this.pnlContainer.Controls.Add(this.label21);
            this.pnlContainer.Controls.Add(this.label15);
            this.pnlContainer.Controls.Add(this.txtPhone);
            this.pnlContainer.Controls.Add(this.guna2PictureBox3);
            this.pnlContainer.Controls.Add(this.guna2PictureBox7);
            this.pnlContainer.Controls.Add(this.txtThirdName);
            this.pnlContainer.Controls.Add(this.label20);
            this.pnlContainer.Controls.Add(this.label16);
            this.pnlContainer.Controls.Add(this.txtEmail);
            this.pnlContainer.Controls.Add(this.guna2PictureBox4);
            this.pnlContainer.Controls.Add(this.guna2PictureBox6);
            this.pnlContainer.Controls.Add(this.txtLastName);
            this.pnlContainer.Controls.Add(this.label19);
            this.pnlContainer.Controls.Add(this.cbGender);
            this.pnlContainer.Controls.Add(this.txtNationalID);
            this.pnlContainer.Controls.Add(this.label17);
            this.pnlContainer.Controls.Add(this.guna2PictureBox5);
            this.pnlContainer.Controls.Add(this.label18);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(54)))));
            this.pnlContainer.FillColor2 = System.Drawing.SystemColors.ButtonFace;
            this.pnlContainer.Location = new System.Drawing.Point(0, 53);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(755, 577);
            this.pnlContainer.TabIndex = 122;
            // 
            // guna2PictureBox10
            // 
            this.guna2PictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox10.Image")));
            this.guna2PictureBox10.ImageRotate = 0F;
            this.guna2PictureBox10.Location = new System.Drawing.Point(155, 235);
            this.guna2PictureBox10.Name = "guna2PictureBox10";
            this.guna2PictureBox10.Size = new System.Drawing.Size(20, 22);
            this.guna2PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox10.TabIndex = 121;
            this.guna2PictureBox10.TabStop = false;
            // 
            // guna2PictureBox11
            // 
            this.guna2PictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox11.Image")));
            this.guna2PictureBox11.ImageRotate = 0F;
            this.guna2PictureBox11.Location = new System.Drawing.Point(260, 436);
            this.guna2PictureBox11.Name = "guna2PictureBox11";
            this.guna2PictureBox11.Size = new System.Drawing.Size(20, 22);
            this.guna2PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox11.TabIndex = 122;
            this.guna2PictureBox11.TabStop = false;
            // 
            // guna2PictureBox12
            // 
            this.guna2PictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox12.Image")));
            this.guna2PictureBox12.ImageRotate = 0F;
            this.guna2PictureBox12.Location = new System.Drawing.Point(599, 9);
            this.guna2PictureBox12.Name = "guna2PictureBox12";
            this.guna2PictureBox12.Size = new System.Drawing.Size(17, 17);
            this.guna2PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox12.TabIndex = 123;
            this.guna2PictureBox12.TabStop = false;
            // 
            // frmAddNewPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(755, 630);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "frmAddNewPeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNewPeople";
            this.Load += new System.EventHandler(this.frmAddNewPeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox9)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel llSetImage;
        private System.Windows.Forms.LinkLabel llRemoveImage;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2TextBox txtThirdName;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2TextBox txtSecondName;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2ComboBox cbGender;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private System.Windows.Forms.Label label23;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox9;
        private System.Windows.Forms.Label label22;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox8;
        private System.Windows.Forms.Label label21;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox7;
        private System.Windows.Forms.Label label20;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox6;
        private System.Windows.Forms.Label label19;
        private Guna.UI2.WinForms.Guna2TextBox txtNationalID;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox cbCountries;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label labelHeadLine;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlContainer;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox10;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox12;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox11;
    }
}