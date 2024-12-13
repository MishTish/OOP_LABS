namespace Task_2
{
    public class BarGraphFactory : GraphFactory
    {
        public override IGraph CreateGraph()
        {
            return new BarGraph();
        }
    }
}
