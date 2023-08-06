using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Exam
{
    public partial class ExamSet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String query = "insert into addquestions values (@question,@opt1,@opt2,@opt3,@opt4,@solution,@keyword,@serialno);";
            SqlConnection sqlcon = new SqlConnection("Initial catalog=OnlineExam; integrated security=true;server=OM\\SQLEXPRESS");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            cmd.Parameters.AddWithValue("@question", TextBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@opt1", TextBox2.Text.Trim());
            cmd.Parameters.AddWithValue("@opt2", TextBox3.Text.Trim());
            cmd.Parameters.AddWithValue("@opt3", TextBox4.Text.Trim());
            cmd.Parameters.AddWithValue("@opt4", TextBox5.Text.Trim());
            cmd.Parameters.AddWithValue("@solution", TextBox6.Text.Trim());
            cmd.Parameters.AddWithValue("@keyword", TextBox7.Text.Trim());
            cmd.Parameters.AddWithValue("@serialno", TextBox8.Text.Trim());

            int i = cmd.ExecuteNonQuery();
            sqlcon.Close();

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
        }
    }
}