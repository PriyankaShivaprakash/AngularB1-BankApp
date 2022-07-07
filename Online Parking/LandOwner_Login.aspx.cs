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
    public partial class WebForm3 : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["database connection"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select count(*) from LandOwner_Details where landownerid=" + txtLandownerid.Text + "and password='" + txtPassword.Text + "'", con);
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                if (i > 0)
                {

                    Response.Redirect("homelandowner.aspx");
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "successfull", "alert('login failed')", true);
                }

            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        protected void txtLandownerid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}