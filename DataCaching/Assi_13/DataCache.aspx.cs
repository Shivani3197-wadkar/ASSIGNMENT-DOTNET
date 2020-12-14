using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Assi_13
{
    public partial class DataCache : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=PRAGMA-PC29\SQLEXPRESS;Initial Catalog=sample3;Integrated Security=True");
            cn.Open();
            SqlCommand cd = new SqlCommand("insert into employee values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')", cn);
            cd.ExecuteNonQuery();
            Label1.Text = "data inserted succesfully";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            GridView1.Visible = true; 
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=PRAGMA-PC29\SQLEXPRESS;Initial Catalog=sample3;Integrated Security=True");
            cn.Open();
            TimeSpan t1 = new TimeSpan(0,0,10);
            DataSet ds = new DataSet();
            if (Cache["Employee1"] == null)
            {
                Cache.Insert("Employee1", ds, null, DateTime.MaxValue, t1);
                GridView1.DataBind();
                Label1.Text = "created and added to cache" + DateTime.Now.ToString();
            }
            else
            {
                Label1.Text = "It is processed from cache" + DateTime.Now.ToString();

            }
            GridView1.DataBind();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
         

            Cache.Remove("Employee1");
            Label1.Text = "cache is cleared..";



        }
    }
}