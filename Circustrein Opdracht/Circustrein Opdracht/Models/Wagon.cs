using System.Collections.Generic;

namespace Circustrein_Opdracht
{
    public class Wagon
    {
        private List<Animal> wagonAnimals = new List<Animal>();

        public Wagon(Animal Animal)
        {
            wagonAnimals.Add(Animal);
        }

        public List<Animal> getanimalsInWagon()
        {
            return wagonAnimals;
        }

        public int getBezettingswaarde()
        {
            int bezetting = 0;

            foreach(Animal animal in wagonAnimals)
            {
                bezetting += animal.GetBezettingswaarde();
            }

            return bezetting;
        }
    }
} 