class User
{
    public string UserName { get; set; }
    public int Points { get; set; }
    public List<TaskList> TaskLists { get; set; }

    public User(string userName)
    {
        UserName = userName;
        Points = 0;
        TaskLists = new List<TaskList>();
    }
}