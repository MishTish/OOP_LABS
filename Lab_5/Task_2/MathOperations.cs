namespace Task_2
{
    public class MathOperations
    {

        public static double Add(double a, double b)
        {
            return a + b;
        }


        public static double[] Add(double[] vector1, double[] vector2)
        {
            if (vector1.Length != vector2.Length)
                throw new ArgumentException("Arrays must have the same length.");

            double[] result = new double[vector1.Length];
            for (int i = 0; i < vector1.Length; i++)
            {
                result[i] = vector1[i] + vector2[i];
            }
            return result;
        }

        public static double[,] Add(double[,] matrix1, double[,] matrix2)
        {
            if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
                throw new ArgumentException("Matrices must have the same dimensions.");

            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);
            double[,] result = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return result;
        }

  
        public static double[,,] Add(double[,,] tensor1, double[,,] tensor2)
        {
            if (tensor1.GetLength(0) != tensor2.GetLength(0) ||
                tensor1.GetLength(1) != tensor2.GetLength(1) ||
                tensor1.GetLength(2) != tensor2.GetLength(2))
                throw new ArgumentException("Tensors must have the same dimensions.");

            int dim1 = tensor1.GetLength(0);
            int dim2 = tensor1.GetLength(1);
            int dim3 = tensor1.GetLength(2);
            double[,,] result = new double[dim1, dim2, dim3];

            for (int i = 0; i < dim1; i++)
            {
                for (int j = 0; j < dim2; j++)
                {
                    for (int k = 0; k < dim3; k++)
                    {
                        result[i, j, k] = tensor1[i, j, k] + tensor2[i, j, k];
                    }
                }
            }
            return result;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double[] Subtract(double[] vector1, double[] vector2)
        {
            if (vector1.Length != vector2.Length)
                throw new ArgumentException("Arrays must have the same length.");

            double[] result = new double[vector1.Length];
            for (int i = 0; i < vector1.Length; i++)
            {
                result[i] = vector1[i] - vector2[i];
            }
            return result;
        }

        public static double[,] Subtract(double[,] matrix1, double[,] matrix2)
        {
            if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
                throw new ArgumentException("Matrices must have the same dimensions.");

            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);
            double[,] result = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return result;
        }
        public static double[,,] Subtract(double[,,] tensor1, double[,,] tensor2)
        {
            if (tensor1.GetLength(0) != tensor2.GetLength(0) ||
                tensor1.GetLength(1) != tensor2.GetLength(1) ||
                tensor1.GetLength(2) != tensor2.GetLength(2))
                throw new ArgumentException("Tensors must have the same dimensions.");

            int dim1 = tensor1.GetLength(0);
            int dim2 = tensor1.GetLength(1);
            int dim3 = tensor1.GetLength(2);
            double[,,] result = new double[dim1, dim2, dim3];

            for (int i = 0; i < dim1; i++)
            {
                for (int j = 0; j < dim2; j++)
                {
                    for (int k = 0; k < dim3; k++)
                    {
                        result[i, j, k] = tensor1[i, j, k] - tensor2[i, j, k];
                    }
                }
            }
            return result;
        }


        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static double[] ElementMultiply(double[] vector1, double[] vector2)
        {
            if (vector1.Length != vector2.Length)
                throw new ArgumentException("Arrays must have the same length.");

            double[] result = new double[vector1.Length];
            for (int i = 0; i < vector1.Length; i++)
            {
                result[i] = vector1[i] * vector2[i];
            }
            return result;
        }
        public static double[,] ElementMultiply(double[,] matrix1, double[,] matrix2)
        {
            if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
                throw new ArgumentException("Matrices must have the same dimensions.");

            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);
            double[,] result = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] * matrix2[i, j];
                }
            }
            return result;
        }
        public static double[,,] ElementMultiply(double[,,] tensor1, double[,,] tensor2)
        {
            if (tensor1.GetLength(0) != tensor2.GetLength(0) ||
                tensor1.GetLength(1) != tensor2.GetLength(1) ||
                tensor1.GetLength(2) != tensor2.GetLength(2))
                throw new ArgumentException("Tensors must have the same dimensions.");

            int dim1 = tensor1.GetLength(0);
            int dim2 = tensor1.GetLength(1);
            int dim3 = tensor1.GetLength(2);
            double[,,] result = new double[dim1, dim2, dim3];

            for (int i = 0; i < dim1; i++)
            {
                for (int j = 0; j < dim2; j++)
                {
                    for (int k = 0; k < dim3; k++)
                    {
                        result[i, j, k] = tensor1[i, j, k] * tensor2[i, j, k];
                    }
                }
            }
            return result;
        }
        public static double DotProduct(double[] vector1, double[] vector2)
        {
            if (vector1.Length != vector2.Length)
                throw new ArgumentException("Vectors must have the same length.");

            double result = 0;
            for (int i = 0; i < vector1.Length; i++)
            {
                result += vector1[i] * vector2[i];
            }
            return result;
        }

        public static double[,] DotProduct(double[,] matrix1, double[,] matrix2)
        {
            if (matrix1.GetLength(1) != matrix2.GetLength(0))
                throw new ArgumentException("Number of columns in the first matrix must equal the number of rows in the second matrix.");

            int rows = matrix1.GetLength(0);
            int cols = matrix2.GetLength(1);
            int innerDim = matrix1.GetLength(1);
            double[,] result = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    for (int k = 0; k < innerDim; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return result;
        }
        public static double[,,] DotProduct(double[,,] tensor1, double[,,] tensor2)
        {
            if (tensor1.GetLength(2) != tensor2.GetLength(1))
                throw new ArgumentException("The last dimension of the first tensor must match the second-to-last dimension of the second tensor.");

            int dim1 = tensor1.GetLength(0);
            int dim2 = tensor1.GetLength(1);
            int dim3 = tensor2.GetLength(2);
            double[,,] result = new double[dim1, dim2, dim3];

            for (int i = 0; i < dim1; i++)
            {
                for (int j = 0; j < dim2; j++)
                {
                    for (int k = 0; k < dim3; k++)
                    {
                        double sum = 0;
                        for (int l = 0; l < tensor1.GetLength(2); l++)
                        {
                            sum += tensor1[i, j, l] * tensor2[i, l, k];
                        }
                        result[i, j, k] = sum;
                    }
                }
            }
            return result;
        }
    }
}
