using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class StartingForm : Form
    {
        public StartingForm()
        {
            InitializeComponent();
        }

        private void picBoxUnShow_Click(object sender, EventArgs e)
        {
            string imagePath = "";
            if (txtBoxPassword.PasswordChar == '*')
            {
                txtBoxPassword.PasswordChar = '\0';
                imagePath = "assets\\unshow-icon.png";
                picBoxUnShow.Image = Image.FromFile(imagePath);
            }
            else
            {
                txtBoxPassword.PasswordChar = '*';
                imagePath = "assets\\show-icon.png";
                picBoxUnShow.Image = Image.FromFile(imagePath);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBoxPassword.Clear();
            txtBoxUsername.Clear();
        }

        private void picBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picBoxMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtBoxUsername.Text) 
                || string.IsNullOrWhiteSpace(txtBoxPassword.Text)) 
            {
                MessageBox.Show("Do not enter empty credentials",
                                "Error: Null Value",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                if (txtBoxUsername.Text == "admin" && txtBoxPassword.Text == "admin")
                {
                    MessageBox.Show("Log In Successfully. Press OK to enter the Main Menu",
                                    "Success!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    MainMenuForm mainMenuForm = new MainMenuForm();
                    mainMenuForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong username or password. Please try again.",
                                    "Warning: Wrong Username/Password",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
        }
    }
}
