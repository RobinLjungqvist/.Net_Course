﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnonymousMethodDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
       
            Button btnHello = new Button();
            btnHello.Text = "Hello!";

            btnHello.Click +=
                delegate
                {
                    MessageBox.Show("Nice knowing you!");

                };
            Controls.Add(btnHello);

        }
    }
}
