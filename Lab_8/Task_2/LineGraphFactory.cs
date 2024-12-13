namespace Task_2
{
    public class LineGraphFactory : GraphFactory
    {
        public override IGraph CreateGraph()
        {
            return new LineGraph();
        }
    }
}
