using System;
using System.Collections.Generic;
using System.Linq;



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