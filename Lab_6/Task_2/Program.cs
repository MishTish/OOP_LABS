using Task_2;

class Program
{
    static void Main(string[] args)
    {

        Repository<int> intRepository = new Repository<int>();
        intRepository.Add(10);
        intRepository.Add(20);
        intRepository.Add(30);

        Repository<int>.Criteria<int> isGreaterThan15 = item => item > 15;

        List<int> foundItems = intRepository.Find(isGreaterThan15);
        Console.WriteLine("Integers greater than 15:");
        foreach (int item in foundItems)
        {
            Console.WriteLine(item);
        }

        Repository<string> stringRepository = new Repository<string>();
        stringRepository.Add("apple");
        stringRepository.Add("banana");
        stringRepository.Add("cherry");

        Repository<string>.Criteria<string> startsWithB = item => item.StartsWith("b");

        List<string> foundStrings = stringRepository.Find(startsWithB);
        Console.WriteLine("Strings that start with 'b':");
        foreach (string item in foundStrings)
        {
            Console.WriteLine(item);
        }
    }
}