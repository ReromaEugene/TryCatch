using System;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            int start = ReadInt("Enter Start Number: ");
            int end = ReadInt("Enter End Number: ");

            if (start <= 0 || start >= end || end <= start || end <= 0 || end >= 101)
            {
                throw new Exception("Invalid input range.");
            }

            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < 10; i++)
            {
                string suffix = GetOrdinalSuffix(i + 1);
                int number = ReadInt($"Enter {i + 1}{suffix} Number: ");

                if (number < start || number > end)
                {
                    throw new Exception($"Input should be between {start} and {end}.");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
        finally
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Goodbye!");
        }
    }

    static int ReadInt(string message)
    {
        int number;
        while (true)
        {
            Console.Write(message);
            if (int.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    static string GetOrdinalSuffix(int number)
    {
        if (number % 10 == 1 && number != 11)
        {
            return "st";
        }
        if (number % 10 == 2 && number != 12)
        {
            return "nd";
        }
        if (number % 10 == 3 && number != 13)
        {
            return "rd";
        }
        return "th";
    }
}
