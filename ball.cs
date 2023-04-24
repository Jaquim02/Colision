using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppColision
{
    public class ball
    {
        Random rdan= new Random();
        public int x;
        public int y;
        public int diameter;
        public Point speed;
        public Color color;


        public ball()
        {
            this.x = rdan.Next(3,70);
            this.y = rdan.Next(43, 80);
            this.diameter = rdan.Next(5, 30);
            this.color = Color.Blue;
            speed.X = rdan.Next(4, 65);
            speed.Y = rdan.Next(4, 7);
        }

        
            public void update(int boundX, int boundY, int boundX0, int boundY0)
            {
                this.x += speed.X;
                this.y += speed.Y;

                if (this.x + diameter > boundX)
                {
                    this.speed.X = -Math.Abs(speed.X); // cambia la dirección horizontal de la velocidad de la bola
                    this.x = boundX - diameter; // coloca la bola justo en la línea de límite
                }
                else if (this.x < boundX0)
                {
                    this.speed.X = Math.Abs(speed.X);
                    this.x = boundX0;
                }

                if (this.y + diameter > boundY)
                {
                    this.speed.Y = -Math.Abs(speed.Y); // cambia la dirección vertical de la velocidad de la bola
                    this.y = boundY - diameter;
                }
                else if (this.y < boundY0)
                {
                    this.speed.Y = Math.Abs(speed.Y);
                    this.y = boundY0;
                }
            

        }


    }
}
