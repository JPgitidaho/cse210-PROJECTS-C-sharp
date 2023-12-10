// Represents an abstract base class for task lists.
abstract class TaskList
{
    // Gets the name of the task list.
    public string ListName { get; protected set; }

    // Stores the tasks in the task list.
    protected List<Task> Tasks;

    // Método abstracto para completar tareas
    public abstract void CompleteTask(int taskIndex, User user);

    // Constructor to initialize the task list with a name.
    public TaskList(string listName)
    {
        ListName = listName;
        Tasks = new List<Task>();
    }

    // Abstract method to be implemented by derived classes for displaying tasks.
    public abstract void DisplayTasks();
    

    // Gets the tasks in the task list.
    public List<Task> GetTasks()
    {
        return Tasks;
    }

    // Adds a new task to the task list.
    public void AddTask(string description)
    {
        Tasks.Add(new Task(description));
    }

    // Gets the name of the task list.
    public string GetListName()
    {
        return ListName;
    }
}
