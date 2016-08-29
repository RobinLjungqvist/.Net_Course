using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lecture1webformsdemo
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Text = "Send";

        }
        protected void Button_Click(object sender, EventArgs e)
        {
            Label1.Text = TextBox1.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var input = TextBox1.Text;
            var output = "";
            var consonants = new char[] { 'q','w','r','t','p','s','d','f','g','h','j','k','l','z','x','c','v','b','n','m' };
            foreach( var c in input)
            {
                if (consonants.Contains(c))
                {
                    output += (c + "o" + c).ToString();
                }
                else output += c;
            }

            Label1.Text = output.ToString();
        }
    }
}