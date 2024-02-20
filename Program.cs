using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть перше число: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть друге число (відсоток): ");
        double percent = Convert.ToDouble(Console.ReadLine());

        double result = (percent / 100) * number1;

        Console.WriteLine($"Результат: {percent}% від {number1} = {result}");
    }
}
