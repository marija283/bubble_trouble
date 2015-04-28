using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bubble_Trouble
{
    public class Document
    {
        public List<Topce> Topcinja;
        public Igrac igrac;

        public Document(int lvl) 
        {
            Topcinja = new List<Topce>();
            if(lvl == 1)
                Topcinja.Add(new GolemoTopce((float)60, (float)60, (float)Math.PI / 4));
            if (lvl == 2)
            {
                Topcinja.Add(new GolemoTopce((float)400, (float)60, (float)Math.PI / 4));
                Topcinja.Add(new SrednoTopce((float)60, (float)60, (float)Math.PI / 4));
                Topcinja.Add(new SrednoTopce((float)850, (float)60, (float)Math.PI / 4));

            }
            if (lvl == 3)
            {
                Topcinja.Add(new GolemoTopce((float)60, (float)60, (float)Math.PI / 4));
                Topcinja.Add(new GolemoTopce((float)850, (float)60, (float)Math.PI / 4));
            }

        }

     
        public void AddMalo(Point point)
        {
            Topcinja.Add(new MaloTopce((float)point.X, (float)point.Y, (float)Math.PI / 4));
            Topcinja.Add(new MaloTopce((float)point.X, (float)point.Y, (float)(2 * Math.PI / 3)));
        }

        public void AddSredno(Point point)
        {
            Topcinja.Add(new SrednoTopce((float)point.X, (float)point.Y, (float) Math.PI / 4));
            Topcinja.Add(new SrednoTopce((float)point.X, (float)point.Y, (float)( 2*Math.PI/3) ));
        }


        public void Draw(Graphics g)
        {
            foreach (Topce t in Topcinja)
            {
                t.Draw(g);
            }
            igrac.Draw(g);
        }

        public void Move(Rectangle bounds) 
        {
            foreach (Topce t in Topcinja)
            {
                t.Move(bounds);
            }
        
        }

        // dali e pogodeno topce so pistolot
        public bool isHit(Point p)
        {
                foreach (Topce t in Topcinja)
                {
                    if (t.isHit(p))
                    {
                        igrac.shooted = false;
                        
                        if (t is GolemoTopce)
                            AddSredno(new Point((int)t.X,(int)t.Y));
                        else if (t is SrednoTopce)
                            AddMalo(new Point((int)t.X, (int)t.Y));

                        Topcinja.Remove(t);

                        return true ;
                    }
                }
                return false;

        }


        public bool proveriPogodok()
        {
            foreach (Point p in igrac.spirala.tocki)
                if (igrac.shooted)
                    if (isHit(p))
                        return true;
            return false;
        }

        // igracot dali e dopren so nekoja topka
        public bool isTouched()
        {
            foreach (Topce t in Topcinja) 
            {
                if (igrac.isTouched(new Point((int)t.X, (int)t.Y), (int) t.Radius))
                    return true;
            }
            return false;
        }

        
        // postavuvanje na igracot
        public void setIgrac(float X,float Y)
        {
            igrac = new Igrac(X, Y);
        }
    }
}
