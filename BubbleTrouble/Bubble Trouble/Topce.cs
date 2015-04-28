using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Trouble
{
    public abstract class Topce
    {
        public float X { get; set; }
        public float Y { get; set; }

        public float Radius { get; set; }

        public float Velocity { get; set; }
        public float Angle { get; set; }


        private float velocityX;
        private float velocityY;



        public Topce(float x, float y, float v,float angle)
        {
            X = x;
            Y = y;
            Angle = angle;
            Velocity = v;
            velocityX = (float)Math.Cos(Angle) * Velocity;
            velocityY = - (float)Math.Sin(Angle) * Velocity;
        }

        public abstract void Draw(Graphics g);

        public bool isHit(Point p) 
        {
            double d = Math.Sqrt((X - p.X) * (X - p.X) + (Y - p.Y) * (Y - p.Y));
            return d <= Radius; 
        }

        public void Move(Rectangle Bounds) 
        {
            
            float nextX = X + velocityX;
            float nextY = Y + velocityY;
            if (nextX - Radius <= Bounds.Left || (nextX + Radius >= Bounds.Right))
            {
                velocityX = -velocityX;
            }
            if (nextY - Radius <= Bounds.Top || (nextY + Radius >= Bounds.Bottom))
            {
                velocityY = -velocityY;
            }
            X += velocityX;
            Y += velocityY;
            
       
        
        }
        

    
    }
}
