namespace IngresePassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ejercicio Desafío 3
            Desarrollar el código que permita a una persona ingresar como máximo tres veces su contraseña.
              ● En caso de ingreso correcto deberá exhibirse la leyenda “Bienvenido!!”, caso contrario se mostrará “tres veces fallidas”.
              ● Indicar cuantas posibilidades de ingresar el código le queda. Por ejemplo, si tiene 2 posibilidades, informar "Tiene dos chances !" y si le queda una última oportunidad "Atención!! Ultima oportunidad!" */

            string? ReadResult = "";
            string Password = "1234";
            int intentos = 0;

            Console.Clear(); //OJO que si ponía el console.clear dentro del bucle, funcionaba mal

            do
            {
                Console.WriteLine("Por favor ingrese su password para continuar: \r");
                ReadResult = Console.ReadLine();
                if (ReadResult != null)
                    Password = ReadResult;

                if (Password == "1234")
                {
                    Console.WriteLine("¡Bienvenido!!");
                    break;
                }

                intentos++;

                switch (intentos)
                {
                    case 1:
                        Console.WriteLine($"Password inválido. Tiene {3 - intentos} chances!");
                        break;
                    case 2:
                        Console.WriteLine($"Password inválido. Atención!! Última oportunidad!!");
                        break;
                    default:
                        Console.WriteLine($"Password inválido. Tres veces fallidas. \nSu usuario ha sido bloqueado");
                        break;
                }

            } while (Password != "1234" && intentos != 3);

        }
    }
}
