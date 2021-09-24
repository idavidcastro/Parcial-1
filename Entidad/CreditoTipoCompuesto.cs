using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
        public class CreditoTipoCompuesto: Creditos
    {
        public CreditoTipoCompuesto(decimal montoDinero, decimal valorInteres, int periodo)
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
            decimal elevacion;
            ValorInteres /= 100;

            elevacion= (decimal)Math.Pow((double)(1 + ValorInteres), Periodo);

            capitalFinal = MontoDinero * elevacion;

            Console.WriteLine($"El capital final a pagar es: {capitalFinal}");
        }

    }
    }

