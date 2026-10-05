namespace DVLD.Applications.Driving_Licenses_Services.Released_Detained_Licneses
{
    partial class frmManageDetainedLicneses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageDetainedLicneses));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlContainer = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnDetain = new Guna.UI2.WinForms.Guna2Button();
            this.btnRelease = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFiltering = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDetainedLicenses = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContainer.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlContainer.Controls.Add(this.btnBack);
            this.pnlContainer.Controls.Add(this.btnDetain);
            this.pnlContainer.Controls.Add(this.btnRelease);
            this.pnlContainer.Controls.Add(this.guna2Panel1);
            this.pnlContainer.Controls.Add(this.cbFilterBy);
            this.pnlContainer.Controls.Add(this.txtFiltering);
            this.pnlContainer.Controls.Add(this.guna2GradientPanel2);
            this.pnlContainer.Controls.Add(this.label1);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContainer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.pnlContainer.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1530, 433);
            this.pnlContainer.TabIndex = 39;
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
            this.btnBack.Location = new System.Drawing.Point(1243, 391);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 34);
            this.btnBack.TabIndex = 76;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDetain
            // 
            this.btnDetain.BackColor = System.Drawing.Color.Transparent;
            this.btnDetain.BorderRadius = 10;
            this.btnDetain.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDetain.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDetain.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDetain.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDetain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(88)))), ((int)(((byte)(220)))));
            this.btnDetain.FocusedColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDetain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetain.ForeColor = System.Drawing.Color.White;
            this.btnDetain.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(45)))), ((int)(((byte)(168)))));
            this.btnDetain.Image = ((System.Drawing.Image)(resources.GetObject("btnDetain.Image")));
            this.btnDetain.Location = new System.Drawing.Point(1365, 382);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(67, 45);
            this.btnDetain.TabIndex = 51;
            this.btnDetain.Text = "Detain";
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // btnRelease
            // 
            this.btnRelease.BackColor = System.Drawing.Color.Transparent;
            this.btnRelease.BorderRadius = 10;
            this.btnRelease.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRelease.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRelease.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRelease.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRelease.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(88)))), ((int)(((byte)(220)))));
            this.btnRelease.FocusedColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRelease.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelease.ForeColor = System.Drawing.Color.White;
            this.btnRelease.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(45)))), ((int)(((byte)(168)))));
            this.btnRelease.Image = ((System.Drawing.Image)(resources.GetObject("btnRelease.Image")));
            this.btnRelease.Location = new System.Drawing.Point(1438, 382);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(80, 45);
            this.btnRelease.TabIndex = 52;
            this.btnRelease.Text = "Release";
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1530, 47);
            this.guna2Panel1.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(306, 32);
            this.label6.TabIndex = 47;
            this.label6.Text = " LIST DETAINED LICNESES";
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
            "Detain ID",
            "Is Released",
            "National No.",
            "Full Name",
            "Release Application ID"});
            this.cbFilterBy.Location = new System.Drawing.Point(73, 391);
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
            this.txtFiltering.Location = new System.Drawing.Point(211, 389);
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
            this.guna2GradientPanel2.Controls.Add(this.label7);
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(88)))), ((int)(((byte)(118)))));
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(67)))), ((int)(((byte)(118)))));
            this.guna2GradientPanel2.Location = new System.Drawing.Point(12, 92);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(127, 100);
            this.guna2GradientPanel2.TabIndex = 45;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCount.ForeColor = System.Drawing.Color.White;
            this.lblTotalCount.Location = new System.Drawing.Point(94, 42);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(15, 17);
            this.lblTotalCount.TabIndex = 32;
            this.lblTotalCount.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(17, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "#Records";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "FilterBy:";
            // 
            // dgvDetainedLicenses
            // 
            this.dgvDetainedLicenses.AllowUserToAddRows = false;
            this.dgvDetainedLicenses.AllowUserToDeleteRows = false;
            this.dgvDetainedLicenses.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDetainedLicenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetainedLicenses.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetainedLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetainedLicenses.ColumnHeadersHeight = 25;
            this.dgvDetainedLicenses.ContextMenuStrip = this.guna2ContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetainedLicenses.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetainedLicenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetainedLicenses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.dgvDetainedLicenses.Location = new System.Drawing.Point(0, 433);
            this.dgvDetainedLicenses.Name = "dgvDetainedLicenses";
            this.dgvDetainedLicenses.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetainedLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetainedLicenses.RowHeadersVisible = false;
            this.dgvDetainedLicenses.RowHeadersWidth = 35;
            this.dgvDetainedLicenses.RowTemplate.Height = 45;
            this.dgvDetainedLicenses.Size = new System.Drawing.Size(1530, 274);
            this.dgvDetainedLicenses.TabIndex = 50;
            this.dgvDetainedLicenses.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.dgvDetainedLicenses.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.dgvDetainedLicenses.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDetainedLicenses.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            this.dgvDetainedLicenses.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDetainedLicenses.ThemeStyle.BackColor = System.Drawing.Color.Black;
            this.dgvDetainedLicenses.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.dgvDetainedLicenses.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.dgvDetainedLicenses.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetainedLicenses.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.dgvDetainedLicenses.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetainedLicenses.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvDetainedLicenses.ThemeStyle.ReadOnly = true;
            this.dgvDetainedLicenses.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(58)))));
            this.dgvDetainedLicenses.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetainedLicenses.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDetainedLicenses.ThemeStyle.RowsStyle.Height = 45;
            this.dgvDetainedLicenses.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            this.dgvDetainedLicenses.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem,
            this.releaseDetainedLicenseToolStripMenuItem});
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
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(241, 132);
            this.guna2ContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.guna2ContextMenuStrip1_Opening);
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
            // releaseDetainedLicenseToolStripMenuItem
            // 
            this.releaseDetainedLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("releaseDetainedLicenseToolStripMenuItem.Image")));
            this.releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            this.releaseDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.releaseDetainedLicenseToolStripMenuItem.Text = "  Release  Detained License";
            // 
            // frmManageDetainedLicneses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1530, 707);
            this.Controls.Add(this.dgvDetainedLicenses);
            this.Controls.Add(this.pnlContainer);
            this.Name = "frmManageDetainedLicneses";
            this.Text = "frmManageDetainedLicneses";
            this.Load += new System.EventHandler(this.frmManageDetainedLicneses_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnlContainer;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterBy;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltering;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDetainedLicenses;
        private Guna.UI2.WinForms.Guna2Button btnDetain;
        private Guna.UI2.WinForms.Guna2Button btnRelease;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
    }
}