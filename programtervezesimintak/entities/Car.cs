using programtervezesimintak.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programtervezesimintak.entities
{
    class Car : Toy
    {
        protected override void Drawimage(Graphics g)
        {
            Image x = Image.FromFile("images/car.png");
            g.DrawImage(x, new Rectangle(0, 0, this.Width, this.Height));

        }
    }
}
