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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AddStudentForm : Form
    {
        private DataAccessLayer _db = new DataAccessLayer();
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;

        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void txtBoxStudentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            StaticFunctionsEvents.KeyCharLetters(e);
        }

        private void txtBoxStudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            StaticFunctionsEvents.KeyCharNumbers(e);
        }

        private void txtBoxStudentDepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            StaticFunctionsEvents.KeyCharLetters(e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxStudentContact.Text)
                || string.IsNullOrWhiteSpace(txtBoxStudentDepartment.Text)
                || string.IsNullOrWhiteSpace(txtBoxStudentEmail.Text)
                || string.IsNullOrWhiteSpace(txtBoxStudentId.Text)
                || string.IsNullOrWhiteSpace(txtBoxStudentName.Text))
            {
                MessageBox.Show("Do not enter empty value/s",
                                "Error: Null/Empty Value",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                string mySqlStatement = @"SELECT * FROM student WHERE student_id = @StudentId";
                Students student = _db.LoadData<Students, dynamic>(mySqlStatement,
                                                                   new { StudentId = txtBoxStudentId.Text },
                                                                   _connectionString).FirstOrDefault();

                if (student != null)
                {
                    MessageBox.Show($"Student with ID of {student.student_id} is owned by {student.student_name} from {student.student_department}",
                                    "Already exists",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (!Regex.IsMatch(txtBoxStudentEmail.Text, "^[a-zA-Z0-9]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$"))
                    {
                        MessageBox.Show("Not valid email address.",
                                        "Try again",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                    else
                    {
                        mySqlStatement = @"INSERT INTO student 
                                           (student_id, student_name, student_department, student_contact, student_email)
                                           VALUES (@StudentId, @StudentName, @StudentDepartment, @StudentContact, @StudentEmail)";

                        _db.SaveData(mySqlStatement,
                                     new 
                                     { 
                                         StudentId = txtBoxStudentId.Text, 
                                         StudentName = txtBoxStudentName.Text, 
                                         studentDepartment = txtBoxStudentDepartment.Text, 
                                         StudentContact = txtBoxStudentContact.Text, 
                                         StudentEmail = txtBoxStudentEmail.Text 
                                     },
                                     _connectionString);

                        MessageBox.Show("Student Added Successfully.",
                                        "Success",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        ClearData();
                    }
                }
            }
        }

        private void ClearData()
        {
            txtBoxStudentDepartment.Clear();
            txtBoxStudentEmail.Clear();
            txtBoxStudentId.Clear();
            txtBoxStudentName.Clear();
            txtBoxStudentContact.Clear();
        }
    }
}
