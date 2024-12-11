namespace Task_1
{
    class Bus : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine($"Bus is driving at a speed of {Speed} km/h.");
        }
    }
}
