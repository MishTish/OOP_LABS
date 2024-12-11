namespace Task_1
{
    public class Calculator<T> where T : struct, IComparable, IConvertible, IFormattable
    {

        public delegate T Operation(T a, T b);

        public T Add(T a, T b, Operation addOperation)
        {
            return addOperation(a, b);
        }

        public T Subtract(T a, T b, Operation subtractOperation)
        {
            return subtractOperation(a, b);
        }

        public T Multiply(T a, T b, Operation multiplyOperation)
        {
            return multiplyOperation(a, b);
        }

        public T Divide(T a, T b, Operation divideOperation)
        {
            if (b.Equals(default(T)))
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return divideOperation(a, b);
        }
        public T Power(T a, T b, Operation powerOperation)
        { return powerOperation(a, b); }

    }

}
