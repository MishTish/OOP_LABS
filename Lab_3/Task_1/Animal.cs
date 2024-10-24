namespace Task_1
{
    internal class Animal : Organism, IReproducible, IPredator
    {

        public bool isHunter { get; set; }
        public bool isFemale {  get; set; }

        public Animal(int age, double size, double energy, Species species, bool isHunter, bool isFemale) : base(age, size, energy, species)
        {
            this.isHunter = isHunter;
            this.isFemale = isFemale;
        }

        public override void GetEnergy()
        {
            Energy += 10;
            Console.WriteLine($"The animal {this.species} found some food and ate it. | +10 Energy ({Energy})");

        }

        public Organism Reproduce(Organism mate)
        {
            if (this.Energy > 30 && mate.Energy > 30) 
            {
                if (mate is Animal animalMate && mate.species == this.species && animalMate.isFemale != this.isFemale)
                {

                    double babySize = (this.Size + mate.Size) / 2 * 1 / 15;
                    double babyEnergy = (this.Energy + mate.Energy) / 2 * 1 / 15;
                    Random rand = new Random();
                    bool gender = Convert.ToBoolean(rand.Next(0, 2));

                    Organism baby = new Animal(0, babySize, babyEnergy, this.species, this.isHunter, gender);
                    this.Energy -= 30;
                    mate.Energy -= 30;
                    Console.WriteLine($"The animal {this.species} found a mate {mate.species} and reproduced. | -30/-30 Energy ({this.Energy})/({mate.Energy})");
                    return baby;
                }
                else
                {
                    Console.WriteLine($"The animal {this.species} cannot find a mate and reproduce.");
                    return null;
                }
            }
            Console.WriteLine($"The animal {this.species} doesn't have enough energy, and cannot reproduce.");
            return null;
            
        }

        public void Hunt(Organism prey)
        {
            if (isHunter)
            {
                Energy = Energy + prey.Energy / 2;
                Console.WriteLine($"The animal {this.species} hunted a {prey.species} and ate it. | + {prey.Energy/2:0.00} Energy ({Energy})");
            }
            else
            {
                Console.WriteLine($"The animal {this.species} is not a predator, and can't hunt.");
            }
        }
    }
}
