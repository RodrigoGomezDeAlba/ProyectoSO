using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoFinal
{
    public partial class FCFS : Form
    {
        int mov = 0;
        List<int> solicitudes = new List<int>();
        int posInicial = 0;
        int totalSolicitudes = 0;

        public FCFS()
        {
            InitializeComponent();
        }

        public FCFS(List<int> ordenada, int movTot, int posicion)
        {
            this.solicitudes = ordenada;
            this.mov = movTot;
            this.posInicial = posicion;

            ordenada.Insert(0, posicion);
            totalSolicitudes = solicitudes.Count;   //se saca el total de solicitudes
            double[] valoresY = new double[totalSolicitudes];   //se crea un vector de tipo double para poder pasarlo a la grafica
            for (int i = 0; i < totalSolicitudes; i++)   //se llena el vector desde 1 hasta el total de solicitudes
            {
                valoresY[i] = i;
            }
            double[] vectorX = ordenada.ConvertAll(item => (double)item).ToArray(); //se convierte la lista ordena a double y a vector para pasarlo a la grafica
            InitializeComponent();
            var scatter = formsPlot1.Plot.Add.Scatter(vectorX, valoresY);   //se mandan los vectores a la grafica

            // Configura el gráfico
            formsPlot1.Plot.Title("Movimiento del cabezal");
            formsPlot1.Plot.XLabel("Posición del cabezal");
            formsPlot1.Plot.YLabel("Solicitudes");

            // Actualiza para mostrar los cambios
            formsPlot1.Refresh();
        }

        private void FCFS_Load(object sender, EventArgs e)
        {
            // Mostrar la posición inicial
            labelPos.Text = "Posición inicial: " + posInicial.ToString();

            // Mostrar la cola de solicitudes **ordenada**
            listBoxCola.Items.Add("Solicitudes Ordenadas:");
            foreach (var solicitud in solicitudes)
            {
                listBoxCola.Items.Add(solicitud);
            }

            // Mostrar el movimiento total
            labelMov.Text = "Cantidad total de movimientos: " + mov.ToString();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
