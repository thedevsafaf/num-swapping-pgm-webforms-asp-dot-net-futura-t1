using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SwappingProgram
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num1, num2, temp;
            num1 = Convert.ToInt32(TextBox1.Text);
            num2 = Convert.ToInt32(TextBox2.Text);
            //before swapping
            TextBox3.Text = num1.ToString();
            TextBox4.Text = num2.ToString();
            //swapping
            temp = num1;
            num1 = num2;
            num2 = temp;
            //after swapping
            TextBox5.Text = num1.ToString();
            TextBox6.Text = num2.ToString();
        }
    }
}