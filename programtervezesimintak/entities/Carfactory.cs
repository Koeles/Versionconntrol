using programtervezesimintak.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programtervezesimintak.entities
{
    class Carfactory : Label, IToyfactory
    {
        public Toy CreateNew()
        {
            return new Car();
        }
    }
}
