using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6
{
    public class ParasitePredator : PredatorAnimal, IParasitize
    {
        public ParasitePredator(string name, int maxLifeTime, LevelOfDanger levelOfDanger, string parasitizedAnimal)
                 : base(name, maxLifeTime, levelOfDanger)
        {
            ParasitizedAnimal = parasitizedAnimal;
        }

        public string ParasitizedAnimal { get; set; }

        public string Parasitize()
        {
           return "I'm parasitizing on " + ParasitizedAnimal;
        }

        public override string ToString()
        {
            return Name + ", max life time: " + MaxLifeTime + " years, level of danger: " + LevelOfDanger + ", last victim: " + ParasitizedAnimal + " \n";
        }
    }
}
