namespace Task_1
{
    class Human
    {
        public int Speed { get; set; }
        public void Move()
        {
            Console.WriteLine($"Human is walking at a speed of {Speed} km/h.");
        }
    }
}