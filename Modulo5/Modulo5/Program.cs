namespace Estructuras
{
    internal class Program
    {
       /*
             Estructuras
            Las estructuras son un conjunto de datos agrupados para formar un tipo de dato compuesto y personalizado.
            De esta manera, permite que un grupo de datos relacionados entre sí, pertenecientes a un objeto del mundo 
            real, se puedan agrupar bajo un identificador único.

            Por ejemplo, podríamos definir los siguientes tipos personalizados:
            ● Cliente: Código, Nombre, Apellido, CUIT, Domicilio.
            ● Alumno: Id, Nombre, Apellido, Mail, Teléfono, Curso.
            ● Producto: Código, Nombre, Presentación,Precio Unitario, Precio de Costo, Proveedor.

            visibilidad struct nombre{      //struct es palabra reservada
            visibilidad tipo campo1;        // a cada uno, se lo llama miembro
            …
            visibilidad tipo campoN;
            } 

            Ejemplo:
             */
            public struct DatoCliente
        {
            public string NumeroCuenta;
            public string TipoCuenta;
            public string Titular;
            public string CBU;
            public double Saldo;
        }

        
        //  Cómo crear una variable de tipo estructura:
        DatoCliente cliente;        //una
        DatoCliente cliente1, cliente2, cliente3;       //varias
       
        /*En caso de necesitar utilizar más de una variable del mismo tipo, se puede crear un arreglo con elementos 
        del tipo de la estructura. Al igual que cualquier arreglo, podrá dimensionarse con la cantidad de elementos 
        necesarios. Cada elemento del array contendrá los datos correspondientes a un cliente específico.*/
        DatoCliente[] clientes = new DatoCliente[5];

        /* Creación de variables de tipo estructura
        Se puede definir una variable de la estructura en la forma tradicional, pero también utilizar
        la palabra reservada new. De esta manera, se puede codificar un constructor*, dentro de la
        estructura, que permita simplificar la creación de variables de este tipo. Si las declaramos de
        la forma tradicional tendremos que inicializar cada campo de la estructura por separado.
        
         Cómo acceder a los campos de una variable de tipo estructura
       
        variableEstructura.Campo

        Ejemplo: cliente1.Titular = "Pedro Gomez";

        Se pueden utilizar los campos en cualquier tipo de expresión válida, del mismo modo que con una variable:

        if(ciente2.Saldo <= 0)
        ...
        disponible = cliente2.Saldo - importeExtraccion;
        ...
        Console.WriteLine(“El saldo es {0}”, cliente2.Saldo);

        Ejemplo
        DatoCliente[] clientes = new DatoCliente[3];
        clientes[1].NumeroCuenta = ”001874572”;
        clientes[1].tipoCuenta = ”Caja de Ahorro en Pesos”;
        clientes[1].CBU = ”0110123456784578234801”;

        Codificación de un constructor para la estructura
        Si bien no es estrictamente necesario, la codificación de un constructor dentro de la estructura tiene como
        objetivo simplificar la creación de variables de tipo estructura y la inicialización de los valores de sus 
        campos

        public DatoCliente(String pNroCuenta, String TipoCuenta, String pTitular, string pCBU, double pSaldo)
        {
        // Asignamos los valores de los parámetros del constructor a los campos de la estructura
        NumeroCuenta = pNrocuenta;
        TipoCuenta = pTipoCuenta;
        Titular = pTitular;
        CBU = pCBU;
        Saldo = pSaldo;
        }

        DatoCliente cliente1 = new DatoCliente(“00156777”, ”Caja de Ahorro en Pesos”, ”Pedro Gomez”,
        ”0110123456784578234801”, 150000);


        Ejercicio 1
        Crear una estructura para almacenar los datos pertenecientes a los productos de una tienda.
        Los datos a registrar para un producto son:
        ● Código.
        ● Nombre.
        ● Precio.
        ● Categoría.
        Codificar una aplicación de consola que permita cargar todos los datos de un producto y mostrarlos por pantalla.
        */

        //Defino la estructura
        public struct Producto
        {
            public int Codigo;
            public string Nombre;
            public double Precio;
            public string Categoria;
        }

        static void Main(string[] args)
        {
            Producto p; //defino la variable
            Console.WriteLine("Ingrese el código del producto:");
            p.Codigo = Convert.ToInt32(Console.ReadLine()); // solicito cada uno de sus miembros
            Console.WriteLine("Ingrese el nombre del producto:");
            p.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el precio del producto:");
            p.Precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la categoría del producto:");
            p.Categoria = Console.ReadLine();

            Console.WriteLine("Datos del producto:");
            Console.WriteLine("Código: {0}", p.Codigo);
            Console.WriteLine("Nombre: {0}", p.Nombre);
            Console.WriteLine("Precio: $ {0}", p.Precio);
            Console.WriteLine("Categoría: {0}", p.Categoria);
            //Console.ReadKey();

            ArrayProductos();
        }

        /*
         En base al ejercicio realizado en el laboratorio adicional anterior:
        1. Crear un arreglo de productos.
        2. Codificar una aplicación de consola que permita cargar todos los datos de 3 productos en el arreglo y mostrarlos por pantalla.
         */

        public static void ArrayProductos()
        {
            Producto[] productos = new Producto[3];
            for (int i = 0; i < productos.Length; i++)
            {

                Console.WriteLine("Ingrese el código del producto:");
                productos[i].Codigo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el nombre del producto:");
                productos[i].Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el precio del producto:");
                productos[i].Precio = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese la categoría del producto:");
                productos[i].Categoria = Console.ReadLine();
                Console.Clear();
            }
                Console.WriteLine("Datos de los productos:");
                Console.WriteLine("----------------------:");
            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine("Código: {0}", productos[i].Codigo);
                Console.WriteLine("Nombre: {0}", productos[i].Nombre);
                Console.WriteLine("Precio: $ {0}", productos[i].Precio);
                Console.WriteLine("Categoría: {0}", productos[i].Categoria);
                Console.WriteLine("");
            }
        }

    }
}