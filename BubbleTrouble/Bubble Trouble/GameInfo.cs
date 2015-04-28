using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Trouble
{
    public class GameInfo
    {
        public int zivoti { get; set; }
        public int poeni { get; set; }
        public int level { get; set; }
        public Image live { get; set; }
        public int X = 791;
        public int Y = 415;

        public GameInfo()
        {
            zivoti = 3;
            poeni = 0;
            level = 1;
            live = Bubble_Trouble.Properties.Resources.heart;
        }

        public void Draw (Graphics g)
        {
            for (int i = 0; i < zivoti*35; i += 35)
            {
                    g.DrawImage(live, X + i, Y , 30, 40);
            }

        }

    }
}
