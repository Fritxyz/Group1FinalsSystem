namespace LibraryManagementSystem
{
    partial class AddStudentForm
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
            this.pnlAddStudentBackground = new System.Windows.Forms.Panel();
            this.picBoxAddStudent = new System.Windows.Forms.PictureBox();
            this.pnlStudentInfo = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxStudentEmail = new System.Windows.Forms.TextBox();
            this.lblStudentEmail = new System.Windows.Forms.Label();
            this.txtBoxStudentContact = new System.Windows.Forms.TextBox();
            this.lblStudentContact = new System.Windows.Forms.Label();
            this.txtBoxStudentDepartment = new System.Windows.Forms.TextBox();
            this.lblStudentDepartment = new System.Windows.Forms.Label();
            this.txtBoxStudentId = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.txtBoxStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.pnlAddStudentBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAddStudent)).BeginInit();
            this.pnlStudentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddStudentBackground
            // 
            this.pnlAddStudentBackground.Controls.Add(this.picBoxAddStudent);
            this.pnlAddStudentBackground.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAddStudentBackground.Location = new System.Drawing.Point(490, 0);
            this.pnlAddStudentBackground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAddStudentBackground.Name = "pnlAddStudentBackground";
            this.pnlAddStudentBackground.Size = new System.Drawing.Size(469, 505);
            this.pnlAddStudentBackground.TabIndex = 0;
            // 
            // picBoxAddStudent
            // 
            this.picBoxAddStudent.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBoxAddStudent.Image = global::LibraryManagementSystem.Properties.Resources.add_student_picture;
            this.picBoxAddStudent.Location = new System.Drawing.Point(2, 0);
            this.picBoxAddStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxAddStudent.Name = "picBoxAddStudent";
            this.picBoxAddStudent.Size = new System.Drawing.Size(467, 505);
            this.picBoxAddStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAddStudent.TabIndex = 0;
            this.picBoxAddStudent.TabStop = false;
            // 
            // pnlStudentInfo
            // 
            this.pnlStudentInfo.Controls.Add(this.btnCancel);
            this.pnlStudentInfo.Controls.Add(this.btnSave);
            this.pnlStudentInfo.Controls.Add(this.btnClear);
            this.pnlStudentInfo.Controls.Add(this.label1);
            this.pnlStudentInfo.Controls.Add(this.txtBoxStudentEmail);
            this.pnlStudentInfo.Controls.Add(this.lblStudentEmail);
            this.pnlStudentInfo.Controls.Add(this.txtBoxStudentContact);
            this.pnlStudentInfo.Controls.Add(this.lblStudentContact);
            this.pnlStudentInfo.Controls.Add(this.txtBoxStudentDepartment);
            this.pnlStudentInfo.Controls.Add(this.lblStudentDepartment);
            this.pnlStudentInfo.Controls.Add(this.txtBoxStudentId);
            this.pnlStudentInfo.Controls.Add(this.lblStudentId);
            this.pnlStudentInfo.Controls.Add(this.txtBoxStudentName);
            this.pnlStudentInfo.Controls.Add(this.lblStudentName);
            this.pnlStudentInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStudentInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlStudentInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlStudentInfo.Name = "pnlStudentInfo";
            this.pnlStudentInfo.Size = new System.Drawing.Size(497, 505);
            this.pnlStudentInfo.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(176, 447);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 48);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(267, 391);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 48);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(91, 391);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 48);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Student Name";
            // 
            // txtBoxStudentEmail
            // 
            this.txtBoxStudentEmail.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStudentEmail.Location = new System.Drawing.Point(173, 335);
            this.txtBoxStudentEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxStudentEmail.MaxLength = 100;
            this.txtBoxStudentEmail.Name = "txtBoxStudentEmail";
            this.txtBoxStudentEmail.Size = new System.Drawing.Size(311, 34);
            this.txtBoxStudentEmail.TabIndex = 9;
            // 
            // lblStudentEmail
            // 
            this.lblStudentEmail.AutoSize = true;
            this.lblStudentEmail.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentEmail.Location = new System.Drawing.Point(12, 341);
            this.lblStudentEmail.Name = "lblStudentEmail";
            this.lblStudentEmail.Size = new System.Drawing.Size(132, 28);
            this.lblStudentEmail.TabIndex = 8;
            this.lblStudentEmail.Text = "Student Email";
            // 
            // txtBoxStudentContact
            // 
            this.txtBoxStudentContact.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStudentContact.Location = new System.Drawing.Point(173, 271);
            this.txtBoxStudentContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxStudentContact.MaxLength = 100;
            this.txtBoxStudentContact.Name = "txtBoxStudentContact";
            this.txtBoxStudentContact.Size = new System.Drawing.Size(311, 34);
            this.txtBoxStudentContact.TabIndex = 7;
            // 
            // lblStudentContact
            // 
            this.lblStudentContact.AutoSize = true;
            this.lblStudentContact.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentContact.Location = new System.Drawing.Point(12, 276);
            this.lblStudentContact.Name = "lblStudentContact";
            this.lblStudentContact.Size = new System.Drawing.Size(153, 28);
            this.lblStudentContact.TabIndex = 6;
            this.lblStudentContact.Text = "Student Contact";
            // 
            // txtBoxStudentDepartment
            // 
            this.txtBoxStudentDepartment.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStudentDepartment.Location = new System.Drawing.Point(173, 203);
            this.txtBoxStudentDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxStudentDepartment.MaxLength = 100;
            this.txtBoxStudentDepartment.Name = "txtBoxStudentDepartment";
            this.txtBoxStudentDepartment.Size = new System.Drawing.Size(311, 34);
            this.txtBoxStudentDepartment.TabIndex = 5;
            this.txtBoxStudentDepartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxStudentDepartment_KeyPress);
            // 
            // lblStudentDepartment
            // 
            this.lblStudentDepartment.AutoSize = true;
            this.lblStudentDepartment.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentDepartment.Location = new System.Drawing.Point(12, 210);
            this.lblStudentDepartment.Name = "lblStudentDepartment";
            this.lblStudentDepartment.Size = new System.Drawing.Size(118, 28);
            this.lblStudentDepartment.TabIndex = 4;
            this.lblStudentDepartment.Text = "Department";
            // 
            // txtBoxStudentId
            // 
            this.txtBoxStudentId.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStudentId.Location = new System.Drawing.Point(173, 135);
            this.txtBoxStudentId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxStudentId.MaxLength = 8;
            this.txtBoxStudentId.Name = "txtBoxStudentId";
            this.txtBoxStudentId.Size = new System.Drawing.Size(311, 34);
            this.txtBoxStudentId.TabIndex = 3;
            this.txtBoxStudentId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxStudentId_KeyPress);
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentId.Location = new System.Drawing.Point(12, 142);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(104, 28);
            this.lblStudentId.TabIndex = 2;
            this.lblStudentId.Text = "Student ID";
            // 
            // txtBoxStudentName
            // 
            this.txtBoxStudentName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStudentName.Location = new System.Drawing.Point(173, 66);
            this.txtBoxStudentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxStudentName.MaxLength = 100;
            this.txtBoxStudentName.Name = "txtBoxStudentName";
            this.txtBoxStudentName.Size = new System.Drawing.Size(311, 34);
            this.txtBoxStudentName.TabIndex = 1;
            this.txtBoxStudentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxStudentName_KeyPress);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(12, 71);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(137, 28);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student Name";
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 505);
            this.Controls.Add(this.pnlStudentInfo);
            this.Controls.Add(this.pnlAddStudentBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "AddStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student";
            this.pnlAddStudentBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAddStudent)).EndInit();
            this.pnlStudentInfo.ResumeLayout(false);
            this.pnlStudentInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddStudentBackground;
        private System.Windows.Forms.PictureBox picBoxAddStudent;
        private System.Windows.Forms.Panel pnlStudentInfo;
        private System.Windows.Forms.TextBox txtBoxStudentEmail;
        private System.Windows.Forms.Label lblStudentEmail;
        private System.Windows.Forms.TextBox txtBoxStudentContact;
        private System.Windows.Forms.Label lblStudentContact;
        private System.Windows.Forms.TextBox txtBoxStudentDepartment;
        private System.Windows.Forms.Label lblStudentDepartment;
        private System.Windows.Forms.TextBox txtBoxStudentId;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox txtBoxStudentName;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
    }
}