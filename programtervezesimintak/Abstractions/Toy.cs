using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programtervezesimintak.Abstractions
{
    public abstract class Toy :Label
    {


        public Toy()
        {
            AutoSize = false;
            Width = Height = 50;
            Paint += Toy_Paint;
        }

        private void Toy_Paint(object sender, PaintEventArgs e)
        {
            Drawimage(this.CreateGraphics());
        }

        protected abstract void Drawimage(Graphics g);
    

        public void MoveToy()
        {
            Left++;
        }
    }
}
