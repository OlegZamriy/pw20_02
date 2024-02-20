using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть число від 1 до 100: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 1 || number > 100)
        {
            Console.WriteLine("Помилка: число має бути від 1 до 100.");
            return;
        }

        if (number % 3 == 0 && number % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (number % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (number % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(number);
        }
    }
}
