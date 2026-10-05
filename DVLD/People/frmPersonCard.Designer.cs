namespace DVLD
{
    partial class frmPersonCard
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
            this.components = new System.ComponentModel.Container();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.ctrlPersonCard1 = new DVLD.ctrlPersonCard();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 15;
            this.guna2GroupBox1.Controls.Add(this.guna2ControlBox1);
            this.guna2GroupBox1.Controls.Add(this.ctrlPersonCard1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(88)))), ((int)(((byte)(220)))));
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(848, 324);
            this.guna2GroupBox1.TabIndex = 2;
            this.guna2GroupBox1.Text = "PERSON CARD";
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderRadius = 11;
            this.guna2ControlBox1.BorderThickness = 1;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.OrangeRed;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(789, 259);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(28, 20);
            this.guna2ControlBox1.TabIndex = 0;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 35;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(0, 43);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(856, 262);
            this.ctrlPersonCard1.TabIndex = 1;
            // 
            // frmPersonCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(848, 305);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPersonCard";
            this.Text = "frmPersonCardcs";
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private ctrlPersonCard ctrlPersonCard1;
    }
}