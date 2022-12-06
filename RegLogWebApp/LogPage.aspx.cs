using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace RegLogWebApp
{
    public partial class LogPage : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(DataSource.DS);
        SqlCommand cmd;
        DataTable DT = new DataTable();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                lblShow.Text = "Please Fill ALL fields!";
                lblShow.ForeColor = Color.Red;
            }
            else
            {
                conn.Open();
                string SqlQuery = "Select COUNT(1) from Table2 where Username=@username and Password=@password";
                SqlCommand cmd = new SqlCommand(SqlQuery, conn);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 1)
                {
                    Session["username"] = txtUsername.Text;
                    Response.Redirect("Welcome.aspx");
                }
                else
                {
                    lblShow.Text = "There is no user such";
                }
            }
        }
    }
}