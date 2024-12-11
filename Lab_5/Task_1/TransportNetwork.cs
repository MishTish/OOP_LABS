namespace Task_1
{
    class TransportNetwork
    {
        private List<Vehicle> vehicles = new List<Vehicle>();

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
            Console.WriteLine($"{vehicle.GetType().Name} added to the network.");
        }

        public void TravelRoute(Vehicle vehicle, Route route)
        {
            Console.WriteLine($"{vehicle.GetType().Name} is traveling on {route}");


            int travelTime = route.CalculateTravelTime(vehicle.Speed);
            Console.WriteLine($"Estimated travel time: {travelTime} hours.");


            Console.WriteLine("Boarding passengers...");
            int passengersToBoard = vehicle.Capacity - vehicle.CurrentPassengers;
            vehicle.BoardPassengers(passengersToBoard);


            vehicle.Move();

            Console.WriteLine("Disembarking passengers...");
            int passengersToDisembark = vehicle.CurrentPassengers;
            vehicle.DisembarkPassengers(passengersToDisembark);

            Console.WriteLine($"{vehicle.GetType().Name} has completed the route from {route.StartPoint} to {route.EndPoint}.");
        }
    }
}
