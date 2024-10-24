namespace Task_1
{
    internal class Animal : Organism, IReproducible, IPredator
    {
        public bool isHunter { get; set; }
        public bool isFemale {  get; set; }

        public Animal(int age, double size, double energy, string species, bool isHunter, bool isFemale) : base(age, size, energy, species)
        {
            this.isHunter = isHunter;
            this.isFemale = isFemale;
        }

        public override void GetEnergy()
        {
            Energy += 10;
            Console.WriteLine($"The animal {this.Species} found some food and ate it. | +10 Energy ({Energy})");

        }

        public Organism Reproduce(Organism mate)
        {
            if (Energy > 30 && mate.Energy > 30) 
            {
                if (mate is Animal animalMate && mate.Species == this.Species && animalMate.isFemale != this.isFemale)
                {
                    Random rand = new Random();
                    bool gender = Convert.ToBoolean(rand.Next(0, 2));

                    Console.WriteLine($"The animal {this.Species} found a mate {mate.Species} and reproduced. | -30/-30 Energy ({Energy-30})/({mate.Energy-30})");
                    Organism baby = new Animal(0, ((this.Size + mate.Size) / 2) * 1 / 15, ((this.Energy + mate.Energy) / 2) * 1 / 15, this.Species, this.isHunter, gender);
                    Energy -= 30;
                    mate.Energy -= 30;
                    return baby;
                }
                else
                {
                    Console.WriteLine($"The animal {this.Species} cannot find a mate and reproduce.");
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
            }
            else
            {
                Console.WriteLine($"The animal {this.Species} is not a predator, and can't hunt.");
            }
        }
    }
}
