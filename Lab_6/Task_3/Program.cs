using Task_3;

class Program
{
    static void Main()
    {

        var cache = new FunctionCache<int, int>();


        FunctionCache<int, int>.Func Add5 = n => n + 5;


        int result1 = cache.GetOrAdd(1, Add5, TimeSpan.FromSeconds(2));
        Console.WriteLine(cache.GetOrAdd(1, Add5)); 

        Console.WriteLine(cache.GetOrAdd(1, Add5)); 

        System.Threading.Thread.Sleep(5000);

        Console.WriteLine(cache.GetOrAdd(1, Add5)); 
    }
}