namespace DVLD.Applications.Manage_Applications.Manage_Local_License.License
{
    partial class frmLicenseHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicenseHistory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tbLocalLicenses = new System.Windows.Forms.TabPage();
            this.dgvLicensesHistory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsLocalLicense = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbInternationalLicenses = new System.Windows.Forms.TabPage();
            this.dgvInternationalLicenses = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblLocalLicensesTotalCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInternationalLicensesTotalCount = new System.Windows.Forms.Label();
            this.cmsInternationalLicense = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlPersonCardWithFilter1 = new DVLD.ctrlPersonCardWithFilter();
            this.guna2TabControl1.SuspendLayout();
            this.tbLocalLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicensesHistory)).BeginInit();
            this.cmsLocalLicense.SuspendLayout();
            this.tbInternationalLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).BeginInit();
            this.cmsInternationalLicense.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 32);
            this.label4.TabIndex = 118;
            this.label4.Text = "License History";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-28, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1164, 32);
            this.label1.TabIndex = 119;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------";
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.tbLocalLicenses);
            this.guna2TabControl1.Controls.Add(this.tbInternationalLicenses);
            this.guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 444);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1006, 240);
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
            this.guna2TabControl1.TabIndex = 121;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tbLocalLicenses
            // 
            this.tbLocalLicenses.BackColor = System.Drawing.Color.Black;
            this.tbLocalLicenses.Controls.Add(this.dgvLicensesHistory);
            this.tbLocalLicenses.Location = new System.Drawing.Point(4, 44);
            this.tbLocalLicenses.Name = "tbLocalLicenses";
            this.tbLocalLicenses.Size = new System.Drawing.Size(998, 192);
            this.tbLocalLicenses.TabIndex = 0;
            this.tbLocalLicenses.Text = "Local Licenses";
            // 
            // dgvLicensesHistory
            // 
            this.dgvLicensesHistory.AllowUserToAddRows = false;
            this.dgvLicensesHistory.AllowUserToDeleteRows = false;
            this.dgvLicensesHistory.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLicensesHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLicensesHistory.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLicensesHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLicensesHistory.ColumnHeadersHeight = 25;
            this.dgvLicensesHistory.ContextMenuStrip = this.cmsLocalLicense;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLicensesHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLicensesHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLicensesHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.dgvLicensesHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvLicensesHistory.Name = "dgvLicensesHistory";
            this.dgvLicensesHistory.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLicensesHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLicensesHistory.RowHeadersVisible = false;
            this.dgvLicensesHistory.RowHeadersWidth = 35;
            this.dgvLicensesHistory.RowTemplate.Height = 45;
            this.dgvLicensesHistory.Size = new System.Drawing.Size(998, 192);
            this.dgvLicensesHistory.TabIndex = 38;
            this.dgvLicensesHistory.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.dgvLicensesHistory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.dgvLicensesHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLicensesHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            this.dgvLicensesHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLicensesHistory.ThemeStyle.BackColor = System.Drawing.Color.Black;
            this.dgvLicensesHistory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.dgvLicensesHistory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.dgvLicensesHistory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLicensesHistory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.dgvLicensesHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLicensesHistory.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvLicensesHistory.ThemeStyle.ReadOnly = true;
            this.dgvLicensesHistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(58)))));
            this.dgvLicensesHistory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLicensesHistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLicensesHistory.ThemeStyle.RowsStyle.Height = 45;
            this.dgvLicensesHistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            this.dgvLicensesHistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // cmsLocalLicense
            // 
            this.cmsLocalLicense.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.cmsLocalLicense.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseToolStripMenuItem});
            this.cmsLocalLicense.Name = "cmsLocalLicense";
            this.cmsLocalLicense.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsLocalLicense.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsLocalLicense.RenderStyle.ColorTable = null;
            this.cmsLocalLicense.RenderStyle.RoundedEdges = true;
            this.cmsLocalLicense.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsLocalLicense.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsLocalLicense.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsLocalLicense.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsLocalLicense.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsLocalLicense.Size = new System.Drawing.Size(161, 36);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseToolStripMenuItem.Image")));
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(160, 32);
            this.showLicenseToolStripMenuItem.Text = "  Show License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // tbInternationalLicenses
            // 
            this.tbInternationalLicenses.BackColor = System.Drawing.Color.Black;
            this.tbInternationalLicenses.Controls.Add(this.dgvInternationalLicenses);
            this.tbInternationalLicenses.Location = new System.Drawing.Point(4, 44);
            this.tbInternationalLicenses.Name = "tbInternationalLicenses";
            this.tbInternationalLicenses.Padding = new System.Windows.Forms.Padding(3);
            this.tbInternationalLicenses.Size = new System.Drawing.Size(998, 192);
            this.tbInternationalLicenses.TabIndex = 1;
            this.tbInternationalLicenses.Text = "International Licenses";
            // 
            // dgvInternationalLicenses
            // 
            this.dgvInternationalLicenses.AllowUserToAddRows = false;
            this.dgvInternationalLicenses.AllowUserToDeleteRows = false;
            this.dgvInternationalLicenses.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInternationalLicenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInternationalLicenses.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternationalLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInternationalLicenses.ColumnHeadersHeight = 25;
            this.dgvInternationalLicenses.ContextMenuStrip = this.cmsInternationalLicense;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInternationalLicenses.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInternationalLicenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInternationalLicenses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.dgvInternationalLicenses.Location = new System.Drawing.Point(3, 3);
            this.dgvInternationalLicenses.Name = "dgvInternationalLicenses";
            this.dgvInternationalLicenses.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternationalLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvInternationalLicenses.RowHeadersVisible = false;
            this.dgvInternationalLicenses.RowHeadersWidth = 35;
            this.dgvInternationalLicenses.RowTemplate.Height = 45;
            this.dgvInternationalLicenses.Size = new System.Drawing.Size(992, 186);
            this.dgvInternationalLicenses.TabIndex = 39;
            this.dgvInternationalLicenses.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.dgvInternationalLicenses.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.dgvInternationalLicenses.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInternationalLicenses.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            this.dgvInternationalLicenses.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInternationalLicenses.ThemeStyle.BackColor = System.Drawing.Color.Black;
            this.dgvInternationalLicenses.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.dgvInternationalLicenses.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.dgvInternationalLicenses.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInternationalLicenses.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.dgvInternationalLicenses.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInternationalLicenses.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvInternationalLicenses.ThemeStyle.ReadOnly = true;
            this.dgvInternationalLicenses.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(58)))));
            this.dgvInternationalLicenses.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInternationalLicenses.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInternationalLicenses.ThemeStyle.RowsStyle.Height = 45;
            this.dgvInternationalLicenses.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            this.dgvInternationalLicenses.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // lblLocalLicensesTotalCount
            // 
            this.lblLocalLicensesTotalCount.AutoSize = true;
            this.lblLocalLicensesTotalCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalLicensesTotalCount.ForeColor = System.Drawing.Color.White;
            this.lblLocalLicensesTotalCount.Location = new System.Drawing.Point(904, 396);
            this.lblLocalLicensesTotalCount.Name = "lblLocalLicensesTotalCount";
            this.lblLocalLicensesTotalCount.Size = new System.Drawing.Size(23, 25);
            this.lblLocalLicensesTotalCount.TabIndex = 119;
            this.lblLocalLicensesTotalCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(688, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 122;
            this.label2.Text = "#Local Licenses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(688, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 25);
            this.label3.TabIndex = 124;
            this.label3.Text = "#International Licenses";
            // 
            // lblInternationalLicensesTotalCount
            // 
            this.lblInternationalLicensesTotalCount.AutoSize = true;
            this.lblInternationalLicensesTotalCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternationalLicensesTotalCount.ForeColor = System.Drawing.Color.White;
            this.lblInternationalLicensesTotalCount.Location = new System.Drawing.Point(904, 421);
            this.lblInternationalLicensesTotalCount.Name = "lblInternationalLicensesTotalCount";
            this.lblInternationalLicensesTotalCount.Size = new System.Drawing.Size(23, 25);
            this.lblInternationalLicensesTotalCount.TabIndex = 123;
            this.lblInternationalLicensesTotalCount.Text = "0";
            // 
            // cmsInternationalLicense
            // 
            this.cmsInternationalLicense.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.cmsInternationalLicense.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.cmsInternationalLicense.Name = "cmsLocalLicense";
            this.cmsInternationalLicense.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsInternationalLicense.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsInternationalLicense.RenderStyle.ColorTable = null;
            this.cmsInternationalLicense.RenderStyle.RoundedEdges = true;
            this.cmsInternationalLicense.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsInternationalLicense.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsInternationalLicense.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsInternationalLicense.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsInternationalLicense.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsInternationalLicense.Size = new System.Drawing.Size(161, 36);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 32);
            this.toolStripMenuItem1.Text = "  Show License";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(71, 62);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(856, 331);
            this.ctrlPersonCardWithFilter1.TabIndex = 120;
            // 
            // frmLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1006, 684);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblInternationalLicensesTotalCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLocalLicensesTotalCount);
            this.Controls.Add(this.guna2TabControl1);
            this.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "frmLicenseHistory";
            this.Text = "frmLicenseHistory";
            this.Load += new System.EventHandler(this.frmLicenseHistory_Load);
            this.guna2TabControl1.ResumeLayout(false);
            this.tbLocalLicenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicensesHistory)).EndInit();
            this.cmsLocalLicense.ResumeLayout(false);
            this.tbInternationalLicenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).EndInit();
            this.cmsInternationalLicense.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tbLocalLicenses;
        private System.Windows.Forms.TabPage tbInternationalLicenses;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLicensesHistory;
        private System.Windows.Forms.Label lblLocalLicensesTotalCount;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvInternationalLicenses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInternationalLicensesTotalCount;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsLocalLicense;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsInternationalLicense;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}