using Entity;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BackpropagationAndPerceptron
{
    public partial class Entrenamiento : Form
    {

        public Entrenamiento()
        {
            InitializeComponent();

        }

        PercetronMulticapa percetronMulticapa = new PercetronMulticapa();
        BackPropagation backPropagation;

        PercetromMulticapaService percetromMulticapaService;
        BackPropagationService backPropagationService;


        // datos para el cargue del data set y entradas salidas y patrones
        private int entradas;
        private int salidas;
        private int patrones;

        private List<string> registros = new List<string>();
        private List<float> Salidasdeseadas = new List<float>();

        private float[] arraydesalidasdelared;
        private float[] arraydeerrordelospatrones;
        private float[] arraydeerroreslineales;
        private double[] arraydeumbrales;
        private double[,] arraydematrizdepesos;
        private float[,] arraydesalidasdeseadas;


        // datos para entrenar la red
        private int NumeroDeCapas = 0;
        public int[] ListaNumeroNeuronasCapas = { };
        public string[] FuncionActivacionCapas = { };

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();
            ventanaPrincipal.Show();
            this.Hide();
        }

        private void BtnCargarDatos_Click(object sender, EventArgs e)
        {
            DtgvDatos.Rows.Clear();
            DtgvDatos.Columns.Clear();
            registros.Clear();
            patrones = -1;
            entradas = 0;
            salidas = 0;

            OpenFileDialog ventana = new OpenFileDialog();
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                string rutadoc = ventana.FileName;
                TextReader leerdatos = new StreamReader(File.OpenRead(rutadoc));
                StreamReader str = new StreamReader(rutadoc);
            
                string fila;
                while ((fila = leerdatos.ReadLine()) != null)
                {
                    patrones += 1;
                    registros.Add(fila);
                }
                leerdatos.Close();
                string[] nentradas = registros[0].Split(' ');
                for (int i = 0; i < nentradas.Length; i++)
                {
                    if (nentradas[i].ToUpper().Equals("X"))
                        entradas = entradas + 1;
                    else
                        salidas = salidas + 1;
                }

                LblResultados.Text = "Entradas: " + entradas.ToString() + " Salidas: " + salidas.ToString() + " Patrones: " + patrones.ToString();
               
                for (int i = 0; i < entradas; i++)
                {
                    string titulo = "X " + (i + 1);
                    DtgvDatos.Columns.Add("Xr", titulo);
                }
                arraydesalidasdelared = new float[salidas];
                arraydesalidasdeseadas = new float[patrones, salidas];
                arraydeerrordelospatrones = new float[patrones];
                arraydeerroreslineales = new float[salidas];
                for (int i = 0; i < salidas; i++)
                {
                    string titulo = "YR " + (i + 1);
                    DtgvDatos.Columns.Add("Yr", titulo);
                }
                registros.RemoveAt(0);
                foreach (string registro in registros)
                {
                    DtgvDatos.Rows.Add(registro.Split(' '));
                }
                DtgvDatos.AllowUserToAddRows = false;

                //Graficando salidas deseadas de la red...   
                for (int i = 0; i < salidas; i++)
                {
                    //graficaComportamientodelentrenamiento.Series.Add("salidas deseadas " + (i+1).ToString());
                    //graficaComportamientodelentrenamiento.Series[i].ChartType = SeriesChartType.Spline;

                    GraficaComportamientoSalida.Series.Add("SalidaObtenida" + (i + 1).ToString());
                    GraficaComportamientoSalida.Series[i].ChartType = SeriesChartType.Spline;
                    GraficaComportamientoSalida.Series[i].Color = Color.Blue;
                    GraficaComportamientoSalida.Series[i].BorderWidth = 2;
                    GraficaComportamientoSalida.Series.Add("SalidaDeseada" + (i + 1).ToString());
                    GraficaComportamientoSalida.Series[i + 1].ChartType = SeriesChartType.Spline;
                    GraficaComportamientoSalida.Series[i + 1].Color = Color.Red;
                    GraficaComportamientoSalida.Series[i + 1].BorderWidth = 2;

                }
                for (int i = entradas; i < (entradas + salidas); i++)
                {
                    List<float> listadesalidasdeseadas = new List<float>();
                    List<int> numerodepatrones = new List<int>();
                    for (int J = 0; J < patrones; J++)
                    {
                        string[] salidadeseada = registros[J].Split(' ');
                        listadesalidasdeseadas.Add(float.Parse(salidadeseada[i]));
                        Salidasdeseadas.Add(float.Parse(salidadeseada[i]));
                        numerodepatrones.Add((J + 1));
                    }
                    // graficaComportamientodelentrenamiento.Series[i - entradas].Points.DataBindXY(numerodepatrones, listadesalidasdeseadas);
                    GraficaComportamientoSalida.Series[i - entradas].Points.DataBindXY(numerodepatrones, listadesalidasdeseadas);

                }

                DtgvDatos.Enabled = true;
                TxtTipoRed.Enabled = true;
                BtnConfigurar.Enabled = true;
                BtnAgregar.Enabled = true;
                TxtNumeroCapas.Enabled = true;
                CbxFuncionActivacionCapaSalida.Enabled = true;
            }
           
        }

        private void BtnConfigurar_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < NumeroDeCapas; j++)
            {
                ListaNumeroNeuronasCapas[j] = Convert.ToInt32(DtgCapas.Rows[j].Cells[1].Value);
                FuncionActivacionCapas[j] = DtgCapas.Rows[j].Cells[2].Value.ToString();
            }

            BtnInicializarPU.Enabled = true;

        }

        
        private void BtnInicializarPU_Click(object sender, EventArgs e)
        {
            if (TxtTipoRed.SelectedItem.ToString().Equals("Perceptrón Multicapa"))
            {
               percetromMulticapaService = new PercetromMulticapaService();
                arraydeumbrales = percetromMulticapaService.InicializarUmbrales(salidas);
                arraydematrizdepesos = percetromMulticapaService.InicializarPesos(entradas, salidas);
    }
            else
            {
                backPropagationService = new BackPropagationService();
                arraydeumbrales = backPropagationService.InicializarUmbrales(salidas);
                arraydematrizdepesos = backPropagationService.InicializarPesos(entradas,salidas);

            }


            TxtNumeroIteraciones.Enabled = true;
            TxtErrorMaximoPermitido.Enabled = true;
            TxtRataAprendizaje.Enabled = true;
            BtnEntrenar.Enabled = true;
        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            NumeroDeCapas = Convert.ToInt32(TxtNumeroCapas.Value);

            ListaNumeroNeuronasCapas = new int[NumeroDeCapas];
            FuncionActivacionCapas = new string[NumeroDeCapas];

            DtgCapas.Rows.Add(NumeroDeCapas - 1);
            int cont = 1;
            for (int j = 0; j < NumeroDeCapas; j++)
            {
                DtgCapas.Rows[j].Cells[0].Value = "Capa " + cont;
                cont++;
            }
        }

        private void DtgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        
           

        private void BtnEntrenar_Click(object sender, EventArgs e)
        {
            if (TxtTipoRed.SelectedItem.ToString().Equals("Perceptrón Multicapa"))
            {
                percetronMulticapa = new PercetronMulticapa();
                

                percetronMulticapa.NumeroEntradas = entradas;
                percetronMulticapa.NumeroSalidas = salidas;
                percetronMulticapa.NumeroPatrones = patrones;

                percetronMulticapa.NumeroCapas = NumeroDeCapas;
                percetronMulticapa.NumeroNeuronasCapas = ListaNumeroNeuronasCapas;
                percetronMulticapa.FuncionesActivacionCapas = FuncionActivacionCapas;
                percetronMulticapa.NumeroIteraciones = Convert.ToInt32(TxtNumeroIteraciones.Value.ToString());
                percetronMulticapa.RataAprendizaje = Convert.ToDouble(TxtRataAprendizaje.Value.ToString());
                percetronMulticapa.ErrorMaximoPermitido = Convert.ToDouble(TxtErrorMaximoPermitido.Value.ToString());
                percetronMulticapa.FuncionActivacionCapaSalida = CbxFuncionActivacionCapaSalida.SelectedItem.ToString(); 
                percetronMulticapa.Umbrales = arraydeumbrales;
                percetronMulticapa.Pesos = arraydematrizdepesos;


            }
            else
            {

                backPropagation = new BackPropagation();

                backPropagation.NumeroEntradas = entradas;
                backPropagation.NumeroSalidas = salidas;
                backPropagation.NumeroSalidas = patrones;

                backPropagation.NumeroCapas = NumeroDeCapas;
                backPropagation.NumeroNeuronasCapas = ListaNumeroNeuronasCapas;
                backPropagation.FuncionesActivacionCapas = FuncionActivacionCapas;
                backPropagation.NumeroIteraciones = Convert.ToInt32(TxtNumeroIteraciones.Value.ToString());
                backPropagation.RataAprendizaje = Convert.ToDouble(TxtRataAprendizaje.Value.ToString());
                backPropagation.ErrorMaximoPermitido = Convert.ToDouble(TxtErrorMaximoPermitido.Value.ToString());
                backPropagation.FuncionActivacionCapaSalida = CbxFuncionActivacionCapaSalida.SelectedItem.ToString();
                backPropagation.Umbrales = arraydeumbrales;
                backPropagation.Pesos = arraydematrizdepesos;



               MessageBox.Show("Numero entradas: " + backPropagation.NumeroEntradas.ToString() + "" +
                                "NumeroSalidas: " + backPropagation.NumeroSalidas.ToString() + "" +
                                "NumeroPatrones: " + backPropagation.NumeroPatrones.ToString() + "" +
                                "NumeroCapas: " + backPropagation.NumeroCapas + "" +
                                "NumeroNeuronasCapas: " + backPropagation.NumeroNeuronasCapas[0].ToString() + "" +
                                "FuncionActivacionCapas: " + backPropagation.FuncionesActivacionCapas[0].ToString() + "" +
                                "NumeroIteraciones: " + backPropagation.NumeroIteraciones.ToString() + "" +
                                "RataAprendizaje: " + backPropagation.RataAprendizaje.ToString() + "" +
                                "ErrorMaximoPermitido: " + backPropagation.ErrorMaximoPermitido.ToString() + "" +
                                "FuncionActivacionCapaSalida: " + backPropagation.FuncionActivacionCapaSalida.ToString() + "" +
                                "Umbrales: " + backPropagation.Umbrales[0].ToString() + "" +
                                "Pesos: " + backPropagation.Pesos[0, 0].ToString() + "", "algo");
            }
        }

        private void TxtTipoRed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DtgCapas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
