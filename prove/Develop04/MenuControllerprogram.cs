
class Program
{
    static void Main(string[] args)
    {
        string input;
        do{
            Console.Clear();
            Console.WriteLine("Welcome to Mindful Activities!");
                Console.WriteLine("\nPlease select an activity:");
                Console.WriteLine("1. Breathing");
                Console.WriteLine("2. Reflection");
                Console.WriteLine("3. Listing");
                Console.WriteLine("4. Quit");
            input = Console.ReadLine();
            if(input == "1")
            {
                BreathingActivity BA = new BreathingActivity();
                BA.StartActivity();
            }
            else if(input == "2")
            {
                ReflectingActivity RA = new ReflectingActivity();
                RA.StartActivity();
            }
            else if(input == "3")
            {
                ListingActivity LA = new ListingActivity();
                LA.StartActivity();
            }
            else if(input == "4")
            {
                break;
            }
        }while(input != "4");
        

    }
}
