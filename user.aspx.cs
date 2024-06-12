using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;

namespace _43938442_Exam_WebApp
{
    public partial class user : System.Web.UI.Page
    {
        SqlConnection con;
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\Patient.mdf';Integrated Security=True"; // global

        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet dataset;
        string password = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateFromCookies();
                loadAllAppt();
                loadAllPatient();
            }
            
            HttpCookie userRetrieve = Request.Cookies["UserInfo"];

            if (userRetrieve != null)
            {
                lblWelcome.Text = "Welcome, " + userRetrieve["FirstName"] + " " + userRetrieve["LastName"] + "!";
                lblShow.Text = "View your upcoming appointments:";

                con = new SqlConnection(conString);

                try
                {
                    con.Open();

                    DateTime date = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);

                    string sql = "SELECT ID, Doctor, Date, Time, AppointmentType, Status, Amount FROM Patients WHERE Date>=@date AND FirstName=@FirstName AND LastName=@LastName ORDER BY Date, Time";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@FirstName", userRetrieve["FirstName"]);
                    cmd.Parameters.AddWithValue("@LastName", userRetrieve["LastName"]);

                    adapter = new SqlDataAdapter();
                    dataset = new DataSet();

                    adapter.SelectCommand = cmd;
                    adapter.Fill(dataset);

                    if (dataset.Tables[0].Rows.Count > 0)
                    {
                        GridView1.DataSource = dataset;
                        GridView1.DataBind();
                    }
                    else
                    {
                        lblShow.Text = "No upcoming appointments found.";
                        GridView1.DataSource = null;
                        GridView1.DataBind();
                    }

                    con.Close();

                    loadAllAppt();
                }
                catch (SqlException ex)
                {
                    throw;
                }

                using (SqlConnection con = new SqlConnection(conString))
                {
                    try
                    {
                        con.Open();

                        string query = "SELECT DISTINCT FirstName, LastName, Cell, Email, EmergencyContact, Allergies, Password FROM Patients WHERE FirstName=@FirstName AND LastName=@LastName";
                        cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@FirstName", userRetrieve["FirstName"]);
                        cmd.Parameters.AddWithValue("@LastName", userRetrieve["LastName"]);

                        adapter = new SqlDataAdapter();
                        dataset = new DataSet();

                        adapter.SelectCommand = cmd;
                        adapter.Fill(dataset);

                        GridView2.DataSource = dataset;
                        GridView2.DataBind();

                        con.Close();

                        loadAllPatient();
                    }
                    catch (SqlException ex)
                    {
                        throw;
                    }
                }
            }
        }

        private void PopulateFromCookies()
        {
            HttpCookie userRetrieve = Request.Cookies["UserInfo"];

            if (userRetrieve != null)
            {
                TextBoxName.Text = userRetrieve["FirstName"];
                TextBoxSurname.Text = userRetrieve["LastName"];
                TextBoxCell.Text = userRetrieve["Cell"];
                TextBoxEmail.Text = userRetrieve["Email"];
                TextBoxEmCell.Text = userRetrieve["EmergencyContact"];
                TextBoxAllergies.Text = userRetrieve["Allergies"];
            }
            else
            {
                lblError.Text = "Error retrieving your information. Please log in.";
            }
            if (userRetrieve == null)
            {
                lblError.Text = "User information not found. Please log in.";
                return;
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            HttpCookie userRetrieve = Request.Cookies["UserInfo"];

            if (userRetrieve != null)
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    try
                    {
                        con.Open();

                        string edit = "UPDATE Patients SET FirstName=@new_name, LastName=@new_surname, Cell=@new_cell, Email=@new_email, EmergencyContact=@new_emergency, Allergies=@new_allergies WHERE FirstName=@name AND LastName=@surname";
                        cmd = new SqlCommand(edit, con);
                        cmd.Parameters.AddWithValue("@new_name", TextBoxName.Text);
                        cmd.Parameters.AddWithValue("@new_surname", TextBoxSurname.Text);
                        cmd.Parameters.AddWithValue("@new_cell", TextBoxCell.Text);
                        cmd.Parameters.AddWithValue("@new_email", TextBoxEmail.Text);
                        cmd.Parameters.AddWithValue("@new_emergency", TextBoxEmCell.Text);
                        cmd.Parameters.AddWithValue("@new_allergies", TextBoxAllergies.Text);
                        cmd.Parameters.AddWithValue("@name", userRetrieve["FirstName"]);
                        cmd.Parameters.AddWithValue("@surname", userRetrieve["LastName"]);

                        adapter = new SqlDataAdapter();
                        adapter.UpdateCommand = cmd;
                        adapter.UpdateCommand.ExecuteNonQuery();

                        con.Close();

                        string selectQuery = "SELECT FirstName, LastName, Cell, Email, EmergencyContact, Allergies FROM Patients WHERE FirstName=@name AND LastName=@surname";
                        SqlCommand selectCmd = new SqlCommand(selectQuery, con);

                        selectCmd.Parameters.AddWithValue("@name", TextBoxName.Text);
                        selectCmd.Parameters.AddWithValue("@surname", TextBoxSurname.Text);

                        con.Open();
                        SqlDataReader reader = selectCmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // Populate the TextBox fields with the updated data
                            TextBoxName.Text = reader["FirstName"].ToString();
                            TextBoxSurname.Text = reader["LastName"].ToString();
                            TextBoxCell.Text = reader["Cell"].ToString();
                            TextBoxEmail.Text = reader["Email"].ToString();
                            TextBoxEmCell.Text = reader["EmergencyContact"].ToString();
                            TextBoxAllergies.Text = reader["Allergies"].ToString();
                        }

                        reader.Close();
                        con.Close();

                        loadAllPatient();
                        lblChanged.Text = "Patient details successfully updated.";
                    }
                    catch (SqlException ex)
                    {
                        lblChanged.Text = ex.Message;
                    }
                }
                if (userRetrieve == null)
                {
                    lblChanged.Text = "No patient selected, please select a patient.";
                }
            }
                    
        }

        protected void ChangePasswordPushButton_Click(object sender, EventArgs e)
        {
            HttpCookie userRetrieve = Request.Cookies["UserInfo"];

            if (userRetrieve != null)
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    try
                    {
                        con.Open();

                        string change = "UPDATE Patients SET Password=@newPassword WHERE FirstName=@name AND LastName=@surname";
                        cmd = new SqlCommand(change, con);
                        cmd.Parameters.AddWithValue("@name", userRetrieve["FirstName"]);
                        cmd.Parameters.AddWithValue("@surname", userRetrieve["LastName"]);
                        cmd.Parameters.AddWithValue("@newPassword", ChangePassword1.ConfirmNewPassword);
                        userRetrieve["Password"] = ChangePassword1.CurrentPassword;

                        adapter.UpdateCommand = cmd;
                        adapter.UpdateCommand.ExecuteNonQuery();

                        con.Close();

                        loadAllPatient();
                        lblPasswordChange.Text = "New password created successfully. Database updated.";
                    }
                    catch (SqlException ex)
                    {
                        lblPasswordChange.Text = ex.Message;
                    }
                }
            }
        }

        private void loadAllAppt()
        {
            HttpCookie userRetrieve = Request.Cookies["UserInfo"];

            if (userRetrieve != null) 
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    try
                    {
                        con.Open();

                        DateTime date = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);

                        string sql = "SELECT ID, Doctor, Date, Time, AppointmentType, Status, Amount FROM Patients WHERE Date>=@date AND FirstName=@FirstName AND LastName=@LastName ORDER BY Date, Time";
                        cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@FirstName", userRetrieve["FirstName"]);
                        cmd.Parameters.AddWithValue("@LastName", userRetrieve["LastName"]);

                        adapter = new SqlDataAdapter();
                        dataset = new DataSet();

                        adapter.SelectCommand = cmd;
                        adapter.Fill(dataset);

                        if (dataset.Tables[0].Rows.Count > 0)
                        {
                            GridView1.DataSource = dataset;
                            GridView1.DataBind();
                        }
                        else
                        {
                            lblShow.Text = "No upcoming appointments found.";
                            GridView1.DataSource = null;
                            GridView1.DataBind();
                        }

                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        throw;
                    }
                }
            }
            
        }

        private void loadAllPatient()
        {
            HttpCookie userRetrieve = Request.Cookies["UserInfo"];

            if (userRetrieve != null)
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    try
                    {
                        con.Open();

                        string query = "SELECT DISTINCT FirstName, LastName, Cell, Email, EmergencyContact, Allergies, Password FROM Patients WHERE FirstName=@FirstName AND LastName=@LastName";
                        cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@FirstName", userRetrieve["FirstName"]);
                        cmd.Parameters.AddWithValue("@LastName", userRetrieve["LastName"]);

                        adapter = new SqlDataAdapter();
                        dataset = new DataSet();

                        adapter.SelectCommand = cmd;
                        adapter.Fill(dataset);

                        GridView2.DataSource = dataset;
                        GridView2.DataBind();

                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        throw;
                    }
                }
            }
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            HttpCookie userRetrieve = Request.Cookies["UserInfo"];
            userRetrieve.Expires = DateTime.Now;

            Response.Redirect("default.aspx");
        }
    }
 }