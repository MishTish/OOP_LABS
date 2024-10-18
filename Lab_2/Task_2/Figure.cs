
namespace Task_2
{
    internal class Figure 
    {
        private Point _a;
        private Point _b;
        private Point _c;
        private Point _d;
        private Point _e;

        public Point A { get { return _a; } }
        public Point B { get { return _b; } }
        public Point C { get { return _c; } }
        public Point D { get { return _d; } }
        public Point E { get { return _e; } }
        public Figure(Point a, Point b, Point c) 
        { 
            _a = a;
            _b = b;
            _c = c;
        }
        public Figure(Point a, Point b, Point c, Point d)
        {
            _a = a;
            _b = b;
            _c = c;
            _d = d;
        }
        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            _a = a;
            _b = b;
            _c = c;
            _d = d;
            _e = e;
        }

        public void FigureName()
        {
            if (_e == null && _d == null)
            {
                Console.WriteLine("Figure: Triangle\n");
            }
            else if (_e == null)
            {
                Console.WriteLine("Figure: Rectangle\n");
            }
            else 
                Console.WriteLine("Figure: Pentagon\n");
        }
        public double GetSideLength(Point A, Point B)
        {
           return Math.Sqrt(Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2)); 
        }
        public void CalculatePerimeter(Point a, Point b, Point c)

        {
            Console.WriteLine($"Perimeter: {GetSideLength(a, b) + GetSideLength(b, c) + GetSideLength(c, a)}");
        }
        public void CalculatePerimeter(Point a, Point b, Point c, Point d)

        {
            Console.WriteLine($"Perimeter: {GetSideLength(a, b) + GetSideLength(b, c) + GetSideLength(c, d) + GetSideLength(d, a)}");
        }
        public void CalculatePerimeter(Point a, Point b, Point c, Point d, Point e)

        {
            Console.WriteLine($"Perimeter:  {GetSideLength(a, b) + GetSideLength(b, c) + GetSideLength(c, d) + GetSideLength(d, e) + GetSideLength(e, a)}");
        }
    }
}
