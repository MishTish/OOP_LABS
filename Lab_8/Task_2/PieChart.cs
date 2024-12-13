using OxyPlot.Series;
using OxyPlot;

namespace Task_2
{
    public class PieChart : IGraph
    {
        public void Draw(List<double> data, Action<PlotModel> showPlotMethod)
        {
            var plotModel = new PlotModel { Title = "Pie Chart" };
            var pieSeries = new PieSeries();
            foreach (var value in data)
            {
                pieSeries.Slices.Add(new PieSlice("Slice", value));
            }
            plotModel.Series.Add(pieSeries);
            showPlotMethod(plotModel);
        }
    }
}
