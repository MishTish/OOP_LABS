namespace Task_2
{
    public class PieChartFactory : GraphFactory
    {
        public override IGraph CreateGraph()
        {
            return new PieChart();
        }
    }
}
