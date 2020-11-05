using System;
using Entity;
using DALL; 

namespace BLL
{
    public abstract class RedNeuronalService
    {

        double[,] pesos = { };
        double[] umbrales = { };
        double errorIteracion = 0;
        double[] patronEntradas = { };
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


        public double[,] InicializarPesos(int NumeroEntradas, int NumeroSalidas)
        {
            Random rnd = new Random();

            pesos = new double[NumeroEntradas, NumeroSalidas];

            for (int i = 0; i < NumeroSalidas; i++)
            {
                for (int j = 0; j < NumeroEntradas; j++)
                {
                    double val = rnd.NextDouble() * 1 - (-1) + (-1);
                    pesos[j,i] = val;
                }

            }

            return pesos;
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
