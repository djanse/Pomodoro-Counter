
namespace Pomodoro_Counter
{
    partial class PomodoroCounterWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerFor = new System.Windows.Forms.TextBox();
            this.timerToggleButton = new System.Windows.Forms.Button();
            this.pomodoroTimer = new System.Windows.Forms.Timer(this.components);
            this.pomodoroTimerLabel = new System.Windows.Forms.Label();
            this.timerStatusBreakLabel = new System.Windows.Forms.Label();
            this.timerStatusWorkingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerFor
            // 
            this.timerFor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerFor.Location = new System.Drawing.Point(12, 12);
            this.timerFor.Name = "timerFor";
            this.timerFor.PlaceholderText = "What is the timer for?";
            this.timerFor.Size = new System.Drawing.Size(359, 32);
            this.timerFor.TabIndex = 2;
            // 
            // timerToggleButton
            // 
            this.timerToggleButton.Location = new System.Drawing.Point(377, 11);
            this.timerToggleButton.Name = "timerToggleButton";
            this.timerToggleButton.Size = new System.Drawing.Size(75, 34);
            this.timerToggleButton.TabIndex = 1;
            this.timerToggleButton.Text = "Start";
            this.timerToggleButton.UseVisualStyleBackColor = true;
            this.timerToggleButton.Click += new System.EventHandler(this.timerToggleButton_Click);
            // 
            // pomodoroTimer
            // 
            this.pomodoroTimer.Interval = 1000;
            // 
            // pomodoroTimerLabel
            // 
            this.pomodoroTimerLabel.AutoSize = true;
            this.pomodoroTimerLabel.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pomodoroTimerLabel.Location = new System.Drawing.Point(12, 47);
            this.pomodoroTimerLabel.Name = "pomodoroTimerLabel";
            this.pomodoroTimerLabel.Size = new System.Drawing.Size(283, 128);
            this.pomodoroTimerLabel.TabIndex = 2;
            this.pomodoroTimerLabel.Text = "25:00";
            // 
            // timerStatusBreakLabel
            // 
            this.timerStatusBreakLabel.AutoSize = true;
            this.timerStatusBreakLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerStatusBreakLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.timerStatusBreakLabel.Location = new System.Drawing.Point(303, 114);
            this.timerStatusBreakLabel.Name = "timerStatusBreakLabel";
            this.timerStatusBreakLabel.Size = new System.Drawing.Size(149, 45);
            this.timerStatusBreakLabel.TabIndex = 3;
            this.timerStatusBreakLabel.Text = "On Break";
            // 
            // timerStatusWorkingLabel
            // 
            this.timerStatusWorkingLabel.AutoSize = true;
            this.timerStatusWorkingLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerStatusWorkingLabel.Location = new System.Drawing.Point(304, 59);
            this.timerStatusWorkingLabel.Name = "timerStatusWorkingLabel";
            this.timerStatusWorkingLabel.Size = new System.Drawing.Size(140, 45);
            this.timerStatusWorkingLabel.TabIndex = 4;
            this.timerStatusWorkingLabel.Text = "Working";
            // 
            // PomodoroCounterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 183);
            this.Controls.Add(this.timerStatusWorkingLabel);
            this.Controls.Add(this.timerStatusBreakLabel);
            this.Controls.Add(this.pomodoroTimerLabel);
            this.Controls.Add(this.timerToggleButton);
            this.Controls.Add(this.timerFor);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 222);
            this.MinimumSize = new System.Drawing.Size(480, 222);
            this.Name = "PomodoroCounterWindow";
            this.Text = "Pomodoro Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox timerFor;
        private System.Windows.Forms.Button timerToggleButton;
        private System.Windows.Forms.Timer pomodoroTimer;
        private System.Windows.Forms.Label pomodoroTimerLabel;
        private System.Windows.Forms.Label timerStatusBreakLabel;
        private System.Windows.Forms.Label timerStatusWorkingLabel;
    }
}

