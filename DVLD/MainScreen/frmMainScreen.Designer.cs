namespace DVLD.MainScreen
{
    partial class frmMainScreen
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
            this.TapControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.tbApplications = new System.Windows.Forms.TabPage();
            this.tbPeople = new System.Windows.Forms.TabPage();
            this.tbDrivers = new System.Windows.Forms.TabPage();
            this.tbUsers = new System.Windows.Forms.TabPage();
            this.tbAccountSettings = new System.Windows.Forms.TabPage();
            this.tbSignOut = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TapControl.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TapControl
            // 
            this.TapControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TapControl.Controls.Add(this.tbApplications);
            this.TapControl.Controls.Add(this.tbPeople);
            this.TapControl.Controls.Add(this.tbDrivers);
            this.TapControl.Controls.Add(this.tbUsers);
            this.TapControl.Controls.Add(this.tbAccountSettings);
            this.TapControl.Controls.Add(this.tbSignOut);
            this.TapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TapControl.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TapControl.ItemSize = new System.Drawing.Size(180, 40);
            this.TapControl.Location = new System.Drawing.Point(0, 0);
            this.TapControl.Name = "TapControl";
            this.TapControl.SelectedIndex = 0;
            this.TapControl.Size = new System.Drawing.Size(1734, 754);
            this.TapControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.TapControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TapControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TapControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.TapControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TapControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.TapControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TapControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TapControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.TapControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TapControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.TapControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.TapControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TapControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.TapControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.TapControl.TabButtonSize = new System.Drawing.Size(180, 40);
            this.TapControl.TabIndex = 2;
            this.TapControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.TapControl.TabStop = false;
            this.TapControl.SelectedIndexChanged += new System.EventHandler(this.TapControl_SelectedIndexChanged);
            this.TapControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TapControl_Selecting);
            // 
            // tbApplications
            // 
            this.tbApplications.BackColor = System.Drawing.Color.Black;
            this.tbApplications.ImageIndex = 0;
            this.tbApplications.Location = new System.Drawing.Point(184, 4);
            this.tbApplications.Name = "tbApplications";
            this.tbApplications.Size = new System.Drawing.Size(1546, 746);
            this.tbApplications.TabIndex = 0;
            this.tbApplications.Text = "Applications";
            // 
            // tbPeople
            // 
            this.tbPeople.BackColor = System.Drawing.Color.Black;
            this.tbPeople.ImageIndex = 1;
            this.tbPeople.Location = new System.Drawing.Point(184, 4);
            this.tbPeople.Name = "tbPeople";
            this.tbPeople.Size = new System.Drawing.Size(1546, 746);
            this.tbPeople.TabIndex = 1;
            this.tbPeople.Text = "People";
            // 
            // tbDrivers
            // 
            this.tbDrivers.BackColor = System.Drawing.Color.Black;
            this.tbDrivers.ImageIndex = 2;
            this.tbDrivers.Location = new System.Drawing.Point(184, 4);
            this.tbDrivers.Name = "tbDrivers";
            this.tbDrivers.Size = new System.Drawing.Size(1546, 746);
            this.tbDrivers.TabIndex = 2;
            this.tbDrivers.Text = "Drivers";
            // 
            // tbUsers
            // 
            this.tbUsers.BackColor = System.Drawing.Color.Black;
            this.tbUsers.ImageIndex = 3;
            this.tbUsers.Location = new System.Drawing.Point(184, 4);
            this.tbUsers.Name = "tbUsers";
            this.tbUsers.Size = new System.Drawing.Size(1546, 746);
            this.tbUsers.TabIndex = 3;
            this.tbUsers.Text = "Users";
            // 
            // tbAccountSettings
            // 
            this.tbAccountSettings.BackColor = System.Drawing.Color.Black;
            this.tbAccountSettings.ImageIndex = 4;
            this.tbAccountSettings.Location = new System.Drawing.Point(184, 4);
            this.tbAccountSettings.Name = "tbAccountSettings";
            this.tbAccountSettings.Size = new System.Drawing.Size(1546, 746);
            this.tbAccountSettings.TabIndex = 4;
            this.tbAccountSettings.Text = "AccountSettings";
            // 
            // tbSignOut
            // 
            this.tbSignOut.BackColor = System.Drawing.Color.Black;
            this.tbSignOut.ImageIndex = 5;
            this.tbSignOut.Location = new System.Drawing.Point(184, 4);
            this.tbSignOut.Name = "tbSignOut";
            this.tbSignOut.Size = new System.Drawing.Size(1546, 746);
            this.tbSignOut.TabIndex = 5;
            this.tbSignOut.Text = "SignOut";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.currentUserInformationToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(207, 48);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // currentUserInformationToolStripMenuItem
            // 
            this.currentUserInformationToolStripMenuItem.Name = "currentUserInformationToolStripMenuItem";
            this.currentUserInformationToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.currentUserInformationToolStripMenuItem.Text = "Current User Information";
            this.currentUserInformationToolStripMenuItem.Click += new System.EventHandler(this.currentUserInformationToolStripMenuItem_Click);
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1734, 754);
            this.Controls.Add(this.TapControl);
            this.Name = "frmMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainScreen";
            this.Load += new System.EventHandler(this.frmMainScreen_Load);
            this.TapControl.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl TapControl;
        private System.Windows.Forms.TabPage tbApplications;
        private System.Windows.Forms.TabPage tbPeople;
        private System.Windows.Forms.TabPage tbDrivers;
        private System.Windows.Forms.TabPage tbUsers;
        private System.Windows.Forms.TabPage tbAccountSettings;
        private System.Windows.Forms.TabPage tbSignOut;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentUserInformationToolStripMenuItem;
    }
}