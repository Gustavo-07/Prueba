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

        public RedNeuronal(int numeroEntradas, int numeroSalidas, int numeroPatrones, double[] entradas, double[] salidas, double[] patrones, int numeroIteraciones, double rataAprendizaje, double errorMaximoPermitido, int numeroCapas, int[] numeroNeuronasCapas, string[] funcionesActivacionCapas, string funcionActivacionCapaSalida, List<double[,]> listaMatrizPesos, double[] umbrales)
        {
            NumeroEntradas = numeroEntradas;
            NumeroSalidas = numeroSalidas;
            NumeroPatrones = numeroPatrones;
            Entradas = entradas;
            Salidas = salidas;
            Patrones = patrones;
            NumeroIteraciones = numeroIteraciones;
            RataAprendizaje = rataAprendizaje;
            ErrorMaximoPermitido = errorMaximoPermitido;
            NumeroCapas = numeroCapas;
            NumeroNeuronasCapas = numeroNeuronasCapas;
            FuncionesActivacionCapas = funcionesActivacionCapas;
            FuncionActivacionCapaSalida = funcionActivacionCapaSalida;
            ListaMatrizPesos = listaMatrizPesos;
            Umbrales = umbrales;
        }

        public int NumeroEntradas { get; set; }
        public int NumeroSalidas { get; set; }
        public int NumeroPatrones { get; set; }
        public double[] Entradas = { };
        public double[] Salidas = { };
        public double[] Patrones = { };
        public int NumeroIteraciones { get; set; }
        public double RataAprendizaje { get; set; }
        public double ErrorMaximoPermitido { get; set; }
        public int NumeroCapas { get; set; }

        public int[] NumeroNeuronasCapas = { };

        public string[] FuncionesActivacionCapas = { };
        public string FuncionActivacionCapaSalida { get; set; }

        public List<double[,]> ListaMatrizPesos;
        public double[] Umbrales = { };

    }
}
