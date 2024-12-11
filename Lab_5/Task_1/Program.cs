using Task_1;

class Program
{
    static void Main()
    {
     
        Car car = new Car { Speed = 100, Capacity = 4 };
        Bus bus = new Bus { Speed = 60, Capacity = 50 };
        Train train = new Train { Speed = 120, Capacity = 200 };


        TransportNetwork network = new TransportNetwork();
        network.AddVehicle(car);
        network.AddVehicle(bus);
        network.AddVehicle(train);


        Route route = new Route("City A", "City B", 300);


        network.TravelRoute(car, route);
        network.TravelRoute(bus, route);
        network.TravelRoute(train, route);
    }
}
