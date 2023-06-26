

namespace IngresePassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            while (numero <= 5) //while se usa mucho en integraciones: "leeme los datos hasta que encuentres la palabra "fin"
            {
                if (numero == 3)
                {
                    Console.WriteLine("El ciclo se interrumpe");
                    break; //el break indica, terminar el ciclo y ejecutar la siguiente instrucción
                }
                Console.WriteLine(numero);
                numero++;
            }
            Console.ReadKey(); //La app se queda esperando que toque alguna tecla
                               //En versiones anteriores, las app se cerraban, luego de mostrar...
                               //Ahora muestran msj por màs que no pongan el readkey
                               //AHORA NO ES NECESARIO EL CONSOLE.READKEY!!
        }
    }
}