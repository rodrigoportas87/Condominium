﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portaria
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 2;
            }
            else
            {

                timer1.Enabled = false;
                this.Visible = false;
                mainMenu menu = new mainMenu();
                menu.Show();
               
               
            }
            
        }

        private void splash_Load(object sender, EventArgs e)
        {

        }


    }
}
