using System;

namespace DiaryApp
{
    public class Entry
    {
        public DateTime Date { get; set; }
        public string Question { get; set; }
        public string Response { get; set; }

        public Entry(DateTime date, string question, string response)
        {
            Date = date;
            Question = question;
            Response = response;
        }

        // Method to get a formatted string representation of the entry
        public string GetFormattedEntry()
        {
            return $"Date: {Date}\nQuestion: {Question}\nResponse: {Response}\n";
        }
    }
}
