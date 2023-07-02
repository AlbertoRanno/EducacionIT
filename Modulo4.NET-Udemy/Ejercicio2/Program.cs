namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Realizar un programa que solicite al usuario dos
            números y la operación a realizar para mostrar
            su resultado; y tenga dos funciones que sean
            capaces de realizar una suma y una resta.
             */
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Los sumo o los resto?";
            int num1, num2;
            string operacion;
            Console.WriteLine("Ingrese un numero:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Presion 'S' si desea realizar una suma, o 'R' si prefiere una resta");
            operacion = Console.ReadLine();

            if (operacion == "S")
            {
                Suma(num1, num2);//LLamada al procedimiento
            }
            if (operacion == "R")
            {
                Resta(num1, num2);//LLamada al procedimiento
            }

            Console.WriteLine("\n");
            Console.WriteLine("-->Fin del programa");
            Console.ReadKey();
        }
        static void Suma(int a, int b)
        {
            Console.WriteLine($"\n {a + b}");
        }
        static void Resta(int a, int b)
        {
            Console.WriteLine($"\n {a - b}");
        }
    }
}