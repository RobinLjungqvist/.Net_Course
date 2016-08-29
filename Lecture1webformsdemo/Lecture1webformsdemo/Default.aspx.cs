using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}