
namespace Task_2
{
    internal class Point
    {
        private double _x;
        private double _y;
        private string _str;

        public double X { get { return _x; } }
        public double Y { get { return _y; } }
        public string Str { get { return _str; } }

        public Point(double x, double y, string str)
        {
            this._x = x;
            this._y = y;
            this._str = str;
        }
    }
}
