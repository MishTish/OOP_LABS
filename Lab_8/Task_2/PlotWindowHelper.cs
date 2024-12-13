using OxyPlot.Wpf;
using OxyPlot;
using System.Windows;

namespace Task_2
{
    public static class PlotWindowHelper
    {
        public static void ShowPlotWindow(PlotModel plotModel)
        {
            var app = new Application();
            var window = new Window
            {
                Title = plotModel.Title,
                Content = new PlotView { Model = plotModel },
                Width = 800,
                Height = 600
            };
            app.Run(window);
        }
    }
}
