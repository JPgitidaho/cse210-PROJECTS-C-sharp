using System;

namespace DiaryApp
{
    class Program
    {
        private static Diary diary;
        private static System.Timers.Timer autoSaveTimer;

        static void Main(string[] args)
        {
            // Initialize the Diary and PromptGenerator.
            diary = new Diary();
            PromptGenerator promptGenerator = new PromptGenerator();
            bool exit = false;

            // This do-while loop allows the user to perform various operations in the program until they choose to exit.
            do
            {
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Write a new entry");  // Option to add a new diary entry.
                Console.WriteLine("2. Show diary");         // Option to display all diary entries.
                Console.WriteLine("3. Save diary to a file");  // Option to save diary entries to a file.
                Console.WriteLine("4. Load diary from a file");  // Option to load diary entries from a file.
                Console.WriteLine("5. Search diary entries by keyword");  // Option to search diary entries.
                Console.WriteLine("6. Exit");  // Option to exit the program.

                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {

