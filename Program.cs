using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть довжину лінії: ");
        int length = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введіть символ заповнювач: ");
        char fillChar = Convert.ToChar(Console.ReadLine());

        Console.Write("Введіть напрямок лінії (h - горизонтальна, v - вертикальна): ");
        char direction = Convert.ToChar(Console.ReadLine());

        if (direction == 'h')
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(fillChar);
            }
        }
        else if (direction == 'v')
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(fillChar);
            }
        }
        else
        {
            Console.WriteLine("Помилка: неправильно введений напрямок лінії.");
        }
    }
}
