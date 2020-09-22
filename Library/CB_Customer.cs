using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class CB_Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Lastname { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }
        public bool Deleted { get; set; }


        public override string ToString()
        {
            return Name+" "+Lastname;
        }
    }
}
