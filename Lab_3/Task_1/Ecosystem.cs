using System.Linq;

namespace Task_1
{
    internal class Ecosystem
    {
        private List<Organism> organisms;

        public Ecosystem()
        {
            organisms = new List<Organism>();
        }

        public void AddOrganism(Organism organism)
        {
            organisms.Add(organism);
        }
        private Organism FindMate(Animal animal)
        {
            foreach (Organism organism in organisms)
            {
                if (organism is Animal mate && mate.Species == animal.Species && mate != animal)
                {
                    return mate;
                }
            }
            Console.WriteLine($"The animal {animal.Species} Cannot find a mate.");
            return null;
            
        }
        public void Play(int count)
        {
            for (int i = 0; i < count; i++)
            {
                organisms[i].GetEnergy();

                if (organisms[i] is IReproducible rep)
                {
                    {
                        if (organisms[i] is Animal)
                        {
                            Organism mate = FindMate((Animal)organisms[i]);
                            Organism newOrg = rep.Reproduce(mate);
                            if (newOrg != null)
                            {
                                organisms.Add(newOrg);
                            }
                        }
                        else
                        {
                            Organism newOrg = rep.Reproduce(organisms[i]);
                            if (newOrg != null)
                            {
                                organisms.Add(newOrg);
                            }
                        }
                    }

                    }
                    if (organisms[i] is IPredator prd)
                    {
                        Organism prey;
                        if (organisms.Count > 1)
                        {
                            prey = organisms[0];
                        }
                        else
                        {
                            prey = null;
                        }

                        prd.Hunt(prey);
                    }
                }
            }
        }
    }

