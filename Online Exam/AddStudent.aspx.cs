using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Exam
{
    public partial class AddStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Initial catalog=OnlineExam; integrated security=true;server=OM\\SQLEXPRESS");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into student values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "'," + TextBox4.Text + ",'"  + TextBox5.Text + "','" + TextBox6.Text  + "')", con);
            Label7.Text = cmd.CommandText;
            int i = cmd.ExecuteNonQuery();
            Label7.Text = " Record inserted successfully";

        }
    }
}