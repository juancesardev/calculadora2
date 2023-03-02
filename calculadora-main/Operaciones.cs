using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSchad
{
    public class Suma : Icalculadora
    {
        public double calcular(double val1, double val2)
        {
            return val1 + val2;
        }


    }


    public class Resta : Icalculadora
    {
        public double calcular(double val1, double val2)
        {
            return val1 - val2;
        }


    }

    public class Multiplica : Icalculadora
    {
        public double calcular(double val1, double val2)
        {
            return val1 * val2;
        }
    }


    public class Divide : Icalculadora
    {
        public double calcular(double val1, double val2)
        {
            
            try
            {
                return val1 / val2;
            }
            catch (DivideByZeroException)
            {
                return 0;
            }
        }


    }
}
