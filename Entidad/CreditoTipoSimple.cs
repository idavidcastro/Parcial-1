using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class CreditoTipoSimple: Creditos
    {
        public CreditoTipoSimple(decimal montoDinero, decimal valorInteres, int periodo)
        {
            MontoDinero = montoDinero;
            ValorInteres = valorInteres;
            Periodo = periodo;
        }
        public decimal MontoDinero { get; set; }
        public decimal ValorInteres { get; set; }
        public int Periodo { get; set; }

        public override void CalcularCredito()
        {
            decimal capitalFinal;
            ValorInteres /= 100;

            capitalFinal = MontoDinero * (1 + ValorInteres * Periodo);

            Console.WriteLine($"El capital final a pagar es: {capitalFinal}");
        }

    }
}
