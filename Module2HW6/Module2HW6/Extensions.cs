using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6
{
    public static class Extensions
    {
        public static Animal[] FindCosmeticsWithBiggestLifeTime(this Forest forest)
        {
            int quantity = 0;
            foreach (var item in forest.Animals)
            {
                if (item.MaxLifeTime > forest.Animals.GetAverageLifeTime())
                {
                    quantity++;
                }
            }

            Animal[] result = new Animal[quantity];

            int k = 0;

            foreach (var item in forest.Animals)
            {
                if (item.MaxLifeTime > forest.Animals.GetAverageLifeTime())
                {
                    result[k] = item;
                    k++;
                }
            }

            return result;
        }

        public static Animal[] GetByName(this Forest forest, string name)
        {
            int quantity = 0;
            foreach (var item in forest.Animals)
            {
                if (item.Name.CompareTo(name) == 0)
                {
                    quantity++;
                }
            }

            Animal[] result = new Animal[quantity];

            int k = 0;

            foreach (var item in forest.Animals)
            {
                if (item.Name.CompareTo(name) == 0)
                {
                    result[k] = item;
                    k++;
                }
            }

            return result;
        }

        public static string FormatAnimalsArray(this Animal[] animals)
        {
            string result = string.Empty;
            foreach (var item in animals)
            {
                result += item.ToString();
            }

            return result;
        }

        public static double GetAverageLifeTime(this Animal[] animals)
        {
            float sum = 0;
            foreach (var a in animals)
            {
                sum += a.MaxLifeTime;
            }

            return Math.Round(sum / animals.Length, 2);
        }
    }
}
