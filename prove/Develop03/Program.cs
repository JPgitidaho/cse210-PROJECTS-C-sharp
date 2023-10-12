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
                    Console.WriteLine("Goodbye, good try!.");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        } while (userInput != "4");
    }

    // Implementation of selecting a book
string SelectBook()
{
    Console.WriteLine("Choose a book from the Bible (e.g., 'John'):");
    string selectedBook = Console.ReadLine();
    // You can add logic here to validate the selected book
    return selectedBook;
}

// Implementation of selecting a random verse
string SelectRandomVerse(List<string> verses)
{
    Random random = new Random();
    int randomIndex = random.Next(verses.Count);
    return verses[randomIndex];
}

// Implementation of memorizing a verse
void MemorizeVerse(string verse)
{
    Console.WriteLine("Selected Verse: ");
    Console.WriteLine(verse);

    // You can add logic here to allow the user to memorize the verse
    Console.WriteLine("Type 'memorized' when you have memorized the verse.");
    string userInput = Console.ReadLine();
    if (userInput.ToLower() == "memorized")
    {
        Console.WriteLine("Verse memorized!");
    }
}

}
