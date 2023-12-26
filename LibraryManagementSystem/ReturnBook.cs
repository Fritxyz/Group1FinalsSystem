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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class ReturnBook : Form
    {
        private DataAccessLayer _db = new DataAccessLayer();
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;

        public ReturnBook()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBoxStudentId.Clear();
            pnlReturnBookInfo.Visible = false; 
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxStudentId.Text))
            {
                MessageBox.Show("Do not enter empty value/s",
                                "Error: Null/Empty Value",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                string mySqlStatement = @"SELECT * FROM issue_book WHERE student_id = @StudentId";
                IssueBook issueBook = _db.LoadData<IssueBook, dynamic>(mySqlStatement,
                                                                       new { StudentId = txtBoxStudentId.Text },
                                                                       _connectionString).FirstOrDefault();

                if (issueBook != null)
                {
                    pnlReturnBookInfo.Visible = true;

                    mySqlStatement = @"SELECT * FROM student WHERE student_id = @StudentId";
                    Students student = _db.LoadData<Students, dynamic>(mySqlStatement,
                                                                       new { StudentId = txtBoxStudentId.Text },
                                                                       _connectionString).FirstOrDefault();

                    mySqlStatement = @"SELECT * FROM add_book WHERE book_id = @BookId";
                    AddBook book = _db.LoadData<AddBook, dynamic>(mySqlStatement,
                                                                  new { BookId = issueBook.book_id },
                                                                  _connectionString).FirstOrDefault();

                    pnlReturnBookInfo.Visible = true;

                    ShowInfo(lblStudentIdInfo, txtBoxStudentId.Text);
                    ShowInfo(lblStudentNameInfo, student.student_name);
                    ShowInfo(lblStudentDepartmentInfo, student.student_department);
                    ShowInfo(lblStudentContactInfo, student.student_contact);
                    ShowInfo(lblStudentEmailInfo, student.student_email);

                    ShowInfo(lblBookIdInfo, book.book_id.ToString());
                    ShowInfo(lblBookTitleInfo, book.book_title);
                    ShowInfo(lblBookAuthorInfo, book.book_author);
                    ShowInfo(lblBookGenreInfo, book.book_genre);
                    ShowInfo(lblNBookIsbnInfo, book.book_isbn);
                }
                else
                {
                    MessageBox.Show($"ID: {txtBoxStudentId.Text} does not issued any books.",
                                    "No Credentials Found",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void ShowInfo(Label info, string value)
        {
            info.Text = value;
            info.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlReturnBookInfo.Visible = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            string mySqlStatement = @"DELETE FROM issue_book WHERE student_id = @StudentId";
            _db.SaveData(mySqlStatement, new { StudentId = txtBoxStudentId.Text }, _connectionString);

            MessageBox.Show("Book Returned Successfully.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void txtBoxStudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            StaticFunctionsEvents.KeyCharNumbers(e);
        }
    }
}
