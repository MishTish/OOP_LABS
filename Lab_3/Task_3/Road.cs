namespace Task_3
{
    public class Road
    {
        public double Length_KM { get; set; }
        public double Width { get; set; }
        public int NumberOfLanes { get; set; }
        public double TrafficLevel { get; set; }
        public double LaneWidth { get; set; }

        public Road(double length, double width, double laneWidth, double trafficLevel)
        {
            Length_KM = length;
            Width = width;
            NumberOfLanes = (int)(width / laneWidth);
            LaneWidth = laneWidth;
            TrafficLevel = trafficLevel;
        }

        public bool CanAccommodate(Vehicle vehicle)
        {
            int lanesRequired = vehicle.GetLanesRequired(LaneWidth);
            return lanesRequired <= NumberOfLanes;
        }

        public void UpdateTrafficLevel(int vehicleCount)
        {
            Random random = new Random();
            double change = random.NextDouble() * (0.3 - -0.3) - 0.3; //Random between -0.3 and +0.3
            TrafficLevel = (Math.Clamp(TrafficLevel + change + vehicleCount * 0.025, 0, 1));
        }
    }
}
