using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Trouble
{
    public class GolemoTopce:Topce
    {
        public GolemoTopce(float x, float y, float angle):base(x,y,5,angle)
        {
            Radius = 50;
          
        }
        public override void Draw(Graphics g) 
        {
            Brush brush = new SolidBrush(Color.Blue);
            g.FillEllipse(brush, X - Radius, Y - Radius, Radius * 2, Radius * 2);
            brush.Dispose();
        
        }
    }
}
