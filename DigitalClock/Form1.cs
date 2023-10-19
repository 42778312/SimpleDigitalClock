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
            clockTimer.Start();
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.White;
        }

        private void digitalClock_Load_1(object sender, EventArgs e)
        {

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
    }
}
