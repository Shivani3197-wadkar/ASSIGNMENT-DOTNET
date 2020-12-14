using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using localhost;
using System.Web.Services;

namespace WebService
{ }
namespace WebApplication1
{
    
        public partial class WebForm1 : System.Web.UI.Page
        {
            WebService w;
            protected void Page_Load(object sender, EventArgs e)
            {
                w = new WebService();

            }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = w.insertemp( Convert.ToInt32(TextBox1.Text), TextBox2.Text, TextBox3.Text, TextBox4.Text);
            Label1.Text = str;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string str = w.UpdateEmployee(TextBox1.Text, Convert.ToInt32(TextBox2.Text));
            Label1.Text = str;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string str = w.deleteEmployee(TextBox1.Text);
            Label1.Text = str;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string str = w.ShowEmployee();
            Label1.Text = str;
        }
    }
}