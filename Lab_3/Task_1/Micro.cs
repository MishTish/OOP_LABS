namespace Task_1
{
    internal class Micro : Organism, IReproducible
    {
        public bool IsPathogenic {  get; set; }

        public Micro(int age, double size, double energy, Species species) : base(age, size, energy, species)
        {

        }


        public override void GetEnergy()
        {
            Energy += 3;
            Console.WriteLine($"The microorganism {this.species} is consuming nearby nutrients. | +3 Energy ({Energy})");
            
        }
        public Organism Reproduce(Organism mate)
        {
            if (Energy > 5)
            {
                Energy -= 5;
                Console.WriteLine($"The microorganism {this.species} reproduces through binary fission. | -5 Energy ({Energy})");
                Micro baby = new Micro(0, Size, Energy, species);
                return baby;
            }
            Console.WriteLine($"The microorganism {this.species} doesn't have enough energy and cannot reproduce.");
            return null;
        }
    }
}
