using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть шестизначне число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 100000 || number > 999999)
        {
            Console.WriteLine("Помилка: введене число не є шестизначним.");
            return;
        }

        Console.Write("Введіть номери розрядів для заміни (наприклад, 1 і 6): ");
        string[] positionsInput = Console.ReadLine().Split(' ');

        if (positionsInput.Length != 2)
        {
            Console.WriteLine("Помилка: введіть два номери розрядів через пробіл.");
            return;
        }

        int position1 = Convert.ToInt32(positionsInput[0]);
        int position2 = Convert.ToInt32(positionsInput[1]);

        if (position1 < 1 || position1 > 6 || position2 < 1 || position2 > 6)
        {
            Console.WriteLine("Помилка: номери розрядів мають бути від 1 до 6.");
            return;
        }

        int[] digits = new int[6];

        for (int i = 5; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }

        int temp = digits[position1 - 1];
        digits[position1 - 1] = digits[position2 - 1];
        digits[position2 - 1] = temp;

        int newNumber = digits[0] * 100000 + digits[1] * 10000 + digits[2] * 1000 + digits[3] * 100 + digits[4] * 10 + digits[5];

        Console.WriteLine($"Результат: {newNumber}");
    }
}
