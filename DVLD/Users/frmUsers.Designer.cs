namespace DVLD.Users
{
    partial class frmUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.dgvUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.msDataGridVeiw = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContainer = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnAddNew = new Guna.UI2.WinForms.Guna2Button();
            this.cbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFiltering = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GradientPanel5 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2PictureBox8 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.llMoreDetails = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.msDataGridVeiw.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.guna2GradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.ColumnHeadersHeight = 25;
            this.dgvUsers.ContextMenuStrip = this.msDataGridVeiw;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.dgvUsers.Location = new System.Drawing.Point(0, 446);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidth = 35;
            this.dgvUsers.RowTemplate.Height = 45;
            this.dgvUsers.Size = new System.Drawing.Size(1549, 260);
            this.dgvUsers.TabIndex = 13;
            this.dgvUsers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.BackColor = System.Drawing.Color.Black;
            this.dgvUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.dgvUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.dgvUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.dgvUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsers.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvUsers.ThemeStyle.ReadOnly = true;
            this.dgvUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(58)))));
            this.dgvUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.RowsStyle.Height = 45;
            this.dgvUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            this.dgvUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeople_CellContentClick);
            this.dgvUsers.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellMouseEnter);
            this.dgvUsers.SelectionChanged += new System.EventHandler(this.dgvUsers_SelectionChanged);
            // 
            // msDataGridVeiw
            // 
            this.msDataGridVeiw.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msDataGridVeiw.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.addUserToolStripMenuItem,
            this.editUserToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.msDataGridVeiw.Name = "guna2ContextMenuStrip1";
            this.msDataGridVeiw.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.msDataGridVeiw.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.msDataGridVeiw.RenderStyle.ColorTable = null;
            this.msDataGridVeiw.RenderStyle.RoundedEdges = true;
            this.msDataGridVeiw.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.msDataGridVeiw.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.msDataGridVeiw.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.msDataGridVeiw.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.msDataGridVeiw.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.msDataGridVeiw.Size = new System.Drawing.Size(183, 154);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showDetailsToolStripMenuItem.Image")));
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(182, 30);
            this.showDetailsToolStripMenuItem.Text = "  Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addUserToolStripMenuItem.Image")));
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(182, 30);
            this.addUserToolStripMenuItem.Text = "  Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editUserToolStripMenuItem.Image")));
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(182, 30);
            this.editUserToolStripMenuItem.Text = "  Edit User";
            this.editUserToolStripMenuItem.Click += new System.EventHandler(this.editUserToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(182, 30);
            this.deleteToolStripMenuItem.Text = "  Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changePasswordToolStripMenuItem.Image")));
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(182, 30);
            this.changePasswordToolStripMenuItem.Text = "  Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlContainer.Controls.Add(this.guna2Panel1);
            this.pnlContainer.Controls.Add(this.btnAddNew);
            this.pnlContainer.Controls.Add(this.cbFilterBy);
            this.pnlContainer.Controls.Add(this.txtFiltering);
            this.pnlContainer.Controls.Add(this.guna2GradientPanel2);
            this.pnlContainer.Controls.Add(this.groupBox1);
            this.pnlContainer.Controls.Add(this.label1);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContainer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.pnlContainer.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1549, 446);
            this.pnlContainer.TabIndex = 36;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNew.BorderRadius = 10;
            this.btnAddNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNew.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(88)))), ((int)(((byte)(220)))));
            this.btnAddNew.FocusedColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(45)))), ((int)(((byte)(168)))));
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(1472, 395);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(67, 45);
            this.btnAddNew.TabIndex = 46;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterBy.BorderRadius = 10;
            this.cbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilterBy.ForeColor = System.Drawing.Color.Black;
            this.cbFilterBy.ItemHeight = 30;
            this.cbFilterBy.Items.AddRange(new object[] {
            "User ID",
            "Person ID",
            "User Name",
            "None"});
            this.cbFilterBy.Location = new System.Drawing.Point(73, 403);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(112, 36);
            this.cbFilterBy.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbFilterBy.TabIndex = 42;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFiltering
            // 
            this.txtFiltering.BackColor = System.Drawing.Color.Transparent;
            this.txtFiltering.BorderRadius = 10;
            this.txtFiltering.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltering.DefaultText = "";
            this.txtFiltering.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFiltering.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFiltering.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltering.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltering.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltering.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltering.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltering.Location = new System.Drawing.Point(191, 403);
            this.txtFiltering.Name = "txtFiltering";
            this.txtFiltering.PlaceholderText = "";
            this.txtFiltering.SelectedText = "";
            this.txtFiltering.Size = new System.Drawing.Size(101, 36);
            this.txtFiltering.TabIndex = 43;
            this.txtFiltering.TextChanged += new System.EventHandler(this.txtFiltering_TextChanged);
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BorderRadius = 15;
            this.guna2GradientPanel2.Controls.Add(this.lblTotalCount);
            this.guna2GradientPanel2.Controls.Add(this.guna2PictureBox3);
            this.guna2GradientPanel2.Controls.Add(this.label7);
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(88)))), ((int)(((byte)(118)))));
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(67)))), ((int)(((byte)(118)))));
            this.guna2GradientPanel2.Location = new System.Drawing.Point(11, 67);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(201, 100);
            this.guna2GradientPanel2.TabIndex = 45;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCount.ForeColor = System.Drawing.Color.White;
            this.lblTotalCount.Location = new System.Drawing.Point(134, 47);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(15, 17);
            this.lblTotalCount.TabIndex = 32;
            this.lblTotalCount.Text = "0";
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(108, 45);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(20, 22);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 31;
            this.guna2PictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Total Users";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BorderColor = System.Drawing.Color.White;
            this.groupBox1.BorderRadius = 25;
            this.groupBox1.BorderThickness = 3;
            this.groupBox1.Controls.Add(this.guna2GradientPanel5);
            this.groupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(88)))), ((int)(((byte)(220)))));
            this.groupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.groupBox1.FillColor = System.Drawing.Color.Transparent;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(535, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.groupBox1.ShadowDecoration.BorderRadius = 15;
            this.groupBox1.ShadowDecoration.Color = System.Drawing.Color.White;
            this.groupBox1.ShadowDecoration.Depth = 5;
            this.groupBox1.ShadowDecoration.Enabled = true;
            this.groupBox1.Size = new System.Drawing.Size(498, 301);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.Text = "USER CARD";
            this.groupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.groupBox1.UseTransparentBackground = true;
            // 
            // guna2GradientPanel5
            // 
            this.guna2GradientPanel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel5.BorderRadius = 8;
            this.guna2GradientPanel5.Controls.Add(this.guna2PictureBox8);
            this.guna2GradientPanel5.Controls.Add(this.lblUserName);
            this.guna2GradientPanel5.Controls.Add(this.label4);
            this.guna2GradientPanel5.Controls.Add(this.lblFullName);
            this.guna2GradientPanel5.Controls.Add(this.guna2PictureBox1);
            this.guna2GradientPanel5.Controls.Add(this.label2);
            this.guna2GradientPanel5.Controls.Add(this.lblIsActive);
            this.guna2GradientPanel5.Controls.Add(this.llMoreDetails);
            this.guna2GradientPanel5.Controls.Add(this.label3);
            this.guna2GradientPanel5.CustomizableEdges.TopLeft = false;
            this.guna2GradientPanel5.CustomizableEdges.TopRight = false;
            this.guna2GradientPanel5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(88)))), ((int)(((byte)(118)))));
            this.guna2GradientPanel5.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(67)))), ((int)(((byte)(118)))));
            this.guna2GradientPanel5.Location = new System.Drawing.Point(2, 40);
            this.guna2GradientPanel5.Name = "guna2GradientPanel5";
            this.guna2GradientPanel5.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.guna2GradientPanel5.Size = new System.Drawing.Size(498, 261);
            this.guna2GradientPanel5.TabIndex = 46;
            // 
            // guna2PictureBox8
            // 
            this.guna2PictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox8.Image")));
            this.guna2PictureBox8.ImageRotate = 0F;
            this.guna2PictureBox8.Location = new System.Drawing.Point(124, 109);
            this.guna2PictureBox8.Name = "guna2PictureBox8";
            this.guna2PictureBox8.Size = new System.Drawing.Size(20, 22);
            this.guna2PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox8.TabIndex = 30;
            this.guna2PictureBox8.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(152, 69);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(83, 20);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Is Active";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.White;
            this.lblFullName.Location = new System.Drawing.Point(152, 110);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(80, 20);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full Name";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(124, 67);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(20, 22);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 23;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "User Name";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.BackColor = System.Drawing.Color.Transparent;
            this.lblIsActive.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActive.ForeColor = System.Drawing.Color.White;
            this.lblIsActive.Location = new System.Drawing.Point(152, 147);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(65, 20);
            this.lblIsActive.TabIndex = 1;
            this.lblIsActive.Text = "IsActive";
            // 
            // llMoreDetails
            // 
            this.llMoreDetails.AutoSize = true;
            this.llMoreDetails.BackColor = System.Drawing.Color.Transparent;
            this.llMoreDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llMoreDetails.ForeColor = System.Drawing.Color.White;
            this.llMoreDetails.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llMoreDetails.LinkColor = System.Drawing.Color.White;
            this.llMoreDetails.Location = new System.Drawing.Point(344, 232);
            this.llMoreDetails.Name = "llMoreDetails";
            this.llMoreDetails.Size = new System.Drawing.Size(132, 15);
            this.llMoreDetails.TabIndex = 7;
            this.llMoreDetails.TabStop = true;
            this.llMoreDetails.Text = "Click To More Details...";
            this.llMoreDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llMoreDetails_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "FilterBy:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 32);
            this.label6.TabIndex = 47;
            this.label6.Text = "MANAGE USERS";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1549, 53);
            this.guna2Panel1.TabIndex = 48;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 706);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.pnlContainer);
            this.Name = "frmUsers";
            this.Text = "frmUsersManagment";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.msDataGridVeiw.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.guna2GradientPanel5.ResumeLayout(false);
            this.guna2GradientPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvUsers;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlContainer;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.Label lblTotalCount;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltering;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterBy;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel5;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox8;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFullName;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.LinkLabel llMoreDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAddNew;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip msDataGridVeiw;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label6;
    }
}