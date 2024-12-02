using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace ProyectoFinal
{
    public partial class FormSCAN : Form
    {
        int mov = 0;
        List<int> solicitudes = new List<int>();    //se declara el arreglo que almacenara las solicitudes aleatorias
        int posInicial = 0;
        List<int> solicitudesOriginales;

        public FormSCAN()
        {
            InitializeComponent();
        }

        public FormSCAN(List<int> ordenada, int movTot, int posicion, int[] originales)
        {
            this.solicitudes = ordenada;
            this.solicitudesOriginales = originales.ToList();
            this.mov = movTot;
            this.posInicial = posicion;
            InitializeComponent();
        }

        private void FormSCAN_Load(object sender, EventArgs e)
        {
            // Mostrar la posición inicial
            labelPosIn.Text = "Posición inicial: " + posInicial.ToString();

            // Mostrar la cola de solicitudes en el ListBox
            foreach (var solicitud in solicitudesOriginales)
            {
                listBoxCola.Items.Add(solicitud);
            }
            listBoxCola.Items.Add("----------------------------");

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

        private void labelMov_Click(object sender, EventArgs e)
        {

        }
    }
}
