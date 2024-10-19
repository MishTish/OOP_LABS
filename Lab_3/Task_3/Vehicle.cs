namespace Task_3
{
    public class Vehicle : IDrivable
    {
        public double BaseSpeed {  get; set; }
        public double Speed { get; set; }
        public double Width { get; set; }
        public string Type { get; set; }
        public double Distance { get; set; }

        public Vehicle(double basespeed, double width, string type)
        {
            BaseSpeed = basespeed;
            Speed = basespeed;
            Width = width;
            Type = type;
            Distance = 0.0;
        }

        public void Move()
        {
            Console.WriteLine($"{Type} is moving at {Speed:0.00} km/h.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Type} has stopped.");
        }

        public int GetLanesRequired(double laneWidth)
        {
            return (int)Math.Ceiling(Width / laneWidth);
        }

        public void AdjustSpeed(double trafficLevel, Road road)
        {

            Speed = BaseSpeed * (1 - trafficLevel);
            if (Speed < 5)
            {
                Stop();
            }
            else
            {
                Move();
            }
        }
    }
}

