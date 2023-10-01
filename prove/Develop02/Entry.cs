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
    }
}
