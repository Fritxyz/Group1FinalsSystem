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
    public partial class IssueBookForm : Form
    {
        private DataAccessLayer _db = new DataAccessLayer();
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;

        public IssueBookForm()
        {
            InitializeComponent();
        }

        private void IssueBookForm_Load(object sender, EventArgs e)
        {
            string mySqlStatement = @"SELECT book_title from add_book";
            List<AddBook> books = _db.LoadData<AddBook, dynamic>(mySqlStatement, new { }, _connectionString);

            foreach (AddBook book in books)
            {
                cmbBoxBookName.Items.Add(book.book_title);
            }
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBoxStudentId.Text))
            {
                string mySqlStatement = @"SELECT * FROM student WHERE student_id = @StudentId";
                Students student = _db.LoadData<Students, dynamic>(mySqlStatement,
                                                                   new { StudentId = txtBoxStudentId.Text },
                                                                   _connectionString).FirstOrDefault();

                if (student != null)
                {
                    txtBoxStudentName.Text = student.student_name;
                    txtBoxStudentDepartment.Text = student.student_department;
                    txtBoxStudentContact.Text = student.student_contact;
                    txtBoxStudentEmail.Text = student.student_email;
                }
                else
                {
                    MessageBox.Show($"ID: {txtBoxStudentId.Text} does not exist in the system.",
                                    "No Credentials Found",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Do not enter empty value/s",
                                "Error: Null/Empty Value",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxStudentContact.Text)
                || string.IsNullOrWhiteSpace(txtBoxStudentDepartment.Text)
                || string.IsNullOrWhiteSpace(txtBoxStudentEmail.Text)
                || string.IsNullOrWhiteSpace(txtBoxStudentName.Text)
                || string.IsNullOrWhiteSpace(cmbBoxBookName.Text))
            {
                MessageBox.Show("Do not enter empty value/s",
                                "Error: Null/Empty Value",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                string mySqlStatement = @"SELECT book_id FROM add_book where book_title = @BookTitle";
                AddBook book = _db.LoadData<AddBook, dynamic>(mySqlStatement,
                                                              new { BookTitle = cmbBoxBookName.Text },
                                                              _connectionString).FirstOrDefault();

                if (book != null)
                {
                    mySqlStatement = @"SELECT * FROM issue_book where student_id = @StudentId";
                    IssueBook issueBook = _db.LoadData<IssueBook, dynamic>(mySqlStatement,
                                                                           new { StudentId = txtBoxStudentId.Text },
                                                                           _connectionString).FirstOrDefault();

                    if (issueBook != null)
                    {
                        MessageBox.Show("This student has already issued a book",
                                        "Book Already Issued",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                    else
                    {
                        mySqlStatement = @"INSERT INTO issue_book 
                                           (student_id, book_id) 
                                           VALUES (@StudentId, @BookId)";

                        _db.SaveData(mySqlStatement,
                                     new 
                                     {
                                         StudentId = txtBoxStudentId.Text, 
                                         BookId = book.book_id 
                                     },
                                     _connectionString);

                        MessageBox.Show("Book Issued Successfully.",
                                        "Success",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Do not enter empty value/s",
                                    "Error: Null/Empty Value",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBoxStudentContact.Clear();
            txtBoxStudentDepartment.Clear();
            txtBoxStudentEmail.Clear();
            txtBoxStudentId.Clear();
            txtBoxStudentName.Clear();
            cmbBoxBookName.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBoxStudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            StaticFunctionsEvents.KeyCharNumbers(e);
        }
    }
}
