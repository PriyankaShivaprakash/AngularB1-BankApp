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
    public partial class WebForm6 : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["Database Connection"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bttnSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into LandOwner_Details values('" + txtPassword.Text + "','" + txtFirstname.Text + "','" + txtLastname.Text + "','" + txtAddress.Text + "','" + txtAadhar.Text + "','" + txtPhone.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {

            }    

        }

        protected void bttnReset_Click(object sender, EventArgs e)
        {
            txtFirstname.Text = " ";
            txtLastname.Text = " ";
            txtAddress.Text = " ";
            txtAadhar.Text = " ";
            txtPhone.Text = " ";
        }
    }
}