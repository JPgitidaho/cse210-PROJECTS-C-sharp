
class Reward
{
    // Provides rewards to the user.
    public static void ProvideRewards(User user)
    {
        user.AddPoints(5);
    }

    // Displays the earned rewards for the user.
    public static void DisplayEarnedRewards(User user)
    {
        Console.WriteLine($"{user.GetPoints()} earned rewards!");
    }
}

