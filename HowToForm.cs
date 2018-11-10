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

namespace FinalProject
{
    public partial class HowToForm : Form
    {
        Random ranVal = new Random();

        public HowToForm()
        {
            InitializeComponent();
        }

        private void HowToForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Timer that would call the graphics of HowToForm and create a Text that has a shadow as well as a random RGB value,
        /// thus making a rainbow effect and giving it more life.
        /// </summary>

        private void HowToTimer_Tick(object sender, EventArgs e)
        {
            this.CreateGraphics().Clear(this.BackColor);                

            int R;
            int B;
            int G;
            for (int i = 0; i < 10; i++)
            {
                R = ranVal.Next(150, 240);
                B = ranVal.Next(150, 240);
                G = ranVal.Next(100, 150);

                SolidBrush titleFill = new SolidBrush(Color.FromArgb(R, G, B));

                string titleGraphic = "How To Play";
                StringFormat toDraw = new StringFormat();
                Font drawFont = new Font("Arial", 20);
                float x = this.ClientSize.Width / 2 - 80;
                float y = this.ClientSize.Height / 3 - 100;

                this.CreateGraphics().DrawString(titleGraphic, drawFont, titleFill, x, y);

                R = ranVal.Next(150, 240);
                B = ranVal.Next(150, 240);
                G = ranVal.Next(150, 240);

                titleFill = new SolidBrush(Color.FromArgb(R, G, B));


                this.CreateGraphics().DrawString(titleGraphic, drawFont, titleFill, x - 2, y - 2);

            }
        }
        private void HowToForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                KeyAButton.BackColor = Color.LightBlue;                     //Key downs that mimic keyButtonPress reaction
            }                                                               //made it more fun by giving it interaction.
            if (e.KeyCode == Keys.S)
            {
                KeySButton.BackColor = Color.LightBlue;
            }
            if (e.KeyCode == Keys.D)
            {
                KeyDButton.BackColor = Color.LightBlue;
            }
        }

        private void HowToForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                KeyAButton.BackColor = Color.OrangeRed;                     //Resets the original color
            }
            if (e.KeyCode == Keys.S)
            {
                KeySButton.BackColor = Color.OrangeRed;
            }
            if (e.KeyCode == Keys.D)
            {
                KeyDButton.BackColor = Color.OrangeRed;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int R = ranVal.Next(150, 240);                                  //used logic from Title to generate random
            int B = ranVal.Next(150, 240);                                  //color for Button
            int G = ranVal.Next(100, 150);

            button1.BackColor = Color.FromArgb(R, B, G);
        }
            
    }
}
