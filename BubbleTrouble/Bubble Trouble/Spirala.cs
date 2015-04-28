using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Trouble
{
   public  class Spirala
    {
       public List<Point> tocki;
       public Point posledna;
       public Point prva;

       public Spirala()
       {

           tocki = new List<Point>();
           posledna = Point.Empty;
           prva = Point.Empty;
       }

       public void AddTocka(Point p)
       {
           if (posledna == Point.Empty)
           {
               posledna = p;
               prva = p;
           }
           else
               posledna = tocki.ElementAt(tocki.Count - 1);

           tocki.Add(p);

       }

       public void Draw(Graphics g)
       {
           Pen penkalo = new Pen(Color.Green, 2);

           Point[] array = tocki.ToArray();
           g.DrawCurve(penkalo, array);
           
           Point krajna = tocki.ElementAt(tocki.Count-1);

           Pen penkalo2 = new Pen(Color.Red, 3);
           g.DrawLine(penkalo2, krajna, new Point(krajna.X - 10, krajna.Y + 10));
           g.DrawLine(penkalo2, krajna, new Point(krajna.X + 10, krajna.Y + 10));
           
           penkalo.Dispose();
           penkalo2.Dispose();

       }
    }
}
