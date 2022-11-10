using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6
{
    public class CarnivorousPredator : PredatorAnimal, IKill
    {
        public CarnivorousPredator(string name, int maxLifeTime, LevelOfDanger levelOfDanger, string lastVictim)
            : base(name, maxLifeTime, levelOfDanger)
        {
            LastVictim = lastVictim;
        }

        public string LastVictim { get; set; }

        public string Kill()
        {
            return "Hehe, I`ve just killed " + LastVictim;
        }

        public override string ToString()
        {
            return Name + ", max life time: " + MaxLifeTime + " years, level of danger: " + LevelOfDanger + ", last victim: " + LastVictim + " \n";
        }
    }
}
