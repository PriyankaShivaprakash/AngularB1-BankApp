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
    public partial class WebForm12 : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["Database Connection"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            //if(!IsPostBack)
            //{
            //    SqlConnection con = new SqlConnection(cs);
            //    con.Open();
            //    string str = "select ResortID,ResortName from ResortDetails";
            //    SqlCommand cmd = new SqlCommand(str, con);
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    ddlResort.DataSource = dr;
            //    ddlResort.DataTextField = "ResortName";
            //    ddlResort.DataValueField = "ResortID";
            //    ddlResort.DataBind();
            //    con.Close();
            //}
        }

        protected void bttnInsert_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Space_Details values('" + txtNumberofslot.Text + "','" + txtParkingarea.Text + "','" + txtlandownerid.Text +"','" + ddltParkingmode.SelectedItem.Text +"')", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {

            }    
        }
    }
}