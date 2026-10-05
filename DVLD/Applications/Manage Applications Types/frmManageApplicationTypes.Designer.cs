namespace DVLD.Applications
{
    partial class frmManageApplicationTypes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageApplicationTypes));
            this.pnlContainer = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvApplicationTypes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.updateApplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContainer.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlContainer.Controls.Add(this.lblTotalCount);
            this.pnlContainer.Controls.Add(this.label1);
            this.pnlContainer.Controls.Add(this.guna2PictureBox1);
            this.pnlContainer.Controls.Add(this.guna2Panel1);
            this.pnlContainer.Controls.Add(this.button1);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContainer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.pnlContainer.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(117)))), ((int)(((byte)(252)))));
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(921, 364);
            this.pnlContainer.TabIndex = 37;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(921, 53);
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
            this.label6.Size = new System.Drawing.Size(360, 32);
            this.label6.TabIndex = 47;
            this.label6.Text = "MANAGE APPLICATION TYPES";
            // 
            // dgvApplicationTypes
            // 
            this.dgvApplicationTypes.AllowUserToAddRows = false;
            this.dgvApplicationTypes.AllowUserToDeleteRows = false;
            this.dgvApplicationTypes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvApplicationTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvApplicationTypes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplicationTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvApplicationTypes.ColumnHeadersHeight = 25;
            this.dgvApplicationTypes.ContextMenuStrip = this.guna2ContextMenuStrip1;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvApplicationTypes.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvApplicationTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvApplicationTypes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.dgvApplicationTypes.Location = new System.Drawing.Point(0, 364);
            this.dgvApplicationTypes.Name = "dgvApplicationTypes";
            this.dgvApplicationTypes.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplicationTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvApplicationTypes.RowHeadersVisible = false;
            this.dgvApplicationTypes.RowHeadersWidth = 35;
            this.dgvApplicationTypes.RowTemplate.Height = 45;
            this.dgvApplicationTypes.Size = new System.Drawing.Size(921, 340);
            this.dgvApplicationTypes.TabIndex = 38;
            this.dgvApplicationTypes.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.dgvApplicationTypes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.dgvApplicationTypes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvApplicationTypes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            this.dgvApplicationTypes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvApplicationTypes.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.dgvApplicationTypes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.dgvApplicationTypes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.dgvApplicationTypes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvApplicationTypes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.dgvApplicationTypes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvApplicationTypes.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvApplicationTypes.ThemeStyle.ReadOnly = true;
            this.dgvApplicationTypes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(58)))));
            this.dgvApplicationTypes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvApplicationTypes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvApplicationTypes.ThemeStyle.RowsStyle.Height = 45;
            this.dgvApplicationTypes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            this.dgvApplicationTypes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvApplicationTypes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "#RECORDS";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCount.ForeColor = System.Drawing.Color.White;
            this.lblTotalCount.Location = new System.Drawing.Point(88, 335);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(20, 17);
            this.lblTotalCount.TabIndex = 51;
            this.lblTotalCount.Text = "??";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(236, 59);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(471, 279);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 49;
            this.guna2PictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BorderRadius = 10;
            this.button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.button1.FocusedColor = System.Drawing.Color.PapayaWhip;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1453, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 34);
            this.button1.TabIndex = 44;
            this.button1.Text = "Close";
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateApplicationTypesToolStripMenuItem});
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
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(209, 26);
            // 
            // updateApplicationTypesToolStripMenuItem
            // 
            this.updateApplicationTypesToolStripMenuItem.Name = "updateApplicationTypesToolStripMenuItem";
            this.updateApplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.updateApplicationTypesToolStripMenuItem.Text = "Update Application Types";
            this.updateApplicationTypesToolStripMenuItem.Click += new System.EventHandler(this.updateApplicationTypesToolStripMenuItem_Click);
            // 
            // frmManageApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 704);
            this.Controls.Add(this.dgvApplicationTypes);
            this.Controls.Add(this.pnlContainer);
            this.Name = "frmManageApplicationTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageApplicationTypes";
            this.Load += new System.EventHandler(this.frmManageApplicationTypes_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnlContainer;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button button1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvApplicationTypes;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateApplicationTypesToolStripMenuItem;
    }
}