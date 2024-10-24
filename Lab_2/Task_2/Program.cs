
using Task_2;

//не зрозумів, чи потрібно робити ввод Point-ов з консолі

// це компактний приклад без цього, знизу закоментован довгий варіант з вводом

Point a = new Point(1, 1, "A");
Point b = new Point(1, 3, "B");
Point c = new Point(2, 5, "C");
Point d = new Point(3, 3, "D");
Point e = new Point(3, 1, "E");

Figure fig1 = new Figure(a, b, c);
Figure fig2 = new Figure(a, b, c, d);
Figure fig3 = new Figure(a, b, c, d, e);

fig1.CalculatePerimeter(fig1.A, fig1.B, fig1.C);
fig1.FigureName();
fig2.CalculatePerimeter(fig2.A, fig2.B, fig2.C, fig2.D);
fig2.FigureName();
fig3.CalculatePerimeter(fig3.A, fig3.B, fig3.C, fig3.D, fig3.E);
fig3.FigureName();








// long spaghetti version bellow
/*
double X;
double Y;
int N = 0;

while (true)
{
    try
    {
        Console.Write("Enter number of sides (3 to 5): ");
        N = Convert.ToInt32(Console.ReadLine());
        while (!(N == 3 || N == 4 || N == 5))
        {

            Console.WriteLine("ERROR: Invalid input\n");
            Console.Write("Enter number of sides (3 to 5): ");
            N = Convert.ToInt32(Console.ReadLine());
            continue;
        }
        break;

    }
    catch (FormatException)
    {
        Console.WriteLine("ERROR: Invalid input\n");
        continue;
    }
}


switch (N)
{
    case 3:
        Console.Write("Enter: X1 : ");
        X = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter: Y1 : ");
        Y = Convert.ToDouble(Console.ReadLine());
        Point A3 = new Point(X, Y, "A");

        Console.Write("Enter: X2 : ");
        X = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter: Y2 : ");
        Y = Convert.ToDouble(Console.ReadLine());
        Point B3 = new Point(X, Y, "B");

        Console.Write("Enter: X3 : ");
        X = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter: Y3 : ");
        Y = Convert.ToDouble(Console.ReadLine());
        Point C3 = new Point(X, Y, "C");

        Figure fig1 = new Figure(A3, B3, C3);
        Console.WriteLine("Figure: Triangle");
        Console.Write("Figure area: ");
        fig1.CalculatePerimeter(fig1.A, fig1.B, fig1.C);

        break;

    case 4:
        Console.Write("Enter: X1 : ");
        X = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter: Y1 : ");
        Y = Convert.ToDouble(Console.ReadLine());
        Point A4 = new Point(X, Y, "A");

        Console.Write("Enter: X2 : ");
        X = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter: Y2 : ");
        Y = Convert.ToDouble(Console.ReadLine());
        Point B4 = new Point(X, Y, "B");

        Console.Write("Enter: X3 : ");
        X = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter: Y3 : ");
        Y = Convert.ToDouble(Console.ReadLine());
        Point C4 = new Point(X, Y, "C");

        Console.Write("Enter: X4 : ");
        X = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter: Y4 : ");
        Y = Convert.ToDouble(Console.ReadLine());
        Point D4 = new Point(X, Y, "D");

        Figure fig2 = new Figure(A4, B4, C4, D4);
        Console.WriteLine("Figure: Rectangle");
        Console.Write("Figure area: ");
        fig2.CalculatePerimeter(fig2.A, fig2.B, fig2.C, fig2.D);

        break;

    case 5:
        Console.Write("Enter: X1 : ");
        X = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter: Y1 : ");
        Y = Convert.ToDouble(Console.ReadLine());
        Point A5 = new Point(X, Y, "A");

        Console.Write("Enter: X2 : ");
        X = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter: Y2 : ");
        Y = Convert.ToDouble(Console.ReadLine());
        Point B5 = new Point(X, Y, "B");

        Console.Write("Enter: X3 : ");
        X = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter: Y3 : ");
        Y = Convert.ToDouble(Console.ReadLine());
        Point C5 = new Point(X, Y, "C");

        Console.Write("Enter: X4 : ");
        X = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter: Y4 : ");
        Y = Convert.ToDouble(Console.ReadLine());
        Point D5 = new Point(X, Y, "D");

        Console.Write("Enter: X5 : ");
        X = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter: Y5 : ");
        Y = Convert.ToDouble(Console.ReadLine());
        Point E5 = new Point(X, Y, "E");

        Figure fig3 = new Figure(A5, B5, C5, D5, E5);
        Console.WriteLine("Figure: Pentagon");
        Console.Write("Figure area: ");
        fig3.CalculatePerimeter(fig3.A, fig3.B, fig3.C, fig3.D, fig3.E);

        break;

    default:
        break;


}
*/




    






