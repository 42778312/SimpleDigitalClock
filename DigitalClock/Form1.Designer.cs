namespace DigitalClock
{
    partial class digitalClock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.clockLabel = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.whiteButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clockLabel
            // 
            this.clockLabel.AutoSize = true;
            this.clockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLabel.ForeColor = System.Drawing.Color.Red;
            this.clockLabel.Location = new System.Drawing.Point(31, 41);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(740, 163);
            this.clockLabel.TabIndex = 0;
            this.clockLabel.Text = "Loading ...";
            this.clockLabel.Click += new System.EventHandler(this.DigitalClock_load);
            // 
            // clockTimer
            // 
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // whiteButton
            // 
            this.whiteButton.BackColor = System.Drawing.Color.White;
            this.whiteButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.whiteButton.Location = new System.Drawing.Point(28, 404);
            this.whiteButton.Name = "whiteButton";
            this.whiteButton.Size = new System.Drawing.Size(40, 34);
            this.whiteButton.TabIndex = 1;
            this.whiteButton.UseVisualStyleBackColor = false;
            this.whiteButton.Click += new System.EventHandler(this.whiteButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Blue;
            this.blueButton.Location = new System.Drawing.Point(89, 404);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(44, 34);
            this.blueButton.TabIndex = 2;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.Lime;
            this.greenButton.ForeColor = System.Drawing.Color.Lime;
            this.greenButton.Location = new System.Drawing.Point(154, 404);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(45, 34);
            this.greenButton.TabIndex = 3;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowButton.ForeColor = System.Drawing.Color.Yellow;
            this.yellowButton.Location = new System.Drawing.Point(218, 404);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(47, 34);
            this.yellowButton.TabIndex = 4;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // digitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.whiteButton);
            this.Controls.Add(this.clockLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Name = "digitalClock";
            this.Text = "digitalClock";
            this.Load += new System.EventHandler(this.digitalClock_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Button whiteButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button yellowButton;
    }
}

