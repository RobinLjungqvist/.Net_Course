using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lecture1Exercise1.site
{
    public partial class calc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
            int first = 0;
            int second = 0;

            if(int.TryParse(textbox_firstnr.Text, out first) && int.TryParse(textbox_secondnr.Text, out second))
            {
                int added = first + second;

                Result.Text = added.ToString();
            }
            else
            {
                Result.Text = "You must enter numbers.";
            }
        }

        protected void btn_Sub_Click(object sender, EventArgs e)
        {
            int first = 0;
            int second = 0;

            if (int.TryParse(textbox_firstnr.Text, out first) && int.TryParse(textbox_secondnr.Text, out second))
            {
                int added = first - second;

                Result.Text = added.ToString();
            }
            else
            {
                Result.Text = "You must enter numbers.";
            }
        }

        protected void btn_Multi_Click(object sender, EventArgs e)
        {
            int first = 0;
            int second = 0;

            if (int.TryParse(textbox_firstnr.Text, out first) && int.TryParse(textbox_secondnr.Text, out second))
            {
                int added = first * second;

                Result.Text = added.ToString();
            }
            else
            {
                Result.Text = "You must enter numbers.";
            }
        }

        protected void btn_div_Click(object sender, EventArgs e)
        {
            int first = 0;
            int second = 0;

            if (int.TryParse(textbox_firstnr.Text, out first) && int.TryParse(textbox_secondnr.Text, out second))
            {
                
                if (first == 0 || second == 0)
                {
                    Result.Text = "You can't divide by zero";
                }
                else
                {
                    int added = first / second;

                    Result.Text = added.ToString();
                }

            }
            else
            {
                Result.Text = "You must enter numbers.";
            }
        }
    }
}