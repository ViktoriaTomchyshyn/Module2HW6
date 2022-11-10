using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Module2HW6
{
    public class Forest
    {
        private static Forest _instance;
        private Animal[] _animals;

        private Forest()
        {
            _animals = null;
        }

        public Animal[] Animals
        {
            get { return _animals; }
            set { _animals = value; }
        }

        public static Forest GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Forest();
            }

            return _instance;
        }

        public Embryo[] GetAnimals()
        {
            return _animals;
        }

        public Embryo GetAnimal(int id)
        {
            return _animals[id - 1];
        }

        public Animal[] SortByDanger()
        {
            Animal temp;
            for (int j = 0; j <= _animals.Length - 2; j++)
            {
                for (int i = 0; i <= _animals.Length - 2; i++)
                {
                    if (_animals[i].CompareTo(_animals[i + 1]) > 0)
                    {
                        temp = _animals[i + 1];
                        _animals[i + 1] = _animals[i];
                        _animals[i] = temp;
                    }
                }
            }

            return _animals;
        }

        public override string ToString()
        {
            string result = "---Animals in the forest---\n";
            foreach (var item in _animals)
            {
                result += item.ToString();
            }

            return result;
        }
    }
}
