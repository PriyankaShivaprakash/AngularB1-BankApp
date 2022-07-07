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
    public partial class WebForm8 : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["database connection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bttnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select count(*) from Admin_Login where adminid=" + txtAdminid.Text + "and password='" + txtPassword.Text + "'", con);
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                if (i > 0)
                {
                    Session["AdminID"] = txtAdminid.Text;
                    Response.Redirect("homeadmin.aspx");
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
    }
}