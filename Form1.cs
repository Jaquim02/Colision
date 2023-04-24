using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WindowsFormsAppColision
{
    public partial class Form1 : Form
    {
        int count;
        private Bitmap bitmap;
        static Graphics graphics;
        ball[] balls;
        public int boundY = 0, boundX = 0, boundX0, boundY0;
        Boolean left;
        Boolean right;
        Boolean up;

        public Form1()
        {
            InitializeComponent();

            count = 0;
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);

            pictureBox1.Image = bitmap;

            // Crear las 25 pelotas
            balls = new ball[25];
            for (int i = 0; i < balls.Length; i++)
            {
                balls[i] = new ball();
            }

            // Suscribirse al evento Paint del PictureBox
            pictureBox1.Paint += new PaintEventHandler(pictureBox1_Paint);
        }



        // Evento Paint del PictureBox
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Dibujar cada pelota
            for (int i = 0; i < balls.Length; i++)
            {
                SolidBrush brush = new SolidBrush(balls[i].color);
                e.Graphics.FillEllipse(brush, balls[i].x, balls[i].y, balls[i].diameter, balls[i].diameter);
                balls[i].update(pictureBox1.Width - balls[i].diameter, pictureBox1.Height - balls[i].diameter, 0, 0);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Forzar el redibujado del PictureBox para llamar al evento Paint
            pictureBox1.Invalidate();
            count++;
        }
    }
}


