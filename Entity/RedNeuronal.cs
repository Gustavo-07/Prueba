using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Entity
{
    public class RedNeuronal
    {
        public RedNeuronal()
        {

        }

        public RedNeuronal(int numeroEntradas, int numeroSalidas, int numeroPatrones, int numeroIteraciones, double rataAprendizaje, double errorMaximoPermitido, int numeroCapas, int[] numeroNeuronasCapas, string[] funcionesActivacionCapas, double[,] pesos, double[] umbrales, string funcionActivacionCapaSalida)
        {
            NumeroEntradas = numeroEntradas;
            NumeroSalidas = numeroSalidas;
            NumeroPatrones = numeroPatrones;
            NumeroIteraciones = numeroIteraciones;
            RataAprendizaje = rataAprendizaje;
            ErrorMaximoPermitido = errorMaximoPermitido;
            NumeroCapas = numeroCapas;
            NumeroNeuronasCapas = numeroNeuronasCapas;
            FuncionesActivacionCapas = funcionesActivacionCapas;
            Pesos = pesos;
            Umbrales = umbrales;
            FuncionActivacionCapaSalida = funcionActivacionCapaSalida;
        }

        public int NumeroEntradas { get; set; }
        public int NumeroSalidas { get; set; }
        public int NumeroPatrones { get; set; }
        public int NumeroIteraciones { get; set; }
        public double RataAprendizaje { get; set; }
        public double ErrorMaximoPermitido { get; set; }
        public int NumeroCapas { get; set; }

        public int[] NumeroNeuronasCapas = { };

        public string[] FuncionesActivacionCapas = { };
        public string FuncionActivacionCapaSalida { get; set; }

        public double[,] Pesos = { };
        public double[] Umbrales = { };

    }
}
