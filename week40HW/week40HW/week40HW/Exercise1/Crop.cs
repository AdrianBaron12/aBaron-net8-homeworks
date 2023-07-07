using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week40HW.Exercise1
{
    public class Crop
    {
        public string name;
        public string currentStage;

        public string SetCurrentStage(string stage)
        {
            if(stage != "Seed")
            {
                throw new Exception("You cannot do that");
            }
            currentStage = stage;
            return currentStage;
        }

        public Crop()
        {
            currentStage = "Seed";
        }

        public void Water()
        {
            if(currentStage == "Seed")
            {
                currentStage = "Sprout";
            }
            else if(currentStage == "Sprout")
            {
                currentStage = "Plant";
            }else if(currentStage == "Plant")
            {
                currentStage = "CanBeHarvested";
            }
        }
        public void Harvest()
        {
            if (currentStage == "CanBeHarvested")
            {
                currentStage = "Harvested";
                Console.WriteLine("You harvested");
            }
            else
            {
                throw new Exception("You cannot harvest");
            }
        }
    }
}
