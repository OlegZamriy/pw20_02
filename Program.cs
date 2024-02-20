using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть початок діапазону: ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введіть кінець діапазону: ");
        int end = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Числа Фібоначчі в діапазоні з {start} до {end}:");
        PrintFibonacciNumbersInRange(start, end);
    }

    static void PrintFibonacciNumbersInRange(int start, int end)
    {
        int a = 0;
        int b = 1;
        int c = a + b;

        if (start <= 1 && end >= 0)
            Console.WriteLine(0);
        if (start <= 1 && end >= 1)
            Console.WriteLine(1);

        while (c <= end)
        {
            if (c >= start)
                Console.WriteLine(c);
            a = b;
            b = c;
            c = a + b;
        }
    }
}
