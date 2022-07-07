using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace Online_Parking
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["Database Connection"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            txtUsername.Text = " ";
            txtFirstname.Text = " ";
            txtLastname.Text = " ";
            txtAddress.Text = " ";
            txtAadhar.Text = " ";
            txtLicense.Text = " ";
            txtPhone.Text = " ";
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into User_Details values('" + txtUsername.Text +"','" + txtPassword.Text +"','" + txtFirstname.Text +"','" + txtLastname.Text +"','" + txtAddress.Text + "','" + txtAadhar.Text +"','" + txtLicense.Text + "','" + txtPhone.Text +"')", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {

            }    
        }

        protected void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}