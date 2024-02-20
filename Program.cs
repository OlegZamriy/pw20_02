using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Виберіть опцію:");
        Console.WriteLine("1. Перевести температуру з Фаренгейта в Цельсій");
        Console.WriteLine("2. Перевести температуру з Цельсія в Фаренгейт");
        Console.Write("Ваш вибір: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        double temperature;

        if (choice == 1)
        {
            Console.Write("Введіть температуру в градусах Фаренгейта: ");
            temperature = Convert.ToDouble(Console.ReadLine());
            double celsius = FahrenheitToCelsius(temperature);
            Console.WriteLine($"Температура в градусах Цельсія: {celsius}");
        }
        else if (choice == 2)
        {
            Console.Write("Введіть температуру в градусах Цельсія: ");
            temperature = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = CelsiusToFahrenheit(temperature);
            Console.WriteLine($"Температура в градусах Фаренгейта: {fahrenheit}");
        }
        else
        {
            Console.WriteLine("Помилка: введено неправильний вибір.");
        }
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static double CelsiusToFahrenheit(double celsius)
    {
        return celsius * 9 / 5 + 32;
    }
}
