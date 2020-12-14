using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace currency1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double txtbx = Convert.ToDouble(TextBox1.Text);

            int i, j;
            double sum = 0;
            double[,] convert = { { 1, 88.92,1.21,0.000063,126.17, 57.90, 66.63 },{ 0.011,1,73, 0.00, 1.42, 0.65, 0.75 },
            {0.83,73.77,1,0.000052,104.69,48.05,55.30 } };
            double d1 = Convert.ToDouble(DropDownList1.SelectedIndex);
            double d2 = Convert.ToDouble(DropDownList2.SelectedIndex);
            for (i = 0; i < 3; i++)
            {
                for(j=0;j<7;j++)
                {
                    if(d1==i && d2==j)
                    {
                        sum = convert[i, j];
                        sum = sum * txtbx;
                    }
                }
            }
            TextBox2.Text = Math.Round(sum).ToString();
        }
    }
}