using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6
{
    public class Animal : Embryo, IComparable<Animal>
    {
       public Animal(string name, int maxLifeTime, LevelOfDanger levelOfDanger)
            : base(name)
        {
            MaxLifeTime = maxLifeTime;
            LevelOfDanger = levelOfDanger;
        }

       public int MaxLifeTime { get; set; }
       public LevelOfDanger LevelOfDanger { get; set; }
       public int CompareTo(Animal other)
        {
            if (other == null)
            {
                return 1;
            }

            return LevelOfDanger.CompareTo(other.LevelOfDanger);
        }

       public Animal Copy()
        {
            return (Animal)MemberwiseClone();
        }
    }
}
