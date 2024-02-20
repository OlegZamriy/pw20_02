using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть чотири цифри:");

        int[] digits = new int[4];

        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Цифра {i + 1}: ");
            digits[i] = Convert.ToInt32(Console.ReadLine());
        }

        int number = digits[0] * 1000 + digits[1] * 100 + digits[2] * 10 + digits[3];

        Console.WriteLine($"Отримане число: {number}");
    }
}
