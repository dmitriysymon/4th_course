using System;

public class Program
{
    public delegate double Func(double x);
    public static double calculate(Func func, double a, double b, int n)
    {
        double h = (b - a) / n;
        double integral = 0.0;
        for (int i = 1; i <= n; i++)
        {
            double x = a + i * h;
            integral += func(x);
        }
        double result = h * integral;
        return result;
    }
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Default;
        double[] result = new double[3];
        int n = 100;
        int a = 0;
        int b = 1;
        Func func = (double x) => 1.0 / Math.Exp(x);
        result[0] = calculate(func, a, b, n);
        func = (double x) => 1.0/Math.Sqrt(Math.Pow(x,2));
        result[1] = calculate(func, a, b, n);
        func = (double x) => 1.0/x*Math.Cos(x);
        result[2] = calculate(func, a, b, n);
        int i = 1;
        foreach (double x in result)
        {
            Console.WriteLine($"Інтеграл функції №{i}: {x}");
            i++;
        }
        func = (double x) => Math.Pow(x, 2.0);
        double integral = calculate(func, -1, 6, n);
        Console.WriteLine("Інтеграл функції f(x) = x^2: " + integral);
        double analyticValue = (Math.Pow(6, 3) / 3) - (Math.Pow(-1, 3) / 3);
        double error = Math.Abs(analyticValue - integral);
        Console.WriteLine("Похибка: " + error);
    }
}