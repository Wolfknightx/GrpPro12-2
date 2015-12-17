﻿using System;
using System.Windows.Forms;
using GrpPro12_2AssigningTicketTimeSlots.Domain;

namespace GrpPro12_2AssigningTicketTimeSlots
{
    public partial class frmOptions : Form
    {
        /// <summary>
        /// this holds our main form instance
        /// </summary>
        public frmMain Main;

        /// <summary>
        /// create a new for and set the main form variables into the 
        /// correct controls on the options form
        /// </summary>
        /// <param name="main"></param>
        public frmOptions(frmMain main)
        {
            InitializeComponent();
            Main = main;
            dtpStartTime.Value = main.today.Start;
            dtpEndTime.Value = main.today.End;
            numMinutes.Value = main.today.WindowSize.Minutes;
            numRidersPer.Value = main.today.MaxRiders;
        }


        #region button
        /// <summary>
        /// create a new day and pass the values from the 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //inserted validation to insure that times cannot come before the start.
            if (dtpEndTime.Value.TimeOfDay < dtpStartTime.Value.TimeOfDay)
            {
                MessageBox.Show("The endtime should not come before the Start Time.  Please adjust.", "Time Error");
            }
            else
            {
            RidingDay newDay = new RidingDay(dtpStartTime.Value, dtpEndTime.Value, numMinutes.Text, (int)numRidersPer.Value, (int)numFirstTickets.Value);
            Main.today = newDay;
            Main.Show();
            Close();
            }
        }
        #endregion

        private void frmOptions_Load(object sender, EventArgs e)
        {


            //hide the main form upon load.
            Main.Hide();
        }
    }
}
