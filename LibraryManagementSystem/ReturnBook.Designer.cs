namespace LibraryManagementSystem
{
    partial class ReturnBook
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
            this.pnlEnterStudentId = new System.Windows.Forms.Panel();
            this.picBoxStudent = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.txtBoxStudentId = new System.Windows.Forms.TextBox();
            this.lblEnterStudentId = new System.Windows.Forms.Label();
            this.pnlReturnBookInfo = new System.Windows.Forms.Panel();
            this.lblNBookIsbnInfo = new System.Windows.Forms.Label();
            this.lblBookGenreInfo = new System.Windows.Forms.Label();
            this.lblBookAuthorInfo = new System.Windows.Forms.Label();
            this.lblBookTitleInfo = new System.Windows.Forms.Label();
            this.lblBookIdInfo = new System.Windows.Forms.Label();
            this.lblStudentEmailInfo = new System.Windows.Forms.Label();
            this.lblStudentContactInfo = new System.Windows.Forms.Label();
            this.lblStudentDepartmentInfo = new System.Windows.Forms.Label();
            this.lblStudentNameInfo = new System.Windows.Forms.Label();
            this.lblStudentIdInfo = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblBookIsbn = new System.Windows.Forms.Label();
            this.lblBookGenre = new System.Windows.Forms.Label();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStudentEmail = new System.Windows.Forms.Label();
            this.lblStudentContact = new System.Windows.Forms.Label();
            this.lblStudentDepartment = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlEnterStudentId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStudent)).BeginInit();
            this.pnlReturnBookInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEnterStudentId
            // 
            this.pnlEnterStudentId.BackColor = System.Drawing.Color.Silver;
            this.pnlEnterStudentId.Controls.Add(this.picBoxStudent);
            this.pnlEnterStudentId.Controls.Add(this.btnExit);
            this.pnlEnterStudentId.Controls.Add(this.btnRefresh);
            this.pnlEnterStudentId.Controls.Add(this.btnSearchStudent);
            this.pnlEnterStudentId.Controls.Add(this.txtBoxStudentId);
            this.pnlEnterStudentId.Controls.Add(this.lblEnterStudentId);
            this.pnlEnterStudentId.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEnterStudentId.Location = new System.Drawing.Point(0, 0);
            this.pnlEnterStudentId.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEnterStudentId.Name = "pnlEnterStudentId";
            this.pnlEnterStudentId.Size = new System.Drawing.Size(451, 612);
            this.pnlEnterStudentId.TabIndex = 1;
            // 
            // picBoxStudent
            // 
            this.picBoxStudent.Image = global::LibraryManagementSystem.Properties.Resources.add_student;
            this.picBoxStudent.Location = new System.Drawing.Point(141, 48);
            this.picBoxStudent.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnExit.Location = new System.Drawing.Point(261, 492);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnRefresh.Location = new System.Drawing.Point(39, 492);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnSearchStudent.Location = new System.Drawing.Point(127, 351);
            this.btnSearchStudent.Margin = new System.Windows.Forms.Padding(4);
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
            this.txtBoxStudentId.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxStudentId.Name = "txtBoxStudentId";
            this.txtBoxStudentId.Size = new System.Drawing.Size(372, 39);
            this.txtBoxStudentId.TabIndex = 1;
            this.txtBoxStudentId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxStudentId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxStudentId_KeyPress);
            // 
            // lblEnterStudentId
            // 
            this.lblEnterStudentId.AutoSize = true;
            this.lblEnterStudentId.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterStudentId.Location = new System.Drawing.Point(128, 218);
            this.lblEnterStudentId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterStudentId.Name = "lblEnterStudentId";
            this.lblEnterStudentId.Size = new System.Drawing.Size(189, 32);
            this.lblEnterStudentId.TabIndex = 0;
            this.lblEnterStudentId.Text = "Enter Student ID";
            // 
            // pnlReturnBookInfo
            // 
            this.pnlReturnBookInfo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlReturnBookInfo.Controls.Add(this.lblNBookIsbnInfo);
            this.pnlReturnBookInfo.Controls.Add(this.lblBookGenreInfo);
            this.pnlReturnBookInfo.Controls.Add(this.lblBookAuthorInfo);
            this.pnlReturnBookInfo.Controls.Add(this.lblBookTitleInfo);
            this.pnlReturnBookInfo.Controls.Add(this.lblBookIdInfo);
            this.pnlReturnBookInfo.Controls.Add(this.lblStudentEmailInfo);
            this.pnlReturnBookInfo.Controls.Add(this.lblStudentContactInfo);
            this.pnlReturnBookInfo.Controls.Add(this.lblStudentDepartmentInfo);
            this.pnlReturnBookInfo.Controls.Add(this.lblStudentNameInfo);
            this.pnlReturnBookInfo.Controls.Add(this.lblStudentIdInfo);
            this.pnlReturnBookInfo.Controls.Add(this.btnReturn);
            this.pnlReturnBookInfo.Controls.Add(this.btnCancel);
            this.pnlReturnBookInfo.Controls.Add(this.lblBookIsbn);
            this.pnlReturnBookInfo.Controls.Add(this.lblBookGenre);
            this.pnlReturnBookInfo.Controls.Add(this.lblBookAuthor);
            this.pnlReturnBookInfo.Controls.Add(this.lblBookTitle);
            this.pnlReturnBookInfo.Controls.Add(this.lblBookId);
            this.pnlReturnBookInfo.Controls.Add(this.label7);
            this.pnlReturnBookInfo.Controls.Add(this.lblStudentEmail);
            this.pnlReturnBookInfo.Controls.Add(this.lblStudentContact);
            this.pnlReturnBookInfo.Controls.Add(this.lblStudentDepartment);
            this.pnlReturnBookInfo.Controls.Add(this.lblStudentName);
            this.pnlReturnBookInfo.Controls.Add(this.lblStudentId);
            this.pnlReturnBookInfo.Controls.Add(this.label1);
            this.pnlReturnBookInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlReturnBookInfo.Location = new System.Drawing.Point(459, 0);
            this.pnlReturnBookInfo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlReturnBookInfo.Name = "pnlReturnBookInfo";
            this.pnlReturnBookInfo.Size = new System.Drawing.Size(816, 612);
            this.pnlReturnBookInfo.TabIndex = 2;
            this.pnlReturnBookInfo.Visible = false;
            // 
            // lblNBookIsbnInfo
            // 
            this.lblNBookIsbnInfo.AutoSize = true;
            this.lblNBookIsbnInfo.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNBookIsbnInfo.Location = new System.Drawing.Point(174, 492);
            this.lblNBookIsbnInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNBookIsbnInfo.Name = "lblNBookIsbnInfo";
            this.lblNBookIsbnInfo.Size = new System.Drawing.Size(97, 32);
            this.lblNBookIsbnInfo.TabIndex = 28;
            this.lblNBookIsbnInfo.Text = "Student";
            this.lblNBookIsbnInfo.Visible = false;
            // 
            // lblBookGenreInfo
            // 
            this.lblBookGenreInfo.AutoSize = true;
            this.lblBookGenreInfo.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookGenreInfo.Location = new System.Drawing.Point(187, 449);
            this.lblBookGenreInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookGenreInfo.Name = "lblBookGenreInfo";
            this.lblBookGenreInfo.Size = new System.Drawing.Size(97, 32);
            this.lblBookGenreInfo.TabIndex = 27;
            this.lblBookGenreInfo.Text = "Student";
            this.lblBookGenreInfo.Visible = false;
            // 
            // lblBookAuthorInfo
            // 
            this.lblBookAuthorInfo.AutoSize = true;
            this.lblBookAuthorInfo.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookAuthorInfo.Location = new System.Drawing.Point(200, 406);
            this.lblBookAuthorInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookAuthorInfo.Name = "lblBookAuthorInfo";
            this.lblBookAuthorInfo.Size = new System.Drawing.Size(97, 32);
            this.lblBookAuthorInfo.TabIndex = 26;
            this.lblBookAuthorInfo.Text = "Student";
            this.lblBookAuthorInfo.Visible = false;
            // 
            // lblBookTitleInfo
            // 
            this.lblBookTitleInfo.AutoSize = true;
            this.lblBookTitleInfo.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitleInfo.Location = new System.Drawing.Point(169, 363);
            this.lblBookTitleInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookTitleInfo.Name = "lblBookTitleInfo";
            this.lblBookTitleInfo.Size = new System.Drawing.Size(97, 32);
            this.lblBookTitleInfo.TabIndex = 25;
            this.lblBookTitleInfo.Text = "Student";
            this.lblBookTitleInfo.Visible = false;
            // 
            // lblBookIdInfo
            // 
            this.lblBookIdInfo.AutoSize = true;
            this.lblBookIdInfo.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookIdInfo.Location = new System.Drawing.Point(145, 320);
            this.lblBookIdInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookIdInfo.Name = "lblBookIdInfo";
            this.lblBookIdInfo.Size = new System.Drawing.Size(97, 32);
            this.lblBookIdInfo.TabIndex = 24;
            this.lblBookIdInfo.Text = "Student";
            this.lblBookIdInfo.Visible = false;
            // 
            // lblStudentEmailInfo
            // 
            this.lblStudentEmailInfo.AutoSize = true;
            this.lblStudentEmailInfo.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentEmailInfo.Location = new System.Drawing.Point(211, 220);
            this.lblStudentEmailInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentEmailInfo.Name = "lblStudentEmailInfo";
            this.lblStudentEmailInfo.Size = new System.Drawing.Size(97, 32);
            this.lblStudentEmailInfo.TabIndex = 23;
            this.lblStudentEmailInfo.Text = "Student";
            this.lblStudentEmailInfo.Visible = false;
            // 
            // lblStudentContactInfo
            // 
            this.lblStudentContactInfo.AutoSize = true;
            this.lblStudentContactInfo.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentContactInfo.Location = new System.Drawing.Point(237, 177);
            this.lblStudentContactInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentContactInfo.Name = "lblStudentContactInfo";
            this.lblStudentContactInfo.Size = new System.Drawing.Size(97, 32);
            this.lblStudentContactInfo.TabIndex = 22;
            this.lblStudentContactInfo.Text = "Student";
            this.lblStudentContactInfo.Visible = false;
            // 
            // lblStudentDepartmentInfo
            // 
            this.lblStudentDepartmentInfo.AutoSize = true;
            this.lblStudentDepartmentInfo.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentDepartmentInfo.Location = new System.Drawing.Point(287, 134);
            this.lblStudentDepartmentInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentDepartmentInfo.Name = "lblStudentDepartmentInfo";
            this.lblStudentDepartmentInfo.Size = new System.Drawing.Size(97, 32);
            this.lblStudentDepartmentInfo.TabIndex = 21;
            this.lblStudentDepartmentInfo.Text = "Student";
            this.lblStudentDepartmentInfo.Visible = false;
            // 
            // lblStudentNameInfo
            // 
            this.lblStudentNameInfo.AutoSize = true;
            this.lblStudentNameInfo.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentNameInfo.Location = new System.Drawing.Point(212, 91);
            this.lblStudentNameInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentNameInfo.Name = "lblStudentNameInfo";
            this.lblStudentNameInfo.Size = new System.Drawing.Size(97, 32);
            this.lblStudentNameInfo.TabIndex = 20;
            this.lblStudentNameInfo.Text = "Student";
            this.lblStudentNameInfo.Visible = false;
            // 
            // lblStudentIdInfo
            // 
            this.lblStudentIdInfo.AutoSize = true;
            this.lblStudentIdInfo.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentIdInfo.Location = new System.Drawing.Point(167, 48);
            this.lblStudentIdInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentIdInfo.Name = "lblStudentIdInfo";
            this.lblStudentIdInfo.Size = new System.Drawing.Size(97, 32);
            this.lblStudentIdInfo.TabIndex = 19;
            this.lblStudentIdInfo.Text = "Student";
            this.lblStudentIdInfo.Visible = false;
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(498, 544);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(151, 53);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(209, 544);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 53);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblBookIsbn
            // 
            this.lblBookIsbn.AutoSize = true;
            this.lblBookIsbn.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookIsbn.Location = new System.Drawing.Point(25, 492);
            this.lblBookIsbn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookIsbn.Name = "lblBookIsbn";
            this.lblBookIsbn.Size = new System.Drawing.Size(141, 32);
            this.lblBookIsbn.TabIndex = 17;
            this.lblBookIsbn.Text = "Book ISBN:";
            // 
            // lblBookGenre
            // 
            this.lblBookGenre.AutoSize = true;
            this.lblBookGenre.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookGenre.Location = new System.Drawing.Point(25, 449);
            this.lblBookGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookGenre.Name = "lblBookGenre";
            this.lblBookGenre.Size = new System.Drawing.Size(154, 32);
            this.lblBookGenre.TabIndex = 16;
            this.lblBookGenre.Text = "Book Genre:";
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookAuthor.Location = new System.Drawing.Point(25, 406);
            this.lblBookAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(167, 32);
            this.lblBookAuthor.TabIndex = 15;
            this.lblBookAuthor.Text = "Book Author:";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.Location = new System.Drawing.Point(25, 363);
            this.lblBookTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(136, 32);
            this.lblBookTitle.TabIndex = 14;
            this.lblBookTitle.Text = "Book Title:";
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookId.Location = new System.Drawing.Point(25, 320);
            this.lblBookId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(112, 32);
            this.lblBookId.TabIndex = 13;
            this.lblBookId.Text = "Book ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(359, 272);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Book Info";
            // 
            // lblStudentEmail
            // 
            this.lblStudentEmail.AutoSize = true;
            this.lblStudentEmail.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentEmail.Location = new System.Drawing.Point(25, 220);
            this.lblStudentEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentEmail.Name = "lblStudentEmail";
            this.lblStudentEmail.Size = new System.Drawing.Size(178, 32);
            this.lblStudentEmail.TabIndex = 11;
            this.lblStudentEmail.Text = "Student Email:";
            // 
            // lblStudentContact
            // 
            this.lblStudentContact.AutoSize = true;
            this.lblStudentContact.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentContact.Location = new System.Drawing.Point(25, 177);
            this.lblStudentContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentContact.Name = "lblStudentContact";
            this.lblStudentContact.Size = new System.Drawing.Size(204, 32);
            this.lblStudentContact.TabIndex = 10;
            this.lblStudentContact.Text = "Student Contact:";
            // 
            // lblStudentDepartment
            // 
            this.lblStudentDepartment.AutoSize = true;
            this.lblStudentDepartment.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentDepartment.Location = new System.Drawing.Point(25, 134);
            this.lblStudentDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentDepartment.Name = "lblStudentDepartment";
            this.lblStudentDepartment.Size = new System.Drawing.Size(254, 32);
            this.lblStudentDepartment.TabIndex = 9;
            this.lblStudentDepartment.Text = "Student Department:";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(25, 91);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(183, 32);
            this.lblStudentName.TabIndex = 8;
            this.lblStudentName.Text = "Student Name:";
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentId.Location = new System.Drawing.Point(25, 48);
            this.lblStudentId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(142, 32);
            this.lblStudentId.TabIndex = 7;
            this.lblStudentId.Text = "Student ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Student Info";
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1275, 612);
            this.Controls.Add(this.pnlReturnBookInfo);
            this.Controls.Add(this.pnlEnterStudentId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Book";
            this.pnlEnterStudentId.ResumeLayout(false);
            this.pnlEnterStudentId.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStudent)).EndInit();
            this.pnlReturnBookInfo.ResumeLayout(false);
            this.pnlReturnBookInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEnterStudentId;
        private System.Windows.Forms.PictureBox picBoxStudent;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.TextBox txtBoxStudentId;
        private System.Windows.Forms.Label lblEnterStudentId;
        private System.Windows.Forms.Panel pnlReturnBookInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStudentEmail;
        private System.Windows.Forms.Label lblStudentContact;
        private System.Windows.Forms.Label lblStudentDepartment;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBookIsbn;
        private System.Windows.Forms.Label lblBookGenre;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblStudentIdInfo;
        private System.Windows.Forms.Label lblStudentEmailInfo;
        private System.Windows.Forms.Label lblStudentContactInfo;
        private System.Windows.Forms.Label lblStudentDepartmentInfo;
        private System.Windows.Forms.Label lblStudentNameInfo;
        private System.Windows.Forms.Label lblBookIdInfo;
        private System.Windows.Forms.Label lblNBookIsbnInfo;
        private System.Windows.Forms.Label lblBookGenreInfo;
        private System.Windows.Forms.Label lblBookAuthorInfo;
        private System.Windows.Forms.Label lblBookTitleInfo;
    }
}