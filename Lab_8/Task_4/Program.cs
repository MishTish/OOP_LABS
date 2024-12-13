using Task_4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Data Format Adapter Application\n");

        while (true)
        {
            Console.WriteLine("Choose source data format:");
            Console.WriteLine("1. CSV");
            Console.WriteLine("2. XML");
            Console.WriteLine("3. JSON");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string sourceChoice = Console.ReadLine();
            DataTemplate sourceTemplate = null;

            switch (sourceChoice)
            {
                case "1":
                    sourceTemplate = new CsvTemplate { CsvData = "value1,value2,value3" };
                    break;
                case "2":
                    sourceTemplate = new XmlTemplate { XmlData = "<root><item>value1</item><item>value2</item></root>" };
                    break;
                case "3":
                    sourceTemplate = new JsonTemplate { JsonData = "[\"value1\",\"value2\"]" };
                    break;
                case "4":
                    Console.WriteLine("Exiting application.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }

            Console.WriteLine("Choose target data format:");
            Console.WriteLine("1. CSV");
            Console.WriteLine("2. XML");
            Console.WriteLine("3. JSON");
            Console.Write("Enter your choice: ");

            string targetChoice = Console.ReadLine();
            DataTemplate targetTemplate = null;
            IDataAdapter adapter = null;

            switch (targetChoice)
            {
                case "1":
                    targetTemplate = new CsvTemplate();
                    if (sourceTemplate is XmlTemplate)
                        adapter = new XmlToCsvAdapter();
                    else if (sourceTemplate is JsonTemplate)
                        adapter = new JsonToCsvAdapter();
                    break;
                case "2":
                    targetTemplate = new XmlTemplate();
                    if (sourceTemplate is CsvTemplate)
                        adapter = new CsvToXmlAdapter();
                    else if (sourceTemplate is JsonTemplate)
                        adapter = new JsonToXmlAdapter();
                    break;
                case "3":
                    targetTemplate = new JsonTemplate();
                    if (sourceTemplate is CsvTemplate)
                        adapter = new CsvToJsonAdapter();
                    else if (sourceTemplate is XmlTemplate)
                        adapter = new XmlToJsonAdapter();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }

            if (adapter == null)
            {
                Console.WriteLine("No compatible adapter found. Conversion not possible.");
                continue;
            }

            adapter.Convert(sourceTemplate, targetTemplate);
            Console.WriteLine("\nConverted Data:");
            if (targetTemplate is CsvTemplate csv)
                Console.WriteLine(csv.CsvData);
            else if (targetTemplate is XmlTemplate xml)
                Console.WriteLine(xml.XmlData);
            else if (targetTemplate is JsonTemplate json)
                Console.WriteLine(json.JsonData);
            Console.WriteLine();
        }
    }
}