namespace DVLD
{
    partial class ctrlPersonCardWithFilter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlPersonCardWithFilter));
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPersonInfoToSearch = new System.Windows.Forms.TextBox();
            this.cbFilteringType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlPersonCard1 = new DVLD.ctrlPersonCard();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.pictureBox2);
            this.gbFilter.Controls.Add(this.btnSearch);
            this.gbFilter.Controls.Add(this.pictureBox1);
            this.gbFilter.Controls.Add(this.btnAdd);
            this.gbFilter.Controls.Add(this.txtPersonInfoToSearch);
            this.gbFilter.Controls.Add(this.cbFilteringType);
            this.gbFilter.Controls.Add(this.label11);
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(3, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(832, 56);
            this.gbFilter.TabIndex = 42;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            this.gbFilter.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(459, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.Location = new System.Drawing.Point(376, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 27);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(342, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(493, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 27);
            this.btnAdd.TabIndex = 48;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPersonInfoToSearch
            // 
            this.txtPersonInfoToSearch.Location = new System.Drawing.Point(227, 24);
            this.txtPersonInfoToSearch.Name = "txtPersonInfoToSearch";
            this.txtPersonInfoToSearch.Size = new System.Drawing.Size(100, 24);
            this.txtPersonInfoToSearch.TabIndex = 45;
            this.txtPersonInfoToSearch.TextChanged += new System.EventHandler(this.txtPersonInfoToSearch_TextChanged);
            this.txtPersonInfoToSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonInfoToSearch_KeyPress);
            this.txtPersonInfoToSearch.Validating += new System.ComponentModel.CancelEventHandler(this.txtPersonInfoToSearch_Validating);
            // 
            // cbFilteringType
            // 
            this.cbFilteringType.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbFilteringType.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbFilteringType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilteringType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilteringType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilteringType.FormattingEnabled = true;
            this.cbFilteringType.Items.AddRange(new object[] {
            "Person ID",
            "National No"});
            this.cbFilteringType.Location = new System.Drawing.Point(88, 24);
            this.cbFilteringType.Name = "cbFilteringType";
            this.cbFilteringType.Size = new System.Drawing.Size(121, 23);
            this.cbFilteringType.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 43;
            this.label11.Text = "Filter By : ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(3, 65);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(850, 281);
            this.ctrlPersonCard1.TabIndex = 43;
            this.ctrlPersonCard1.Load += new System.EventHandler(this.ctrlPersonCard1_Load);
            // 
            // ctrlPersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.gbFilter);
            this.Name = "ctrlPersonCardWithFilter";
            this.Size = new System.Drawing.Size(856, 331);
            this.Load += new System.EventHandler(this.ctrlPersonCardWithFilter_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPersonInfoToSearch;
        private System.Windows.Forms.ComboBox cbFilteringType;
        private System.Windows.Forms.Label label11;
        private ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
