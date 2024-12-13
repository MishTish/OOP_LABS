using OxyPlot;

namespace Task_2
{
    public interface IGraph
    {
        void Draw(List<double> data, Action<PlotModel> showPlotMethod);
    }

}
