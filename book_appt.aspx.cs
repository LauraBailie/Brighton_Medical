using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace _43938442_Exam_WebApp
{
    public partial class book_appt : System.Web.UI.Page
    {
        SqlConnection con;
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\Patient.mdf';Integrated Security=True"; // global

        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet dataset;

        string app_type = "";
        string doctor = "";
        string status = "";
        int amount = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedIndex == 0)
            {
                doctor = "Dr A.H. van Zyl";
            }
            else if (RadioButtonList1.SelectedIndex == 1)
            {
                doctor = "Dr C. Hendricks";
            }
            else if (RadioButtonList1.SelectedIndex == -1)
            {
                ListBox2.Items.Add("Please select a doctor.");
            }
        }

        protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList2.SelectedIndex == 0)
            {
                app_type = "Surgical";
                amount = 1500;
                status = "Pending";
            }
            else if (RadioButtonList2.SelectedIndex == 1)
            {
                app_type = "Lab analysis";
                amount = 360;
                status = "Pending";
            }
            else if (RadioButtonList2.SelectedIndex == 2)
            {
                app_type = "Routine check-up";
                amount = 500;
                status = "Pending";
            }
            else if (RadioButtonList2.SelectedIndex == 3)
            {
                app_type = "Urgent check-up";
                amount = 2000;
                status = "Pending";
            }
            else if (RadioButtonList2.SelectedIndex == -1)
            {
                ListBox2.Items.Add("Please select an appointment type.");
            }
        }

        protected void btnBook_Click(object sender, EventArgs e)
        {
            HttpCookie userRetrieve = Request.Cookies["UserInfo"];

            if (userRetrieve != null)
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    try
                    {
                        con.Open();

                        ListBox2.Items.Clear();
                        DateTime date = Calendar1.SelectedDate;
                        string timeString = DropDownList1.SelectedItem.Text;
                        DateTime time = DateTime.Parse(timeString);

                        string sql = $"INSERT INTO Patients (Doctor, Date, Time, AppointmentType, Status, Amount, FirstName, LastName, Cell, Email, EmergencyContact, Allergies, Password) VALUES (@doctor, @date, @time, @app_type, @status, @amount, @Firstname, @LastName, @cell, @email, @emergency, @allergies, @password) SELECT SCOPE_IDENTITY()";
                        cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@doctor", doctor);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@time", time);
                        cmd.Parameters.AddWithValue("@app_type", app_type);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@amount", amount);
                        cmd.Parameters.AddWithValue("@FirstName", userRetrieve["FirstName"]);
                        cmd.Parameters.AddWithValue("@LastName", userRetrieve["LastName"]);
                        cmd.Parameters.AddWithValue("@cell", userRetrieve["Cell"]);
                        cmd.Parameters.AddWithValue("@email", userRetrieve["Email"]);
                        cmd.Parameters.AddWithValue("@emergency", userRetrieve["EmergencyContact"]);
                        cmd.Parameters.AddWithValue("@allergies", userRetrieve["Allergies"]);
                        cmd.Parameters.AddWithValue("@password", userRetrieve["Password"]);

                        object result = cmd.ExecuteScalar();
                        int id = Convert.ToInt32(result);

                        if (id > 0)
                        {
                            ListBox2.Items.Add("Appointment successfully created for " + userRetrieve["FirstName"] + " " + userRetrieve["LastName"] + ".");
                            ListBox2.Items.Add($"ID: {id.ToString()}");
                            ListBox2.Items.Add($"Date: {date.ToShortDateString()}");
                            ListBox2.Items.Add($"Time: {timeString}");
                            ListBox2.Items.Add($"Appointment Type: {app_type}");
                            ListBox2.Items.Add($"Amount: {amount.ToString()}");
                            ListBox2.Items.Add($"Doctor: {doctor}");
                            ListBox2.Items.Add($"Status: {status}");
                        }
                        else
                        {
                            ListBox2.Items.Add("Failed to create the appointment. Please try again.");
                        } 

                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        ListBox2.Items.Add(ex.Message);
                    }
                }
            }
            else
            {
                ListBox2.Items.Add("Please log in to book an appointment.");
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

                        ListBox2.Items.Clear();
                        DateTime date = Calendar1.SelectedDate;
                        string timeString = DropDownList1.SelectedItem.Text;
                        DateTime time = DateTime.Parse(timeString);
                        int id = int.Parse(TextBoxID.Text);

                        string sql = "UPDATE Patients SET Date=@date, Time=@time WHERE ID=@id";
                        cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@time", time);

                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            ListBox2.Items.Add("Appointment successfully updated.");
                            ListBox2.Items.Add($"Date: {date.ToShortDateString()}");
                            ListBox2.Items.Add($"Time: {timeString}");
                        }
                        else
                        {
                            ListBox2.Items.Add("Failed to update the appointment. Please try again.");
                        }

                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        ListBox2.Items.Add(ex.Message);
                    }
                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            HttpCookie userRetrieve = Request.Cookies["UserInfo"];

            if (userRetrieve != null)
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    try
                    {
                        con.Open();

                        ListBox2.Items.Clear();
                        DateTime date = Calendar1.SelectedDate;
                        string timeString = DropDownList1.SelectedItem.Text;
                        DateTime time = DateTime.Parse(timeString);
                        int id = int.Parse(TextBoxID.Text);

                        string sql = "DELETE FROM Patients WHERE ID=@id";
                        cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@id", id);

                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            ListBox2.Items.Add("Appointment successfully cancelled.");
                        }
                        else
                        {
                            ListBox2.Items.Add("Failed to cancel the appointment. Please try again.");
                        }

                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        ListBox2.Items.Add(ex.Message);
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