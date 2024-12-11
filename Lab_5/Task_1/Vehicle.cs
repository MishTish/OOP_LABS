namespace Task_1
{
    abstract class Vehicle
    {
        public int Speed { get; set; }
        public int Capacity { get; set; }
        public int CurrentPassengers { get; set; } = 0;

        public abstract void Move();

        public void BoardPassengers(int passengers)
        {
            int spaceAvailable = Capacity - CurrentPassengers;
            int boarding = Math.Min(passengers, spaceAvailable);
            CurrentPassengers += boarding;
            Console.WriteLine($"{boarding} passengers boarded. Current passengers: {CurrentPassengers}");
        }

        public void DisembarkPassengers(int passengers)
        {
            int disembarking = Math.Min(passengers, CurrentPassengers);
            CurrentPassengers -= disembarking;
            Console.WriteLine($"{disembarking} passengers disembarked. Current passengers: {CurrentPassengers}");
        }
    }
}
