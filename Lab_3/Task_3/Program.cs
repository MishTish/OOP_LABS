using Task_3;

Road mainRoad = new Road(300, 8, 2, 0.3);

Vehicle car = new Vehicle(80, 2, "Car");
Vehicle truck = new Vehicle(60, 4, "Truck");
Vehicle oldCar = new Vehicle(50, 2, "Car");


TrafficSimulator simulator = new TrafficSimulator(mainRoad);


simulator.AddVehicle(car);
simulator.AddVehicle(truck);
simulator.AddVehicle(oldCar);


simulator.SimulateTraffic(10);