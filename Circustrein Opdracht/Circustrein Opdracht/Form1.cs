using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Circustrein_Opdracht
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public enum grootteEnum
        {
            groot,
            middel,
            klein
        }

        private int CarnivoorGrootCount;
        private int CarnivoorMiddelCount;
        private int CarnivoorKleinCount;

        private int CarnivoorCount;

        private int HerbivoorGrootCount;
        private int HerbivoorMiddelCount;
        private int HerbivoorKleinCount;

        private int HerbivoorCount;

        private List<Animal> listOfAnimals;

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            listOfAnimals = new List<Animal>();

            SetCounts();
            CarnivoorCreation();
            HerbivoorCreation();

            Trein trein = new Trein(listOfAnimals);
        }

        public void SetCounts()
        {
            CarnivoorGrootCount = Convert.ToInt32(GrootCarnivoorTb.Text);
            CarnivoorMiddelCount = Convert.ToInt32(MiddelCarnivoorTb.Text);
            CarnivoorKleinCount = Convert.ToInt32(KleinCarnivoorTb.Text);

            CarnivoorCount = CarnivoorGrootCount + CarnivoorMiddelCount + CarnivoorKleinCount;

            HerbivoorGrootCount = Convert.ToInt32(GrootHerbivoorTb.Text);
            HerbivoorMiddelCount = Convert.ToInt32(MiddelHerbivoorTb.Text);
            HerbivoorKleinCount = Convert.ToInt32(KleinHerbivoorTb.Text);

            HerbivoorCount = HerbivoorGrootCount + HerbivoorMiddelCount + HerbivoorKleinCount;
        }

        public void CarnivoorCreation()
        {
            //Voeg Carnivoren toe aan lijst
            for (int x = 1; x <= CarnivoorCount; x++)
            {
                if (x <= CarnivoorGrootCount)
                {
                    listOfAnimals.Add(new Carnivoor("grootte"));
                }
                else if (x > CarnivoorGrootCount && x <= (CarnivoorGrootCount + CarnivoorMiddelCount))
                {
                    listOfAnimals.Add(new Carnivoor("middel"));
                }
                else
                {
                    listOfAnimals.Add(new Carnivoor("klein"));
                }

            }
        }

        public void HerbivoorCreation()
        {
            //Voeg Herbivoren toe aan lijst
            for (int x = 1; x <= HerbivoorCount; x++)
            {
                if (x <= HerbivoorGrootCount)
                {
                    listOfAnimals.Add(new Herbivoor("groot"));
                }
                else if (x > HerbivoorGrootCount && x <= (HerbivoorGrootCount + HerbivoorMiddelCount))
                {
                    listOfAnimals.Add(new Herbivoor("middel"));
                }
                else
                {
                    listOfAnimals.Add(new Herbivoor("klein"));
                }
            }

            
        }
    }
}

