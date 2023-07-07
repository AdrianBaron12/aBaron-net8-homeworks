using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week40.Animal1
{
    public class Animal
    {
        public string Name;
        public string Species;
        public string Breed;
        public int Age;
        public string Color;
        public double Weight;
        public bool IsSpayedOrNeutered;

        public Animal(string name, string breed, string species, int age, string color, double weight, bool isSpayedOrNeutered)
        {
            Name = name;
            Breed = breed;
            Species = species;
            Age = age;
            Color = color;
            Weight = weight;
            IsSpayedOrNeutered = isSpayedOrNeutered;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetBreed()
        {
            return Breed;
        }

        public string GetSpecies()
        {
            return Species;
        }
        public int GetAge()
        {
            return Age;
        }
        public string GetColor()
        {
            return Color;
        }
        public double GetWeight()
        {
            return Weight;
        }
        public bool GetIsSpayedOrNeutered()
        {
            return IsSpayedOrNeutered;
        }

        public void SetName(string name)
        {
            Name = name;
        }
        public void SetSpecies(string species)
        {
            Species = species;
        }

        public void SetBreed(string breed)
        {
            Breed = breed;
        }

        public void SetAge(int age)
        {
            Age = age;
        }

        public void SetColor(string color)
        {
            Color = color;
        }

        public void SetWeight(double weight)
        {
            Weight = weight;
        }

        public void SetIsSpayedOrNeutered(bool isSpayedOrNeutered)
        {
            IsSpayedOrNeutered = isSpayedOrNeutered;
        }

    }
}
