using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task_2_asp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(Num1.Text);
            int num2 = int.Parse(Num2.Text);
            int result = num1 * num2;
            TextBox1.Text = $" The result is {result.ToString()}";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(Num1.Text);
            int num2 = int.Parse(Num2.Text);
            int result = num1 + num2;
            TextBox1.Text = $" The result is {result.ToString()}";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(Num1.Text);
            int num2 = int.Parse(Num2.Text);
            int result = num1 - num2;
            TextBox1.Text = $" The result is {result.ToString()}";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

    
