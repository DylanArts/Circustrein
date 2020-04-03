using System.Collections.Generic;
using System.Linq;

namespace Circustrein_Opdracht
{
    public class Trein
    {
        private List<Animal> AnimalList { get; }
        private List<Wagon> wagonCache = new List<Wagon>();

        public Trein(IEnumerable<Animal> animalList)
        {
            AnimalList = animalList.ToList();
            sorteerWagons();
        }

        int bezetting = 0;

        public void sorteerWagons()
        {
            foreach(Animal animal in AnimalList)
            {
                if(bezettingCheck(animal.GetSoort(), animal.GetBezettingswaarde()))
                {
                    //Animal aan wagon toevoegen
                }
                else
                {
                    //Nieuwe wagon maken
                }

            }

        }

        public bool bezettingCheck(string soort, int bezetting)
        {
            //Hier komt validatie
            return true;
        }
    }
}
