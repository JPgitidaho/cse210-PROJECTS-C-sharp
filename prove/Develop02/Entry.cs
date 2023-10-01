using System;

namespace DiaryApp
{
    // This class represents an individual diary entry.
    public class Entry
    {
        public DateTime Date { get; set; }      // Date of the diary entry.
        public string Question { get; set; }     // Prompt or question for the entry.
        public string Response { get; set; }     // Response or answer to the question.

        // Constructor to initialize an Entry.
        public Entry(DateTime date, string question, string response)
        {
            Date = date;
            Question = question;
            Response = response;
        }
    }
}
