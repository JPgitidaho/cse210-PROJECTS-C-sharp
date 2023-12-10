class User
{
    public string UserName { get; private set; }
    public int Points { get; private set; }
    public List<TaskList> TaskLists { get; private set; }

    // Constructor to initialize the user with a username.
    public User(string userName)
    {
        UserName = userName;
        Points = 0;
        TaskLists = new List<TaskList>();
    }

    // Gets the points of the user.
    public int GetPoints()
    {
        return Points;
    }

    // Adds additional points to the user.
    public void AddPoints(int additionalPoints)
    {
        Points += additionalPoints;
    }

    // Gets the task lists of the user.
    public List<TaskList> GetTaskLists()
    {
        return TaskLists;
    }

    // Adds a task list to the user.
    public void AddTaskList(TaskList taskList)
    {
        TaskLists.Add(taskList);
    }
}
