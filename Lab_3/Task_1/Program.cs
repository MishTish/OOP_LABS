using Task_1;
Animal zebra = new Animal(12, 4.5, 75, Organism.Species.Zebra, false, false);
Animal zebra2 = new Animal(12, 4.5, 40, Organism.Species.Zebra, false, true);
Animal zebra3 = new Animal(12, 4.5, 75, Organism.Species.Zebra, false, false);
Animal zebra4 = new Animal(12, 4.5, 40, Organism.Species.Zebra, false, true);
Animal zebra5 = new Animal(12, 4.5, 100, Organism.Species.Zebra, false, true);

Animal lion = new Animal(10, 5, 100, Organism.Species.Lion, true, false);
Animal lion2 = new Animal(10, 5, 30, Organism.Species.Lion, true, true);

Plant appleTree = new Plant(15, 10, 50, Organism.Species.AppleTree, true);
Plant violetFlower = new Plant(1, 0.2, 15, Organism.Species.VioletFlower, false);

Micro algae = new Micro(1, 0.001, 5, Organism.Species.Algae);
Micro virus = new Micro(1, 0.001, 4, Organism.Species.Virus);


Ecosystem ecosystem = new Ecosystem();
ecosystem.AddOrganism(zebra);
ecosystem.AddOrganism(zebra2);
ecosystem.AddOrganism(zebra3);
ecosystem.AddOrganism(zebra4);
ecosystem.AddOrganism(zebra5);
ecosystem.AddOrganism(lion);
ecosystem.AddOrganism(lion2);
ecosystem.AddOrganism(appleTree);
ecosystem.AddOrganism(violetFlower);
ecosystem.AddOrganism(algae);
ecosystem.AddOrganism(virus);

ecosystem.Play(ecosystem.LivingCount());


Console.ReadLine();