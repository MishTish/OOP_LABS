namespace Task_1
{
    class Route
    {
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public int Distance { get; set; }

        public Route(string start, string end, int distance)
        {
            StartPoint = start;
            EndPoint = end;
            Distance = distance;
        }

        public int CalculateTravelTime(int speed)
        {
            return Distance / speed;
        }

        public override string ToString()
        {
            return $"Route from {StartPoint} to {EndPoint}, Distance: {Distance} km.";
        }
    }
}
