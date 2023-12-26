namespace LibraryManagementSystem
{
    partial class ViewBookForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBookSearch = new System.Windows.Forms.Label();
            this.txtBoxBookSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvViewBook = new System.Windows.Forms.DataGridView();
            this.pnlEditData = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtBoxBookISBN = new System.Windows.Forms.TextBox();
            this.lblBookISBN = new System.Windows.Forms.Label();
            this.txtBoxBookGenre = new System.Windows.Forms.TextBox();
            this.lblBookGenre = new System.Windows.Forms.Label();
            this.txtBoxBookAuthor = new System.Windows.Forms.TextBox();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.txtBoxBookTitle = new System.Windows.Forms.TextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.txtBoxBookId = new System.Windows.Forms.TextBox();
            this.lblBookId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBook)).BeginInit();
            this.pnlEditData.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 123);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.view_book_picture1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1051, 491);
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
            this.lblBookSearch.Size = new System.Drawing.Size(104, 23);
            this.lblBookSearch.TabIndex = 1;
            this.lblBookSearch.Text = "Book Search";
            // 
            // txtBoxBookSearch
            // 
            this.txtBoxBookSearch.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBookSearch.Location = new System.Drawing.Point(388, 137);
            this.txtBoxBookSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxBookSearch.Name = "txtBoxBookSearch";
            this.txtBoxBookSearch.Size = new System.Drawing.Size(284, 29);
            this.txtBoxBookSearch.TabIndex = 2;
            this.txtBoxBookSearch.TextChanged += new System.EventHandler(this.txtBoxBookSearch_TextChanged);
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
            // dgvViewBook
            // 
            this.dgvViewBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewBook.ColumnHeadersHeight = 29;
            this.dgvViewBook.Location = new System.Drawing.Point(16, 175);
            this.dgvViewBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvViewBook.Name = "dgvViewBook";
            this.dgvViewBook.RowHeadersWidth = 51;
            this.dgvViewBook.Size = new System.Drawing.Size(1035, 373);
            this.dgvViewBook.TabIndex = 0;
            this.dgvViewBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewBook_CellClick);
            // 
            // pnlEditData
            // 
            this.pnlEditData.BackColor = System.Drawing.SystemColors.Control;
            this.pnlEditData.Controls.Add(this.btnCancel);
            this.pnlEditData.Controls.Add(this.btnDelete);
            this.pnlEditData.Controls.Add(this.btnUpdate);
            this.pnlEditData.Controls.Add(this.txtBoxBookISBN);
            this.pnlEditData.Controls.Add(this.lblBookISBN);
            this.pnlEditData.Controls.Add(this.txtBoxBookGenre);
            this.pnlEditData.Controls.Add(this.lblBookGenre);
            this.pnlEditData.Controls.Add(this.txtBoxBookAuthor);
            this.pnlEditData.Controls.Add(this.lblBookAuthor);
            this.pnlEditData.Controls.Add(this.txtBoxBookTitle);
            this.pnlEditData.Controls.Add(this.lblBookTitle);
            this.pnlEditData.Controls.Add(this.txtBoxBookId);
            this.pnlEditData.Controls.Add(this.lblBookId);
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
            // txtBoxBookISBN
            // 
            this.txtBoxBookISBN.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBookISBN.Location = new System.Drawing.Point(212, 274);
            this.txtBoxBookISBN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxBookISBN.MaxLength = 13;
            this.txtBoxBookISBN.Name = "txtBoxBookISBN";
            this.txtBoxBookISBN.Size = new System.Drawing.Size(771, 34);
            this.txtBoxBookISBN.TabIndex = 9;
            this.txtBoxBookISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxBookISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxBookISBN_KeyPress);
            // 
            // lblBookISBN
            // 
            this.lblBookISBN.AutoSize = true;
            this.lblBookISBN.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookISBN.Location = new System.Drawing.Point(44, 278);
            this.lblBookISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookISBN.Name = "lblBookISBN";
            this.lblBookISBN.Size = new System.Drawing.Size(112, 28);
            this.lblBookISBN.TabIndex = 8;
            this.lblBookISBN.Text = "Book ISBN";
            // 
            // txtBoxBookGenre
            // 
            this.txtBoxBookGenre.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBookGenre.Location = new System.Drawing.Point(212, 213);
            this.txtBoxBookGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxBookGenre.MaxLength = 100;
            this.txtBoxBookGenre.Name = "txtBoxBookGenre";
            this.txtBoxBookGenre.Size = new System.Drawing.Size(771, 34);
            this.txtBoxBookGenre.TabIndex = 7;
            this.txtBoxBookGenre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxBookGenre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxBookGenre_KeyPress);
            // 
            // lblBookGenre
            // 
            this.lblBookGenre.AutoSize = true;
            this.lblBookGenre.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookGenre.Location = new System.Drawing.Point(44, 223);
            this.lblBookGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookGenre.Name = "lblBookGenre";
            this.lblBookGenre.Size = new System.Drawing.Size(122, 28);
            this.lblBookGenre.TabIndex = 6;
            this.lblBookGenre.Text = "Book Genre";
            // 
            // txtBoxBookAuthor
            // 
            this.txtBoxBookAuthor.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBookAuthor.Location = new System.Drawing.Point(212, 159);
            this.txtBoxBookAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxBookAuthor.MaxLength = 100;
            this.txtBoxBookAuthor.Name = "txtBoxBookAuthor";
            this.txtBoxBookAuthor.Size = new System.Drawing.Size(771, 34);
            this.txtBoxBookAuthor.TabIndex = 5;
            this.txtBoxBookAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxBookAuthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxBookAuthor_KeyPress);
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookAuthor.Location = new System.Drawing.Point(44, 162);
            this.lblBookAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(132, 28);
            this.lblBookAuthor.TabIndex = 4;
            this.lblBookAuthor.Text = "Book Author";
            // 
            // txtBoxBookTitle
            // 
            this.txtBoxBookTitle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBookTitle.Location = new System.Drawing.Point(212, 97);
            this.txtBoxBookTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxBookTitle.MaxLength = 100;
            this.txtBoxBookTitle.Name = "txtBoxBookTitle";
            this.txtBoxBookTitle.Size = new System.Drawing.Size(771, 34);
            this.txtBoxBookTitle.TabIndex = 3;
            this.txtBoxBookTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.Location = new System.Drawing.Point(44, 101);
            this.lblBookTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(109, 28);
            this.lblBookTitle.TabIndex = 2;
            this.lblBookTitle.Text = "Book Title";
            // 
            // txtBoxBookId
            // 
            this.txtBoxBookId.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBookId.Location = new System.Drawing.Point(212, 34);
            this.txtBoxBookId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxBookId.MaxLength = 10;
            this.txtBoxBookId.Name = "txtBoxBookId";
            this.txtBoxBookId.Size = new System.Drawing.Size(771, 34);
            this.txtBoxBookId.TabIndex = 1;
            this.txtBoxBookId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxBookId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxBookId_KeyPress);
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookId.Location = new System.Drawing.Point(44, 44);
            this.lblBookId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(87, 28);
            this.lblBookId.TabIndex = 0;
            this.lblBookId.Text = "Book ID";
            // 
            // ViewBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1049, 576);
            this.Controls.Add(this.pnlEditData);
            this.Controls.Add(this.dgvViewBook);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtBoxBookSearch);
            this.Controls.Add(this.lblBookSearch);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ViewBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Book";
            this.Load += new System.EventHandler(this.ViewBookForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBook)).EndInit();
            this.pnlEditData.ResumeLayout(false);
            this.pnlEditData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBookSearch;
        private System.Windows.Forms.TextBox txtBoxBookSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvViewBook;
        private System.Windows.Forms.Panel pnlEditData;
        private System.Windows.Forms.TextBox txtBoxBookISBN;
        private System.Windows.Forms.Label lblBookISBN;
        private System.Windows.Forms.TextBox txtBoxBookGenre;
        private System.Windows.Forms.Label lblBookGenre;
        private System.Windows.Forms.TextBox txtBoxBookAuthor;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.TextBox txtBoxBookTitle;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.TextBox txtBoxBookId;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}