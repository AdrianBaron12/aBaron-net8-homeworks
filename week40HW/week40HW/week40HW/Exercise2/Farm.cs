using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace week40HW.Exercise2
{
    public class Farm
    {
        public string name;
        public double area;
        public int animalCount;

        public Farm(string name, double area, int animalCount)
        {
            this.name = name;
            this.area = area;
            this.animalCount = animalCount;
        }

        public void AddAnimals(int count)
        {
         animalCount += count;
        }

        public double CalculateDensity()
        {
            return (double)animalCount / area;
        }

    }
}
