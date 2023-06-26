namespace Arrays1D
{
    internal class Program
    {

        #region Declaraciones de Arrays
        //las regiones se usan para emprolijar / ordenar el documento si es largo
                     
        static void Main(string[] args)           
        {
            /* En los lenguajes fuertemente tipados, los arrays vienen con un tamaño predefinido, y no se puede modificar el mismo sobre
            el transcurso, motivo por el cual en NET y JAVA, existen varios tipos de datos más flexibles, como las LISTAS. */

            //si todavía NO tuviera los valores del array, no es una buena práctica, tener la memoria ocupada, entonces solo declaro:
            int[] losValores;

            //si no supiera a priori cuántos valores van a ser, lo pregunto de alguna forma, y reservo en consecuencia:
            int CuantosValores = 4; 
                    
            //Una vez que pido los datos, los valido, y recien ahi reservo la memoria:
            losValores = new int[CuantosValores]; 

            losValores[0] = 154;
            losValores[1] = 28;
            losValores[2] = -1684;
            losValores[3] = 0;
            
            //Los arrays se manejan por lo gral con FOR, y FOREACH, aunque podría usar WHILE
            for (int Posicion = 0; Posicion < losValores.Length; Posicion++)
            {
                Console.WriteLine(losValores[Posicion]);
            }
            
            /* El ReadKey, se usaba en versiones viejas para que la consola se detuviera a mostrar el resultado, antes de cerrarse.
            
             Actualmente no es necesario, dado que viene un msj por default de presionar cualquier tecla para salir
            
             Pero entiendo que podría ser util cuando, en casos como este, muestro una tandas de resultados, y quiero una pausa,
            antes de mostrar la siguiente oleada: */

            Console.ReadKey();

            //Otra forma de asignar valores a un array: 
            int[] OtrosValores = { 31554, 6528, -16847, 0 };

            //Otra forma de recorrer el array. A esta no le interesa que le definamos la cantidad de veces, o condiciones, recorre 1 a 1
            foreach (var valor in OtrosValores)
            {
                Console.WriteLine(valor);
            }

            //Console.ReadKey(); Acá ya no hace falta porque viene el msj default
        }


        #endregion

    }
}