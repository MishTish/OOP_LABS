namespace Task_1
{
    class Train : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine($"Train is running at a speed of {Speed} km/h.");
        }
    }
}
