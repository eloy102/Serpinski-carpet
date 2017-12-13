using System;
using System.Drawing;
using System.Windows.Forms;

namespace Serpinski
{
    public partial class Form1 : Form
    {
         int width;
         int height;
         Bitmap fractal;
         Graphics graph;

        public Form1()
        {
            InitializeComponent();
            width = FractalPictureBox.Width;
            height = FractalPictureBox.Height;
        }


        private void CarpetButton_Click(object sender, EventArgs e)
        {
            int Level;
            if (textBox1.Text == "") Level = 0;
            else
            Level = Convert.ToInt32(textBox1.Text);
            
            fractal = new Bitmap(width, height);
            graph = Graphics.FromImage(fractal);
            RectangleF carpet = new RectangleF(0, 0, width, height);
            DrawCarpet(Level, carpet);
            FractalPictureBox.BackgroundImage = fractal;
        }

        public PointF MidPoint(PointF p1, PointF p2)
        {
            return new PointF((p1.X + p2.X) / 2f, (p1.Y + p2.Y) / 2f);
        }

        public void DrawCarpet(int level, RectangleF carpet)
        {
            if (level == 0)
            {
                graph.FillRectangle(Brushes.Black, carpet);
            }
            else
            {

                var width = carpet.Width / 3;
                var height = carpet.Height / 3;
                var x1 = carpet.Left;
                var x2 = x1 + width;
                var x3 = x1 + 2 * width;

                var y1 = carpet.Top;
                var y2 = y1 + height;
                var y3 = y1 + 2 * height;

                DrawCarpet(level - 1, new RectangleF(x1, y1, width, height)); // левый 1(верхний)
                DrawCarpet(level - 1, new RectangleF(x2, y1, width, height)); // средний 1
                DrawCarpet(level - 1, new RectangleF(x3, y1, width, height)); // правый 1
                DrawCarpet(level - 1, new RectangleF(x1, y2, width, height)); // левый 2
                DrawCarpet(level - 1, new RectangleF(x3, y2, width, height)); // правый 2
                DrawCarpet(level - 1, new RectangleF(x1, y3, width, height)); // левый 3
                DrawCarpet(level - 1, new RectangleF(x2, y3, width, height)); // средний 3
                DrawCarpet(level - 1, new RectangleF(x3, y3, width, height)); // правый 3
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
