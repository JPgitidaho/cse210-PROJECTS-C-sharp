using System;

class Menu
{
    public static int ShowMenu()
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Display Tasks");
        Console.WriteLine("2. Add Custom Task");
        Console.WriteLine("3. Complete Task");
        Console.WriteLine("4. Display Statistics");
        Console.WriteLine("5. Generate Report");
        Console.WriteLine("0. Exit");

        Console.Write("Enter your choice: ");
        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            return choice;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return -1; 
        }
    }
}
