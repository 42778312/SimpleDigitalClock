using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class digitalClock : Form
        
    {
        private DateTime startTime;
        public digitalClock()
        {
            InitializeComponent();
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void DigitalClock_load(object sender, EventArgs e)
        {
            //clockTimer.Start(); //  this Section later 
        }

        private void whiteButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.White;
            
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Blue;
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Green;
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Yellow;
        }

        

        private void stopTimer_Click(object sender, EventArgs e)
        {
            clockTimer.Stop();
        }

        private void startTimer_Click(object sender, EventArgs e)
        { // set a valur to satrt time & start the time ;)
            clockTimer.Start();
            dateLabel.Text = DateTime.Now.ToLongDateString();
            
        }

        private void resetTimer_Click(object sender, EventArgs e)
        {
            clockTimer.Stop();
            dateLabel.Text = null;
            clockLabel.Text = "00:00:00";


        }

        private void digitalClock_Load_1(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            
        }

        private void dateLabel_Click(object sender, EventArgs e)
        {
            //clockLabel.Text = DateTime.Now.ToString("DD:MM:YYYY");
        }
    }
}
