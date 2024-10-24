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
                if (organism is Animal mate && mate.species == animal.species && mate != animal)
                {
                    return mate;
                }
            }
            Console.WriteLine($"The animal {animal.species} Cannot find a mate.");
            return null;

        }
        public void Play(int count)
        {
            for (int i = 0; i < count; i++)
            {
                if (organisms[i].isAlive == true)
                {
                    organisms[i].GetEnergy();




                    if (organisms[i] is IPredator prd)
                    {
                        if (organisms[i] is Animal j && j.isHunter)
                        {
                            foreach (Organism hunted in organisms)
                            {
                                if (((int)hunted.species) < 200 && organisms[i].Energy <= 40)
                                {
                                    prd.Hunt(hunted);
                                    hunted.isAlive = false;
                                }

                            }
                        }
                    }


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
                }
            }

        }

        public int LivingCount()
        {
            int count = 0;
            foreach (Organism o in organisms)
            {
                if (o.isAlive == true)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

