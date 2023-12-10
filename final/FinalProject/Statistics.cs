class Statistics
{
    // Displays user statistics, including the total points.
    public static void DisplayStatistics(User user)
    {
        Console.WriteLine($"User Statistics: Total Points - {user.GetPoints()}");
    }
}
