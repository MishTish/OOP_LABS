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
        public enum Species
        {
            Zebra = 101,
            Lion = 201,
            AppleTree = 301,
            VioletFlower = 302,
            Algae = 401,
            Virus = 402
        }
        // 10X - Vegetarians, 20X - Carnivores, 30X - Plants, 40X - Micro
        public int Age { get; set; }
        public double Size { get; set; }
        public double Energy { get; set; }
        public Species species { get; set; }
        public bool isAlive { get; set; }

        public Organism(int age, double size, double energy, Species species)
        {
            Energy = energy;
            Age = age;
            Size = size;
            this.species = species;
            isAlive = true;
        }

        public abstract void GetEnergy();


    }
}