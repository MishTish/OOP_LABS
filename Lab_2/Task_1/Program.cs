
using Task_1;

double height = 0;
double width = 0;

while (true)
{
    try
    {
        Console.Write("Enter rectangle height: ");
        height = Convert.ToDouble(Console.ReadLine());
        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("ERROR: Incorrect input");
        continue;
    }
}
while (true)
{
    try
    {
        Console.Write("Enter rectangle width: ");
        width = Convert.ToDouble(Console.ReadLine());
        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("ERROR: Incorrect input");
        continue;
    }

}


Rectangle rec = new Rectangle(height, width);

// Як правільніше? в завданні було сказано створити і метод, і властивість
double recArea = rec.Area;
double recPerimeter = rec.CalculatePerimeter();

Console.WriteLine($"\nRectangle area: {recArea}");
Console.WriteLine($"Rectangle perimeter: {recPerimeter}");

