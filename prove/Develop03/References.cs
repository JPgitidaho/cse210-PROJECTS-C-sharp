using System;
using System.Collections.Generic;
using System.Linq;

public class Reference
{
    private string book;
    private int chapter;
    private int verseStart;
    private int verseEnd;

    // Constructor for a reference with a single verse.
    public Reference(string book, int chapter, int verse)
    {
        this.book = book;
        this.chapter = chapter;
        this.verseStart = verse;
        this.verseEnd = verse;
    }

    // Constructor for a reference with a range of verses.
    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        this.book = book;
        this.chapter = chapter;
        this.verseStart = verseStart;
        this.verseEnd = verseEnd;
    }

    // Get a formatted reference string.
    public string GetReferenceString()
    {
        if (verseStart == verseEnd)
        {
            return $"{book} {chapter}:{verseStart}";
        }
        else
        {
            return $"{book} {chapter}:{verseStart}-{verseEnd}";
        }
    }
}