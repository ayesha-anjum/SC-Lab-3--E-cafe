using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
namespace WebApplication3
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


   

        protected void Button2_Click1(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=ecafe;password=root");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM customer where username='" + TextBox1.Text + "' and pass='" + TextBox2.Text + "'", con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Response.Redirect("Order.aspx");
            }

            else
            {

                Label1.Text = "Invalid username or password!";

            }
             
          
        }
    }
}