using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula_cuadrática_Mvvm.Models
{
    internal class FormulaCuadratica
    {
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }
        public double Numero3 { get; set; }

        public double Calcular() 
        {
            return Numero2 * Numero2 - 4 * Numero1 * Numero3;
        }
    }
}
