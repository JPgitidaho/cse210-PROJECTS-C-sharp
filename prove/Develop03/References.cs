using System;
using System.Collections.Generic;
using System.Linq;

public class Reference
{
    private string book;
    private int chapter;
    private List<int> verses;



    // Constructor for a reference with a range of verses.
    public Reference(string book, int chapter, params int[] verseNumbers)
    {
        this.book = book;
        this.chapter = chapter;
        this.verses = verseNumbers.ToList();
    }

    // Get a formatted reference string.
     public string GetReferenceString()
    {
        string verseString = string.Join("-", verses);
        return $"{book} {chapter}:{verseString}";
    }
    
}