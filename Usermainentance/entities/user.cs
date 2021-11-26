using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usermainentance.entities
{
    class user
    {
        public Guid guid { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string Lastname { get; set; }

       
        public string Fullname
        {
            get { return Lastname + " " + FirstName; }
        }
    }
}
