using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _43938442_ExamProject
{
    public partial class frmAdminLogin : Form
    {
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // close this form and go back to main form
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // show frmAdmin if username AND password fields are correct
            if (txtUsername.Text == "Brighton_Admin" && txtPassword.Text == "!@iLm3Nt$")
            {
                frmAdmin frmAdmin = new frmAdmin();
                frmAdmin.ShowDialog();
            }            
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text == "") // if username field is left blank
            {
                errorProvider1.Icon = SystemIcons.Warning;
                errorProvider1.SetError(txtUsername, "Required field. Please enter the username.");
            }
            else if (txtUsername.Text != "Brighton_Admin") // if username is incorrect
            {
                errorProvider1.Clear();
                errorProvider2.Icon = SystemIcons.Error;
                errorProvider2.SetError(txtUsername, "Incorrect username.");
            }
            // otherwise, if username field is not blank and is correct
            else if (txtUsername.Text != "" && txtUsername.Text == "Brighton_Admin")
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "") // if password field is left blank
            {
                errorProvider1.Icon = SystemIcons.Warning;
                errorProvider1.SetError(txtPassword, "Required field. Please enter the password.");
            }
            else if (txtPassword.Text != "!@iLm3Nt$") // if password is incorrect
            {
                errorProvider1.Clear();
                errorProvider2.Icon = SystemIcons.Error;
                errorProvider2.SetError(txtPassword, "Incorrect password.");
            }
            // otherwise, if password field is not blank and is correct
            else if (txtPassword.Text != "" && txtPassword.Text == "!@iLm3Nt$")
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
            }
        }
    }
}
