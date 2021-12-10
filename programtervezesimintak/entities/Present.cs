using programtervezesimintak.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programtervezesimintak.entities
{
    class Present : Toy
    {
        public SolidBrush Pbrush { get; private set; }

        public Present(Color kivantszin)
        {
            Pbrush = new SolidBrush(kivantszin);

        }

        protected override void Drawimage(Graphics g)
        {
            g.FillRectangle(Pbrush, 0, 0, Width, Height);
          
        }
    }
}
