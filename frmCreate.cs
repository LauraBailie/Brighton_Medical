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

namespace _43938442_ExamProject
{
    public partial class frmAppointment : Form
    {
        SqlConnection cnn;
        string cnnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename = '|DataDirectory|\Schedule.mdf';Integrated Security=True"; // global connection
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        string doctor = "";
        string app_type = "";
        string status = "";

        public frmAppointment()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // close form
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(cnnString);

            try
            {
                cnn.Open();

                string date = monthCalendar1.SelectionRange.Start.ToString("yyyy/MM/dd");
                string time = dateTimePicker1.Value.ToString("HH:mm:ss");

                string sql = $"INSERT INTO Schedule (FirstName, LastName, Doctor, Date, Time, AppointmentType, Status) VALUES (@name, @surname, @doctor, @date, @time, @app_type, @status)";
                cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@surname", txtSurname.Text);
                cmd.Parameters.AddWithValue("@doctor", doctor);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@time", time);
                cmd.Parameters.AddWithValue("@app_type", app_type);
                cmd.Parameters.AddWithValue("@status", status);

                da = new SqlDataAdapter();
                ds = new DataSet();

                da.InsertCommand = cmd;
                da.InsertCommand.ExecuteNonQuery();

                MessageBox.Show("Record inserted successfully.");

                cnn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message); // catch and display error
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(cnnString);

            try // update Schedule
            {
                cnn.Open();

                string date = monthCalendar1.SelectionRange.Start.ToString("yyyy/MM/dd");
                string time = dateTimePicker1.Value.ToString("HH:mm:ss");

                string sql = "UPDATE Schedule SET Date=@date, Time=@time, Status=@status WHERE Id=@id";
                cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@time", time);
                cmd.Parameters.AddWithValue("@status", status);

                da = new SqlDataAdapter();
                ds = new DataSet();

                da.UpdateCommand = cmd;
                da.UpdateCommand.ExecuteNonQuery();

                MessageBox.Show("Record updated successfully."); 

                cnn.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message); // catch and display error
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(cnnString);

            try // delete from Schedule
            {
                cnn.Open();

                string date = monthCalendar1.SelectionRange.Start.ToString("yyyy/MM/dd");
                string time = dateTimePicker1.Value.ToString("HH:mm:ss");

                string sql = "DELETE FROM Schedule WHERE Id = @id";
                cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@id", txtID.Text);

                da = new SqlDataAdapter();
                ds = new DataSet();

                da.DeleteCommand = cmd;
                da.DeleteCommand.ExecuteNonQuery();

                MessageBox.Show("Record deleted successfully.");

                cnn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message); // catch and display error
            }
        }

        // Populate DB variables according to the selected value item of the radio buttons
        private void rbVanZyl_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVanZyl.Checked == true)
            {
                doctor = "Dr A.H. van Zyl";
            }
        }

        private void rbHendricks_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHendricks.Checked == true)
            {
                doctor = "Dr C. Hendricks";
            }
        }

        private void rbSurgical_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSurgical.Checked == true)
            {
                app_type = "Surgical";
            }
        }

        private void rbLab_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLab.Checked == true)
            {
                app_type = "Lab analysis";
            }
        }

        private void rbRoutine_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRoutine.Checked == true)
            {
                app_type = "Routine check-up";
            }
        }

        private void rbUrgent_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUrgent.Checked == true)
            {
                app_type = "Urgent check-up";
            }
        }

        private void rbComplete_CheckedChanged(object sender, EventArgs e)
        {
            if (rbComplete.Checked == true)
            {
                status = "Complete";
            }
        }

        private void rbPending_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPending.Checked == true)
            {
                status = "Pending";
            }
        }

        private void rbCancelled_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCancelled.Checked == true)
            {
                status = "Cancelled";
            }
        }
    }
}
