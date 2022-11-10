using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6
{
    public class PredatorAnimal : Animal
    {
        public PredatorAnimal(string name, int maxLifeTime, LevelOfDanger levelOfDanger)
             : base(name, maxLifeTime, levelOfDanger)
        {
        }
    }
}
