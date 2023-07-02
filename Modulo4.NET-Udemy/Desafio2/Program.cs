namespace Desafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Dado un arreglo origen de 12 elementos que
            representan meses del añoo (cuyos indices van
            del 0 al 11), y contiene la facturación
            correspondiente a todo un año, informar la
            facturación por trimestre. Para esto,armar un
            arreglo destino de 4 posiciones, donde cada
            posición contenga la facturación de cada
            trimestre.
             */
            int[] factAnual = { 1500, 2000, 3000, 500, -5000, 6000, 1000, 1000, 500, 6000, 7000, 8000 };
            int[] factTrimestre = new int[4];

            for (int i = 0; i <= 11; i++)
            {
                switch (i)
                {
                    case 0:
                    case 1:
                    case 2:
                        factTrimestre[0] += factAnual[i];
                        break;
                    case 3:
                    case 4:
                    case 5:
                        factTrimestre[1] += factAnual[i];
                        break;
                    case 6:
                    case 7:
                    case 8:
                        factTrimestre[2] += factAnual[i];
                        break;
                    case 9:
                    case 10:
                    case 11:
                        factTrimestre[3] += factAnual[i];
                        break;
                    default:
                        break;
                }
            }

            for (int i = 0; i < factTrimestre.Length; i++)
            {
                Console.WriteLine($"Trimestre {i + 1} ${factTrimestre[i]}");
            }

        }
    }
}