using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace StateMgmt
{
    public partial class Employee : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=PRAGMA-PC29\SQLEXPRESS;Initial Catalog=sample3;Integrated Security=True");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "select * from employee";
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                GridView1.DataSource = dr;
                GridView1.DataBind();
               
            }
            con.Close();
        }
    } 
    }

   