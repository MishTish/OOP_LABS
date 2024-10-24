//##### 2 #####

using Task_2;

Console.WriteLine("##### 2 ##### \n# Converter #\n");

Converter someConverter = new Converter(usd: 0.0243, eur: 0.0222, pln: 0.0952);
bool loop1;
bool loop2;
double value;
string selector;

loop1 = true;
while (loop1)
{

    loop2 = true;
    Console.WriteLine("Choose converter mode:");
    Console.WriteLine("1. FROM UAH");
    Console.WriteLine("2. TO UAH");
    Console.WriteLine("3. EXIT");
    selector = Console.ReadLine();
    switch (selector)
    {
        case "1":
            {
                while (loop2)
                {
                    Console.WriteLine();
                    Console.WriteLine("1. UAH > USD");
                    Console.WriteLine("2. UAH > EUR");
                    Console.WriteLine("3. UAH > PLN");
                    selector = Console.ReadLine();
                    switch (selector)
                    {
                        case "1":
                            try
                            {
                                Console.WriteLine("Enter value in UAH:");
                                value = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine($"{value} UAH === {someConverter.Uah_Usd(value):0.00} USD");
                                loop2 = false;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("ERROR: incorrect input");
                            }
                            break;

                        case "2":
                            try
                            {
                                Console.WriteLine("Enter value in UAH:");
                                value = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine($"{value} UAH === {someConverter.Uah_Usd(value):0.00} EUR");
                                loop2 = false;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("ERROR: incorrect input");
                            }
                            break;

                        case "3":
                            try
                            {
                                Console.WriteLine("Enter value in UAH:");
                                value = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine($"{value} UAH === {someConverter.Uah_Usd(value):0.00} PLN");
                                loop2 = false;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("ERROR: incorrect input");
                            }
                            break;

                        default:
                            Console.WriteLine("ERROR: incorrect input");
                            loop2 = true;
                            break;
                    }
                }
                break;
            }

        case "2":
            {
                while (loop2)
                {
                    Console.WriteLine();
                    Console.WriteLine("1. USD > UAH");
                    Console.WriteLine("2. EUR > UAH");
                    Console.WriteLine("3. PLN > UAH");
                    selector = Console.ReadLine();
                    switch (selector)
                    {
                        case "1":
                            try
                            {
                                Console.WriteLine("Enter value in USD:");
                                value = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine($"{value} USD === {someConverter.Usd_Uah(value):0.00} UAH");
                                loop2 = false;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("ERROR: incorrect input");
                            }
                            break;

                        case "2":
                            try
                            {
                                Console.WriteLine("Enter value in EUR:");
                                value = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine($"{value} EUR === {someConverter.Eur_Uah(value):0.00} UAH");
                                loop2 = false;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("ERROR: incorrect input");
                            }
                            break;

                        case "3":
                            try
                            {
                                Console.WriteLine("Enter value in PLN:");
                                value = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine($"{value} PLN === {someConverter.Pln_Uah(value):0.00} UAH");
                                loop2 = false;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("ERROR: incorrect input");
                            }
                            break;

                        default:
                            Console.WriteLine("ERROR: incorrect input");
                            loop2 = true;
                            break;
                    }
                }
                break;
            }
        case "3":
            {
                loop1 = false;
                break;
            }
        default:
            {
                Console.WriteLine("ERROR: incorrect input");
                loop1 = true;
                break;
            }
    }
}