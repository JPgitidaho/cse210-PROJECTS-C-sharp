class Program
{
    static void Main()
    {
        // Solicitar el nombre del usuario
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        // Crear una instancia del usuario
        User user = new User(userName);

        // Crear una lista personalizada de tareas para el usuario
        CleaningTaskList customTaskList = new CleaningTaskList("Your Tasks list");

        // Agregar la instancia de CleaningTaskList a la lista TaskLists del usuario
        user.TaskLists.Add(customTaskList);

        // Mensaje de bienvenida
        Console.WriteLine($"Welcome to the Household Task Manager, {user.UserName}!");

        // Bucle principal del programa
        while (true)
        {
            // Menú de opciones
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Display Tasks");
            Console.WriteLine("2. Add Custom Task");
            Console.WriteLine("3. Complete Task");
            Console.WriteLine("4. Display Statistics");
            Console.WriteLine("5. Generate Report");
            Console.WriteLine("0. Exit");

            // Solicitar la elección del usuario
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            // Procesar la elección del usuario
            switch (choice)
            {
                case "1":
                    customTaskList.DisplayTasks();
                    break;
                case "2":
                    // Solicitar al usuario descripción de la tarea y agregarla a la lista
                    Console.Write("Enter task description: ");
                    string taskDescription = Console.ReadLine();
                    customTaskList.AddTask(taskDescription);
                    Console.WriteLine($"Task '{taskDescription}' added.");
                    break;
                case "3":
                    // Solicitar al usuario el índice de la tarea a completar y marcarla como completada
                    Console.Write("Enter the index of the task to complete: ");
                    if (int.TryParse(Console.ReadLine(), out int taskIndex))
                    {
                        customTaskList.CompleteTask(taskIndex, user);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    break;
                case "4":
                    // Mostrar estadísticas del usuario
                    Statistics.DisplayStatistics(user);
                    break;
                case "5":
                    // Generar un informe para el usuario
                    Report.GenerateReport(user);
                    break;

                case "0":
                    // Salir del programa
                    Console.WriteLine("Exiting. Goodbye!");
                    return;
                default:
                    // Mensaje para elecciones no válidas
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
