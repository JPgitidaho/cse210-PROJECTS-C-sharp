// Encapsulation: Separate concerns with a dedicated class for rewards
class Reward
{
    public static void ProvideRewards(User user)
    {
        Console.WriteLine($"{user.UserName} earned rewards!");
        user.Points += 5;
    }
}