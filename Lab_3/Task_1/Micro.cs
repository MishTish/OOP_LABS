namespace Task_1
{
    internal class Micro : Organism, IReproducible
    {
        public bool IsPathogenic {  get; set; }

        public Micro(int age, double size, double energy, string species, bool IsPathogenic) : base(age, size, energy, species)
        {
            this.IsPathogenic = IsPathogenic;
        }


        public override void GetEnergy()
        {
            Energy += 3;
            Console.WriteLine($"The microorganism {this.Species} is consuming nearby nutrients. | +2 Energy ({Energy})");
            
        }
        public Organism Reproduce(Organism mate)
        {
            if (Energy > 5)
            {
                Energy -= 5;
                Console.WriteLine($"The microorganism {this.Species} reproduces through binary fission. | -5 Energy ({Energy})");
                Micro baby = new Micro(0, Size, Energy, Species, IsPathogenic);
                return baby;
            }
            Console.WriteLine($"The microorganism {this.Species} doesn't have enough energy and cannot reproduce.");
            return null;
        }
    }
}
