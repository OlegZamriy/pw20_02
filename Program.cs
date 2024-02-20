using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть початок діапазону: ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введіть кінець діапазону: ");
        int end = Convert.ToInt32(Console.ReadLine());

        if (start > end)
        {
            Console.WriteLine("Помилка: початок діапазону не може бути більше кінця. Виконуємо нормалізацію.");
            int temp = start;
            start = end;
            end = temp;
        }

        Console.WriteLine($"Парні числа в діапазоні від {start} до {end}:");
        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
