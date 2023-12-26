using LibraryManagementSystemLibrary;
using LibraryManagementSystemLibrary.DataAccessLayer;
using LibraryManagementSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class ViewBookForm : Form
    {
        private DataAccessLayer _db = new DataAccessLayer();
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;
        private int bookId = 0;

        public ViewBookForm()
        {
            InitializeComponent();
        }

        private void ViewBookForm_Load(object sender, EventArgs e)
        {
            pnlEditData.Visible = false;
            LoadDataGridView();
        }

        private void dgvViewBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvViewBook.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bookId = int.Parse(dgvViewBook.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            pnlEditData.Visible = true;

            string mySqlStatement = @"SELECT * FROM add_book WHERE book_id = @BookId";
            AddBook books = _db.LoadData<AddBook, dynamic>(mySqlStatement,
                                                           new { BookId = bookId },
                                                           _connectionString).FirstOrDefault();
           
            txtBoxBookId.Text = books.book_id.ToString();
            txtBoxBookTitle.Text = books.book_title.ToString();
            txtBoxBookAuthor.Text = books.book_author.ToString();
            txtBoxBookGenre.Text = books.book_genre.ToString();
            txtBoxBookISBN.Text = books.book_isbn.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlEditData.Visible = false;
        }

        private void txtBoxBookSearch_TextChanged(object sender, EventArgs e)
        {
            string mySqlStatement = "";
            if (!string.IsNullOrEmpty(txtBoxBookSearch.Text))
            {
                mySqlStatement = @"SELECT * FROM add_book WHERE book_id LIKE @BookId
                                    OR book_title LIKE @BookTitle
                                    OR book_author LIKE @BookAuthor
                                    OR book_genre LIKE @BookGenre
                                    OR book_isbn LIKE @BookISBN";

                List<AddBook> books = _db.LoadData<AddBook, dynamic>(mySqlStatement,
                                                                     new 
                                                                     {
                                                                        BookId = txtBoxBookSearch.Text + "%", 
                                                                        BookTitle = txtBoxBookSearch.Text + "%",
                                                                        BookAuthor = txtBoxBookSearch.Text + "%", 
                                                                        BookGenre = txtBoxBookSearch.Text + "%", 
                                                                        BookISBN = txtBoxBookSearch.Text + "%"
                                                                     },
                                                                     _connectionString);

                dgvViewBook.DataSource = books;
                dgvViewBook.Refresh();
            }
            else
            {
                LoadDataGridView();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBoxBookSearch.Clear();
            pnlEditData.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updatedBookId = txtBoxBookId.Text;
            string updatedBookTitle = txtBoxBookTitle.Text;
            string updatedBookAuthor = txtBoxBookAuthor.Text;
            string updatedBookGenre = txtBoxBookGenre.Text;
            string updatedBookISBN = txtBoxBookISBN.Text;

            if (string.IsNullOrWhiteSpace(updatedBookId)
               || string.IsNullOrWhiteSpace(updatedBookTitle)
               || string.IsNullOrWhiteSpace(updatedBookAuthor)
               || string.IsNullOrWhiteSpace(updatedBookGenre)
               || string.IsNullOrWhiteSpace(updatedBookISBN))
            {
                MessageBox.Show("Do not enter empty value/s",
                                "Error: Null/Empty Value",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Data will be updated. Confirm?",
                                    "Please double check.",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int oldBookId = bookId;

                    string mySqlStatement = @"UPDATE add_book 
                                         SET book_id = @BookId,
                                         book_title = @BookTitle,
                                         book_author = @BookAuthor,
                                         book_genre = @BookGenre,
                                         book_isbn = @BookISBN
                                         WHERE book_id = @OldBookId";

                    _db.SaveData(mySqlStatement,
                                 new
                                 {
                                     BookId = updatedBookId,
                                     BookTitle = updatedBookTitle,
                                     BookAuthor = updatedBookAuthor,
                                     BookGenre = updatedBookGenre,
                                     BookISBN = updatedBookISBN,
                                     oldBookId
                                 },
                                 _connectionString);

                    MessageBox.Show("Book Data Updated Successfully.",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    pnlEditData.Visible = false;
                    LoadDataGridView();
                } 
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be deleted. Confirm?",
                                "Please double check.",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int oldBookId = bookId;

                string mySqlStatement = @"DELETE FROM add_book WHERE book_id = @OldBookId";

                _db.SaveData(mySqlStatement, new { oldBookId }, _connectionString);

                MessageBox.Show("Book Data Deleted Successfully.",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                pnlEditData.Visible = false;
                LoadDataGridView();
            }
        }

        private void LoadDataGridView()
        {
            string mySqlStatement = @"SELECT * FROM add_book";
            List<AddBook> books = _db.LoadData<AddBook, dynamic>(mySqlStatement, new { }, _connectionString);

            dgvViewBook.DataSource = books;
            dgvViewBook.Refresh();
        }

        private void txtBoxBookId_KeyPress(object sender, KeyPressEventArgs e)
        {
            StaticFunctionsEvents.KeyCharNumbers(e);
        }

        private void txtBoxBookAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            StaticFunctionsEvents.KeyCharLetters(e);
        }

        private void txtBoxBookGenre_KeyPress(object sender, KeyPressEventArgs e)
        {
            StaticFunctionsEvents.KeyCharLetters(e);
        }

        private void txtBoxBookISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            StaticFunctionsEvents.KeyCharNumbers(e);
        }
    }
}
