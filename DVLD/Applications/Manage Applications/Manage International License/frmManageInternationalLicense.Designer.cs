namespace DVLD.Applications.Manage_Applications.Manage_International_License
{
    partial class frmManageInternationalLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageInternationalLicense));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlContainer = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.cbIsActive = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNew = new Guna.UI2.WinForms.Guna2Button();
            this.dgvInternational = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblTotalApplicatoins = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFiltering = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternational)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlContainer.Controls.Add(this.cbIsActive);
            this.pnlContainer.Controls.Add(this.btnBack);
            this.pnlContainer.Controls.Add(this.btnAddNew);
            this.pnlContainer.Controls.Add(this.dgvInternational);
            this.pnlContainer.Controls.Add(this.guna2GradientPanel1);
            this.pnlContainer.Controls.Add(this.guna2GradientPanel2);
            this.pnlContainer.Controls.Add(this.txtFiltering);
            this.pnlContainer.Controls.Add(this.cbFilterBy);
            this.pnlContainer.Controls.Add(this.label1);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlContainer.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1544, 742);
            this.pnlContainer.TabIndex = 37;
            // 
            // cbIsActive
            // 
            this.cbIsActive.BackColor = System.Drawing.Color.Transparent;
            this.cbIsActive.BorderRadius = 10;
            this.cbIsActive.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsActive.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIsActive.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIsActive.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbIsActive.ItemHeight = 30;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsActive.Location = new System.Drawing.Point(206, 398);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(140, 36);
            this.cbIsActive.TabIndex = 76;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderRadius = 7;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1438, 401);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 34);
            this.btnBack.TabIndex = 75;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNew.BorderRadius = 10;
            this.btnAddNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNew.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(67)))), ((int)(((byte)(118)))));
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(45)))), ((int)(((byte)(168)))));
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(14, 332);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(58, 45);
            this.btnAddNew.TabIndex = 49;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // dgvInternational
            // 
            this.dgvInternational.AllowUserToAddRows = false;
            this.dgvInternational.AllowUserToDeleteRows = false;
            this.dgvInternational.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInternational.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInternational.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternational.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInternational.ColumnHeadersHeight = 25;
            this.dgvInternational.ContextMenuStrip = this.guna2ContextMenuStrip1;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInternational.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInternational.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvInternational.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.dgvInternational.Location = new System.Drawing.Point(0, 440);
            this.dgvInternational.Name = "dgvInternational";
            this.dgvInternational.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternational.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvInternational.RowHeadersVisible = false;
            this.dgvInternational.RowTemplate.Height = 50;
            this.dgvInternational.Size = new System.Drawing.Size(1544, 302);
            this.dgvInternational.TabIndex = 48;
            this.dgvInternational.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.dgvInternational.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.dgvInternational.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInternational.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            this.dgvInternational.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInternational.ThemeStyle.BackColor = System.Drawing.Color.Black;
            this.dgvInternational.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.dgvInternational.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.dgvInternational.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInternational.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.dgvInternational.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInternational.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvInternational.ThemeStyle.ReadOnly = true;
            this.dgvInternational.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(58)))));
            this.dgvInternational.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInternational.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInternational.ThemeStyle.RowsStyle.Height = 50;
            this.dgvInternational.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            this.dgvInternational.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(241, 100);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showPersonDetailsToolStripMenuItem.Image")));
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.showPersonDetailsToolStripMenuItem.Text = "  Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseDetailsToolStripMenuItem.Image")));
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.showLicenseDetailsToolStripMenuItem.Text = "  Show License Details";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showPersonLicenseHistoryToolStripMenuItem.Image")));
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "  Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.guna2GradientPanel1.Controls.Add(this.label6);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1544, 53);
            this.guna2GradientPanel1.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(502, 32);
            this.label6.TabIndex = 19;
            this.label6.Text = "Manage International License Applications";
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BorderRadius = 15;
            this.guna2GradientPanel2.Controls.Add(this.lblTotalApplicatoins);
            this.guna2GradientPanel2.Controls.Add(this.label7);
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(88)))), ((int)(((byte)(118)))));
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(67)))), ((int)(((byte)(118)))));
            this.guna2GradientPanel2.Location = new System.Drawing.Point(12, 59);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(201, 100);
            this.guna2GradientPanel2.TabIndex = 45;
            // 
            // lblTotalApplicatoins
            // 
            this.lblTotalApplicatoins.AutoSize = true;
            this.lblTotalApplicatoins.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalApplicatoins.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalApplicatoins.ForeColor = System.Drawing.Color.White;
            this.lblTotalApplicatoins.Location = new System.Drawing.Point(160, 43);
            this.lblTotalApplicatoins.Name = "lblTotalApplicatoins";
            this.lblTotalApplicatoins.Size = new System.Drawing.Size(23, 25);
            this.lblTotalApplicatoins.TabIndex = 32;
            this.lblTotalApplicatoins.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 21);
            this.label7.TabIndex = 31;
            this.label7.Text = "Total Applications";
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
            this.txtFiltering.Location = new System.Drawing.Point(206, 399);
            this.txtFiltering.Name = "txtFiltering";
            this.txtFiltering.PlaceholderText = "";
            this.txtFiltering.SelectedText = "";
            this.txtFiltering.Size = new System.Drawing.Size(101, 36);
            this.txtFiltering.TabIndex = 43;
            this.txtFiltering.TextChanged += new System.EventHandler(this.txtFiltering_TextChanged);
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
            "None",
            "DriverID",
            "IsActive"});
            this.cbFilterBy.Location = new System.Drawing.Point(88, 399);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(112, 36);
            this.cbFilterBy.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbFilterBy.TabIndex = 42;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "FilterBy:";
            // 
            // frmManageInternationalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 742);
            this.Controls.Add(this.pnlContainer);
            this.Name = "frmManageInternationalLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageInternationalLicense";
            this.Load += new System.EventHandler(this.frmManageInternationalLicense_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternational)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnlContainer;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnAddNew;
        private Guna.UI2.WinForms.Guna2DataGridView dgvInternational;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.Label lblTotalApplicatoins;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltering;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ComboBox cbIsActive;
    }
}