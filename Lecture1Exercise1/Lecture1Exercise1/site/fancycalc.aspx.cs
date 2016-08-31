using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lecture1Exercise1.logic;

namespace Lecture1Exercise1.site
{
    public partial class fancycalc : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text += 1;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text += 2;

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox1.Text += 3;

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            TextBox1.Text += 5;

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            TextBox1.Text += 6;

        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            TextBox1.Text += 7;

        }
        protected void Button8_Click(object sender, EventArgs e)
        {
            TextBox1.Text += 8;

        }
        protected void Button9_Click(object sender, EventArgs e)
        {
            TextBox1.Text += 9;

        }

        protected void Button0_Click(object sender, EventArgs e)
        {
            TextBox1.Text += 0;

        }

        protected void ButtonEqual_Click(object sender, EventArgs e)
        {

            TextBox1.Text = Calculator.Calculate().ToString();
        }

        protected void Button_C_Click(object sender, EventArgs e)
        {
            TextBox1.Text = string.Empty;
            Calculator.firstNumber = string.Empty;
            Calculator.secondNumber = string.Empty;
            Calculator.Operator = Operator.Empty;
        }
    }
}