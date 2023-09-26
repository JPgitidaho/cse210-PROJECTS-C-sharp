using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store the numbers entered by the user.
        List<double> numbers = new List<double>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Keep prompting the user for numbers until they enter 0.
        while (true)
        {
            Console.Write("Enter number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            // If the user enters 0, break out of the loop.
            if (number == 0)
                break;

            // Add the entered number to the list.
            numbers.Add(number);
        }

        // Check if there are any numbers in the list.
        if (numbers.Count > 0)
        {
            double sum = 0;
            double max = numbers[0];

            // Calculate the sum and find the maximum number in the list.
            foreach (double number in numbers)
            {
                sum += number;

                if (number > max)
                    max = number;
            }

            // Calculate the average.
            double average = sum / numbers.Count;

            // Display the results.
            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine("The average is: " + average);
            Console.WriteLine("The largest number is: " + max);
        }
        else
        {
            // If no numbers were entered, display a message.
            Console.WriteLine("No numbers were entered in the list.");
        }
    }
}