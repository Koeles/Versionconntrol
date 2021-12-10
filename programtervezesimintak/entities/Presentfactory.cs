using programtervezesimintak.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programtervezesimintak.entities
{
    class Presentfactory : IToyfactory
    {
        public Color PColor { get;  set; }
        public Toy CreateNew()
        {
            return new Present(PColor);
        }
    }
}
