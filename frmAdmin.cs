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
using System.Linq.Expressions;

namespace _43938442_ExamProject
{
    public partial class frmAdmin : Form
    {
        // Relative paths for the DBs have been created below:

        SqlConnection con; // global connection for Patient DB
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename = '|DataDirectory|\Patient.mdf'; Integrated Security=True";

        SqlConnection cnn; // global connection for Schedule DB
        string cnnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename = '|DataDirectory|\Schedule.mdf'; Integrated Security=True";

        // command, adapter and dataset for Patients DB
        SqlCommand cmd; // sql command
        SqlDataAdapter da; // sql data adapter
        DataSet ds; // dataset

        // command, adapter and dataset for Schedule DB
        SqlCommand com;
        DataSet dataset;
        SqlDataAdapter adapter;

        string sql = ""; // empty here but changes depending on button clicked

        public frmAdmin()
        {
            InitializeComponent();
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            loadAll(dateTimePicker1.Value);
        }

        private void loadAll(DateTime selectedDate) 
        {
            con = new SqlConnection(conString);
            // display Patients gridview
            try
            {
                con.Open();

                sql = "SELECT * FROM Patients";
                cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter();
                ds = new DataSet();

                da.SelectCommand = cmd;
                da.Fill(ds, "Patients");

                dataGridView2.DataSource = ds;
                dataGridView2.DataMember = "Patients";

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message); // catch and display error
            }

            cnn = new SqlConnection(cnnString);
            // display appointments for the day
            try
            {
                cnn.Open();

                //string date = dateTimePicker1.Value.ToString("yyyy/MM/dd");

                // display only patient first and last name + appointment details
                sql = "SELECT Id, FirstName, LastName, Date, Time, Doctor, AppointmentType, Status FROM Schedule WHERE Date = @date ORDER BY Time ASC";
                com = new SqlCommand(sql, cnn);
                com.Parameters.AddWithValue("@date", selectedDate.Date);

                adapter = new SqlDataAdapter();
                dataset = new DataSet();

                adapter.SelectCommand = com;
                adapter.Fill(dataset, "Schedule");

                dataGridView3.DataSource = dataset;
                dataGridView3.DataMember = "Schedule";

                cnn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message); // catch and display error
            }

        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scheduleDataSet.Schedule' table. You can move, or remove it, as needed.
            this.scheduleTableAdapter.Fill(this.scheduleDataSet.Schedule);
            // TODO: This line of code loads data into the 'patientDataSet3.Patients' table. You can move, or remove it, as needed.
            //this.patientsTableAdapter.Fill(this.patientDataSet3.Patients);

            con = new SqlConnection(conString);
            // display Patients gridview
            try
            {
                con.Open();

                sql = "SELECT * FROM Patients";
                cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter();
                ds = new DataSet();
                
                da.SelectCommand = cmd;
                da.Fill(ds, "Patients");

                dataGridView2.DataSource = ds;
                dataGridView2.DataMember = "Patients";

                con.Close();

                loadAll(dateTimePicker1.Value);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            cnn = new SqlConnection(cnnString);
            try // display schedule gridview
            {
                cnn.Open();

                string date = dateTimePicker1.Value.ToString("yyyy/MM/dd");

                // display daily schedule according to the value in the dateTimePicker and order appointments by time value in ascending order
                sql = "SELECT DISTINCT Id, FirstName, LastName, Doctor, Date, Time, AppointmentType, Status FROM Schedule WHERE Date = '"+date+"' ORDER BY Time ASC";
                com = new SqlCommand(sql, cnn);
                adapter = new SqlDataAdapter(); 
                dataset = new DataSet();

                if (dataGridView3.Columns["Id"] != null)
                {
                    dataGridView3.Columns["Id"].Visible = true; // make sure ID column is visible in dataGridView
                }

                adapter.SelectCommand = com;
                adapter.Fill(dataset, "Schedule");

                dataGridView3.DataSource = dataset;
                dataGridView3.DataMember = "Schedule";

                cnn.Close();

                loadAll(dateTimePicker1.Value);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Show new form (frmAppointment)
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAppointment create = new frmAppointment();
            create.ShowDialog();
        }

        private void linkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAppointment edit = new frmAppointment();
            edit.ShowDialog();
        }

        private void linkCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAppointment cancel = new frmAppointment();
            cancel.ShowDialog();
        }

        // Show new form (frmPatients)
        private void linkNewPt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPatients create = new frmPatients();
            create.ShowDialog();
        }

        private void linkEditPt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPatients edit = new frmPatients();
            edit.ShowDialog();
        }

        private void linkDeletePt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPatients remove = new frmPatients();
            remove.ShowDialog();
        }

        // Show new form (frmInvoices)
        private void linkNewInvoice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInvoices create = new frmInvoices();
            create.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            loadAll(dateTimePicker1.Value); // load time
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close(); // close form
        }
    }
}
