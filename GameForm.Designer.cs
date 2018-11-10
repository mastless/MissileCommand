namespace FinalProject
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Warzone = new System.Windows.Forms.Panel();
            this.Tower3 = new System.Windows.Forms.PictureBox();
            this.Tower1 = new System.Windows.Forms.PictureBox();
            this.Tower2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.City1 = new System.Windows.Forms.PictureBox();
            this.Warzone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tower3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tower1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tower2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.City1)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 52);
            this.panel1.TabIndex = 1;
            // 
            // Warzone
            // 
            this.Warzone.Controls.Add(this.Tower3);
            this.Warzone.Controls.Add(this.Tower1);
            this.Warzone.Controls.Add(this.Tower2);
            this.Warzone.Controls.Add(this.pictureBox3);
            this.Warzone.Controls.Add(this.pictureBox2);
            this.Warzone.Controls.Add(this.pictureBox1);
            this.Warzone.Controls.Add(this.City1);
            this.Warzone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Warzone.Location = new System.Drawing.Point(0, 0);
            this.Warzone.Name = "Warzone";
            this.Warzone.Size = new System.Drawing.Size(484, 259);
            this.Warzone.TabIndex = 2;
            this.Warzone.Click += new System.EventHandler(this.Warzone_Click);
            this.Warzone.Paint += new System.Windows.Forms.PaintEventHandler(this.Warzone_Paint);
            this.Warzone.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Warzone_MouseMove);
            // 
            // Tower3
            // 
            this.Tower3.Image = ((System.Drawing.Image)(resources.GetObject("Tower3.Image")));
            this.Tower3.Location = new System.Drawing.Point(375, 231);
            this.Tower3.Name = "Tower3";
            this.Tower3.Size = new System.Drawing.Size(16, 10);
            this.Tower3.TabIndex = 9;
            this.Tower3.TabStop = false;
            // 
            // Tower1
            // 
            this.Tower1.Image = ((System.Drawing.Image)(resources.GetObject("Tower1.Image")));
            this.Tower1.Location = new System.Drawing.Point(95, 231);
            this.Tower1.Name = "Tower1";
            this.Tower1.Size = new System.Drawing.Size(16, 10);
            this.Tower1.TabIndex = 8;
            this.Tower1.TabStop = false;
            // 
            // Tower2
            // 
            this.Tower2.Image = ((System.Drawing.Image)(resources.GetObject("Tower2.Image")));
            this.Tower2.Location = new System.Drawing.Point(237, 231);
            this.Tower2.Name = "Tower2";
            this.Tower2.Size = new System.Drawing.Size(16, 10);
            this.Tower2.TabIndex = 7;
            this.Tower2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.WindowText;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(420, 217);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 42);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.WindowText;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(301, 217);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 42);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(153, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // City1
            // 
            this.City1.BackColor = System.Drawing.SystemColors.WindowText;
            this.City1.Image = ((System.Drawing.Image)(resources.GetObject("City1.Image")));
            this.City1.Location = new System.Drawing.Point(26, 217);
            this.City1.Name = "City1";
            this.City1.Size = new System.Drawing.Size(42, 42);
            this.City1.TabIndex = 2;
            this.City1.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.Warzone);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(350, 0);
            this.MaximumSize = new System.Drawing.Size(500, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Missile Command";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Warzone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tower3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tower1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tower2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.City1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Warzone;
        private System.Windows.Forms.PictureBox City1;
        private System.Windows.Forms.PictureBox Tower3;
        private System.Windows.Forms.PictureBox Tower1;
        private System.Windows.Forms.PictureBox Tower2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

