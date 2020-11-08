using System;
using System.Collections.Generic;
using System.Text;

namespace consola_parcial
{
    class LogicaCambio
    {
 

        public double Conversion(double vorigen, double tasa, int cardinalidad)
        {
            double resultado = double.NaN;
            if (cardinalidad == 1)
            {
                resultado = vorigen * tasa;
            }
            else
            {
                resultado = vorigen / tasa;
            }
            return resultado;
        }
        public double ConversionBit(double resultado, double tasa,double a ) {
            return resultado * tasa * a;
        }
    }
}
