﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrpPro12_2AssigningTicketTimeSlots
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this method call handles starting the timer.
            tmrClock.Start();

        }

        private void updateTime(object sender, EventArgs e)
        {
            //This method will display the time in the mainform window.
            this.Text = DateTime.Now.ToString("hh:mm:ss tt") + ("   OPEN");
        }
        #region buttons
        private void btnOptions_Click(object sender, EventArgs e)
        {
            frmOptions frmOptions = new frmOptions();
            frmOptions.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
