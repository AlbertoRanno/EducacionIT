namespace Ejercicio1
{
    #region Paso a paso explicado
    /*
     
    Se declara el espacio de nombres Ejercicio1. 
    Los espacios de nombres se utilizan para organizar y agrupar clases y otros elementos relacionados en un programa.
    (Vendrían a ser como los paquetes de Java?)

    Se define la clase Program, que es la clase principal del programa.

    El método Main es el punto de entrada del programa. Aquí comienza la ejecución del programa.

    Se establece el formato de color de la consola en negro (Console.ForegroundColor = ConsoleColor.Black)
    y el fondo en blanco (Console.BackgroundColor = ConsoleColor.White).
    Esto cambia la apariencia de la consola en la que se muestran los mensajes.

    Console.Clear() se utiliza para borrar la pantalla de la consola.

    Console.Title se utiliza para establecer el título de la ventana de la consola.

    Se declara una variable num de tipo int para almacenar el número ingresado por el usuario.

    Se muestra un mensaje en la consola que solicita al usuario que ingrese un número entero positivo.

    Se utiliza Console.ReadLine() para leer la entrada del usuario desde la consola,
    y luego int.Parse() para convertir esa entrada en un número entero y asignarlo a la variable num.

    Se llama al procedimiento Par() pasando el valor de num como argumento.
    La función Par() determinará si el número es par o impar.

    Se muestra un salto de línea en la consola (Console.WriteLine("\n"))
    para separar la salida del procedimiento del mensaje final.

    Se muestra un mensaje en la consola indicando que el programa ha terminado (Console.WriteLine("-->Fin del programa")).

    Console.ReadKey() se utiliza para esperar a que el usuario presione una tecla antes de salir del programa.

    El procedimiento Par() es declarado como static void (no devuelve ningún valor) y toma un parámetro de tipo int llamado a.

    Dentro del procedimiento Par(), se verifica si el número a es par o impar utilizando el operador % para obtener el residuo 
    de la división entre a y 2. Si el residuo es igual a cero, significa que a es par y se muestra el mensaje "Es par". 
    De lo contrario, se muestra el mensaje "Es impar".
     */
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Realizar un programa que permita ingresar un
            número entero positivo e informe si es par o
            impar. Deberá crear al menos un procedimiento
            y/o una función.
             */
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Uso de un procedimiento";
            int num;
            Console.WriteLine("Ingrese un numero entero positivo:");
            num = int.Parse(Console.ReadLine());

            Par(num); //LLamada al procedimiento
            Console.WriteLine("\n");
            Console.WriteLine("-->Fin del programa");
            Console.ReadKey();
        }
        static void Par(int a)
        {

            if ((a % 2) == 0)
            {
                Console.WriteLine("\n Es par");
            }
            else
            {
                Console.WriteLine("\n Es impar");
            }
        }

    }
}