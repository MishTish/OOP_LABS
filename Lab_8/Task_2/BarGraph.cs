using OxyPlot.Series;
using OxyPlot;

namespace Task_2
{
    public class BarGraph : IGraph
    {
        public void Draw(List<double> data, Action<PlotModel> showPlotMethod)
        {
            var plotModel = new PlotModel { Title = "Bar Graph" };
            var barSeries = new BarSeries();
            for (int i = 0; i < data.Count; i++)
            {
                barSeries.Items.Add(new BarItem(data[i]));
            }
            plotModel.Series.Add(barSeries);
            showPlotMethod(plotModel);
        }
    }
}
