

namespace Task_1
{

    internal class Rectangle
    {
        private double _side1;
        private double _side2;

        public Rectangle(double side1, double side2)
        {
            this._side1 = side1;
            this._side2 = side2;
        }

        public double Area
        {
            get { return _side1 * _side2; }
        }

        public double Perimeter
        {
            get { return _side1 * 2 + _side2 * 2; }
        }


        public double CalculateArea()
        {
            return _side1 * _side2;
        }
        public double CalculatePerimeter()
        {
            return _side1 * 2 + _side2 * 2;
        }

    }
}
