using System;
using System.Collections.Generic;
using System.Linq;

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