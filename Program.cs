using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть дату (у форматі dd.mm.yyyy): ");
        string inputDate = Console.ReadLine();

        DateTime date;
        if (!DateTime.TryParseExact(inputDate, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out date))
        {
            Console.WriteLine("Помилка: неправильний формат дати.");
            return;
        }

        string season = GetSeason(date.Month);

        string dayOfWeek = date.DayOfWeek.ToString();

        Console.WriteLine($"{season} {dayOfWeek}");
    }

    static string GetSeason(int month)
    {
        switch (month)
        {
            case 12:
            case 1:
            case 2:
                return "Winter";
            case 3:
            case 4:
            case 5:
                return "Spring";
            case 6:
            case 7:
            case 8:
                return "Summer";
            case 9:
            case 10:
            case 11:
                return "Autumn";
            default:
                return "Unknown";
        }
    }
}
