using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6
{
    public class HerbivorousAnimal : Animal
    {
        public HerbivorousAnimal(string name, int maxLifeTime, string meal)
            : base(name, maxLifeTime, LevelOfDanger.No)
        {
            Meal = meal;
        }

        public string Meal { get; set; }
        public override string ToString()
        {
            return Name + ", max life time: " + MaxLifeTime + " years, level of danger: " + LevelOfDanger + ", meal: " + Meal + " \n";
        }
    }
}
