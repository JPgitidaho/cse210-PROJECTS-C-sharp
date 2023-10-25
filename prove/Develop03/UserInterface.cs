using System;

public class UserInterface
{
    public static void DisplayIntroduction()
    {
        Console.WriteLine("Scripture Hiding Game");
    }

    public static void DisplayScripture(Reference reference, string text)
    {
        Console.WriteLine(reference.GetReferenceString());
        Console.WriteLine(text);
    }

    public static string GetUserInput()
    {
        Console.WriteLine("Press ENTER to continue or type 'quit' to exit.");
        return Console.ReadLine();
    }

    public static string GetPlayAgainInput()
    {
        Console.WriteLine("Do you want to play again with the same scripture, a different scripture, or quit? (same/different/quit)");
        return Console.ReadLine().ToLower();
    }

    public static void DisplayCompletionMessage()
    {
        Console.WriteLine("All words in the scripture are hidden.");
    }

public static int ShowMainMenu()
{
    Console.WriteLine("Main Menu");
    Console.WriteLine("1. Jugar con una nueva Escritura");
    Console.WriteLine("2. Cargar Escrituras desde un archivo");
    Console.WriteLine("3. Mostrar Estadísticas");
    Console.WriteLine("4. Salir");

    int choice = 0; // Inicializa choice con un valor predeterminado
    bool validChoice = false;

    while (!validChoice)
    {
        Console.Write("Seleccione una opción: ");
        if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 4)
        {
            validChoice = true;
        }
        else
        {
            Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
        }
    }

    return choice;
}
}
