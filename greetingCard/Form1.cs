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
using System.Media;

namespace greetingCard
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen darkgoldPen = new Pen(Color.DarkGoldenrod, 10);
        Pen whitePen = new Pen(Color.White);
        Pen goldPen = new Pen(Color.Goldenrod);
        Pen silverPen = new Pen(Color.Silver);
        Pen redPen = new Pen(Color.Red);
        SolidBrush silverBrush = new SolidBrush(Color.Silver);
        SolidBrush goldBrush = new SolidBrush(Color.Goldenrod);
        SolidBrush darkgoldBrush = new SolidBrush(Color.DarkGoldenrod);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush graybrush = new SolidBrush(Color.Gray);
        SolidBrush darkGrayBrush = new SolidBrush(Color.DarkGray);
        Font greeting = new Font("Arial", 20, FontStyle.Bold);
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {

            //Flower on the card
            g.Clear(Color.Black);
            g.DrawEllipse(goldPen, 280, 20, 30, 170);
            g.DrawEllipse(goldPen, 280, 200, 30, 170);
            g.DrawEllipse(goldPen, 300, 180, 170, 30);
            g.DrawEllipse(goldPen, 280, 180, 30, 30);
            g.DrawEllipse(goldPen, 120, 180, 170, 30);
            g.FillEllipse(goldBrush, 280, 180, 30, 30);
            g.FillEllipse(goldBrush, 280, 20, 30, 170);
            g.FillEllipse(goldBrush, 280, 200, 30, 170);
            g.FillEllipse(goldBrush, 300, 180, 170, 30);
            g.FillEllipse(goldBrush, 120, 180, 170, 30);

            g.TranslateTransform(215, -170);
            g.RotateTransform(45);
            g.DrawEllipse(goldPen, 300, 20, 30, 170);
            g.FillEllipse(goldBrush, 300, 20, 30, 170);
            g.ResetTransform();

            g.TranslateTransform(80, -35);
            g.RotateTransform(45);
            g.DrawEllipse(goldPen, 300, 20, 30, 170);
            g.FillEllipse(goldBrush, 300, 20, 30, 170);
            g.ResetTransform();

            g.TranslateTransform(523, -23);
            g.RotateTransform(135);
            g.DrawEllipse(goldPen, 300, 20, 30, 170);
            g.FillEllipse(goldBrush, 300, 20, 30, 170);
            g.ResetTransform();

            g.TranslateTransform(660, 115);
            g.RotateTransform(135);
            g.DrawEllipse(goldPen, 300, 20, 30, 170);
            g.FillEllipse(goldBrush, 300, 20, 30, 170);
            g.ResetTransform();

            g.TranslateTransform(360, -170);
            g.RotateTransform(67);
            g.DrawEllipse(goldPen, 300, 20, 30, 170);
            g.FillEllipse(goldBrush, 300, 20, 30, 170);
            g.ResetTransform();

            g.TranslateTransform(175, -95);
            g.RotateTransform(67);
            g.DrawEllipse(goldPen, 300, 20, 30, 170);
            g.FillEllipse(goldBrush, 300, 20, 30, 170);
            g.ResetTransform();

            g.TranslateTransform(420, -95);
            g.RotateTransform(113);
            g.DrawEllipse(goldPen, 300, 20, 30, 170);
            g.FillEllipse(goldBrush, 300, 20, 30, 170);
            g.ResetTransform();

            g.TranslateTransform(600, -20);
            g.RotateTransform(113);
            g.DrawEllipse(goldPen, 300, 20, 30, 170);
            g.FillEllipse(goldBrush, 300, 20, 30, 170);
            g.ResetTransform();

            g.TranslateTransform(590, 80);
            g.RotateTransform(157);
            g.DrawEllipse(goldPen, 300, 20, 30, 170);
            g.FillEllipse(goldBrush, 300, 20, 30, 170);
            g.ResetTransform();

            g.TranslateTransform(660, 250);
            g.RotateTransform(157);
            g.DrawEllipse(goldPen, 300, 20, 30, 170);
            g.FillEllipse(goldBrush, 300, 20, 30, 170);
            g.ResetTransform();

            g.TranslateTransform(80, -110);
            g.RotateTransform(23);
            g.DrawEllipse(goldPen, 300, 20, 30, 170);
            g.FillEllipse(goldBrush, 300, 20, 30, 170);
            g.ResetTransform();

            g.TranslateTransform(10, 65);
            g.RotateTransform(23);
            g.DrawEllipse(goldPen, 300, 20, 30, 170);
            g.FillEllipse(goldBrush, 300, 20, 30, 170);
            g.ResetTransform();
            g.FillEllipse(darkgoldBrush, 265, 170, 60, 60);
            g.DrawString("HAPPY ANNIVERSARY LUCAS", greeting, silverBrush, 100, 200);

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            SoundPlayer clap = new SoundPlayer(Properties.Resources.clap);
            clap.Play();

            fireworks();
            fireworksblow();
            fireworks2();
            fireworks2blow();
            ending();



        }
        public void fireworks()
        {
            for (int i = 0; i <= 25; i++)
            {
                //base
                g.Clear(Color.Navy);
                g.FillEllipse(whiteBrush, 250, 10, 60, 60);
                g.FillRectangle(darkGrayBrush, 10, 200, 100, 200);
                g.FillRectangle(darkGrayBrush, 110, 250, 100, 200);
                g.FillRectangle(darkGrayBrush, 210, 200, 100, 200);
                g.FillRectangle(darkGrayBrush, 310, 270, 100, 200);
                g.FillRectangle(darkGrayBrush, 410, 180, 100, 200);

                //first firework shooting up in the sky
                g.FillRectangle(graybrush, 0, 300, 600, 150);
                g.FillEllipse(redBrush, 50, 250 - i * 10, 20, 60);
                g.DrawString("HAPPY 16th ANNIVERSARY", greeting, goldBrush, 100, 180);
                Thread.Sleep(100);
                Refresh();
            }
        }

        public void fireworksblow()
        {
            for (int i = 0; i <= 25; i++)
            {
                //base
                g.Clear(Color.Navy);
                g.FillEllipse(whiteBrush, 250, 10, 60, 60);
                g.FillRectangle(darkGrayBrush, 10, 200, 100, 200);
                g.FillRectangle(darkGrayBrush, 110, 250, 100, 200);
                g.FillRectangle(darkGrayBrush, 210, 200, 100, 200);
                g.FillRectangle(darkGrayBrush, 310, 270, 100, 200);
                g.FillRectangle(darkGrayBrush, 410, 180, 100, 200);
                g.FillRectangle(graybrush, 0, 300, 600, 150);
                g.DrawString("HAPPY 16th ANNIVERSARY", greeting, goldBrush, 100, 180);


                //firework blowing up
                g.RotateTransform(20);
                g.DrawLine(redPen, 500, 200 - i * 10, 100, 10);
                g.ResetTransform();

                g.RotateTransform(40);
                g.DrawLine(redPen, 500, 200 - i * 10, 100, 10);
                g.ResetTransform();

                g.RotateTransform(60);
                g.DrawLine(redPen, 500, 200 - i * 10, 100, 10);
                g.ResetTransform();

                g.RotateTransform(80);
                g.DrawLine(redPen, 500, 200 - i * 10, 100, 10);
                g.ResetTransform();

                g.RotateTransform(100);
                g.DrawLine(redPen, 500, 200 - i * 10, 100, 10);
                g.ResetTransform();

                g.RotateTransform(120);
                g.DrawLine(redPen, 500, 200 - i * 10, 100, 10);
                g.ResetTransform();

                g.RotateTransform(140);
                g.DrawLine(redPen, 500, 200 - i * 10, 100, 10);
                g.ResetTransform();

                g.RotateTransform(160);
                g.DrawLine(redPen, 500, 200 - i * 10, 100, 10);
                g.ResetTransform();

                g.RotateTransform(180);
                g.DrawLine(redPen, 500, 200 - i * 10, 100, 10);
                g.ResetTransform();

                g.RotateTransform(200);
                g.DrawLine(redPen, 500, 200 - i * 10, 100, 10);
                g.ResetTransform();

                g.RotateTransform(220);
                g.DrawLine(redPen, 500, 200 - i * 10, 100, 10);
                g.ResetTransform();

                g.RotateTransform(240);
                g.DrawLine(redPen, 500, 200 - i * 10, 100, 10);
                g.ResetTransform();

                g.RotateTransform(260);
                g.DrawLine(redPen, 500, 200 - i * 10, 100, 10);
                g.ResetTransform();

                g.RotateTransform(280);
                g.DrawLine(redPen, 500, 200 - i * 10, 100, 10);
                g.ResetTransform();

                g.RotateTransform(300);
                g.DrawLine(redPen, 500, 200 - i * 10, 100, 10);
                g.ResetTransform();

                g.RotateTransform(320);
                g.DrawLine(redPen, 500, 200 - i * 10, 100, 10);
                g.ResetTransform();

                g.RotateTransform(340);
                g.DrawLine(redPen, 500, 200 - i * 10, 100, 10);
                g.ResetTransform();

                g.RotateTransform(360);
                g.DrawLine(redPen, 500, 200 - i * 10, 100, 10);
                g.ResetTransform();


                Thread.Sleep(100);
                Refresh();
            }
        }

        public void fireworks2()
        {
            for (int i = 0; i <= 25; i++)
            {
                //base
                g.Clear(Color.Navy);
                g.FillEllipse(whiteBrush, 250, 10, 60, 60);
                g.FillRectangle(darkGrayBrush, 10, 200, 100, 200);
                g.FillRectangle(darkGrayBrush, 110, 250, 100, 200);
                g.FillRectangle(darkGrayBrush, 210, 200, 100, 200);
                g.FillRectangle(darkGrayBrush, 310, 270, 100, 200);
                g.FillRectangle(darkGrayBrush, 410, 180, 100, 200);

                //second firework shoots on other side of card
                g.FillRectangle(graybrush, 0, 300, 600, 150);
                g.FillEllipse(redBrush, 450, 250 - i * 10, 20, 60);
                g.DrawString("HAPPY 16th ANNIVERSARY", greeting, goldBrush, 100, 180);
                Thread.Sleep(100);
                Refresh();
            }
        }

        public void fireworks2blow()
        {
            for (int i = 0; i <= 25; i++)
            {
                //base
                g.Clear(Color.Navy);
                g.FillEllipse(whiteBrush, 250, 10, 60, 60);
                g.FillRectangle(darkGrayBrush, 10, 200, 100, 200);
                g.FillRectangle(darkGrayBrush, 110, 250, 100, 200);
                g.FillRectangle(darkGrayBrush, 210, 200, 100, 200);
                g.FillRectangle(darkGrayBrush, 310, 270, 100, 200);
                g.FillRectangle(darkGrayBrush, 410, 180, 100, 200);
                g.FillRectangle(graybrush, 0, 300, 600, 150);
                g.DrawString("HAPPY 16th ANNIVERSARY", greeting, goldBrush, 100, 180);

                //Image firework
                g.DrawLine(redPen, 500 - i * 10, 200 - i * 10, 500 - i * 10, 10);
                g.DrawLine(redPen, 500 - i * 10, 200 - i * 10, 500, 10);
                g.DrawLine(redPen, 500, 200 - i * 10, 500 - i * 10, 10);
                g.DrawLine(redPen, 500 - i * 10, 200 - i * 10, 500, 10 - i * 10);
                g.DrawLine(redPen, 500, 200 - i * 10, 500, 10);
                g.DrawLine(redPen, 500, 200 - i * 10, 500 - i * 10, 10);
                g.DrawLine(redPen, 500, 200 - i * 10, 500, 10);
                g.DrawLine(redPen, 500, 200 - i * 10, 500, 10);
                g.DrawLine(redPen, 500 - i * 10, 200 - i * 10, 500 - i * 10, 10);
                g.DrawLine(redPen, 500, 200 - i * 10, 500, 10);
                g.DrawLine(redPen, 500, 200 - i * 10, 500, 10);
                g.DrawLine(redPen, 500, 200 - i * 10, 500 - i * 10, 10);

                Thread.Sleep(100);
                Refresh();
            }
        }

        public void ending()
        {
            for (int i = 0; i <= 25; i++)
            {
                //base
                g.Clear(Color.Navy);
                g.FillEllipse(whiteBrush, 250, 10, 60, 60);
                g.FillRectangle(darkGrayBrush, 10, 200, 100, 200);
                g.FillRectangle(darkGrayBrush, 110, 250, 100, 200);
                g.FillRectangle(darkGrayBrush, 210, 200, 100, 200);
                g.FillRectangle(darkGrayBrush, 310, 270, 100, 200);
                g.FillRectangle(darkGrayBrush, 410, 180, 100, 200);
                g.FillRectangle(graybrush, 0, 300, 600, 150);
                g.DrawString("CONGRATS ON 16 YEARS", greeting, goldBrush, 70, 180);

                //confetti/Lasers
                g.DrawLine(redPen, 500 - i * 10, 200 - i * 10, 500, 10);
                g.DrawLine(whitePen, 300 - i * 10, 200 - i * 10, 500, 10);
                g.DrawLine(goldPen, 520 - i * 10, 200 - i * 10, 500, 10);
                g.DrawLine(silverPen, 350 - i * 10, 200 - i * 10, 500, 10);
                g.DrawLine(redPen, 200 - i * 10, 200 - i * 10, 500, 10);
                g.DrawLine(redPen, 420 - i * 10, 200 - i * 10, 500, 10);
                g.DrawLine(redPen, 600 - i * 10, 200 - i * 10, 500, 10);
                g.DrawLine(whitePen, 200 - i * 10, 200 - i * 10, 500, 10);
                g.DrawLine(redPen, 150 - i * 10, 200 - i * 10, 500, 10);
                g.DrawLine(goldPen, 100 - i * 10, 200 - i * 10, 500, 10);



                Thread.Sleep(100);
                Refresh();
            }
        }
    }
}


