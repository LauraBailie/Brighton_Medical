using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _43938442_ExamProject
{
    public partial class frmPatients : Form
    {
        // Relative path for Patient DB
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\Patient.mdf';Integrated Security=True"; // global connection

        SqlConnection con; 
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        string app_type = "";
        string doctor = "";
        string status = "";
        int amount = 0;

        public frmPatients()
        {
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            // if field is blank, display an errorProvider message
            if (txtEmail.Text == " ")
            {
                errorProvider1.Icon = SystemIcons.Warning;
                errorProvider1.SetError(txtEmail, "Enter an email address.");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(conString);

            try
            {
                con.Open();

                string date = monthCalendar1.SelectionRange.Start.ToString("yyyy/MM/dd");
                string time = dateTimePicker1.Value.ToString("HH:mm:ss");

                // add a patient to the DB
                string sql = $"INSERT INTO Patients (FirstName, LastName, Cell, Email, Allergies, EmergencyContact, Password) VALUES (@name, @surname, @cell, @email, @allergies, @emergency, @password)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@surname", txtSurname.Text);
                cmd.Parameters.AddWithValue("@cell", txtCell.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@allergies", txtAllergies.Text);
                cmd.Parameters.AddWithValue("@emergency", txtEmergency.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text); // parametised values

                da = new SqlDataAdapter();
                ds = new DataSet();

                da.InsertCommand = cmd;
                da.InsertCommand.ExecuteNonQuery();

                MessageBox.Show("Patient added successfully.");

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message); // catch and display error
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(conString);

            try
            {
                con.Open();

                string date = monthCalendar1.SelectionRange.Start.ToString("yyyy/MM/dd");
                string time = dateTimePicker1.Value.ToString("HH:mm:ss");

                // update a record in the DB
                string sql = "UPDATE Patients SET Password=@password WHERE ID=@id";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                da = new SqlDataAdapter();
                ds = new DataSet();

                da.UpdateCommand = cmd;
                da.UpdateCommand.ExecuteNonQuery();

                MessageBox.Show("Patient details updated successfully.");

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message); // catch and display error
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(conString);

            try
            {
                con.Open();

                string date = monthCalendar1.SelectionRange.Start.ToString("yyyy/MM/dd");
                string time = dateTimePicker1.Value.ToString("HH:mm:ss");

                // delete a record from the DB
                string sql = "DELETE FROM Patients WHERE ID=@id";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", txtID.Text);

                da = new SqlDataAdapter();
                ds = new DataSet();

                da.DeleteCommand = cmd;
                da.DeleteCommand.ExecuteNonQuery();

                MessageBox.Show("Patient record deleted successfully.");

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message); // catch and display error
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close(); // close form
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            // if field is blank, display an errorProvider message
            if (txtName.Text == " ") 
            {
                errorProvider1.Icon = SystemIcons.Warning;
                errorProvider1.SetError(txtName, "Enter a name.");
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            // if field is blank, display an errorProvider message
            if (txtSurname.Text == " ")
            {
                errorProvider1.Icon = SystemIcons.Warning;
                errorProvider1.SetError(txtSurname, "Enter a surname.");
            }
        }

        private void txtCell_TextChanged(object sender, EventArgs e)
        {
            // if field is blank, display an errorProvider message
            if (txtCell.Text == " ")
            {
                errorProvider1.Icon = SystemIcons.Warning;
                errorProvider1.SetError(txtCell, "Enter a cellphone number.");
            }

            // if cell number is less than 10 numbers, display an errorProvider message
            if (txtCell.Text.Length < 10)
            {
                errorProvider2.Icon = SystemIcons.Error;
                errorProvider2.SetError(txtCell, "Cell number must be 10 digits long.");
            }
            else
            {
                errorProvider2.Clear();
            }
            
        }

        private void txtEmergency_TextChanged(object sender, EventArgs e)
        {
            // if field is blank, display an errorProvider message
            if (txtEmergency.Text == " ")
            {
                errorProvider1.Icon = SystemIcons.Warning;
                errorProvider1.SetError(txtEmergency, "Enter an emergency contact number.");
            }
        }

        private void txtAllergies_TextChanged(object sender, EventArgs e)
        {
            // if field is blank, display an errorProvider message
            if (txtAllergies.Text == " ")
            {
                errorProvider1.Icon = SystemIcons.Warning;
                errorProvider1.SetError(txtAllergies, "Enter an allergy. If not applicable, put 'None'.");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // if field is blank, display an errorProvider message
            if (txtPassword.Text == " ")
            {
                errorProvider1.Icon = SystemIcons.Warning;
                errorProvider1.SetError(txtPassword, "Enter a password.");
            }
        }
    }
}
