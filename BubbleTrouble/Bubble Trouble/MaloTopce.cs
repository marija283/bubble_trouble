using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Trouble
{
    public class MaloTopce : Topce
    {
       public MaloTopce(float x, float y, float angle):base(x,y,15,angle)
        {
            Radius = 18;
        }
        public override void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color.Red);
            g.FillEllipse(brush, X - Radius, Y - Radius, Radius * 2, Radius * 2);
            brush.Dispose();

        }
    }
}
