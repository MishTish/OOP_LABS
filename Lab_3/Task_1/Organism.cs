using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal abstract class Organism
    {
        public int Age { get; set; }
        public double Size { get; set; }
        public double Energy { get; set; }
        public string Species {  get; set; }

        public Organism(int age, double size, double energy, string species)
        {
            Energy = energy;
            Age = age;
            Size = size;
            Species = species;
        }

        public abstract void GetEnergy();
    }
}