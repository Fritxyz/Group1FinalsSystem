namespace LibraryManagementSystem
{
    partial class AddBookForm
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
            this.pnlRght = new System.Windows.Forms.Panel();
            this.lblAddBook = new System.Windows.Forms.Label();
            this.btnCLear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBoxBookIsbn = new System.Windows.Forms.TextBox();
            this.txtBoxBookGenre = new System.Windows.Forms.TextBox();
            this.txtBoxBookAuthor = new System.Windows.Forms.TextBox();
            this.txtBoxBookTitle = new System.Windows.Forms.TextBox();
            this.txtBoxBookId = new System.Windows.Forms.TextBox();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.picBoxAddBook = new System.Windows.Forms.PictureBox();
            this.pnlRght.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAddBook)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRght
            // 
            this.pnlRght.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(149)))), ((int)(((byte)(150)))));
            this.pnlRght.Controls.Add(this.lblAddBook);
            this.pnlRght.Controls.Add(this.btnCLear);
            this.pnlRght.Controls.Add(this.btnCancel);
            this.pnlRght.Controls.Add(this.btnSave);
            this.pnlRght.Controls.Add(this.txtBoxBookIsbn);
            this.pnlRght.Controls.Add(this.txtBoxBookGenre);
            this.pnlRght.Controls.Add(this.txtBoxBookAuthor);
            this.pnlRght.Controls.Add(this.txtBoxBookTitle);
            this.pnlRght.Controls.Add(this.txtBoxBookId);
            this.pnlRght.Controls.Add(this.lblIsbn);
            this.pnlRght.Controls.Add(this.lblGenre);
            this.pnlRght.Controls.Add(this.lblAuthor);
            this.pnlRght.Controls.Add(this.lblBookId);
            this.pnlRght.Controls.Add(this.lblName);
            this.pnlRght.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRght.Location = new System.Drawing.Point(365, 0);
            this.pnlRght.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRght.Name = "pnlRght";
            this.pnlRght.Size = new System.Drawing.Size(643, 670);
            this.pnlRght.TabIndex = 0;
            // 
            // lblAddBook
            // 
            this.lblAddBook.AutoSize = true;
            this.lblAddBook.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddBook.ForeColor = System.Drawing.Color.White;
            this.lblAddBook.Location = new System.Drawing.Point(267, 32);
            this.lblAddBook.Name = "lblAddBook";
            this.lblAddBook.Size = new System.Drawing.Size(171, 45);
            this.lblAddBook.TabIndex = 13;
            this.lblAddBook.Text = "Add Book";
            // 
            // btnCLear
            // 
            this.btnCLear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCLear.Location = new System.Drawing.Point(75, 545);
            this.btnCLear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCLear.Name = "btnCLear";
            this.btnCLear.Size = new System.Drawing.Size(139, 62);
            this.btnCLear.TabIndex = 12;
            this.btnCLear.Text = "Clear";
            this.btnCLear.UseVisualStyleBackColor = true;
            this.btnCLear.Click += new System.EventHandler(this.btnCLear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(469, 545);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 62);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(275, 545);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 62);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBoxBookIsbn
            // 
            this.txtBoxBookIsbn.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBookIsbn.Location = new System.Drawing.Point(229, 432);
            this.txtBoxBookIsbn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxBookIsbn.MaxLength = 13;
            this.txtBoxBookIsbn.Name = "txtBoxBookIsbn";
            this.txtBoxBookIsbn.Size = new System.Drawing.Size(380, 51);
            this.txtBoxBookIsbn.TabIndex = 9;
            this.txtBoxBookIsbn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxBookIsbn_KeyPress);
            // 
            // txtBoxBookGenre
            // 
            this.txtBoxBookGenre.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBookGenre.Location = new System.Drawing.Point(229, 348);
            this.txtBoxBookGenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxBookGenre.MaxLength = 100;
            this.txtBoxBookGenre.Name = "txtBoxBookGenre";
            this.txtBoxBookGenre.Size = new System.Drawing.Size(380, 51);
            this.txtBoxBookGenre.TabIndex = 8;
            this.txtBoxBookGenre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxBookGenre_KeyPress);
            // 
            // txtBoxBookAuthor
            // 
            this.txtBoxBookAuthor.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBookAuthor.Location = new System.Drawing.Point(229, 263);
            this.txtBoxBookAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxBookAuthor.MaxLength = 100;
            this.txtBoxBookAuthor.Name = "txtBoxBookAuthor";
            this.txtBoxBookAuthor.Size = new System.Drawing.Size(380, 51);
            this.txtBoxBookAuthor.TabIndex = 7;
            this.txtBoxBookAuthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxBookAuthor_KeyPress);
            // 
            // txtBoxBookTitle
            // 
            this.txtBoxBookTitle.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBookTitle.Location = new System.Drawing.Point(229, 182);
            this.txtBoxBookTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxBookTitle.MaxLength = 100;
            this.txtBoxBookTitle.Name = "txtBoxBookTitle";
            this.txtBoxBookTitle.Size = new System.Drawing.Size(380, 51);
            this.txtBoxBookTitle.TabIndex = 6;
            // 
            // txtBoxBookId
            // 
            this.txtBoxBookId.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBookId.Location = new System.Drawing.Point(229, 100);
            this.txtBoxBookId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxBookId.MaxLength = 10;
            this.txtBoxBookId.Name = "txtBoxBookId";
            this.txtBoxBookId.Size = new System.Drawing.Size(380, 51);
            this.txtBoxBookId.TabIndex = 5;
            this.txtBoxBookId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxBookId_KeyPress);
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsbn.ForeColor = System.Drawing.Color.White;
            this.lblIsbn.Location = new System.Drawing.Point(67, 437);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(96, 45);
            this.lblIsbn.TabIndex = 4;
            this.lblIsbn.Text = "ISBN";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.White;
            this.lblGenre.Location = new System.Drawing.Point(67, 353);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(112, 45);
            this.lblGenre.TabIndex = 3;
            this.lblGenre.Text = "Genre";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.White;
            this.lblAuthor.Location = new System.Drawing.Point(67, 270);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(129, 45);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author";
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookId.ForeColor = System.Drawing.Color.White;
            this.lblBookId.Location = new System.Drawing.Point(67, 105);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(142, 45);
            this.lblBookId.TabIndex = 1;
            this.lblBookId.Text = "Book ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(67, 187);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 45);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Title";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.picBoxAddBook);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(389, 670);
            this.pnlLeft.TabIndex = 1;
            // 
            // picBoxAddBook
            // 
            this.picBoxAddBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.picBoxAddBook.Image = global::LibraryManagementSystem.Properties.Resources.add_book_pic;
            this.picBoxAddBook.Location = new System.Drawing.Point(0, 0);
            this.picBoxAddBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxAddBook.Name = "picBoxAddBook";
            this.picBoxAddBook.Size = new System.Drawing.Size(389, 670);
            this.picBoxAddBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxAddBook.TabIndex = 0;
            this.picBoxAddBook.TabStop = false;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 670);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRght);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "AddBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Book";
            this.pnlRght.ResumeLayout(false);
            this.pnlRght.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAddBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRght;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.PictureBox picBoxAddBook;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBoxBookIsbn;
        private System.Windows.Forms.TextBox txtBoxBookGenre;
        private System.Windows.Forms.TextBox txtBoxBookAuthor;
        private System.Windows.Forms.TextBox txtBoxBookTitle;
        private System.Windows.Forms.TextBox txtBoxBookId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCLear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAddBook;
    }
}