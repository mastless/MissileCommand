///  Tristan Sizik
///  818006833
///  12.10.17


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FinalProject
{
    /// <summary>
    /// StartMenu was second form I made, so had to figure out how to make it the first form that shows up in application,
    /// thus had to manually place it into program.cs, which I found kind of intimidating since I felt it could potentially
    /// make bugs. So far so good though.
    /// Redirects the user to different forms based on the button they press.
    /// Not the Cheats button yet, Cheats aren't finished because game isn't finished.
    /// </summary>
    public partial class StartMenu : Form
    {
        Pen whitePen = new Pen(Color.White);
        SolidBrush fillRed = new SolidBrush(Color.Red);
        Random ranVal = new Random();

        public StartMenu()
        {
            InitializeComponent();

        }


        private void EnterGame_Click(object sender, EventArgs e)
        {
            GameForm newForm = new GameForm();
            this.Hide();
            newForm.ShowDialog();
        }

        private void HowToButton_Click(object sender, EventArgs e)
        {
            HowToForm newForm = new HowToForm();

            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void Cheat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uh Oh! \nUnder Construction :)");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MyNameLabel.Font = new Font("Arial", 15);           
        }

        private void GraphicsTimer_Tick(object sender, EventArgs e)
        {
            this.CreateGraphics().Clear(this.BackColor);                    //Same logic as found in HowToForm

            int R;
            int B;
            int G;
            for(int i =0; i<10; i++)
            {
                R = ranVal.Next(150, 240);
                B = ranVal.Next(150, 240);
                G = ranVal.Next(100, 150);

                SolidBrush titleFill = new SolidBrush(Color.FromArgb(R, G, B));

                string titleGraphic = "Missile Command";
                StringFormat toDraw = new StringFormat();
                Font drawFont = new Font("Arial", 20);
                float x = this.ClientSize.Width / 2 - 110;
                float y = this.ClientSize.Height / 2 - 100;

                this.CreateGraphics().DrawString(titleGraphic, drawFont, titleFill, x, y);

                R = ranVal.Next(150, 240);
                B = ranVal.Next(150, 240);
                G = ranVal.Next(150, 240);

                titleFill = new SolidBrush(Color.FromArgb(R, G, B));


                this.CreateGraphics().DrawString(titleGraphic, drawFont, titleFill, x-2, y-2);

            }
            

            
        }
    }
}
