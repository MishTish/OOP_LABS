using Task_1;
Animal zebra = new Animal(12, 4.5, 75, "Zebra", false, false);
Animal zebra2 = new Animal(12, 4.5, 40, "Zebra", false, true);
Animal zebra3 = new Animal(12, 4.5, 75, "Zebra", false, false);
Animal zebra4 = new Animal(12, 4.5, 40, "Zebra", false, true);
Animal zebra5 = new Animal(12, 4.5, 100, "Zebra", false, true);

Animal lion = new Animal(10, 5, 100, "Lion", true, false);
Animal lion2 = new Animal(10, 5, 30, "Lion", true, true);

Plant appleTree = new Plant(15, 10, 50, "Apple tree", true);
Plant violetFlower = new Plant(1, 0.2, 15, "Violet", false);

Micro algae = new Micro(1, 0.001, 5, "Algae");
Micro virus = new Micro(1, 0.001, 4, "Virus");


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
