namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ejercicio 1
             Copiar el contenido del arreglo origen al arreglo
            destino, dejando en este último los valores
            invertidos respecto del arreglo origen. Utilizar
            estructura de control de flujo repetitiva, y luego
            informar el índice y los valores del nuevo vector.
            
            Por ejemplo, informar de la siguiente manera:
            Arreglo origen
            0 1002
            1 104
            2 309
            3 500
            Arreglo destino
            0 500
            1 309
            2 104
            3 1002
             */

            short[] origen = { 1002, 104, 309, 500 };
            short[] destino = new short[4];

            for (int i = 0; i < origen.Length; i++)
            {
                destino[origen.Length - i - 1] = origen[i];
                //el -1, es x sino cuando i=0 entonces origen.Length = 4, y destino[4], esta fuera de la memoria reservada       
            }

            for (int i = 0; i < destino.Length; i++)
            {
                Console.WriteLine($"{i} \t {destino[i]}");
            }
        }
    }
}