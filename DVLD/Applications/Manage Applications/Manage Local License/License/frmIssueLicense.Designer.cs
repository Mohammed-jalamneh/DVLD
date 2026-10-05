namespace DVLD.Applications.Manage_Applications.Manage_Local_License.License
{
    partial class frmIssueLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssueLicense));
            this.guna2PictureBox6 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIssue = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlLocalLicenseAndBaseApplication1 = new DVLD.Controls.ctrlLocalLicenseAndBaseApplication();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox6
            // 
            this.guna2PictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox6.Image")));
            this.guna2PictureBox6.ImageRotate = 0F;
            this.guna2PictureBox6.Location = new System.Drawing.Point(105, 672);
            this.guna2PictureBox6.Name = "guna2PictureBox6";
            this.guna2PictureBox6.Size = new System.Drawing.Size(33, 32);
            this.guna2PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox6.TabIndex = 119;
            this.guna2PictureBox6.TabStop = false;
            // 
            // txtNotes
            // 
            this.txtNotes.BorderRadius = 10;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = "";
            this.txtNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.Location = new System.Drawing.Point(144, 672);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PlaceholderText = "";
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(605, 92);
            this.txtNotes.TabIndex = 118;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 672);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 30);
            this.label4.TabIndex = 117;
            this.label4.Text = "Notes";
            // 
            // btnIssue
            // 
            this.btnIssue.BorderRadius = 7;
            this.btnIssue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIssue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIssue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIssue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIssue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnIssue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.ForeColor = System.Drawing.Color.White;
            this.btnIssue.Location = new System.Drawing.Point(762, 767);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(94, 34);
            this.btnIssue.TabIndex = 116;
            this.btnIssue.Text = "Issue";
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
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
            this.btnClose.Location = new System.Drawing.Point(30, 767);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 34);
            this.btnClose.TabIndex = 115;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlLocalLicenseAndBaseApplication1
            // 
            this.ctrlLocalLicenseAndBaseApplication1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ctrlLocalLicenseAndBaseApplication1.Location = new System.Drawing.Point(-7, -11);
            this.ctrlLocalLicenseAndBaseApplication1.Name = "ctrlLocalLicenseAndBaseApplication1";
            this.ctrlLocalLicenseAndBaseApplication1.Size = new System.Drawing.Size(884, 666);
            this.ctrlLocalLicenseAndBaseApplication1.TabIndex = 120;
            // 
            // frmIssueLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(868, 816);
            this.Controls.Add(this.ctrlLocalLicenseAndBaseApplication1);
            this.Controls.Add(this.guna2PictureBox6);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnClose);
            this.Name = "frmIssueLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIssueLicense";
            this.Load += new System.EventHandler(this.frmIssueLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox6;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnIssue;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Controls.ctrlLocalLicenseAndBaseApplication ctrlLocalLicenseAndBaseApplication1;
    }
}