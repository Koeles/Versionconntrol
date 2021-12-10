using programtervezesimintak.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programtervezesimintak.entities
{
   public class Ball: Toy
    {

        public SolidBrush Ballbrush { get; private set; }

        public Ball(Color kivantszin)
        {
            Ballbrush = new SolidBrush(kivantszin);

        }
        protected override void Drawimage(Graphics g)
        {
            g.FillEllipse( Ballbrush, 0, 0, Width, Height);
        }

    }
}
