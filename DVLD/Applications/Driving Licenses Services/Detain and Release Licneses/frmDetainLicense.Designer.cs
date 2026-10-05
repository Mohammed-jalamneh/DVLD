namespace DVLD.Applications.Driving_Licenses_Services.Released_Detained_Licneses
{
    partial class frmDetainLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetainLicense));
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.llShowReplacementLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnDetain = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.llShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.txtFineFees = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.guna2PictureBox7 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.guna2PictureBox12 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label23 = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrlDriverLicenseWithFilter1 = new DVLD.Controls.ctrlDriverLicenseWithFilter();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 141;
            this.label1.Text = "Detain Info";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(198, 562);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 15);
            this.label10.TabIndex = 140;
            this.label10.Text = "License History:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(448, 564);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 139;
            this.label7.Text = "New License:";
            // 
            // llShowReplacementLicenseInfo
            // 
            this.llShowReplacementLicenseInfo.AutoSize = true;
            this.llShowReplacementLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llShowReplacementLicenseInfo.LinkColor = System.Drawing.Color.White;
            this.llShowReplacementLicenseInfo.Location = new System.Drawing.Point(529, 576);
            this.llShowReplacementLicenseInfo.Name = "llShowReplacementLicenseInfo";
            this.llShowReplacementLicenseInfo.Size = new System.Drawing.Size(87, 15);
            this.llShowReplacementLicenseInfo.TabIndex = 138;
            this.llShowReplacementLicenseInfo.TabStop = true;
            this.llShowReplacementLicenseInfo.Text = "Show  License";
            this.llShowReplacementLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseInfo_LinkClicked);
            // 
            // btnDetain
            // 
            this.btnDetain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDetain.BorderRadius = 7;
            this.btnDetain.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDetain.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDetain.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDetain.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDetain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnDetain.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetain.ForeColor = System.Drawing.Color.White;
            this.btnDetain.Image = ((System.Drawing.Image)(resources.GetObject("btnDetain.Image")));
            this.btnDetain.Location = new System.Drawing.Point(755, 564);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(84, 34);
            this.btnDetain.TabIndex = 137;
            this.btnDetain.Text = "Detain";
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
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
            this.btnClose.Location = new System.Drawing.Point(18, 564);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 34);
            this.btnClose.TabIndex = 136;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // llShowLicenseHistory
            // 
            this.llShowLicenseHistory.AutoSize = true;
            this.llShowLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llShowLicenseHistory.LinkColor = System.Drawing.Color.White;
            this.llShowLicenseHistory.Location = new System.Drawing.Point(286, 575);
            this.llShowLicenseHistory.Name = "llShowLicenseHistory";
            this.llShowLicenseHistory.Size = new System.Drawing.Size(133, 15);
            this.llShowLicenseHistory.TabIndex = 135;
            this.llShowLicenseHistory.TabStop = true;
            this.llShowLicenseHistory.Text = "Show License History...";
            this.llShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseHistory_LinkClicked);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.txtFineFees);
            this.guna2ShadowPanel1.Controls.Add(this.lblLicenseID);
            this.guna2ShadowPanel1.Controls.Add(this.guna2PictureBox7);
            this.guna2ShadowPanel1.Controls.Add(this.label12);
            this.guna2ShadowPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2ShadowPanel1.Controls.Add(this.label6);
            this.guna2ShadowPanel1.Controls.Add(this.lblDetainDate);
            this.guna2ShadowPanel1.Controls.Add(this.guna2PictureBox12);
            this.guna2ShadowPanel1.Controls.Add(this.label23);
            this.guna2ShadowPanel1.Controls.Add(this.lblCreatedBy);
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.lblDetainID);
            this.guna2ShadowPanel1.Controls.Add(this.guna2PictureBox4);
            this.guna2ShadowPanel1.Controls.Add(this.guna2PictureBox5);
            this.guna2ShadowPanel1.Controls.Add(this.label5);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.AliceBlue;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(6, 398);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Blue;
            this.guna2ShadowPanel1.ShadowShift = 10;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(842, 151);
            this.guna2ShadowPanel1.TabIndex = 134;
            // 
            // txtFineFees
            // 
            this.txtFineFees.BorderRadius = 10;
            this.txtFineFees.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFineFees.DefaultText = "";
            this.txtFineFees.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFineFees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFineFees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFineFees.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFineFees.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFineFees.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFineFees.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFineFees.Location = new System.Drawing.Point(245, 104);
            this.txtFineFees.Name = "txtFineFees";
            this.txtFineFees.PlaceholderText = "";
            this.txtFineFees.SelectedText = "";
            this.txtFineFees.Size = new System.Drawing.Size(110, 27);
            this.txtFineFees.TabIndex = 128;
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.ForeColor = System.Drawing.Color.Black;
            this.lblLicenseID.Location = new System.Drawing.Point(599, 36);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(31, 21);
            this.lblLicenseID.TabIndex = 126;
            this.lblLicenseID.Text = "???";
            // 
            // guna2PictureBox7
            // 
            this.guna2PictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox7.Image")));
            this.guna2PictureBox7.ImageRotate = 0F;
            this.guna2PictureBox7.Location = new System.Drawing.Point(573, 36);
            this.guna2PictureBox7.Name = "guna2PictureBox7";
            this.guna2PictureBox7.Size = new System.Drawing.Size(20, 22);
            this.guna2PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox7.TabIndex = 127;
            this.guna2PictureBox7.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(438, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 25);
            this.label12.TabIndex = 125;
            this.label12.Text = "License ID";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(215, 107);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(20, 22);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 115;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(51, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 113;
            this.label6.Text = "Fine  Fees";
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainDate.ForeColor = System.Drawing.Color.Black;
            this.lblDetainDate.Location = new System.Drawing.Point(244, 68);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(31, 21);
            this.lblDetainDate.TabIndex = 86;
            this.lblDetainDate.Text = "???";
            // 
            // guna2PictureBox12
            // 
            this.guna2PictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox12.Image")));
            this.guna2PictureBox12.ImageRotate = 0F;
            this.guna2PictureBox12.Location = new System.Drawing.Point(208, 66);
            this.guna2PictureBox12.Name = "guna2PictureBox12";
            this.guna2PictureBox12.Size = new System.Drawing.Size(30, 22);
            this.guna2PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox12.TabIndex = 87;
            this.guna2PictureBox12.TabStop = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label23.Location = new System.Drawing.Point(50, 64);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(115, 25);
            this.label23.TabIndex = 84;
            this.label23.Text = "Detain Date";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedBy.Location = new System.Drawing.Point(599, 68);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(31, 21);
            this.lblCreatedBy.TabIndex = 81;
            this.lblCreatedBy.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(438, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 80;
            this.label2.Text = "CreatedBy";
            // 
            // lblDetainID
            // 
            this.lblDetainID.AutoSize = true;
            this.lblDetainID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainID.ForeColor = System.Drawing.Color.Black;
            this.lblDetainID.Location = new System.Drawing.Point(241, 32);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(31, 21);
            this.lblDetainID.TabIndex = 67;
            this.lblDetainID.Text = "???";
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.Image")));
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(215, 32);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(20, 22);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox4.TabIndex = 70;
            this.guna2PictureBox4.TabStop = false;
            // 
            // guna2PictureBox5
            // 
            this.guna2PictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox5.Image")));
            this.guna2PictureBox5.ImageRotate = 0F;
            this.guna2PictureBox5.Location = new System.Drawing.Point(573, 68);
            this.guna2PictureBox5.Name = "guna2PictureBox5";
            this.guna2PictureBox5.Size = new System.Drawing.Size(20, 22);
            this.guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox5.TabIndex = 69;
            this.guna2PictureBox5.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(50, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 65;
            this.label5.Text = "Detain ID";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(324, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(179, 32);
            this.lblTitle.TabIndex = 133;
            this.lblTitle.Text = "Detain License";
            // 
            // ctrlDriverLicenseWithFilter1
            // 
            this.ctrlDriverLicenseWithFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ctrlDriverLicenseWithFilter1.Location = new System.Drawing.Point(3, 48);
            this.ctrlDriverLicenseWithFilter1.Name = "ctrlDriverLicenseWithFilter1";
            this.ctrlDriverLicenseWithFilter1.Size = new System.Drawing.Size(843, 325);
            this.ctrlDriverLicenseWithFilter1.TabIndex = 132;
            // 
            // frmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(850, 622);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.llShowReplacementLicenseInfo);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.llShowLicenseHistory);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlDriverLicenseWithFilter1);
            this.Name = "frmDetainLicense";
            this.Text = "frmDetainLicense";
            this.Load += new System.EventHandler(this.frmDetainLicense_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel llShowReplacementLicenseInfo;
        private Guna.UI2.WinForms.Guna2Button btnDetain;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.LinkLabel llShowLicenseHistory;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txtFineFees;
        private System.Windows.Forms.Label lblLicenseID;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox7;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDetainDate;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox12;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDetainID;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTitle;
        private Controls.ctrlDriverLicenseWithFilter ctrlDriverLicenseWithFilter1;
    }
}