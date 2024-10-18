using Task_1;
Animal zebra = new Animal(12, 4.5, 75, "Zebra", false);
Animal zebra2 = new Animal(12, 4.5, 40, "Zebra", false);

Animal lion = new Animal(10, 5, 100, "Lion", true);

Plant appleTree = new Plant(15, 10, 50, "Apple tree", true);
Plant violetFlower = new Plant(1, 0.2, 10, "Violet", false);

Micro algae = new Micro(1, 0.001, 5, "Algae", false);
Micro virus = new Micro(1, 0.001, 4, "Virus", true);


Ecosystem ecosystem = new Ecosystem();
ecosystem.AddOrganism(zebra);
ecosystem.AddOrganism(zebra2);
ecosystem.AddOrganism(lion);
ecosystem.AddOrganism(appleTree);
ecosystem.AddOrganism(violetFlower);
ecosystem.AddOrganism(algae);
ecosystem.AddOrganism(virus);

ecosystem.Play(7);

Console.ReadLine();