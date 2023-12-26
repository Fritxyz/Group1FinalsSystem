namespace LibraryManagementSystem
{
    partial class IssueBookForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.picBoxStudent = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.txtBoxStudentId = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBookName = new System.Windows.Forms.Label();
            this.cmbBoxBookName = new System.Windows.Forms.ComboBox();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.txtBoxStudentEmail = new System.Windows.Forms.TextBox();
            this.lblStudentEmail = new System.Windows.Forms.Label();
            this.txtBoxStudentContact = new System.Windows.Forms.TextBox();
            this.lblStudentContact = new System.Windows.Forms.Label();
            this.txtBoxStudentDepartment = new System.Windows.Forms.TextBox();
            this.lblStudentDepartment = new System.Windows.Forms.Label();
            this.txtBoxStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStudent)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.picBoxStudent);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnSearchStudent);
            this.panel1.Controls.Add(this.txtBoxStudentId);
            this.panel1.Controls.Add(this.lblStudentId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 590);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 554);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "1 BOOK CAN BE ISSUED PER STUDENT";
            // 
            // picBoxStudent
            // 
            this.picBoxStudent.Image = global::LibraryManagementSystem.Properties.Resources.add_student;
            this.picBoxStudent.Location = new System.Drawing.Point(141, 48);
            this.picBoxStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBoxStudent.Name = "picBoxStudent";
            this.picBoxStudent.Size = new System.Drawing.Size(168, 148);
            this.picBoxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxStudent.TabIndex = 5;
            this.picBoxStudent.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(261, 449);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(151, 53);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(39, 449);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(151, 53);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchStudent.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStudent.Location = new System.Drawing.Point(134, 347);
            this.btnSearchStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(212, 53);
            this.btnSearchStudent.TabIndex = 2;
            this.btnSearchStudent.Text = "Search  Student";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // txtBoxStudentId
            // 
            this.txtBoxStudentId.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStudentId.Location = new System.Drawing.Point(39, 273);
            this.txtBoxStudentId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxStudentId.Name = "txtBoxStudentId";
            this.txtBoxStudentId.Size = new System.Drawing.Size(372, 39);
            this.txtBoxStudentId.TabIndex = 1;
            this.txtBoxStudentId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxStudentId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxStudentId_KeyPress);
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentId.Location = new System.Drawing.Point(128, 218);
            this.lblStudentId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(189, 32);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "Enter Student ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.lblBookName);
            this.panel2.Controls.Add(this.cmbBoxBookName);
            this.panel2.Controls.Add(this.btnIssueBook);
            this.panel2.Controls.Add(this.txtBoxStudentEmail);
            this.panel2.Controls.Add(this.lblStudentEmail);
            this.panel2.Controls.Add(this.txtBoxStudentContact);
            this.panel2.Controls.Add(this.lblStudentContact);
            this.panel2.Controls.Add(this.txtBoxStudentDepartment);
            this.panel2.Controls.Add(this.lblStudentDepartment);
            this.panel2.Controls.Add(this.txtBoxStudentName);
            this.panel2.Controls.Add(this.lblStudentName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(459, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 590);
            this.panel2.TabIndex = 1;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(208, 427);
            this.lblBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(139, 32);
            this.lblBookName.TabIndex = 9;
            this.lblBookName.Text = "Book Name";
            // 
            // cmbBoxBookName
            // 
            this.cmbBoxBookName.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxBookName.FormattingEnabled = true;
            this.cmbBoxBookName.Location = new System.Drawing.Point(59, 462);
            this.cmbBoxBookName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBoxBookName.Name = "cmbBoxBookName";
            this.cmbBoxBookName.Size = new System.Drawing.Size(441, 40);
            this.cmbBoxBookName.TabIndex = 8;
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueBook.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueBook.Location = new System.Drawing.Point(215, 522);
            this.btnIssueBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(151, 53);
            this.btnIssueBook.TabIndex = 6;
            this.btnIssueBook.Text = "Issue Book";
            this.btnIssueBook.UseVisualStyleBackColor = true;
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            // 
            // txtBoxStudentEmail
            // 
            this.txtBoxStudentEmail.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStudentEmail.Location = new System.Drawing.Point(59, 361);
            this.txtBoxStudentEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxStudentEmail.MaxLength = 100;
            this.txtBoxStudentEmail.Name = "txtBoxStudentEmail";
            this.txtBoxStudentEmail.ReadOnly = true;
            this.txtBoxStudentEmail.Size = new System.Drawing.Size(441, 39);
            this.txtBoxStudentEmail.TabIndex = 7;
            this.txtBoxStudentEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStudentEmail
            // 
            this.lblStudentEmail.AutoSize = true;
            this.lblStudentEmail.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentEmail.Location = new System.Drawing.Point(196, 326);
            this.lblStudentEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentEmail.Name = "lblStudentEmail";
            this.lblStudentEmail.Size = new System.Drawing.Size(161, 32);
            this.lblStudentEmail.TabIndex = 6;
            this.lblStudentEmail.Text = "Student Email";
            // 
            // txtBoxStudentContact
            // 
            this.txtBoxStudentContact.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStudentContact.Location = new System.Drawing.Point(59, 260);
            this.txtBoxStudentContact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxStudentContact.MaxLength = 100;
            this.txtBoxStudentContact.Name = "txtBoxStudentContact";
            this.txtBoxStudentContact.ReadOnly = true;
            this.txtBoxStudentContact.Size = new System.Drawing.Size(441, 39);
            this.txtBoxStudentContact.TabIndex = 5;
            this.txtBoxStudentContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStudentContact
            // 
            this.lblStudentContact.AutoSize = true;
            this.lblStudentContact.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentContact.Location = new System.Drawing.Point(189, 225);
            this.lblStudentContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentContact.Name = "lblStudentContact";
            this.lblStudentContact.Size = new System.Drawing.Size(186, 32);
            this.lblStudentContact.TabIndex = 4;
            this.lblStudentContact.Text = "Student Contact";
            // 
            // txtBoxStudentDepartment
            // 
            this.txtBoxStudentDepartment.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStudentDepartment.Location = new System.Drawing.Point(59, 159);
            this.txtBoxStudentDepartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxStudentDepartment.MaxLength = 100;
            this.txtBoxStudentDepartment.Name = "txtBoxStudentDepartment";
            this.txtBoxStudentDepartment.ReadOnly = true;
            this.txtBoxStudentDepartment.Size = new System.Drawing.Size(441, 39);
            this.txtBoxStudentDepartment.TabIndex = 3;
            this.txtBoxStudentDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStudentDepartment
            // 
            this.lblStudentDepartment.AutoSize = true;
            this.lblStudentDepartment.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentDepartment.Location = new System.Drawing.Point(165, 124);
            this.lblStudentDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentDepartment.Name = "lblStudentDepartment";
            this.lblStudentDepartment.Size = new System.Drawing.Size(233, 32);
            this.lblStudentDepartment.TabIndex = 2;
            this.lblStudentDepartment.Text = "Student Department";
            // 
            // txtBoxStudentName
            // 
            this.txtBoxStudentName.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStudentName.Location = new System.Drawing.Point(59, 66);
            this.txtBoxStudentName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxStudentName.MaxLength = 100;
            this.txtBoxStudentName.Name = "txtBoxStudentName";
            this.txtBoxStudentName.ReadOnly = true;
            this.txtBoxStudentName.Size = new System.Drawing.Size(441, 39);
            this.txtBoxStudentName.TabIndex = 1;
            this.txtBoxStudentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(191, 32);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(168, 32);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student Name";
            // 
            // IssueBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1019, 590);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "IssueBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Book";
            this.Load += new System.EventHandler(this.IssueBookForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStudent)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.TextBox txtBoxStudentId;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox picBoxStudent;
        private System.Windows.Forms.TextBox txtBoxStudentEmail;
        private System.Windows.Forms.Label lblStudentEmail;
        private System.Windows.Forms.TextBox txtBoxStudentContact;
        private System.Windows.Forms.Label lblStudentContact;
        private System.Windows.Forms.TextBox txtBoxStudentDepartment;
        private System.Windows.Forms.Label lblStudentDepartment;
        private System.Windows.Forms.TextBox txtBoxStudentName;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.ComboBox cmbBoxBookName;
    }
}