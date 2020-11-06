using System;
using Entity;
using DALL;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public abstract class RedNeuronalService
    {

        double[,] pesos = { };
        double[] umbrales = { };
        double errorIteracion = 0;
        double[] patronEntradas = { };
        List<double[,]> ListaMatrizPesos;
    public void Entrenar(RedNeuronal redNeuronal)
        {
            //CALCULAR LAS SALIDAS DE LAS NEURONAS QUE SE ENCUENTRAN EN LAS CAPAS OCULTAS

           
            int contador = 1;
            errorIteracion = 1000;

            while (redNeuronal.ErrorMaximoPermitido < errorIteracion && contador < redNeuronal.NumeroIteraciones)
            {
            }
        }

        public void Simular(RedNeuronal redNeuronal)
        {

        }

        public double[] InicializarUmbrales(int NumeroSalidas)
        {
            Random rnd = new Random();
            umbrales = new double[NumeroSalidas];
            for (int i = 0; i < NumeroSalidas; i++)
            {
                double val = rnd.NextDouble() * 1 - (-1) + (-1);
                umbrales[i] = val;
            }

            return umbrales;
        }

        
        public List<double[,]> InicializarPesos(int NumeroEntradas, int NumeroSalidas, int numeroCapasOcultas, int[] ListaNumeroNeuronasCapas, int numeroNeuronasCapaSalida)
        {
            Random rnd = new Random();
            ListaMatrizPesos = new List<double[,]> { };


            pesos = new double[NumeroEntradas, ListaNumeroNeuronasCapas[0]];
            for (int i = 0; i < ListaNumeroNeuronasCapas[0]; i++)
            {
                for (int j = 0; j < NumeroEntradas; j++)
                {
                    double val = rnd.NextDouble() * 1 - (-1) + (-1);
                    pesos[j, i] = val;
                }

            }
            ListaMatrizPesos.Add(pesos);

            for (int k = 0; k < numeroCapasOcultas-1; k++)
            {

                // comandos para llenar la matriz de pesos aleatoriamente

                int auxiliar1 = ListaNumeroNeuronasCapas[k];
                int auxiliar2 = ListaNumeroNeuronasCapas[k + 1];

                pesos = new double[auxiliar1, auxiliar2];

                for (int i = 0; i < auxiliar2; i++)
                {
                    for (int j = 0; j < auxiliar1; j++)
                    {
                        double val = rnd.NextDouble() * 1 - (-1) + (-1);
                        pesos[j, i] = val;
                    }

                }
                ListaMatrizPesos.Add(pesos);

            }

            pesos = new double[ListaNumeroNeuronasCapas.Last(), numeroNeuronasCapaSalida];
            for (int i = 0; i < NumeroSalidas; i++)
            {
                for (int j = 0; j < ListaNumeroNeuronasCapas.Last(); j++)
                {
                    double val = rnd.NextDouble() * 1 - (-1) + (-1);
                    pesos[j, i] = val;
                }

            }
            ListaMatrizPesos.Add(pesos);

            return ListaMatrizPesos;
        }

      /*  public double SalidaNeuronaXCapa(RedNeuronal redNeuronal)
        {
            double[] Hi = { };

            return Hi;
        }*/
   
        public void ActualizarPesosXCapa()
        {

        }
    
        //public void ActualizarUmbralesXCapa() { }

        public double FuncionSigmoidal(double x)
        {
            return  (1)/(1 + Math.Exp(-x));
        }

        public double FuncionTangenteHiperbolida(double x)
        {
            return Math.Tanh(-x);
        }

        public double FuncionGaussiana(double x)
        {
            return Math.Tanh(-x);
        }
    }
}
