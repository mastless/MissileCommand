namespace FinalProject
{
    partial class StartMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
            this.EnterGame = new System.Windows.Forms.Button();
            this.GraphicsTimer = new System.Windows.Forms.Timer(this.components);
            this.HowToButton = new System.Windows.Forms.Button();
            this.Cheat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MyNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnterGame
            // 
            this.EnterGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnterGame.Location = new System.Drawing.Point(76, 135);
            this.EnterGame.Name = "EnterGame";
            this.EnterGame.Size = new System.Drawing.Size(80, 25);
            this.EnterGame.TabIndex = 0;
            this.EnterGame.Text = "Start Game";
            this.EnterGame.UseVisualStyleBackColor = true;
            this.EnterGame.Click += new System.EventHandler(this.EnterGame_Click);
            // 
            // GraphicsTimer
            // 
            this.GraphicsTimer.Enabled = true;
            this.GraphicsTimer.Tick += new System.EventHandler(this.GraphicsTimer_Tick);
            // 
            // HowToButton
            // 
            this.HowToButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HowToButton.Location = new System.Drawing.Point(67, 175);
            this.HowToButton.Name = "HowToButton";
            this.HowToButton.Size = new System.Drawing.Size(100, 25);
            this.HowToButton.TabIndex = 1;
            this.HowToButton.Text = "How To Play";
            this.HowToButton.UseVisualStyleBackColor = true;
            this.HowToButton.Click += new System.EventHandler(this.HowToButton_Click);
            // 
            // Cheat
            // 
            this.Cheat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cheat.Location = new System.Drawing.Point(67, 215);
            this.Cheat.Name = "Cheat";
            this.Cheat.Size = new System.Drawing.Size(100, 25);
            this.Cheat.TabIndex = 1;
            this.Cheat.Text = "Cheats";
            this.Cheat.UseVisualStyleBackColor = true;
            this.Cheat.Click += new System.EventHandler(this.Cheat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Created By";
            // 
            // MyNameLabel
            // 
            this.MyNameLabel.AutoSize = true;
            this.MyNameLabel.ForeColor = System.Drawing.Color.White;
            this.MyNameLabel.Location = new System.Drawing.Point(60, 104);
            this.MyNameLabel.Name = "MyNameLabel";
            this.MyNameLabel.Size = new System.Drawing.Size(64, 13);
            this.MyNameLabel.TabIndex = 2;
            this.MyNameLabel.Text = "Tristan Sizik";
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(234, 261);
            this.Controls.Add(this.MyNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cheat);
            this.Controls.Add(this.HowToButton);
            this.Controls.Add(this.EnterGame);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 300);
            this.MinimumSize = new System.Drawing.Size(250, 300);
            this.Name = "StartMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MC Start";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnterGame;
        private System.Windows.Forms.Timer GraphicsTimer;
        private System.Windows.Forms.Button HowToButton;
        private System.Windows.Forms.Button Cheat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MyNameLabel;
    }
}