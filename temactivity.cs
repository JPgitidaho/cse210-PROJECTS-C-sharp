//Inicio del Programa:
//Comenzamos con la declaración de variables y el método Main.


using System;

class Program
{
    static void Main()
    {
       
        string scriptureText = "Juan 3:16 Porque de tal manera amó Dios al mundo ...";
        string[] words = scriptureText.Split(' ');
        //Inicialización de Variables:
        //Inicializamos un arreglo de booleanos hiddenWords para rastrear si cada palabra está oculta o no.

        bool[] hiddenWords = new bool[words.Length];
        //Bucle Principal:
        //bucle que se ejecutará hasta que el usuario decida salir.


        using System;

class Program
    {


        static void Main()
        {

         //Definición de Datos Iniciales:
        //Definimos el pasaje de las Escrituras y lo dividimos en palabras.

            string scriptureText = "Juan 3:16 Porque de tal manera amó Dios al mundo ...";
            string[] words = scriptureText.Split(' ');
            bool[] hiddenWords = new bool[words.Length];
            string option;

            do
            {

                //Mostrar el Pasaje de las Escrituras:
                //Mostramos el pasaje de las Escrituras en la consola, ocultando las palabras marcadas 
                //en hiddenWords con asteriscos y mostrando las demás palabras normalmente.

                Console.Clear();

                Console.WriteLine("Pasaje de las Escrituras:");
                for (int i = 0; i < words.Length; i++)
                {
                    if (hiddenWords[i])
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write(words[i] + " ");
                    }
                }
                //Procesar la Entrada del Usuario:
                //Solicitamos al usuario que elija una opción y almacenamos su elección en la variable option.

                Console.WriteLine("\nElija una opción:");
                Console.WriteLine("1. Ocultar palabras al azar");
                Console.WriteLine("2. Ocultar solo palabras no ocultas");
                Console.WriteLine("Escriba 'quit' para salir");

                option = Console.ReadLine();
                //Ocultar Palabras:
                //Dependiendo de la opción del usuario:
                //Si elige "1", se oculta una palabra al azar seleccionando un índice aleatorio en hiddenWords.
                //Si elige "2", se oculta la primera palabra no oculta encontrada (recorriendo hiddenWords).

                if (option == "1")
                {
                    Random random = new Random();
                    int randomIndex = random.Next(words.Length);
                    hiddenWords[randomIndex] = true;
                }
                else if (option == "2")
                {
                    for (int i = 0; i < words.Length; i++)
                    {
                        if (!hiddenWords[i])
                        {
                            hiddenWords[i] = true;
                            break;
                        }
                    }
                }
            }
            while (option.ToLower() != "quit");

            Console.WriteLine("Programa finalizado.");
        }

        //Limpiar la Pantalla y Repetir:
        //Limpiamos la pantalla para mostrar la visualización actualizada y repetimos el bucle.

        Console.Clear(); // Limpia la pantalla antes de repetir
        }
    //Salida del Programa:
    //Cuando el usuario escribe "quit", el bucle principal termina y el programa se despide.

    Console.WriteLine("Programa finalizado.");
    }
}