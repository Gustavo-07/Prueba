using System;
using Entity;
using DALL; 

namespace BLL
{
    public abstract class RedNeuronalService
    {

        double[,] pesos = { };
        double[] umbrales = { };
        public void Entrenar(RedNeuronal redNeuronal)
        {
            
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

        public void SalidaNeuronaXCapa()
        {

        }
   
        public void ActualizarPesosXCapa()
        {

        }
    
        //public void ActualizarUmbralesXCapa() { }
    }
}
