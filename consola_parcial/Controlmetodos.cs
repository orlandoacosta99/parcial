using System;
using System.Collections.Generic;
using System.Text;

namespace consola_parcial
{
    class Controlmetodos
    {
        private double vorigen;
        private double tasa;
        private double vdestino;
        private double resultado;
        private int oporigen;
        private int opdestino;


        public double Numero1 { get => vorigen; set => vorigen = value; }
        public double Numero2 { get => vdestino; set => vdestino = value; }
        public double Resultado { get => resultado; set => resultado = value; }

        /*public int Oporigen { get => oporigen; set => oporigen = value; }
        public int Opdestino { get => opdestino; set => opdestino = value; }


        double convertirEntreMonedas(double voriginal, int cardinalidad, double tasa);
        string obtenerResultado(string tipoOrigen, string tipoDestino, double tasa, string cardinalidad, double moneda);*/

    }
}
