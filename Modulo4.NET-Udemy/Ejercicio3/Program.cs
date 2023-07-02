namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Realizar un programa que solicite al usuario dos
            números y la operación a realizar para mostrar
            su resultado. El programa deberá tener un menú
            de opciones para llamar a funciones que realizan
            las operaciones matemáticas: obtener el mayor
            entre dos números, indicar si un número es
            múltiplo del otro (usar operador %), y calcular la
            potencia es decir un número elevado otro número
            (usar Math.Pow()).
             */
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Elige tu operación matemática";
            int num1, num2;
            string operacion;
            Console.WriteLine("Ingrese un número:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Presione 'A' si desea obtener el mayor de los dos números");
            Console.WriteLine("Presione 'B' si desea saber si un número es múltiplo del otro");
            Console.WriteLine("Presione 'C' si desea obtener el resultado de elevar un número al otro número");
            operacion = Console.ReadLine();

            switch (operacion)
            {
                case "A":
                    elMayor(num1, num2);
                    break;
                case "B":
                    esMultiplo(num1, num2);
                    break;
                case "C":
                    potencia(num1, num2);
                    break;
                default:
                    Console.WriteLine("Presione una opción válida");
                    break;
            }

            Console.WriteLine("\n");
            Console.WriteLine("--> Fin del programa");
            Console.ReadKey();
        }

        static void elMayor(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine($"\n {a} es el mayor");
            }
            else
            {
                Console.WriteLine($"\n {b} es el mayor");
            }
        }

        static void esMultiplo(int a, int b)
        {
            if (a % b == 0)
            {
                Console.WriteLine($"\n {a} y {b} son múltiplos");
            }
            else
            {
                Console.WriteLine($"\n {a} y {b} no son múltiplos");
            }
        }

        static void potencia(int a, int b)
        {
            Console.WriteLine($"\n {a} elevado a {b} es igual a {Math.Pow(a, b)}");
        }
    }
}