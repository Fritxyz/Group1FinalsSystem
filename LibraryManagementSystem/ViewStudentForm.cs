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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class ViewStudentForm : Form
    {
        private DataAccessLayer _db = new DataAccessLayer();
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;
        private int studentId = 0;

        public ViewStudentForm()
        {
            InitializeComponent();
        }

        private void ViewStudentForm_Load(object sender, EventArgs e)
        {
            pnlEditData.Visible = false;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string mySqlStatement = @"SELECT * FROM student";
            List<Students> students = _db.LoadData<Students, dynamic>(mySqlStatement, new { }, _connectionString);

            dgvViewStudent.DataSource = students;
            dgvViewStudent.Refresh();
        }

        private void dgvViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvViewStudent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                studentId = int.Parse(dgvViewStudent.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            pnlEditData.Visible = true;

            string mySqlStatement = @"SELECT * FROM student WHERE student_id = @StudentId";
            Students student = _db.LoadData<Students, dynamic>(mySqlStatement, 
                                                               new { StudentId = studentId },
                                                               _connectionString).FirstOrDefault();

            txtBoxStudentId.Text = student.student_id.ToString();
            txtBoxStudentName.Text = student.student_name.ToString();
            txtBoxStudentDepartment.Text = student.student_department.ToString();
            txtBoxStudentContact.Text = student.student_contact.ToString();
            txtBoxStudentEmail.Text = student.student_email.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlEditData.Visible = false;
        }

        private void txtBoxStudentSearch_TextChanged(object sender, EventArgs e)
        {
            string mySqlStatement = "";
            if (!string.IsNullOrEmpty(txtBoxStudentSearch.Text))
            {
                mySqlStatement = @"SELECT * FROM student WHERE student_id LIKE @StudentId
                                    OR student_name LIKE @StudentName
                                    OR student_department LIKE @StudentDepartment
                                    OR student_contact LIKE @StudentContact
                                    OR student_email LIKE @StudentEmail";

                List<Students> students = _db.LoadData<Students, dynamic>(mySqlStatement,
                                                                     new
                                                                     {
                                                                         StudentId = txtBoxStudentSearch.Text + "%",
                                                                         StudentName = txtBoxStudentSearch.Text + "%",
                                                                         StudentDepartment = txtBoxStudentSearch.Text + "%",
                                                                         StudentContact = txtBoxStudentSearch.Text + "%",
                                                                         StudentEmail = txtBoxStudentSearch.Text + "%"
                                                                     },
                                                                     _connectionString);

                dgvViewStudent.DataSource = students;
                dgvViewStudent.Refresh();
            }
            else
            {
                LoadDataGridView();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBoxStudentSearch.Clear();
            pnlEditData.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxStudentId.Text)
               || string.IsNullOrWhiteSpace(txtBoxStudentName.Text)
               || string.IsNullOrWhiteSpace(txtBoxStudentDepartment.Text)
               || string.IsNullOrWhiteSpace(txtBoxStudentContact.Text)
               || string.IsNullOrWhiteSpace(txtBoxStudentEmail.Text))
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
                    if (!Regex.IsMatch(txtBoxStudentEmail.Text, "^[a-zA-Z0-9]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$"))
                    {
                        MessageBox.Show("Not valid email address.",
                                        "Try again",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int oldStudentId = studentId;

                        string mySqlStatement = @"UPDATE student 
                                         SET student_id = @StudentId,
                                         student_name = @StudentName,
                                         student_department = @StudentDepartment,
                                         student_contact = @StudentContact,
                                         student_email = @StudentEmail
                                         WHERE student_id = @OldStudentId";

                        _db.SaveData(mySqlStatement,
                                     new
                                     {
                                         StudentId = txtBoxStudentId.Text,
                                         StudentName = txtBoxStudentName.Text,
                                         StudentDepartment = txtBoxStudentDepartment.Text,
                                         StudentContact = txtBoxStudentContact.Text,
                                         StudentEmail = txtBoxStudentEmail.Text,
                                         OldStudentId = oldStudentId
                                     },
                                     _connectionString); ;

                        MessageBox.Show("Student Data Updated Successfully.",
                                        "Success",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        pnlEditData.Visible = false;
                        LoadDataGridView();
                    }  
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
                int oldStudentId = studentId;

                string mySqlStatement = @"DELETE FROM student WHERE student_id = @OldStudentId";

                _db.SaveData(mySqlStatement, new { OldStudentId = oldStudentId }, _connectionString);

                MessageBox.Show("Student Data Deleted Successfully.",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                pnlEditData.Visible = false;
                LoadDataGridView();
            }
        }

        private void txtBoxStudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            StaticFunctionsEvents.KeyCharNumbers(e);
        }

        private void txtBoxStudentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            StaticFunctionsEvents.KeyCharLetters(e);
        }

        private void txtBoxStudentDepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            StaticFunctionsEvents.KeyCharLetters(e);
        }
    }
}
