using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Online_Parking
{
    public partial class WebForm5 : System.Web.UI.Page
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
                SqlCommand cmd = new SqlCommand("select count(*) from User_Details where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'", con);
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                if (i > 0)
                {
                    Session["UserName"] = txtUsername.Text;
                    Response.Redirect("homeuser.aspx");
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
