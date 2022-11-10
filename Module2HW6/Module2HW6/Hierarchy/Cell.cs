using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6
{
    public abstract class Cell : ILive
    {
        public string Live()
        {
            return "I`m alive";
        }
    }
}
