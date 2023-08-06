using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Exam
{
    public partial class Admin_Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Initial catalog=OnlineExam; integrated security=true;server=OM\\SQLEXPRESS");
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(1) from admin where username='" + TextBox1.Text + "'" + "and password='" + TextBox2.Text + "'", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 1)
            {
                Session["username"] = TextBox1.Text.Trim();
                Label3.Text = "login successful";

                Response.Redirect("AdminModification.aspx");
            }

            else
            {
                Label3.Text = "*invalid username or password";
            }

        }
    }
}