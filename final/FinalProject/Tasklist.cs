using System;
using System.Collections.Generic;

// Abstraction: Define abstract classes/interfaces to model objects
abstract class TaskList
{
    public string ListName { get; set; }
    public List<Task> Tasks { get; set; }

    // Abstraction: Constructor para inicializar las propiedades
    public TaskList(string listName)
    {
        ListName = listName;
        Tasks = new List<Task>();
    }

    // Abstraction: Defining an abstract method to be implemented by derived classes
    public abstract void DisplayTasks();
}