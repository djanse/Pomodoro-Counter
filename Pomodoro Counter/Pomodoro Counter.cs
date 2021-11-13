using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro_Counter
{
    public partial class PomodoroCounterWindow : Form
    {
        bool timerRunning = false;

        public PomodoroCounterWindow()
        {
            InitializeComponent();
        }

        private void timerToggleButton_Click(object sender, EventArgs e)
        {
            if (this.timerRunning == true)
            {
                this.stopTimer();
            }
            else
            {
                this.startTimer();
            }
        }

        private void stopTimer()
        {
            this.timerToggleButton.Text = "Start";
            this.timerRunning = false;
        }

        private void startTimer()
        {
            this.timerToggleButton.Text = "Stop";
            this.timerRunning = true;
        }
    }
}
