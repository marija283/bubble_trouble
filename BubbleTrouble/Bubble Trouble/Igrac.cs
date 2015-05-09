using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Trouble
{
    public class Igrac
    {
        public float X { get; set; }
        public float Y { get; set; }
        public Spirala spirala;
        public bool shooted;
        public Image imgGore;
        public Image imgLevo;
        public Image imgDesno;
        public Image imgSegasna;
        

        public Igrac(float x, float y)
        {
            X = x;
            Y = y;
            shooted = false;
            spirala = null;
            imgGore = Bubble_Trouble.Properties.Resources.gore;
            imgLevo = Bubble_Trouble.Properties.Resources.levo;
            imgDesno = Bubble_Trouble.Properties.Resources.desno;
            imgSegasna = imgGore;

        }

        public void moveLeft(Rectangle bounds)
        {
            if (X > 0) 
               X -= 20;
        }

        public void moveRight(Rectangle bounds)
        {
            if (X < bounds.Right - 40)
               X += 20;
        }

        // crtanje na coveceto
        public void Draw(Graphics g)
        {
            if (shooted)
                spirala.Draw(g);
            //Brush brush = new SolidBrush(Color.Black);
            g.DrawImage(imgSegasna, (int)X, (int)Y, 50,50);
            //brush.Dispose();
        }

        public bool Shot()
        {
            if (!shooted)  
            {
                shooted = true;
                spirala = new Spirala();
                spirala.AddTocka(new Point((int)X + 20, (int)Y + 45));
                spirala.AddTocka(new Point((int)X + 21, (int)Y + 45));
                return true;
            }
            return false;
        }

        public bool isTouched(Point p, int rad) 
        {
            //double d = Math.Sqrt((X + 25 - p.X) * (X + 25 - p.X) + (Y + 25 - p.Y) * (Y + 25 - p.Y));
            return (Math.Sqrt((X + 25 - p.X) * (X + 25 - p.X) + (Y + 25 - p.Y) * (Y + 25 - p.Y))) <= 25 + rad; 
        }
    }
}
