using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Services.Description;
using System.Drawing;

namespace RegLogWebApp
{
    public partial class RegPage : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(DataSource.DS);
        SqlCommand cmd;
        DataTable DT = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtEmail.Text == "" || txtUsername.Text == "")
            {
                lblShow.Text = "Please Fill All Fields!!!";
                lblShow.ForeColor = Color.Red;
            }
            else
            {
                conn.Open();
                string sqlQuery =
                    "declare @check int; execute Regweb1 @check output, @Username, @Email, @Password; SELECT @check";

                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("Password", txtPassword.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                int x = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                if (x == 1)
                {
                    lblShow.Text = "This user exist";
                    lblShow.ForeColor = Color.Red;
                }
                else
                {
                    lblShow.Text = "Successfully inserted";
                    lblShow.ForeColor = Color.Green;
                    ClearMethod();
                }

                conn.Close();
            }


        }
        private void ClearMethod()
        {
            txtUsername.Text = txtEmail.Text = txtPassword.Text = "";
        }
    }

}