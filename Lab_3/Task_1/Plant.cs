namespace Task_1
{
    internal class Plant : Organism, IReproducible
    {
        public bool IsInBloom { get; set; }

        public Plant(int age, double size, double energy, string species, bool IsInBloom) : base(age, size, energy, species)
        {
            this.IsInBloom = IsInBloom;
        }


        public override void GetEnergy()
        {
            if (7 < DateTime.Now.Hour && DateTime.Now.Hour < 17)
            {
                Energy += 3;
                Console.WriteLine($"The plant {this.Species} is absorbing sunlight and gaining energy. | +5 Energy ({Energy})");

            }
            else
            {
                Console.WriteLine($"The sun isn't out, plant {this.Species} can't gain energy.");
            }

        }
        public Organism Reproduce(Organism mate)
        {
            if (Energy > 10)
            {
                if (IsInBloom)
                {
                    Energy -= 10;
                    Console.WriteLine($"The plant {this.Species} is blooming and reproduces with seeds. | -10 Energy ({Energy})");
                    Plant baby = new Plant(0, 0.1, 0.1, Species, false);
                    return baby;
                }
                else
                {
                    Console.WriteLine($"The plant {this.Species} is not blooming and cannot reproduce.");
                    return null;
                }
            }
            Console.WriteLine($"The plant {this.Species} doesn't have enough energy and cannot reproduce.");
            return null;

        }

    }
}
