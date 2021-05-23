using System;

namespace Metodos_y_Arrays___C2_Ej7
{
    class CambioMoneda
    {
        public void Cambiodivisas(double euros,string moneda)
        {
            double cantidad = 0;
            
            switch (moneda)
            {
                
                case "libras":
                    cantidad = euros * 0.86;
                    Console.WriteLine("{0} libras", cantidad);
                    break;

                case "dolares":
                    cantidad = euros * 1.28611;
                    Console.WriteLine("{0} dolares", cantidad);
                    break;

                case "yenes":
                    cantidad = euros * 129.852;
                    Console.WriteLine("{0} yenes", cantidad);
                    break;

                default:
                    Console.WriteLine("Moneda incorrecta");
                    break;
            }
        }
        static void Main(string[] args)
        {
            CambioMoneda conviertemoneda = new CambioMoneda();
            double cantidad;
            string ladivisa;

            Console.WriteLine("Introduce la cantidad en Euros:");
            cantidad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce el tipo de moneda: libras, dolares o yenes:");
            ladivisa = Console.ReadLine();

            conviertemoneda.Cambiodivisas(cantidad, ladivisa);
        }
    }
}
