using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IMCPlatform
{
    internal class Program
    {
        #region IMCPlatform
        /* Ej. Calcula IMC - Plataforma de Cálculo para el Indice de Masa Corporal (Peso en Relacion a Altura) 
         * Lo calcularemos a nivel general. Para ir implementando todo
         IMC            Diagnostico
        debajo de 18.5  bajo peso
        18.5-24.9       peso saludable
        25.0-29.9       sobrepeso
        30.0 o más      obesidad

        Primero algo basico para mostrarle al cliente. Ej a una farmacia.
        Pero pensarlo de forma que pueda escalar.
        */

        #endregion
        static void Main(string[] args)
        {


            string? ReadResult;
            //Datos basicos
            string Nombre = "", Apellido = "", Tlf = "", NroDocumento = "";

            //Datos para el calculo
            double Altura, Peso, IMC;

            Console.Clear();
            Console.WriteLine("IMC Platformm v 1.0.0, Bienvenido!");
            Console.WriteLine("==================================");

            //Pedimos los datos basicos
            Console.WriteLine("=== Datos básicos del paciente ===:");
            Console.Write("Ingrese el Nro de Documento: ");
            ReadResult = Console.ReadLine();
            if (ReadResult != null)
            {
                NroDocumento = ReadResult;
            }
            Console.Write("Ingrese su Nombre: ");
            ReadResult = Console.ReadLine();
            if (ReadResult != null)
            {
                Nombre = ReadResult;
            }
            Console.Write("Ingrese su Apellido: ");
            ReadResult = Console.ReadLine();
            if (ReadResult != null)
            {
                Apellido = ReadResult;
            }
            Console.Write("Ingrese el Nro de Teléfono: ");
            ReadResult = Console.ReadLine();
            if (ReadResult != null)
            {
                Tlf = ReadResult;
            }

            //Telefono y Documento los pido como string, porque probablemente los ingresen con puntos o guiones

            #region Parse vs TryParse
            /*
             La principal diferencia entre TryParse y Parse en C# es la forma en que manejan las conversiones de tipos de datos.

            Parse es un método que intenta convertir una cadena en un valor de otro tipo de datos. Si la cadena no se puede convertir al tipo de destino, se lanza una excepción FormatException. Por ejemplo, si intentas convertir una cadena que no representa un número en un tipo numérico, se producirá una excepción.

            Por otro lado, TryParse es un método que intenta realizar la conversión, pero en lugar de lanzar una excepción en caso de error, devuelve un valor booleano que indica si la conversión fue exitosa o no. Si la conversión es exitosa, el valor convertido se asigna a una variable de salida. Si la conversión falla, la variable de salida se establece en el valor predeterminado del tipo de destino y el método devuelve false.

            La ventaja de TryParse es que evita la necesidad de manejar excepciones en situaciones en las que se espera que la conversión pueda fallar, como cuando se solicita entrada al usuario. Proporciona un mecanismo más seguro y controlado para realizar conversiones de tipos de datos. Puedes usar el valor de retorno booleano para tomar decisiones basadas en el éxito o el fracaso de la conversión.

            En resumen, Parse se utiliza cuando se espera que la conversión sea exitosa y se quiere lanzar una excepción en caso de fallo, mientras que TryParse se utiliza cuando se desea verificar el éxito de la conversión sin lanzar una excepción y se prefiere manejar el fallo de manera controlada.
             */
            #endregion

            // Pedimos los datos para el cálculo
            Console.Write("Ingrese su Altura: ");
            ReadResult = Console.ReadLine();
            if (double.TryParse(ReadResult, out Altura))
            {
                Console.Write("Ingrese su Peso: ");
                ReadResult = Console.ReadLine();
                if (double.TryParse(ReadResult, out Peso))
                {
                  // Realizamos el cálculo del IMC pasa a "Pedimos el calculo del IMC", dado que ahora lo importo
                  IMC = CalcularIMC(Peso, Altura); //Lo invoco y le paso los parámetro que necesita
                  //o podria haber pasado  IMC = CalcularIMC(80, 1,65); pero ya se los pedi al usuario
                  // IMC = Peso / (Altura * Altura);
                  //parado aqui con f12 voy al metodo



                    //Realizamos el calculo del IMC (Antes lo calculaba acá, luego lo hice en método aparte)
                    //IMC = Peso / Math.Pow(2, Altura); // Metodo para calcular potencia
                    //IMC = Peso / (Altura * Altura); // La forma segura

                    Console.WriteLine($"Su IMC es de: {IMC}");

                    //Ctrl K Ó Ctrl F para formatear, uno con selección de código, otro gral

                    //Aqui se procesa el diagnostico (void, no retorna valor)
                    MostrarDiagnostico(IMC);

                }
            }

            
        }



        /* Como toda app escalable, es conveniente tenerla en varias funcionalidades pequeñas, por lo que,
        comienzo a desestructurar.
        Vamos entonces a separar en lo más básico, bloques de código pequeños, con distinta responsiblidades.
        Dentro de la clase Program puedo tener varios metodos.
        Algunos calcularán un valor (como en este caso el IMC, de tipo double), y otros solo muestran (los void).
        
        Las clases, son la estructura fundamental, y tienen miembros (metodos o propiedades)
                 
        El metodo main es static, y es propio de la clase program.
        Todo lo statico, al momento de que la aplicacion se inicie ya se carga en memoria.
        Lo que yo pida fuera del main, debe ser statico, porque Main lo es, y similar consume a similar.
        Por lo tanto el metodo del imc, debe ser statico,
        y también, debe ser double, porque eso es lo que va a devolver
        lo nombro
        los () oara que se ejecute
        las {} para el cuerpo del metodo
        como va a retornar algo, debe llevar la palabra reservada return
        al menos un "return 0;"        
         */

        //Metodo que calcula el IMC 
        //static double CalcularIMC(double Peso, double Altura) 
        //Metodo que retorna valor - Me traigo el Peso y Altura y son ACCESIBLES SOLO ACA, en este metodo
        static double CalcularIMC(double peso, double altura) 
        //llamo a las variables con minuscula porque seran parametros, y para distinguirlas, pero NO es obligatorio ese cambio
        {
            //Cuerpo
            //return 0;
            var IMCResult = peso / Math.Pow(2, altura);
            //IMC = Peso / (Altura * Altura);
            return IMCResult;

        }

        //eL ORDEN EN QUE ESCRIBA LOS METODOS NO IMPORTA, IMPORTA EL ORDEN EN QUE LOS LLAME EN MAIN!!

        //Metodo retorna los datos de la tabla
        static string[,] ObtenerDatosRef()
        {
            string[,] DatosTabla = new string[5, 3];

            //luego la importaremos, por ahora lo hardcodeamos

            DatosTabla[0, 0] = "0";
            DatosTabla[0, 1] = "18.5";
            DatosTabla[0, 2] = "Bajo Peso";

            DatosTabla[1, 0] = "18.6";
            DatosTabla[1, 1] = "24.9";
            DatosTabla[1, 2] = "Peso saludable";

            DatosTabla[2, 0] = "25";
            DatosTabla[2, 1] = "29.9";
            DatosTabla[2, 2] = "Sobrepeso";

            DatosTabla[3, 0] = "30";
            DatosTabla[3, 1] = "39.9";
            DatosTabla[3, 2] = "Obesisdad";

            DatosTabla[4, 0] = "40";
            DatosTabla[4, 1] = "60";
            DatosTabla[4, 2] = "Obesidad inventada";

            return DatosTabla;
        }

        static void MostrarDiagnostico(double IMC) 
            //Metodo que no retorna valor - Pero por mas que no retornen, necesitan
        {
            /* 
            -quiero refactorizarla para que se maneje con un array de 2dimnensiones...
            -asi la preparo para absorver info de una tabla que luego importaremos
            -ahora esta demasiado hardcodeado... cada modificacion seria otro if... modificar.. etc..
            
             Tabla Array Diagnostico
            DESDE   HASTA   DIAGNOSTICO
            0       18.5    BAJO PESO
            18.6    24.9    PESO SALUDABLE
            ....
            AHORA VOY A ROMPER SOLO ESTE PEDACITO:
             if (IMC < 18.5)
            {
                Console.WriteLine("Ud es un paciente con Bajo Peso, visite a su médico");
            }
            else if (IMC >= 18.5 && IMC <= 24.9)
            {
                Console.WriteLine($" tienes un Peso Saludable, Felicitaciones!");
            }
            else if (IMC > 24.9 && IMC <= 29.9)
            {
                Console.WriteLine("Ud es un paciente que tiene sobrepeso");
            }
            else if (IMC > 29.9)
            {
                Console.WriteLine("Ud es un paciente con obsesidad");
            }
             */

            // string[,] TablaRef = new string[5, 3]; //5 filas 3 columnas - el encabezado no me sirve
            // preparo la app para que la data venga de afuera, para eso creo un metodo que disponibilice la data
            string[,] TablaRef = ObtenerDatosRef(); // me traigo los datos

            //Traje la tabla, La recorro
            for (int Index = 0; Index < TablaRef.GetLength(0); Index++)
            { //Punto de interrupcion en debug, windows, autos  //puedo poner ptos interrup. con F9

                if (IMC >= double.Parse(TablaRef[Index, 0]) && IMC <= double.Parse(TablaRef[Index, 1])) 
                    //comparo , pasando a nro, desde 18.5.. / hasta 24.9
                {
                    Console.WriteLine($"Ud es un paciente con {(TablaRef[Index, 2])} "); //aca no parsear porque quiero que muestre el string
                    break; //ya le mostre el diagnostico, sino seguiria, y ocupariamos procesameinto de cpu
                }
            }

            //if (IMC < 18.5)
            //{
            //    Console.WriteLine("Ud es un paciente con Bajo Peso, visite a su médico");
            //}
            //else if (IMC >= 18.5 && IMC <= 24.9)
            //{
            //    Console.WriteLine($" tienes un Peso Saludable, Felicitaciones!");
            //}
            //else if (IMC > 24.9 && IMC <= 29.9)
            //{
            //    Console.WriteLine("Ud es un paciente que tiene sobrepeso");
            //}
            //else if (IMC > 29.9)
            //{
            //    Console.WriteLine("Ud es un paciente con obsesidad");
            //}
        }
    }
}
//void solo ejecuta un bloque y muestra en consola
//Nos falta ver la estructura de datos
