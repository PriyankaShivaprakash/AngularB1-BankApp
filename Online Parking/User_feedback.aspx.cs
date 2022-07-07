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
    public partial class WebForm13 : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["Database Connection"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string str = "select spaceid,parking_area from Space_Details";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataReader dr = cmd.ExecuteReader();
                ddltSelectspace.DataSource = dr;
                ddltSelectspace.DataTextField = "parking_area";
                ddltSelectspace.DataValueField = "spaceid";
                ddltSelectspace.DataBind();
                con.Close();
            }
        }

        protected void bttnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Feedback values('" + txtFeedback.Text + "','" + txtUserid.Text + "','" + ddltSelectspace.SelectedItem.Value + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {

            }    
        }
    }
}