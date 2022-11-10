using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6
{
    public class Embryo : Cell
    {
        public Embryo()
            : base()
        {
            Name = string.Empty;
        }

        public Embryo(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
