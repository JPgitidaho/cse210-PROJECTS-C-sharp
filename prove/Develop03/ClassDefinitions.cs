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

public class Scripture
{
    private Reference reference;
    private string text;
    private List<Word> words;
    private int hiddenWordCount;

    // Constructor to create a Scripture object.
    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        this.text = text;
        this.words = ParseWords(text);
        this.hiddenWordCount = 0;
    }

    // Hide a random word in the scripture.
    public void HideRandomWord(Random random)
    {
        List<Word> visibleWords = words.FindAll(word => !word.IsHidden());

        if (visibleWords.Count > 0)
        {
            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
            hiddenWordCount++;
        }
    }

    // Check if all words in the scripture are hidden.
    public bool IsCompletelyHidden()
    {
        return hiddenWordCount == words.Count;
    }

    // Get a formatted reference string.
    public string GetReferenceString()
    {
        return reference.GetReferenceString();
    }

    // Get the scripture's text with hidden and revealed words.
    public string GetRenderedText()
    {
        var result = new List<string>();

        foreach (var word in words)
        {
            result.Add(word.Display());
        }

        return string.Join(" ", result);
    }

    // Split the scripture's text into individual words.
    private List<Word> ParseWords(string text)
    {
        string[] words = text.Split(' ');
        return Array.ConvertAll(words, word => new Word(word, true)).ToList();
    }

    // Reset the scripture by revealing all words and resetting the hidden word count.
    public void Reset()
    {
        foreach (var word in words)
        {
            word.Reveal();
        }
        hiddenWordCount = 0;
    }
}

public class Word
{
    private string text;
    private bool hidden;

    // Constructor to create a Word object with an initial visibility state.
    public Word(string text, bool visible = true)
    {
        this.text = text;
        this.hidden = !visible;
    }

    // Hide the word.
    public void Hide()
    {
        hidden = true;
    }

    // Reveal the word.
    public void Reveal()
    {
        hidden = false;
    }

    // Get a display string, showing underscores for hidden words.
    public string Display()
    {
        return hidden ? "_____" : text;
    }

    // Check if the word is hidden.
    public bool IsHidden()
    {
        return hidden;
    }
}