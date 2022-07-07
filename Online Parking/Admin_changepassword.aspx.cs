using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Online_Parking
{
    public partial class WebForm10 : System.Web.UI.Page
    {

        string cs = ConfigurationManager.ConnectionStrings["Database Connection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bttnSubmit_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);
            try
            {
                con.Open();
                //int UsrId = Convert.ToInt32(Session["user_id"]);
                SqlCommand cmd = new SqlCommand("select * from Admin_Login where adminid=" + Session["AdminID"] + " ", con);
                // SqlCommand cmd = new SqlCommand("select * from login where u_id=" + Session["userid"] + " ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string pswd = dt.Rows[0]["password"].ToString();
                    string t = txtCurrentpw.Text;
                    if (t == pswd)
                    {
                        SqlCommand cmd1 = new SqlCommand("update Admin_Login set password='" +txtNewpw.Text + "' where adminid=" + Session["AdminID"] + "", con);
                        cmd1.ExecuteNonQuery();
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect", "alert('Password Changed Successfully'); window.location='" +
                        Request.ApplicationPath + "Admin_changepassword.aspx';", true);
                        // SqlCommand cmd2 = new SqlCommand("update login set password='" + txtconpass.Text + "' where u_id='" + Session["userid"] + "'", con);
                        // cmd2.ExecuteNonQuery();
                    }

                    else
                    {
                        //Label1.Text = "Incorrect Old Password";
                        Label4.Visible = true;
                    }
                }

            }
            catch
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect", "alert('Error!!!..Try Again'); window.location='" +
                Request.ApplicationPath + "Admin_changepassword.aspx';", true);
            }
            con.Close();
        }

        protected void txtNewpw_TextChanged(object sender, EventArgs e)
        {

        }
    }
}