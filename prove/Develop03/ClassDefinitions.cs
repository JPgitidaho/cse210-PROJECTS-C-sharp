using System;
using System.Collections.Generic;

public class Reference
{
    private string book;
    private int chapter;
    private int verseStart;
    private int verseEnd;

    public Reference(string book, int chapter, int verse)
    {
        this.book = book;
        this.chapter = chapter;
        this.verseStart = verse;
        this.verseEnd = verse;
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        this.book = book;
        this.chapter = chapter;
        this.verseStart = verseStart;
        this.verseEnd = verseEnd;
    }

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

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        this.text = text;
        this.words = ParseWords(text);
        this.hiddenWordCount = 0;
    }

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

    public bool IsCompletelyHidden()
    {
        return hiddenWordCount == words.Count;
    }

    public string GetReferenceString()
    {
        return reference.GetReferenceString();
    }

    public string GetRenderedText()
    {
        var result = new List<string>();

        foreach (var word in words)
        {
            result.Add(word.Display());
        }

        return string.Join(" ", result);
    }

    private List<Word> ParseWords(string text)
    {
        string[] words = text.Split(' ');
        return Array.ConvertAll(words, word => new Word(word, true)).ToList();
    }

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

    public Word(string text, bool visible = true)
    {
        this.text = text;
        this.hidden = !visible;
    }

    public void Hide()
    {
        hidden = true;
    }

    public void Reveal()
    {
        hidden = false;
    }

    public string Display()
    {
        return hidden ? "_____" : text;
    }

    public bool IsHidden()
    {
        return hidden;
    }
}
