
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
            this.timerFor = new System.Windows.Forms.TextBox();
            this.timerToggleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timerFor
            // 
            this.timerFor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerFor.Location = new System.Drawing.Point(12, 12);
            this.timerFor.Name = "timerFor";
            this.timerFor.PlaceholderText = "What is the timer for?";
            this.timerFor.Size = new System.Drawing.Size(359, 32);
            this.timerFor.TabIndex = 0;
            // 
            // timerToggleButton
            // 
            this.timerToggleButton.Location = new System.Drawing.Point(377, 12);
            this.timerToggleButton.Name = "timerToggleButton";
            this.timerToggleButton.Size = new System.Drawing.Size(75, 32);
            this.timerToggleButton.TabIndex = 1;
            this.timerToggleButton.Text = "Start";
            this.timerToggleButton.UseVisualStyleBackColor = true;
            this.timerToggleButton.Click += new System.EventHandler(this.timerToggleButton_Click);
            // 
            // PomodoroCounterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 281);
            this.Controls.Add(this.timerToggleButton);
            this.Controls.Add(this.timerFor);
            this.Name = "PomodoroCounterWindow";
            this.Text = "Pomodoro Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox timerFor;
        private System.Windows.Forms.Button timerToggleButton;
    }
}

