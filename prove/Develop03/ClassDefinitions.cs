using System;
using System.Collections.Generic;
using System.Text;



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

    public void Show()
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

public class Reference
{
    private string book;
    private int chapter;
    private int verse;
    private int? verseEnd;

    public Reference(string book, int chapter, int verse, int? verseEnd = null)
    {
        this.book = book;
        this.chapter = chapter;
        this.verse = verse;
        this.verseEnd = verseEnd;
    }

    public string GetReference()
    {
        if (verseEnd.HasValue)
        {
            return $"{book} {chapter}:{verse}-{verseEnd}";
        }
        return $"{book} {chapter}:{verse}";
    }
}

public class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, List<Word> words)
    {
        this.reference = reference;
        this.words = words;
    }

    public void HideWords()
    {
        foreach (var word in words)
        {
            if (!word.IsHidden())
            {
                word.Hide();
                break; // Hide the first visible word
            }
        }
    }

    public bool AllWordsHidden()
    {
        return words.All(word => word.IsHidden());
    }

    public string RenderText()
    {
        var text = new StringBuilder();
        foreach (var word in words)
        {
            text.Append(word.Display() + " ");
        }
        return text.ToString();
    }
}
