using static Task_2.MathOperations;
namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 2;
            Console.WriteLine($"a = {a}");
            double b = 3;
            Console.WriteLine($"b = {b}");
            double Sum = Add(a, b);
            Console.WriteLine($"Sum = {Sum}");
            double Diff = Subtract(a, b);
            Console.WriteLine($"Diff = {Diff}");
            double Prod = Multiply(a, b);
            Console.WriteLine($"Prod = {Prod}");

            double[] vector1 = { 2, 3 };
            Console.WriteLine("vector1: [" + string.Join(", ", vector1) + "]");
            double[] vector2 = { 4, 5 };
            Console.WriteLine("vector2: [" + string.Join(", ", vector2) + "]");

            double[] vectorSum = Add(vector1, vector2);
            Console.WriteLine("Vector Sum: [" + string.Join(", ", vectorSum) + "]");
            double[] vectorDiff = Subtract(vector1, vector2);
            Console.WriteLine("Vector Diff: [" + string.Join(", ", vectorDiff) + "]");
            double[] vectorEWMult = ElementMultiply(vector1, vector2);
            Console.WriteLine("Vector Element-wise mult: [" + string.Join(", ", vectorEWMult) + "]");
            double vectorDotProd = DotProduct(vector1, vector2);
            Console.WriteLine("Vector Dot product: [" + string.Join(", ", vectorDotProd) + "]");


            double[,] matrix1 = { { 1, 2 }, { 3, 4 } };
            Console.WriteLine("matrix1:");
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    Console.Write(matrix1[i, j] + " ");
                }
                Console.WriteLine();
            }
            double[,] matrix2 = { { 5, 6 }, { 7, 8 } };
            Console.WriteLine("matrix2:");
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Console.Write(matrix2[i, j] + " ");
                }
                Console.WriteLine();
            }

            double[,] matrixSum = Add(matrix1, matrix2);
            Console.WriteLine("Matrix Sum:");
            for (int i = 0; i < matrixSum.GetLength(0); i++)
            {
                for (int j = 0; j < matrixSum.GetLength(1); j++)
                {
                    Console.Write(matrixSum[i, j] + " ");
                }
                Console.WriteLine();
            }

            double[,] matrixDiff = Subtract(matrix1, matrix2);
            Console.WriteLine("Matrix Diff:");
            for (int i = 0; i < matrixDiff.GetLength(0); i++)
            {
                for (int j = 0; j < matrixDiff.GetLength(1); j++)
                {
                    Console.Write(matrixDiff[i, j] + " ");
                }
                Console.WriteLine();
            }

            double[,] matrixEWmult = ElementMultiply(matrix1, matrix2);
            Console.WriteLine("Matrix Element-wise mult:");
            for (int i = 0; i < matrixEWmult.GetLength(0); i++)
            {
                for (int j = 0; j < matrixEWmult.GetLength(1); j++)
                {
                    Console.Write(matrixEWmult[i, j] + " ");
                }
                Console.WriteLine();
            }

            double[,] matrixDotProd = DotProduct(matrix1, matrix2);
            Console.WriteLine("Matrix Dot product:");
            for (int i = 0; i < matrixDotProd.GetLength(0); i++)
            {
                for (int j = 0; j < matrixDotProd.GetLength(1); j++)
                {
                    Console.Write(matrixDotProd[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}




