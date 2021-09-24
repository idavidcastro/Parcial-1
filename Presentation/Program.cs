using System;
using Entidad;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal montoDinero;
            decimal valorInteres;
            int periodo, tipoTasaInteres;
            Console.Write("Ingrese el monto de dinero a solicitar: ");
            montoDinero = decimal.Parse(Console.ReadLine());
            Console.Write("Ingrese el tipo de tasa de interes (1-compuesto ; 2-simple): ");
            tipoTasaInteres = int.Parse(Console.ReadLine());
            while(tipoTasaInteres <1 || tipoTasaInteres > 2)
            {
                Console.Write("ERROR! Digite un número de tipo correcto: ");
                tipoTasaInteres = int.Parse(Console.ReadLine());
            }
            Console.Write("Ingrese el valor de la tasa de interes: ");
            valorInteres = decimal.Parse(Console.ReadLine());
            Console.Write("Ingrese el periodo de prestamo (AÑOS): ");
            periodo = int.Parse(Console.ReadLine());

            if (tipoTasaInteres == 1)
            {
                Creditos creditos = new CreditoTipoCompuesto(montoDinero, valorInteres, periodo);
                creditos.CalcularCredito();
            }
            else if(tipoTasaInteres == 2)
            {
                Creditos creditos = new CreditoTipoSimple(montoDinero, valorInteres, periodo);
                creditos.CalcularCredito();
            }

        }
    }
}
