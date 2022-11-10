using System;
using System.IO;

namespace Module2HW6
{
    public class Starter
    {
        public static void Run()
        {
            FullForest();
            Console.WriteLine("\n\n-Animals sorted by danger:-\n" + Forest.GetInstance().SortByDanger().FormatAnimalsArray());
            Console.WriteLine("\n-Average lifetime-\n" + Forest.GetInstance().Animals.GetAverageLifeTime());
            Console.WriteLine("\n-Animals with bigger than average lifetime-\n" + Forest.GetInstance().FindCosmeticsWithBiggestLifeTime().FormatAnimalsArray());
            Console.WriteLine("\n-Animals with name \"Deer\"-\n" + Forest.GetInstance().GetByName("Deer").FormatAnimalsArray());
            Console.WriteLine("\n-Animals with name \"Dog\"-\n" + Forest.GetInstance().GetByName("Dog").FormatAnimalsArray());

            Console.WriteLine("\n-Observing animals-");
            ILive live = (ILive)Forest.GetInstance().GetByName("Deer")[0];
            Console.WriteLine("Observing deer: " + live.Live());
            IKill kill = (IKill)Forest.GetInstance().GetByName("Lion")[0];
            Console.WriteLine("Observing lion: " + kill.Kill());
            IParasitize parasitize = (IParasitize)Forest.GetInstance().GetByName("Flea")[0];
            Console.WriteLine("Observing flea: " + parasitize.Parasitize());
        }

        public static Animal[] FullForest()
        {
            var father = new CarnivorousPredator("Tiger", 15, LevelOfDanger.High, "Antelope");
            var child = father.Copy();

            Animal[] animals =
            {
                new CarnivorousPredator("Lion", 30, LevelOfDanger.High, "Goat"),
                new CarnivorousPredator("Dog", 20, LevelOfDanger.Low, "Chicken"),
                new ParasitePredator("Flea", 1, LevelOfDanger.Medium, "Cat"),
                new HerbivorousAnimal("Deer", 5, "Grass"),
                child
            };

            Forest.GetInstance().Animals = animals;
            Console.Write(Forest.GetInstance().ToString());

            return Forest.GetInstance().Animals;
        }
    }
}
