using System;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Pomodoro_Counter
{
    public partial class PomodoroCounterWindow : Form
    {
        //Stopwatch pomodoroStopwatch = new Stopwatch();
        int remainingMinutes = 25;
        int remainingSeconds = 0;
        bool onBreak = false;

        SoundPlayer workSoundPlayer = new SoundPlayer("Audio\\work.wav");
        SoundPlayer breakSoundPlayer = new SoundPlayer("Audio\\break.wav");

        public PomodoroCounterWindow()
        {
            InitializeComponent();

            string temp = System.IO.Directory.GetCurrentDirectory();
            this.workSoundPlayer.Load();
            this.breakSoundPlayer.Load();

            this.pomodoroTimer.Tick += PomodoroTimer_Tick;
        }

        private void PomodoroTimer_Tick(object sender, EventArgs e)
        {
            //this.pomodoroTimerLabel.Text = this.pomodoroTimer
            this.remainingSeconds--;
            if (this.remainingSeconds == -1)
            {
                this.remainingSeconds = 59;
                this.remainingMinutes--;
            }

            if (this.remainingMinutes == -1)
            {
                if (onBreak == true)
                {
                    onBreak = false;

                    this.remainingMinutes = 25;
                    this.remainingSeconds = 0;

                    this.timerStatusWorkingLabel.ForeColor = Color.Black;
                    this.timerStatusBreakLabel.ForeColor = Color.LightGray;

                    workSoundPlayer.Play();
                }
                else
                {
                    onBreak = true;

                    this.remainingMinutes = 5;
                    this.remainingSeconds = 0;

                    this.timerStatusWorkingLabel.ForeColor = Color.LightGray;
                    this.timerStatusBreakLabel.ForeColor = Color.Black;

                    breakSoundPlayer.Play();
                }
            }

            string minutesString = (this.remainingMinutes < 10) ? "0"  : "";
            string secondsString = (this.remainingSeconds < 10) ? "0"  : "";

            minutesString += this.remainingMinutes;
            secondsString += this.remainingSeconds;

            this.pomodoroTimerLabel.Text = minutesString + ":" + secondsString;
        }

        private void timerToggleButton_Click(object sender, EventArgs e)
        {
            if (this.pomodoroTimer.Enabled == true)
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
            pomodoroTimer.Stop();
            breakSoundPlayer.Play();
        }

        private void startTimer()
        {
            this.timerToggleButton.Text = "Stop";
            pomodoroTimer.Start();
            workSoundPlayer.Play();
        }
    }
}
