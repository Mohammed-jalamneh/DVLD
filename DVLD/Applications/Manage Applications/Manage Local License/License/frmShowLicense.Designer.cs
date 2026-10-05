namespace DVLD.Applications.Manage_Applications.Manage_Local_License.License
{
    partial class frmShowLicense
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
            this.ctrlDriverLicense1 = new DVLD.Controls.ctrlDriverLicense();
            this.SuspendLayout();
            // 
            // ctrlDriverLicense1
            // 
            this.ctrlDriverLicense1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ctrlDriverLicense1.Location = new System.Drawing.Point(-9, -6);
            this.ctrlDriverLicense1.Name = "ctrlDriverLicense1";
            this.ctrlDriverLicense1.Size = new System.Drawing.Size(848, 272);
            this.ctrlDriverLicense1.TabIndex = 0;
            // 
            // frmShowLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(832, 259);
            this.Controls.Add(this.ctrlDriverLicense1);
            this.Name = "frmShowLicense";
            this.Text = "frmShowLicense";
            this.Load += new System.EventHandler(this.frmShowLicense_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlDriverLicense ctrlDriverLicense1;
    }
}