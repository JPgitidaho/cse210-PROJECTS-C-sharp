using System;
using System.IO;

class ListingActivity : Activity
{
    private List<string> Prompt = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes"
    };

    public ListingActivity()
    {
        NameOfActivity = "Listing Activity";
        Message = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n**If you play this option more than once, you can view your previous responses**.";    }

    public override void activity()
    {
        base.activity();
        Random randomGenerator = new Random();
        int RandomNumber = randomGenerator.Next(0, Prompt.Count);
        Console.WriteLine();

        string filePath = @"D:text.txt";

        // Cargar y mostrar respuestas previas
        if (File.Exists(filePath))
        {
            Console.WriteLine("Your previous responses:");
            string[] previousResponses = File.ReadAllLines(filePath);
            foreach (string response in previousResponses)
            {
                Console.WriteLine($"- {response}");
            }
        }

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($">>>>>>{Prompt[RandomNumber]}");
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        do
        {
            Console.Write(" > ");
            string input = Console.ReadLine();

            // Guardar la respuesta en el archivo
            File.AppendAllText(filePath, $"{input}\n");
        } while (endTime > DateTime.Now);

        // Mostrar mensaje de respuestas guardadas
        Console.WriteLine("Responses saved to file.");
    }
}
