namespace DVLD.Applications.Manage_Applications
{
    partial class frmApplicationDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApplicationDetails));
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlLocalLicenseAndBaseApplication1 = new DVLD.Controls.ctrlLocalLicenseAndBaseApplication();
            this.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(762, 677);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 34);
            this.btnClose.TabIndex = 72;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlLocalLicenseAndBaseApplication1
            // 
            this.ctrlLocalLicenseAndBaseApplication1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ctrlLocalLicenseAndBaseApplication1.Location = new System.Drawing.Point(-1, -1);
            this.ctrlLocalLicenseAndBaseApplication1.Name = "ctrlLocalLicenseAndBaseApplication1";
            this.ctrlLocalLicenseAndBaseApplication1.Size = new System.Drawing.Size(884, 672);
            this.ctrlLocalLicenseAndBaseApplication1.TabIndex = 73;
            // 
            // frmApplicationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(868, 723);
            this.Controls.Add(this.ctrlLocalLicenseAndBaseApplication1);
            this.Controls.Add(this.btnClose);
            this.Name = "frmApplicationDetails";
            this.Text = "frmApplicationDetails";
            this.Load += new System.EventHandler(this.frmApplicationDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Controls.ctrlLocalLicenseAndBaseApplication ctrlLocalLicenseAndBaseApplication1;
    }
}