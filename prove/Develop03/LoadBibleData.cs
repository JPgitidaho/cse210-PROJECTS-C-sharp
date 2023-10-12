// Function to load Bible data from a CSV file
static List<Book> LoadBibleData(string csvFilePath)
{
    List<Book> books = new List<Book>();
    using (StreamReader reader = new StreamReader(csvFilePath))
    {
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            string[] parts = line.Split(',');
            if (parts.Length >= 4 && int.TryParse(parts[0], out int bookNumber)
                && int.TryParse(parts[1], out int chapterNumber)
                && int.TryParse(parts[2], out int verseNumber))
            {
                string bookName = parts[3];
                string verseText = parts.Length > 4 ? parts[4] : string.Empty;
                // Create or find the book
                Book book = books.FirstOrDefault(b => b.Name == bookName);
                if (book == null)
                {
                    book = new Book(bookName, new List<Chapter>());
                    books.Add(book);
                }
                // Create or find the chapter
                Chapter chapter = book.Chapters.FirstOrDefault(c => c.Number == chapterNumber);
                if (chapter == null)
                {
                    chapter = new Chapter(chapterNumber, new List<Verse>());
                    book.Chapters.Add(chapter);
                }
                // Add the verse
                Verse verse = new Verse(verseText, chapterNumber, verseNumber);
                chapter.Verses.Add(verse);
            }
        }
    }
    return books;
}
