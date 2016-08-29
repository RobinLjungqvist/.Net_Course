using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lecture1Exercise1.site
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Send_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text != string.Empty)
            {
                OutputLabel.Text = $"Hello, {TextBox1.Text}!";
            }
            else
            {
                OutputLabel.Text = "Write your name!";
            }
        }
    }
}