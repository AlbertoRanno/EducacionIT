namespace Arrays2D
{
    internal class Program
    {
        #region Arrays de 2 dimensiones
        /* Pensar en tablas de Excel: 1 Dimension las columnas, otra dimension las filas. 
         * A ambas accedo mediante los índices
        Ejemplo tabla de Estudiantes y Notas. 
        En las columnas 0 1 2 3
        En las filas 0 1 2 ... 9
        En la columna 0, pongo los nombres uno debajo del otro
        En la columna 1 las notas del primer parcial, en la 2, la del segundo, en la 3 el promedio
        En Excel, el principio fundamente es el del Array. y este caso sería:
        Califaciones: 10,4 (10 elementos por fila, 4 por columna, 40 en total)
        
         ******** IMPORTANTE ******
         Como dentro del array todo tiene que ser del mismo tipo de dato, aca tendria que ser todo string.
         Y luego pasar a tipo int los valores, para poder usarlos para calcular.
        ***************************
        *
        * Después de los arrays, C# incorpora lo que es "colecciones". Es otra gama de estructura de datos.
        * Para un manejo más avanzado de los datos (listas, pilas, colas, etc... JAVA lo mismo...)


        *
         */

        #endregion
        static void Main(string[] args) {

            string[,] Calificaciones = new string [5,4];//Poner la "," al [], para que entienda que son 2 dimensiones!
            //Ahi reservo el espacio de memoria. Para guardar indico, 1ero Fila, 2do Columna
            Calificaciones[0, 0] = "Pedro";
            Calificaciones[0, 1] = "5";
            Calificaciones[0, 2] = "8";
            //Calculo el promedio:
            //Calificaciones[0, 3] = (int.Parse(Calificaciones[0, 1]) + int.Parse(Calificaciones[0, 2])) / 2;
            //Si hiciera eso, da error, porque querria guardar un int, en una posicion de la tabla que espera un string
            Calificaciones[0, 3] = ((int.Parse(Calificaciones[0, 1]) + int.Parse(Calificaciones[0, 2])) / 2).ToString();

            Calificaciones[1, 0] = "Juan";
            Calificaciones[1, 1] = "9";
            Calificaciones[1, 2] = "6";
            //Calculo el promedio:
            Calificaciones[1, 3] = ((int.Parse(Calificaciones[1, 1]) + int.Parse(Calificaciones[1, 2])) / 2).ToString();

            Calificaciones[2, 0] = "Luis";
            Calificaciones[2, 1] = "2";
            Calificaciones[2, 2] = "10";
            //Calculo el promedio:
            Calificaciones[2, 3] = ((int.Parse(Calificaciones[2, 1]) + int.Parse(Calificaciones[2, 2])) / 2).ToString();

            Calificaciones[3, 0] = "María";
            Calificaciones[3, 1] = "4";
            Calificaciones[3, 2] = "2";
            //Calculo el promedio:
            Calificaciones[3, 3] = ((int.Parse(Calificaciones[3, 1]) + int.Parse(Calificaciones[3, 2])) / 2).ToString();

            Calificaciones[4, 0] = "Francisco";
            Calificaciones[4, 1] = "10";
            Calificaciones[4, 2] = "10";
            //Calculo el promedio:
            Calificaciones[4, 3] = ((int.Parse(Calificaciones[4, 1]) + int.Parse(Calificaciones[4, 2])) / 2).ToString();

            //OBS! SI NO USÉ TODAS LAS FILAS, CORREGIR EL ESPACIO RESERVADO EN MEMORIA:
            //DE string[,] Calificaciones = new string [10,4]; A string[,] Calificaciones = new string [5,4];
            //Si las dejara las 10 filas, el resto veeria "null" que es el valor por defecto del string

            /********* IMPORTANTE ******
             si uso "Length()" me dará el total de elementos del array (filas * columnas)!!
             si quiero sola las filas le pongo GetLeng(0), porque las filas son 0 en este caso
             si quisiera las columnas seria GetLength(1)"
            ****************************/
            for (int Index = 0; Index < Calificaciones.GetLength(0); Index++)
            {
                Console.WriteLine($"{Calificaciones[Index, 0]} {Calificaciones[Index, 1]} {Calificaciones[Index, 2]} Promedio: {Calificaciones[Index, 3]}");
            }

            //Primero forcé el paso de string a int, quedaria modificar a float para que muestre decimales
    }
}
}