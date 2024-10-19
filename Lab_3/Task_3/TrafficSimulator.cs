namespace Task_3
{
    public class TrafficSimulator
    {
        public Road Road { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        public TrafficSimulator(Road road)
        {
            Road = road;
            Vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            if (Road.CanAccommodate(vehicle))
            {
                Vehicles.Add(vehicle);
                Console.WriteLine($"{vehicle.Type} added to the road.");
                Road.NumberOfLanes -= vehicle.GetLanesRequired(Road.LaneWidth);
            }
            else
            {
                Console.WriteLine($"{vehicle.Type} cannot be added, it is too wide for the road.");
            }
        }
        public void RemoveVehicle(Vehicle vehicle)
        {
            if (Road.CanAccommodate(vehicle))
            {
                Vehicles.Remove(vehicle);
                Road.NumberOfLanes += vehicle.GetLanesRequired(Road.LaneWidth);
            }
        }


        public void SimulateTraffic(int simulationDuration)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Road length: {Road.Length_KM}km, width: {Road.Width}m, # of lanes: {(int)(Road.Width/Road.LaneWidth)}");
            Console.WriteLine("-------------------------");
            for (int i = 0; i < simulationDuration; i++)
            {
                Console.WriteLine($"Time: {i + 1} hour(s)");


                Road.UpdateTrafficLevel(Vehicles.Count);
                Console.WriteLine($"Traffic Level: {Road.TrafficLevel:0.00}");

                foreach (var vehicle in Vehicles)
                {

                    if (vehicle.Distance >= Road.Length_KM)
                    {
                        Console.WriteLine($"{vehicle.Type} has reached the end of the road");
                        RemoveVehicle(vehicle);
                    }
                    else
                    {
                        vehicle.AdjustSpeed(Road.TrafficLevel, Road);
                    }
                    vehicle.Distance += vehicle.Speed;
                }

                Console.WriteLine("-------------------------");
            }
        }
    }
}
