using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Class to represent a Bible verse
class Verse
{
    public string Text { get; }
    public int ChapterNumber { get; }
    public int VerseNumber { get; }

    public Verse(string text, int chapterNumber, int verseNumber)
    {
        Text = text;
        ChapterNumber = chapterNumber;
        VerseNumber = verseNumber;
    }
}

// Class to represent a Bible chapter
class Chapter
{
    public int Number { get; }
    public List<Verse> Verses { get; }

    public Chapter(int number, List<Verse> verses)
    {
        Number = number;
        Verses = verses;
    }
}

// Class to represent a Bible book
class Book
{
    public string Name { get; }
    public List<Chapter> Chapters { get; }

    public Book(string name, List<Chapter> chapters)
    {
        Name = name;
        Chapters = chapters;
    }
}
