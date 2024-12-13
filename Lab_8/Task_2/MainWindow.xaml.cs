namespace Task_2
{
    class Program
    {
        [STAThread]
        static public void Main(string[] args)
        {
            Console.WriteLine("Graph Factory Application\n");

            while (true)
            {
                Console.WriteLine("Choose a graph type to draw:");
                Console.WriteLine("1. Line Graph");
                Console.WriteLine("2. Bar Graph");
                Console.WriteLine("3. Pie Chart");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();
                GraphFactory factory = null;

                switch (choice)
                {
                    case "1":
                        factory = new LineGraphFactory();
                        break;
                    case "2":
                        factory = new BarGraphFactory();
                        break;
                    case "3":
                        factory = new PieChartFactory();
                        break;
                    case "4":
                        Console.WriteLine("Exiting application.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        continue;
                }

                Console.Write("Enter data points separated by commas: ");
                string dataInput = Console.ReadLine();
                List<double> data = new List<double>();

                try
                {
                    data = new List<double>(Array.ConvertAll(dataInput.Split(','), double.Parse));
                }
                catch
                {
                    Console.WriteLine("Invalid data input. Please enter numeric values separated by commas.");
                    continue;
                }

                IGraph graph = factory.CreateGraph();
                graph.Draw(data, PlotWindowHelper.ShowPlotWindow);
            }
        }
    }
}