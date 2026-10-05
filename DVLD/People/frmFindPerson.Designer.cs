namespace DVLD
{
    partial class frmFindPerson
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctrlPersonCardWithFilter1 = new DVLD.ctrlPersonCardWithFilter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ctrlPersonCardWithFilter2 = new DVLD.ctrlPersonCardWithFilter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(88)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 62);
            this.panel1.TabIndex = 0;
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(0, 59);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(799, 356);
            this.ctrlPersonCardWithFilter1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIND PERSON";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(88)))), ((int)(((byte)(220)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(710, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(88)))), ((int)(((byte)(220)))));
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 363);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 38);
            this.panel2.TabIndex = 3;
            // 
            // ctrlPersonCardWithFilter2
            // 
            this.ctrlPersonCardWithFilter2.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFilter2.FilterEnabled = true;
            this.ctrlPersonCardWithFilter2.Location = new System.Drawing.Point(3, 63);
            this.ctrlPersonCardWithFilter2.Name = "ctrlPersonCardWithFilter2";
            this.ctrlPersonCardWithFilter2.Size = new System.Drawing.Size(799, 314);
            this.ctrlPersonCardWithFilter2.TabIndex = 1;
            this.ctrlPersonCardWithFilter2.Load += new System.EventHandler(this.ctrlPersonCardWithFilter2_Load);
            // 
            // frmFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 401);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ctrlPersonCardWithFilter2);
            this.Controls.Add(this.panel1);
            this.Name = "frmFindPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\'";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private ctrlPersonCardWithFilter ctrlPersonCardWithFilter2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
    }
}