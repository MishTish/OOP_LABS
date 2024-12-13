using OxyPlot.Series;
using OxyPlot;

namespace Task_2
{
    public class LineGraph : IGraph
    {
        public void Draw(List<double> data, Action<PlotModel> showPlotMethod)
        {
            var plotModel = new PlotModel { Title = "Line Graph" };
            var lineSeries = new LineSeries();
            for (int i = 0; i < data.Count; i++)
            {
                lineSeries.Points.Add(new DataPoint(i, data[i]));
            }
            plotModel.Series.Add(lineSeries);
            showPlotMethod(plotModel);
        }
    }
}
