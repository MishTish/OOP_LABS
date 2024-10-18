namespace Task_1
{
    internal class Animal : Organism, IReproducible, IPredator
    {

        public bool isHunter { get; set; }

        public Animal(int age, double size, double energy, string species, bool ishunter) : base(age, size, energy, species)
        {         
            isHunter = ishunter;
        }

        public override void GetEnergy()
        {
            Energy += 10;
            Console.WriteLine($"The animal {this.Species} found some food and ate it. | +10 Energy ({Energy})");

        }

        public Organism Reproduce(Organism mate)
        {
            if (Energy > 30) 
            {
                if (mate is Animal && mate.Species == this.Species)
                {
                    Energy -= 30;
                    mate.Energy -= 30;
                    Console.WriteLine($"The animal {this.Species} found a mate {mate.Species} and reproduced. | -30/-30 Energy ({Energy})/({mate.Energy})");
                    Organism baby = new Animal(0, ((this.Size + mate.Size) / 2) * 1 / 15, ((this.Energy + mate.Energy) / 2) * 1 / 15, this.Species, this.isHunter);
                    return baby;
                }
                else
                {
                    Console.WriteLine($"The animal {this.Species} Cannot reproduce.");
                    return null;
                }
            }
            Console.WriteLine($"The animal {this.Species} doesn't have enough energy, and cannot reproduce.");
            return null;
            
        }

        public void Hunt(Organism prey)
        {
            if (isHunter)
            {
                Energy += prey.Energy/2;
                Console.WriteLine($"The animal {this.Species} hunted a {prey.Species} and ate it. | + {prey.Energy/2} Energy ({Energy})");
                prey.Energy = 0;
                prey = null;

            }
            else
            {
                Console.WriteLine($"The animal {this.Species} is not a predator, and can't hunt.");
            }
        }
    }
}
