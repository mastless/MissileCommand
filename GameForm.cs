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
using System.Diagnostics;

namespace FinalProject
{   
    /// <summary>
    /// Game Form is created as the Form that will play the game.
    /// Attempted to get around making a class which Implemented a Control, but couldn't understand how to implement it.
    /// 
    /// Goal was to make a number of Threads that would call the Panel Paint method. I Believe that I used alot of memory
    /// due to the amount of new objects that I made within my Thread calls, however, this was the only idea I had at the time.
    /// 
    /// </summary>
    public partial class GameForm : Form
    {

        #region Global Variables

        Point Val = new Point();                            
        Random ranLoc = new Random();
        int i = 0;
        Pen whitePen = new Pen(Color.White, 3);

        #endregion


        public GameForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Warzone_Paint(object sender, PaintEventArgs e)
        {

        }
        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void Warzone_MouseMove(object sender, MouseEventArgs e)
        {
            Val = this.PointToClient(Cursor.Position);              //Set Cursor to Client point. Had most difficult problem w this
        }                                                           //besides threads.

        /// <summary>
        /// Used a number of Threading calls in order to create calls to Painting graphics that would be then creating
        /// lines from point at top of client to Padding Bottom. 
        /// </summary>

        #region Drawing Missiles from Sky
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Thread DrawMissiles = new Thread(DrawMissile);
            DrawMissiles.Start();                                    //Timer Creating new Threads
        }


        public void DrawMissile()
        {
            int x_initial = ranLoc.Next(0, Warzone.Width);                      //Will move a Line from top to bottom of panel
            int y_initial = 0;
            double x_current = x_initial;
            int y_current = y_initial;
            int city = ranLoc.Next(0, 3);
            int time = Tower1.Location.Y;

            double add = 0;          

            Point[] move = new Point[2];
            Pen myPen = new Pen(Color.White, 1);
            Pen outlineBase = new Pen(Color.Gold, 2);
            SolidBrush allWhite = new SolidBrush(Color.LightGray);
            SolidBrush missileF = new SolidBrush(Color.Blue);

            Graphics g = Warzone.CreateGraphics();
           

            
            Rectangle baseMid = new Rectangle(240, Warzone.Height - 5, 20, 10);
            g.DrawEllipse(outlineBase, baseMid);                                    //was supposed to represent the towers
            g.FillEllipse(allWhite, baseMid);

            Rectangle baseLeft = new Rectangle(120, Warzone.Height - 5, 20, 10);
            g.DrawEllipse(outlineBase, baseLeft);
            g.FillEllipse(allWhite, baseLeft);

            Rectangle baseRight = new Rectangle(360, Warzone.Height - 5, 20, 10);
            g.DrawEllipse(outlineBase, baseRight);
            g.FillEllipse(allWhite, baseRight);

            switch (city)
            {
                case 0:
                    add = ((double)Tower1.Location.X+8 - (double)x_initial) / time;              // rate = distance/time

                    for (int i = 0; i < Warzone.Height; i++)
                    {
                        Thread.Sleep(10);
                        x_current += add;
                        y_current += 1;

                        move[0] = new Point(x_initial, y_initial);
                        move[1] = new Point(Convert.ToInt32(Math.Round(x_current)), y_current);

                        g.DrawLines(myPen, move);

                    }
                    g.Clear(Warzone.BackColor);
                    break;

                case 1:
                    add = ((double)Tower2.Location.X+8 - (double)x_initial) / time;


                    for (int i = 0; i < Warzone.Height; i++)
                    {
                        Thread.Sleep(10);
                        x_current += add;
                        y_current += 1;

                        move[0] = new Point(x_initial, y_initial);
                        move[1] = new Point(Convert.ToInt32((Math.Round(x_current))), y_current);

                        g.DrawLines(myPen, move);
                    }
                    g.Clear(Warzone.BackColor);
                    break;

                case 2:
                    add = ((double)Tower3.Location.X+8 - (double)x_initial) / time;


                    for (int i = 0; i < Warzone.Height; i++)
                    {
                        Thread.Sleep(10);
                        x_current += add;
                        y_current += 1;

                        move[0] = new Point(x_initial, y_initial);
                        move[1] = new Point(Convert.ToInt32((Math.Round(x_current))), y_current);

                        g.DrawLines(myPen, move);
                    }
                    g.Clear(Warzone.BackColor);
                    break;

            }
        }

        #endregion




        /// <summary>
        /// Essentially repeated the logic that was held in the previous region in order to create drawings and explosions
        /// that would be based on key strokes and clicks. The click would evaluate the location identified by MoveMouse.
        /// </summary>


        #region Drawing Missiles from Tower


        private void Warzone_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(DrawClick);
            th.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A)
            {
                Thread vari = new Thread(DrawA);                        //keys would start a new thread each stroke.
                vari.Start();
            }
            else if(e.KeyCode == Keys.S)
            { 
                Thread th = new Thread(DrawS);
                th.Start();
            }
            else if(e.KeyCode == Keys.D)
            {
                Invalidate();
                Thread th = new Thread(DrawD);
                th.Start();
            }
            
        }

        /// <summary>
        /// Each of these Draw Methods are essentially the same, however they all start at a different tower location.
        /// Same math as the Missiles used from sky to bottom, but opposite direction.
        /// </summary>
        public void DrawA()
        {
            int x_initial = Tower1.Location.X+8;
            int y_initial = Tower1.Location.Y;

            int x_final = Val.X;
            int y_final = Val.Y;

            double x_current = (double)x_initial;
            int y_current = y_initial;

            int exR = 5;
            
            int time = y_final - y_initial;

            double add = ((double)x_final - (double)x_initial) / (double)time;

            Point[] move = new Point[2];
            Pen myPen = new Pen(Color.Pink, 1);
            SolidBrush pinkBomb = new SolidBrush(Color.Pink);

            Rectangle explosionRec = new Rectangle();

            Graphics g = Warzone.CreateGraphics();
            
            for(int i = 0; i < Math.Abs(y_initial - y_final); i++)
            {
                Thread.Sleep(10);
                x_current -= add;
                y_current -= 1;

                move[0] = new Point(x_initial, y_initial);
                move[1] = new Point(Convert.ToInt32(Math.Round(x_current)), y_current);

                g.DrawLines(myPen, move);
            }

            

            for(i = 0; i < 5; i++)
            {
                Thread.Sleep(100);
                exR += 4;
                explosionRec.X = move[1].X-7-i;
                explosionRec.Y = move[1].Y-7-i;
                explosionRec.Size = new Size(exR, exR);
                g.FillPie(pinkBomb, explosionRec, 0, 360);
            }
            g.Clear(Warzone.BackColor);
            
        }

        public void DrawS()
        {
            int x_initial = Tower2.Location.X+8;
            int y_initial = Tower2.Location.Y;

            int x_final = Val.X;
            int y_final = Val.Y;

            double x_current = (double)x_initial;
            int y_current = y_initial;

            int exR = 5;

            int time = y_final - y_initial;

            double add = ((double)x_final - (double)x_initial) / (double)time;

            Point[] move = new Point[2];
            Pen myPen = new Pen(Color.Pink, 1);
            SolidBrush pinkBomb = new SolidBrush(Color.Pink);

            Rectangle explosionRec = new Rectangle();

            Graphics g = Warzone.CreateGraphics();

            for (int i = 0; i < Math.Abs(y_initial - y_final); i++)
            {
                Thread.Sleep(10);
                x_current -= add;
                y_current -= 1;

                move[0] = new Point(x_initial, y_initial);
                move[1] = new Point(Convert.ToInt32(Math.Round(x_current)), y_current);

                g.DrawLines(myPen, move);
            }



            for (i = 0; i < 5; i++)
            {
                Thread.Sleep(100);
                exR += 4;
                explosionRec.X = move[1].X - 7 - i;
                explosionRec.Y = move[1].Y - 7 - i;
                explosionRec.Size = new Size(exR, exR);
                g.FillPie(pinkBomb, explosionRec, 0, 360);
            }
            g.Clear(Warzone.BackColor);
        }

        public void DrawD()
        {
            int x_initial = Tower3.Location.X+8;
            int y_initial = Tower3.Location.Y;

            int x_final = Val.X;
            int y_final = Val.Y;

            double x_current = (double)x_initial;
            int y_current = y_initial;

            int exR = 5;

            int time = y_final - y_initial;

            double add = ((double)x_final - (double)x_initial) / (double)time;

            Point[] move = new Point[2];
            Pen myPen = new Pen(Color.Pink, 1);
            SolidBrush pinkBomb = new SolidBrush(Color.Pink);

            Rectangle explosionRec = new Rectangle();

            Graphics g = Warzone.CreateGraphics();

            for (int i = 0; i < Math.Abs(y_initial - y_final); i++)
            {
                Thread.Sleep(10);
                x_current -= add;
                y_current -= 1;

                move[0] = new Point(x_initial, y_initial);
                move[1] = new Point(Convert.ToInt32(Math.Round(x_current)), y_current);

                g.DrawLines(myPen, move);
            }



            for (i = 0; i < 5; i++)
            {
                Thread.Sleep(100);
                exR += 4;
                explosionRec.X = move[1].X - 7 - i;
                explosionRec.Y = move[1].Y - 7 - i;
                explosionRec.Size = new Size(exR, exR);
                g.FillPie(pinkBomb, explosionRec, 0, 360);
            }
            g.Clear(Warzone.BackColor);
        }

        //DrawClick would create a drawing from a nearby tower based on the position of the Cursor.
        //I think this one was even more exciting to make since I took calculations of my cursor position and placed it into
        //different outcomes of a seperate thread.
        //Also added an explosion to wherever the point ended up in using DrawPie

        public void DrawClick()
        {
            if (Val.X < 200)
            {
                int x_initial = Tower1.Location.X + 8;
                int y_initial = Tower1.Location.Y;

                int x_final = Val.X;
                int y_final = Val.Y;

                double x_current = (double)x_initial;
                int y_current = y_initial;

                int exR = 5;

                int time = y_final - y_initial;

                double add = ((double)x_final - (double)x_initial) / (double)time;

                Point[] move = new Point[2];
                Pen myPen = new Pen(Color.Pink, 1);
                SolidBrush pinkBomb = new SolidBrush(Color.Pink);

                Rectangle explosionRec = new Rectangle();

                Graphics g = Warzone.CreateGraphics();

                for (int i = 0; i < Math.Abs(y_initial - y_final); i++)         //Abs used to get distance of y, which is my time
                {
                    Thread.Sleep(10);
                    x_current -= add;
                    y_current -= 1;

                    move[0] = new Point(x_initial, y_initial);
                    move[1] = new Point(Convert.ToInt32(Math.Round(x_current)), y_current);

                    g.DrawLines(myPen, move);
                }



                for (i = 0; i < 5; i++)
                {
                    Thread.Sleep(100);
                    exR += 4;
                    explosionRec.X = move[1].X - 7 - i;
                    explosionRec.Y = move[1].Y - 7 - i;
                    explosionRec.Size = new Size(exR, exR);
                    g.FillPie(pinkBomb, explosionRec, 0, 360);
                }
                g.Clear(Warzone.BackColor);

            }

            if (Val.X >= 200 && Val.X <= 350)
            {
                int x_initial = Tower2.Location.X + 8;
                int y_initial = Tower2.Location.Y;

                int x_final = Val.X;
                int y_final = Val.Y;

                double x_current = (double)x_initial;
                int y_current = y_initial;

                int exR = 5;

                int time = y_final - y_initial;

                double add = ((double)x_final - (double)x_initial) / (double)time;

                Point[] move = new Point[2];
                Pen myPen = new Pen(Color.Pink, 1);
                SolidBrush pinkBomb = new SolidBrush(Color.Pink);

                Rectangle explosionRec = new Rectangle();

                Graphics g = Warzone.CreateGraphics();

                for (int i = 0; i < Math.Abs(y_initial - y_final); i++)
                {
                    Thread.Sleep(10);
                    x_current -= add;
                    y_current -= 1;

                    move[0] = new Point(x_initial, y_initial);
                    move[1] = new Point(Convert.ToInt32(Math.Round(x_current)), y_current);

                    g.DrawLines(myPen, move);
                }



                for (i = 0; i < 5; i++)
                {
                    Thread.Sleep(100);
                    exR += 4;
                    explosionRec.X = move[1].X - 7 - i;
                    explosionRec.Y = move[1].Y - 7 - i;
                    explosionRec.Size = new Size(exR, exR);
                    g.FillPie(pinkBomb, explosionRec, 0, 360);
                }
                g.Clear(Warzone.BackColor);
            }
            if (Val.X > 350)
            {
                int x_initial = Tower3.Location.X + 8;
                int y_initial = Tower3.Location.Y;

                int x_final = Val.X;
                int y_final = Val.Y;

                double x_current = (double)x_initial;
                int y_current = y_initial;

                int exR = 5;

                int time = y_final - y_initial;

                double add = ((double)x_final - (double)x_initial) / (double)time;

                Point[] move = new Point[2];
                Pen myPen = new Pen(Color.Pink, 1);
                SolidBrush pinkBomb = new SolidBrush(Color.Pink);

                Rectangle explosionRec = new Rectangle();

                Graphics g = Warzone.CreateGraphics();

                for (int i = 0; i < Math.Abs(y_initial - y_final); i++)
                {
                    Thread.Sleep(10);
                    x_current -= add;
                    y_current -= 1;

                    move[0] = new Point(x_initial, y_initial);
                    move[1] = new Point(Convert.ToInt32(Math.Round(x_current)), y_current);

                    g.DrawLines(myPen, move);
                }



                for (i = 0; i < 5; i++)
                {
                    Thread.Sleep(100);
                    exR += 4;
                    explosionRec.X = move[1].X - 7 - i;
                    explosionRec.Y = move[1].Y - 7 - i;
                    explosionRec.Size = new Size(exR, exR);
                    g.FillPie(pinkBomb, explosionRec, 0, 360);
                }
                g.Clear(Warzone.BackColor);
            }
        }


        #endregion


        
        //
        //
        //
    }
}
