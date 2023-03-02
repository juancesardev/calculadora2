using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSchad
{
    public class Operacion
    {
        private Icalculadora calculadora;

        public Operacion(Icalculadora operacion)
        {
            calculadora = operacion;
        }

        public double Execute(double val1, double val2)
        {
            return calculadora.calcular(val1, val2);
        }
    }
}
