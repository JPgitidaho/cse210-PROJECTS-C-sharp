// Encapsulation: Separate concerns with a dedicated class for statistics

class Statistics
{
    public static void DisplayStatistics(User user)
    {
        Console.WriteLine($"Statistics for {user.UserName}: Points - {user.Points}");
    }
}