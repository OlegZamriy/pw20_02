using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть шестизначне число:");
        int number = Convert.ToInt32(Console.ReadLine());

        int reversedNumber = ReverseNumber(number);

        Console.WriteLine($"Результат перевертання числа: {reversedNumber}");
    }

    static int ReverseNumber(int num)
    {
        int reversedNum = 0;
        while (num > 0)
        {
            int digit = num % 10;
            reversedNum = reversedNum * 10 + digit;
            num /= 10;
        }
        return reversedNum;
    }
}
