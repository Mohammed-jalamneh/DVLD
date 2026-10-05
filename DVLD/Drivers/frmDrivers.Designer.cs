namespace DVLD
{
    partial class frmDrivers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDrivers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlContainer = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFiltering = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDrivers
            // 
            this.dgvDrivers.AllowUserToAddRows = false;
            this.dgvDrivers.AllowUserToDeleteRows = false;
            this.dgvDrivers.AllowUserToOrderColumns = true;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDrivers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDrivers.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDrivers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDrivers.ColumnHeadersHeight = 25;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDrivers.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDrivers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDrivers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.dgvDrivers.Location = new System.Drawing.Point(0, 433);
            this.dgvDrivers.Name = "dgvDrivers";
            this.dgvDrivers.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDrivers.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDrivers.RowHeadersVisible = false;
            this.dgvDrivers.RowHeadersWidth = 35;
            this.dgvDrivers.RowTemplate.Height = 45;
            this.dgvDrivers.Size = new System.Drawing.Size(1530, 274);
            this.dgvDrivers.TabIndex = 37;
            this.dgvDrivers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.dgvDrivers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.dgvDrivers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDrivers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            this.dgvDrivers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDrivers.ThemeStyle.BackColor = System.Drawing.Color.Black;
            this.dgvDrivers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.dgvDrivers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.dgvDrivers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDrivers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.dgvDrivers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDrivers.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvDrivers.ThemeStyle.ReadOnly = true;
            this.dgvDrivers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(58)))));
            this.dgvDrivers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDrivers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDrivers.ThemeStyle.RowsStyle.Height = 45;
            this.dgvDrivers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(240)))));
            this.dgvDrivers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDrivers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrivers_CellContentClick);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.Transparent;
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
            this.pnlContainer.TabIndex = 38;
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
            this.label6.Size = new System.Drawing.Size(114, 32);
            this.label6.TabIndex = 47;
            this.label6.Text = "DRIVERS";
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
            "DriverID",
            "NationalNo",
            "FullName",
            "None"});
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
            this.txtFiltering.Location = new System.Drawing.Point(191, 391);
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
            // frmDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1530, 707);
            this.Controls.Add(this.dgvDrivers);
            this.Controls.Add(this.pnlContainer);
            this.Name = "frmDrivers";
            this.Text = "frmDrivers";
            this.Load += new System.EventHandler(this.frmDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvDrivers;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlContainer;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterBy;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltering;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}