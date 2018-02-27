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
            /*MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=ecafe;password=root");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select count(*) from customer where username='" + TextBox1.Text + "' and pass='" + TextBox2.Text + "'", con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count < 0)
            {
                Label1.Text = dt.Rows.Count.ToString();
            }

            else
            {
                //Response.Redirect("Order.aspx");
                Label1.Text = dt.Rows.Count.ToString();

            }
             */
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=ecafe;password=root");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT count(*) FROM [customer] where [username]='" + TextBox1.Text + "' and [pass]='" + TextBox2.Text + "'", con);
            MySqlDataReader dr;

   
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                Response.Write("valid userame or Password!");
            }
            else
            {
                Response.Write("Invalid userame or Password!");
            }
            /*
             *
             * MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT count(*) FROM [customer] where [username]='" + TextBox1.Text + "' and [pass]='" + TextBox2.Text + "'";
            
      
             * cmd.ExecuteNonQuery();
                  DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows )
            {
                Session["username"] = dr["username"].ToString();
                Response.Redirect("Order.aspx");
            }
            con.Close();
            Label1.Text= "Invalid";
            */
        }
    }
}