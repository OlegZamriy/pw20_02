using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть значення A: ");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введіть значення B: ");
        int B = Convert.ToInt32(Console.ReadLine());

        if (A >= B)
        {
            Console.WriteLine("Помилка: A повинне бути менше B.");
            return;
        }

        for (int i = A; i <= B; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(); 
        }
    }
}
