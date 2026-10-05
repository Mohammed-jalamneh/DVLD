namespace DVLD.Applications.Manage_Applications.Tests
{
    partial class frmTestTypeAppointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTestTypeAppointments));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHeadLine = new System.Windows.Forms.Label();
            this.pbHeadLine = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblTotalAppointments = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddNewAppointment = new Guna.UI2.WinForms.Guna2Button();
            this.dgvAppointments = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.updateAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlLocalLicenseAndBaseApplication1 = new DVLD.Controls.ctrlLocalLicenseAndBaseApplication();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeadLine)).BeginInit();
            this.guna2GradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeadLine
            // 
            this.lblHeadLine.AutoSize = true;
            this.lblHeadLine.BackColor = System.Drawing.Color.Transparent;
            this.lblHeadLine.Font = new System.Drawing.Font("Segoe UI", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadLine.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblHeadLine.Location = new System.Drawing.Point(564, 9);
            this.lblHeadLine.Name = "lblHeadLine";
            this.lblHeadLine.Size = new System.Drawing.Size(319, 35);
            this.lblHeadLine.TabIndex = 79;
            this.lblHeadLine.Text = "Vision Test Appointments";
            // 
            // pbHeadLine
            // 
            this.pbHeadLine.Image = ((System.Drawing.Image)(resources.GetObject("pbHeadLine.Image")));
            this.pbHeadLine.ImageRotate = 0F;
            this.pbHeadLine.Location = new System.Drawing.Point(889, 9);
            this.pbHeadLine.Name = "pbHeadLine";
            this.pbHeadLine.Size = new System.Drawing.Size(33, 35);
            this.pbHeadLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHeadLine.TabIndex = 80;
            this.pbHeadLine.TabStop = false;
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
            this.btnClose.Location = new System.Drawing.Point(1392, 729);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 34);
            this.btnClose.TabIndex = 88;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BorderRadius = 15;
            this.guna2GradientPanel2.Controls.Add(this.lblTotalAppointments);
            this.guna2GradientPanel2.Controls.Add(this.label7);
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(88)))), ((int)(((byte)(118)))));
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(67)))), ((int)(((byte)(118)))));
            this.guna2GradientPanel2.Location = new System.Drawing.Point(12, 112);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(201, 100);
            this.guna2GradientPanel2.TabIndex = 87;
            // 
            // lblTotalAppointments
            // 
            this.lblTotalAppointments.AutoSize = true;
            this.lblTotalAppointments.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalAppointments.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAppointments.ForeColor = System.Drawing.Color.White;
            this.lblTotalAppointments.Location = new System.Drawing.Point(160, 43);
            this.lblTotalAppointments.Name = "lblTotalAppointments";
            this.lblTotalAppointments.Size = new System.Drawing.Size(23, 25);
            this.lblTotalAppointments.TabIndex = 32;
            this.lblTotalAppointments.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 21);
            this.label7.TabIndex = 31;
            this.label7.Text = "Total Appointments";
            // 
            // btnAddNewAppointment
            // 
            this.btnAddNewAppointment.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewAppointment.BorderColor = System.Drawing.Color.White;
            this.btnAddNewAppointment.BorderRadius = 10;
            this.btnAddNewAppointment.BorderThickness = 2;
            this.btnAddNewAppointment.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnAddNewAppointment.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnAddNewAppointment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewAppointment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewAppointment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewAppointment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewAppointment.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewAppointment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewAppointment.ForeColor = System.Drawing.Color.White;
            this.btnAddNewAppointment.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(45)))), ((int)(((byte)(168)))));
            this.btnAddNewAppointment.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewAppointment.Image")));
            this.btnAddNewAppointment.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddNewAppointment.Location = new System.Drawing.Point(1, 458);
            this.btnAddNewAppointment.Name = "btnAddNewAppointment";
            this.btnAddNewAppointment.Size = new System.Drawing.Size(58, 45);
            this.btnAddNewAppointment.TabIndex = 86;
            this.btnAddNewAppointment.Click += new System.EventHandler(this.btnAddNewAppointment_Click);
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppointments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAppointments.ColumnHeadersHeight = 25;
            this.dgvAppointments.ContextMenuStrip = this.guna2ContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppointments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAppointments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.dgvAppointments.Location = new System.Drawing.Point(1, 509);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAppointments.RowHeadersVisible = false;
            this.dgvAppointments.RowTemplate.Height = 50;
            this.dgvAppointments.RowTemplate.ReadOnly = true;
            this.dgvAppointments.Size = new System.Drawing.Size(663, 205);
            this.dgvAppointments.TabIndex = 85;
            this.dgvAppointments.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAppointments.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.dgvAppointments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.dgvAppointments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAppointments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.dgvAppointments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAppointments.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvAppointments.ThemeStyle.ReadOnly = true;
            this.dgvAppointments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(58)))));
            this.dgvAppointments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAppointments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAppointments.ThemeStyle.RowsStyle.Height = 50;
            this.dgvAppointments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            this.dgvAppointments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateAppointmentToolStripMenuItem,
            this.takeTestToolStripMenuItem});
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
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(199, 60);
            // 
            // updateAppointmentToolStripMenuItem
            // 
            this.updateAppointmentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateAppointmentToolStripMenuItem.Image")));
            this.updateAppointmentToolStripMenuItem.Name = "updateAppointmentToolStripMenuItem";
            this.updateAppointmentToolStripMenuItem.Size = new System.Drawing.Size(198, 28);
            this.updateAppointmentToolStripMenuItem.Text = "  Update Appointment";
            this.updateAppointmentToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.updateAppointmentToolStripMenuItem.Click += new System.EventHandler(this.updateAppointmentToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("takeTestToolStripMenuItem.Image")));
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(198, 28);
            this.takeTestToolStripMenuItem.Text = "  Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // ctrlLocalLicenseAndBaseApplication1
            // 
            this.ctrlLocalLicenseAndBaseApplication1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ctrlLocalLicenseAndBaseApplication1.Location = new System.Drawing.Point(637, 49);
            this.ctrlLocalLicenseAndBaseApplication1.Name = "ctrlLocalLicenseAndBaseApplication1";
            this.ctrlLocalLicenseAndBaseApplication1.Size = new System.Drawing.Size(859, 674);
            this.ctrlLocalLicenseAndBaseApplication1.TabIndex = 0;
            // 
            // frmTestTypeAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1508, 772);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.btnAddNewAppointment);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.pbHeadLine);
            this.Controls.Add(this.lblHeadLine);
            this.Controls.Add(this.ctrlLocalLicenseAndBaseApplication1);
            this.Name = "frmTestTypeAppointments";
            this.Text = "frmVisionTestAppointments";
            this.Load += new System.EventHandler(this.frmVisionTestAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHeadLine)).EndInit();
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrlLocalLicenseAndBaseApplication ctrlLocalLicenseAndBaseApplication1;
        private System.Windows.Forms.Label lblHeadLine;
        private Guna.UI2.WinForms.Guna2PictureBox pbHeadLine;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.Label lblTotalAppointments;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnAddNewAppointment;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAppointments;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}