namespace Task_1
{
    class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine($"Car is driving at a speed of {Speed} km/h.");
        }
    }
}