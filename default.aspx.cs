using _43938442_ExamProject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace _43938442_Exam_WebApp
{
    public partial class _default : System.Web.UI.Page
    {
        SqlConnection con; 
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\Patient.mdf';Integrated Security=True"; // global connection
        SqlCommand cmd;
        SqlDataReader reader;

        string email = "";
        string password = "";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private static bool CheckUserExists(string conString, string email, string password)
        {
            string sql = "SELECT COUNT(*) FROM Patients WHERE Email=@email AND Password=@password";

            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                try
                {
                    con.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
                catch (SqlException ex)
                {
                    return false;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            email = Login1.UserName;
            password = Login1.Password;

            con = new SqlConnection(conString);
            string query = "SELECT * FROM Patients WHERE Email=@email AND Password=@password";

            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    try
                    {
                        con.Open();
                        using (reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string name = reader["FirstName"].ToString();
                                string surname = reader["LastName"].ToString();
                                string cell = reader["Cell"].ToString();
                                string email = reader["Email"].ToString();
                                string allergies = reader["Allergies"].ToString();
                                string emContact = reader["EmergencyContact"].ToString();
                                string password = reader["Password"].ToString();
                                string doctor = reader["Doctor"].ToString();
                                DateTime date = Convert.ToDateTime(reader["Date"]);
                                TimeSpan time = (TimeSpan)reader["Time"];
                                string app_type = reader["AppointmentType"].ToString();
                                string status = reader["Status"].ToString();
                                int amount = Convert.ToInt32(reader["Amount"]);


                                bool ptExists = CheckUserExists(conString, email, password);

                                if (ptExists)
                                {
                                    HttpCookie userInfo = new HttpCookie("UserInfo");
                                    userInfo["FirstName"] = name;
                                    userInfo["LastName"] = surname;
                                    userInfo["Cell"] = cell;
                                    userInfo["Email"] = email;
                                    userInfo["Allergies"] = allergies;
                                    userInfo["EmergencyContact"] = emContact;
                                    userInfo["Password"] = password;
                                    userInfo["Doctor"] = doctor;
                                    userInfo["Date"] = date.ToString();
                                    userInfo["Time"] = time.ToString();
                                    userInfo["AppointmentType"] = app_type;
                                    userInfo["Status"] = status;
                                    userInfo["Amount"] = amount.ToString();

                                    Response.Cookies.Add(userInfo);
                                    userInfo.Expires = DateTime.Now.AddDays(5);

                                    Response.Redirect("user.aspx");
                                }
                                else
                                {
                                    Label3.Text = "This user is not registered in the database. Please consult administration to allow you to log in.";
                                }
                            }
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

        protected void UserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}