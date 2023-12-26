using LibraryManagementSystemLibrary.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using LibraryManagementSystemLibrary;

namespace LibraryManagementSystem
{
    public partial class AddBookForm : Form
    {
        private DataAccessLayer _db = new DataAccessLayer();
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;

        public AddBookForm()
        {
            InitializeComponent();
        }

        private void btnCLear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void txtBoxBookId_KeyPress(object sender, KeyPressEventArgs e)
        {
            StaticFunctionsEvents.KeyCharNumbers(e);
        }

        private void txtBoxBookGenre_KeyPress(object sender, KeyPressEventArgs e)
        {
            StaticFunctionsEvents.KeyCharLetters(e);
        } 

        private void txtBoxBookIsbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            StaticFunctionsEvents.KeyCharNumbers(e);
        }

        private void txtBoxBookAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            StaticFunctionsEvents.KeyCharLetters(e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string bookId = txtBoxBookId.Text;
            string bookName = txtBoxBookTitle.Text;
            string bookAuthor = txtBoxBookAuthor.Text;
            string bookGenre = txtBoxBookGenre.Text;
            string bookISBN = txtBoxBookIsbn.Text;

            if (string.IsNullOrWhiteSpace(bookId)
                || string.IsNullOrWhiteSpace(bookName)
                || string.IsNullOrWhiteSpace(bookAuthor)
                || string.IsNullOrWhiteSpace(bookGenre)
                || string.IsNullOrWhiteSpace(bookISBN))
            {
                MessageBox.Show("Do not enter empty value/s",
                                "Error: Null/Empty Value",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                string mySqlStatement = @"INSERT INTO add_book 
                                         (book_id, book_title, book_author, book_genre, book_isbn)
                                         VALUES (@BookId, @BookName, @BookAuthor, @BookGenre, @BookISBN)";

                _db.SaveData(mySqlStatement,
                             new 
                             { 
                                 BookId = bookId, 
                                 BookName = bookName, 
                                 BookAuthor = bookAuthor, 
                                 BookGenre = bookGenre, 
                                 BookISBN = bookISBN 
                             },
                             _connectionString);

                MessageBox.Show("Book Added Successfully.",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                ClearData();
            }
        }

        private void ClearData()
        {
            txtBoxBookAuthor.Clear();
            txtBoxBookGenre.Clear();
            txtBoxBookId.Clear();
            txtBoxBookIsbn.Clear();
            txtBoxBookTitle.Clear();
        }
    }
}
