using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _43938442_ExamProject
{
    public partial class frmInvoices : Form
    {
        // Relative path for Schedule DB
        string cnnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\Schedule.mdf';Integrated Security=True"; // global connection

        SqlConnection cnn; 
        SqlCommand cmd;
        SqlDataReader reader;

        // global variables to be populated upon button event handlers
        string doctor = "";
        string app_type = "";
        string status = "";
        int amount = 0;

        public frmInvoices()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // close form
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(cnnString);

            try
            {
                cnn.Open();

                string sql = "SELECT * FROM Schedule WHERE Id=@id";
                cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@id", txtID.Text);

                reader = cmd.ExecuteReader();

                // Read in values to be displayed in listBox
                while (reader.Read())
                {
                    lstInvoice.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t" + reader.GetValue(2) + "\t" + reader.GetValue(3) + "\t" + reader.GetValue(4) + "\t" + reader.GetValue(5) + "\t" + reader.GetValue(6) + "\t" + reader.GetValue(7) + "\t" + reader.GetValue(8));
                }

                cnn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message); // catch and display error
            }
        }

        // For all event handlers below, the global variables will be populated
        // according to the radio button value

        private void rbVanZyl_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbVanZyl.Checked == true)
            {
                doctor = "Dr A.H. van Zyl";
            }
        }

        private void rbHendricks_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbHendricks.Checked == true)
            {
                doctor = "Dr C. Hendricks";
            }
        }

        private void rbSurgical_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbSurgical.Checked == true)
            {
                app_type = "Surgical";
                amount = 1500;
            }
        }

        private void rbLab_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbLab.Checked == true)
            {
                app_type = "Lab analysis";
                amount = 360;
            }
        }

        private void rbRoutine_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbRoutine.Checked == true)
            {
                app_type = "Routine check-up";
                amount = 500;
            }
        }

        private void rbUrgent_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbUrgent.Checked == true)
            {
                app_type = "Urgent check-up";
                amount = 2000;
            }
        }

        private void rbComplete_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbComplete.Checked == true)
            {
                status = "Complete";
            }
        }

        private void rbPending_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbPending.Checked == true)
            {
                status = "Pending";
            }
        }

        private void rbCancelled_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbCancelled.Checked == true)
            {
                status = "Cancelled";
            }
        }
    }
}
