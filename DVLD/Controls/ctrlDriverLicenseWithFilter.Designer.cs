namespace DVLD.Controls
{
    partial class ctrlDriverLicenseWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlDriverLicense1 = new DVLD.Controls.ctrlDriverLicense();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtLicenseID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlDriverLicense1
            // 
            this.ctrlDriverLicense1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ctrlDriverLicense1.Location = new System.Drawing.Point(-1, 49);
            this.ctrlDriverLicense1.Name = "ctrlDriverLicense1";
            this.ctrlDriverLicense1.Size = new System.Drawing.Size(848, 272);
            this.ctrlDriverLicense1.TabIndex = 0;
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.txtLicenseID);
            this.gbFilter.Controls.Add(this.label11);
            this.gbFilter.Controls.Add(this.btnSearch);
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.ForeColor = System.Drawing.Color.White;
            this.gbFilter.Location = new System.Drawing.Point(8, -3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(832, 56);
            this.gbFilter.TabIndex = 43;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.Location = new System.Drawing.Point(248, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 27);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtLicenseID
            // 
            this.txtLicenseID.Location = new System.Drawing.Point(142, 20);
            this.txtLicenseID.Name = "txtLicenseID";
            this.txtLicenseID.Size = new System.Drawing.Size(100, 24);
            this.txtLicenseID.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(69, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 43;
            this.label11.Text = "LicenseID";
            // 
            // ctrlDriverLicenseWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ctrlDriverLicense1);
            this.Name = "ctrlDriverLicenseWithFilter";
            this.Size = new System.Drawing.Size(843, 325);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlDriverLicense ctrlDriverLicense1;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtLicenseID;
        private System.Windows.Forms.Label label11;
    }
}
