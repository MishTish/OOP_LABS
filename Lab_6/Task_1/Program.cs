using Task_1;

Calculator<int> intCalculator = new Calculator<int>();

Calculator<int>.Operation intAdd = (a, b) => a + b;
Calculator<int>.Operation intSubtract = (a, b) => a - b;
Calculator<int>.Operation intMultiply = (a, b) => a * b;
Calculator<int>.Operation intDivide = (a, b) => a / b;
Calculator<int>.Operation intPower = (a, b) => (int)Math.Pow(a, b);

Console.WriteLine("Integer Calculator:");
Console.WriteLine($"Addition: {intCalculator.Add(10, 5, intAdd)}");
Console.WriteLine($"Subtraction: {intCalculator.Subtract(10, 5, intSubtract)}");
Console.WriteLine($"Multiplication: {intCalculator.Multiply(10, 5, intMultiply)}");
Console.WriteLine($"Division: {intCalculator.Divide(10, 5, intDivide)}");
Console.WriteLine($"Power: {intCalculator.Power(2, 5, intPower)}");

Calculator<double> doubleCalculator = new Calculator<double>();

Calculator<double>.Operation doubleAdd = (a, b) => a + b;
Calculator<double>.Operation doubleSubtract = (a, b) => a - b;
Calculator<double>.Operation doubleMultiply = (a, b) => a * b;
Calculator<double>.Operation doubleDivide = (a, b) => a / b;
Calculator<double>.Operation doublePower = (a, b) => Math.Pow(a, b);

Console.WriteLine("\nDouble Calculator:");
Console.WriteLine($"Addition: {doubleCalculator.Add(10.5, 5.2, doubleAdd)}");
Console.WriteLine($"Subtraction: {doubleCalculator.Subtract(10.5, 5.2, doubleSubtract)}");
Console.WriteLine($"Multiplication: {doubleCalculator.Multiply(10.5, 5.2, doubleMultiply)}");
Console.WriteLine($"Division: {doubleCalculator.Divide(10.5, 5.2, doubleDivide)}");
Console.WriteLine($"Power: {doubleCalculator.Power(2, 0.5, doublePower)}");
