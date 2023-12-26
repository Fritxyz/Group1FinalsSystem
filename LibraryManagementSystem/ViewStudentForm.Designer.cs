namespace LibraryManagementSystem
{
    partial class ViewStudentForm
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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBookSearch = new System.Windows.Forms.Label();
            this.txtBoxStudentSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvViewStudent = new System.Windows.Forms.DataGridView();
            this.pnlEditData = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtBoxStudentEmail = new System.Windows.Forms.TextBox();
            this.lblStudentEmail = new System.Windows.Forms.Label();
            this.txtBoxStudentContact = new System.Windows.Forms.TextBox();
            this.lblStudentContact = new System.Windows.Forms.Label();
            this.txtBoxStudentDepartment = new System.Windows.Forms.TextBox();
            this.lblStudentDepartmenr = new System.Windows.Forms.Label();
            this.txtBoxStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtBoxStudentId = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStudent)).BeginInit();
            this.pnlEditData.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 123);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::LibraryManagementSystem.Properties.Resources.view_book_picture;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1085, 137);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Image = global::LibraryManagementSystem.Properties.Resources.view_book_picture1;
            this.pictureBox3.Location = new System.Drawing.Point(0, 491);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1086, 491);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1086, 491);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblBookSearch
            // 
            this.lblBookSearch.AutoSize = true;
            this.lblBookSearch.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookSearch.Location = new System.Drawing.Point(252, 140);
            this.lblBookSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookSearch.Name = "lblBookSearch";
            this.lblBookSearch.Size = new System.Drawing.Size(125, 23);
            this.lblBookSearch.TabIndex = 1;
            this.lblBookSearch.Text = "Student Search";
            // 
            // txtBoxStudentSearch
            // 
            this.txtBoxStudentSearch.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStudentSearch.Location = new System.Drawing.Point(388, 137);
            this.txtBoxStudentSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxStudentSearch.Name = "txtBoxStudentSearch";
            this.txtBoxStudentSearch.Size = new System.Drawing.Size(284, 29);
            this.txtBoxStudentSearch.TabIndex = 2;
            this.txtBoxStudentSearch.TextChanged += new System.EventHandler(this.txtBoxStudentSearch_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(707, 137);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 31);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvViewStudent
            // 
            this.dgvViewStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewStudent.ColumnHeadersHeight = 29;
            this.dgvViewStudent.Location = new System.Drawing.Point(3, 175);
            this.dgvViewStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvViewStudent.Name = "dgvViewStudent";
            this.dgvViewStudent.RowHeadersWidth = 51;
            this.dgvViewStudent.Size = new System.Drawing.Size(1083, 373);
            this.dgvViewStudent.TabIndex = 0;
            this.dgvViewStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewStudent_CellClick);
            // 
            // pnlEditData
            // 
            this.pnlEditData.BackColor = System.Drawing.SystemColors.Control;
            this.pnlEditData.Controls.Add(this.btnCancel);
            this.pnlEditData.Controls.Add(this.btnDelete);
            this.pnlEditData.Controls.Add(this.btnUpdate);
            this.pnlEditData.Controls.Add(this.txtBoxStudentEmail);
            this.pnlEditData.Controls.Add(this.lblStudentEmail);
            this.pnlEditData.Controls.Add(this.txtBoxStudentContact);
            this.pnlEditData.Controls.Add(this.lblStudentContact);
            this.pnlEditData.Controls.Add(this.txtBoxStudentDepartment);
            this.pnlEditData.Controls.Add(this.lblStudentDepartmenr);
            this.pnlEditData.Controls.Add(this.txtBoxStudentName);
            this.pnlEditData.Controls.Add(this.lblStudentName);
            this.pnlEditData.Controls.Add(this.txtBoxStudentId);
            this.pnlEditData.Controls.Add(this.lblStudentId);
            this.pnlEditData.Location = new System.Drawing.Point(16, 567);
            this.pnlEditData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlEditData.Name = "pnlEditData";
            this.pnlEditData.Size = new System.Drawing.Size(1035, 415);
            this.pnlEditData.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(805, 336);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(179, 54);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(439, 336);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(179, 54);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(49, 336);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(179, 54);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtBoxStudentEmail
            // 
            this.txtBoxStudentEmail.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStudentEmail.Location = new System.Drawing.Point(237, 274);
            this.txtBoxStudentEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxStudentEmail.MaxLength = 100;
            this.txtBoxStudentEmail.Name = "txtBoxStudentEmail";
            this.txtBoxStudentEmail.Size = new System.Drawing.Size(771, 34);
            this.txtBoxStudentEmail.TabIndex = 9;
            this.txtBoxStudentEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStudentEmail
            // 
            this.lblStudentEmail.AutoSize = true;
            this.lblStudentEmail.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentEmail.Location = new System.Drawing.Point(23, 277);
            this.lblStudentEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentEmail.Name = "lblStudentEmail";
            this.lblStudentEmail.Size = new System.Drawing.Size(143, 28);
            this.lblStudentEmail.TabIndex = 8;
            this.lblStudentEmail.Text = "Student Email";
            // 
            // txtBoxStudentContact
            // 
            this.txtBoxStudentContact.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStudentContact.Location = new System.Drawing.Point(237, 213);
            this.txtBoxStudentContact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxStudentContact.MaxLength = 100;
            this.txtBoxStudentContact.Name = "txtBoxStudentContact";
            this.txtBoxStudentContact.Size = new System.Drawing.Size(771, 34);
            this.txtBoxStudentContact.TabIndex = 7;
            this.txtBoxStudentContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStudentContact
            // 
            this.lblStudentContact.AutoSize = true;
            this.lblStudentContact.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentContact.Location = new System.Drawing.Point(23, 219);
            this.lblStudentContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentContact.Name = "lblStudentContact";
            this.lblStudentContact.Size = new System.Drawing.Size(164, 28);
            this.lblStudentContact.TabIndex = 6;
            this.lblStudentContact.Text = "Student Contact";
            // 
            // txtBoxStudentDepartment
            // 
            this.txtBoxStudentDepartment.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStudentDepartment.Location = new System.Drawing.Point(237, 159);
            this.txtBoxStudentDepartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxStudentDepartment.MaxLength = 100;
            this.txtBoxStudentDepartment.Name = "txtBoxStudentDepartment";
            this.txtBoxStudentDepartment.Size = new System.Drawing.Size(771, 34);
            this.txtBoxStudentDepartment.TabIndex = 5;
            this.txtBoxStudentDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxStudentDepartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxStudentDepartment_KeyPress);
            // 
            // lblStudentDepartmenr
            // 
            this.lblStudentDepartmenr.AutoSize = true;
            this.lblStudentDepartmenr.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentDepartmenr.Location = new System.Drawing.Point(23, 161);
            this.lblStudentDepartmenr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentDepartmenr.Name = "lblStudentDepartmenr";
            this.lblStudentDepartmenr.Size = new System.Drawing.Size(206, 28);
            this.lblStudentDepartmenr.TabIndex = 4;
            this.lblStudentDepartmenr.Text = "Student Department";
            // 
            // txtBoxStudentName
            // 
            this.txtBoxStudentName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStudentName.Location = new System.Drawing.Point(237, 97);
            this.txtBoxStudentName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxStudentName.MaxLength = 100;
            this.txtBoxStudentName.Name = "txtBoxStudentName";
            this.txtBoxStudentName.Size = new System.Drawing.Size(771, 34);
            this.txtBoxStudentName.TabIndex = 3;
            this.txtBoxStudentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxStudentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxStudentName_KeyPress);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(23, 100);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(147, 28);
            this.lblStudentName.TabIndex = 2;
            this.lblStudentName.Text = "Student Name";
            // 
            // txtBoxStudentId
            // 
            this.txtBoxStudentId.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStudentId.Location = new System.Drawing.Point(237, 34);
            this.txtBoxStudentId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxStudentId.MaxLength = 8;
            this.txtBoxStudentId.Name = "txtBoxStudentId";
            this.txtBoxStudentId.Size = new System.Drawing.Size(771, 34);
            this.txtBoxStudentId.TabIndex = 1;
            this.txtBoxStudentId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxStudentId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxStudentId_KeyPress);
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentId.Location = new System.Drawing.Point(23, 37);
            this.lblStudentId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(112, 28);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "Student ID";
            // 
            // ViewStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1082, 618);
            this.Controls.Add(this.pnlEditData);
            this.Controls.Add(this.dgvViewStudent);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtBoxStudentSearch);
            this.Controls.Add(this.lblBookSearch);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ViewStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Student";
            this.Load += new System.EventHandler(this.ViewStudentForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStudent)).EndInit();
            this.pnlEditData.ResumeLayout(false);
            this.pnlEditData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBookSearch;
        private System.Windows.Forms.TextBox txtBoxStudentSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvViewStudent;
        private System.Windows.Forms.Panel pnlEditData;
        private System.Windows.Forms.TextBox txtBoxStudentEmail;
        private System.Windows.Forms.Label lblStudentEmail;
        private System.Windows.Forms.TextBox txtBoxStudentContact;
        private System.Windows.Forms.Label lblStudentContact;
        private System.Windows.Forms.TextBox txtBoxStudentDepartment;
        private System.Windows.Forms.Label lblStudentDepartmenr;
        private System.Windows.Forms.TextBox txtBoxStudentName;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtBoxStudentId;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}