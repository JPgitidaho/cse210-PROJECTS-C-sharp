class Program
{
    static void Main()
    {
        // Load Bible data from a CSV file
        string csvFilePath = "D:\\BYU 3 SEMESTRE\\cse210-project\\prove\\Develop03\\bible.csv";
        List<Book> bibleBooks = LoadBibleData(csvFilePath);

        string userInput;
        do
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Select a book");
            Console.WriteLine("2. Select a random verse");
            Console.WriteLine("3. Memorize a verse");
            Console.WriteLine("4. Exit");

            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    SelectBook(bibleBooks);
                    break;
                case "2":
                    SelectRandomVerse(bibleBooks);
                    break;
                case "3":
                    MemorizeVerse(bibleBooks);
                    break;
                case "4":
                    Console.WriteLine("Goodbye.");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        } while (userInput != "4");
    }

    // Implementation of SelectBook, SelectRandomVerse, and MemorizeVerse
    // ...
}
