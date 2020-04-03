using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein_Opdracht
{
    public class Herbivoor : Animal
    {
        private string Soort { get; }

        public Herbivoor(string soort) => Soort = soort;

        public override int GetBezettingswaarde()
        {
            switch (Soort)
            {
                case "groot":
                    return 5;
                case "middel":
                    return 3;
                case "klein":
                    return 1;
            }

            return 0;
        }

        public override string GetSoort()
        {
            return "Herbivoor";
        }
    }
}
