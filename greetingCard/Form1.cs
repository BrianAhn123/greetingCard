using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace greetingCard
{
    public partial class Form1 : Form
    {
            Graphics g;
            Pen darkgoldPen = new Pen(Color.DarkGoldenrod, 10);
            Pen whitePen = new Pen(Color.White);
            Pen goldPen = new Pen(Color.Goldenrod);
            Pen silverPen = new Pen(Color.Silver);
            SolidBrush silverBrush = new SolidBrush(Color.Silver);
            SolidBrush goldBrush = new SolidBrush(Color.Goldenrod);
            SolidBrush darkgoldBrush = new SolidBrush(Color.DarkGoldenrod);
            public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
           

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
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.Black);
            g.DrawEllipse(silverPen, 550, 20, 40, 40);
            g.FillEllipse(silverBrush, 550, 20, 40, 40);
            g.TranslateTransform(555, -15);
            g.RotateTransform(45);
            g.DrawEllipse(silverPen, 540, 40, 20, 60);
            g.FillEllipse(silverBrush, 40, 40, 20, 60);
            g.ResetTransform();
            for (int i = 0; i <= 19; i++)
            {
                
            }
        }
    }
}
