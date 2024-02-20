using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        Console.WriteLine("Введіть п'ять чисел:");

        int[] numbers = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Число {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        int max = numbers[0];
        int min = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
                max = num;
            if (num < min)
                min = num;
        }

        int product = 1;
        foreach (int num in numbers)
        {
            product *= num;
        }

        Console.WriteLine($"Сума: {sum}");
        Console.WriteLine($"Максимум: {max}");
        Console.WriteLine($"Мінімум: {min}");
        Console.WriteLine($"Добуток: {product}");
    }
}
