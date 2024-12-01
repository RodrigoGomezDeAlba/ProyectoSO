using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormCSCAN : Form
    {
        int mov = 0;
        List<int> solicitudesOrdenadas;    //se declara el arreglo que almacenara las solicitudes aleatorias
        int posInicial = 0;
        List<int> solicitudesOriginales;

        public FormCSCAN()
        {
            InitializeComponent();
        }

        public FormCSCAN(List<int> ordenada, int movTot, int posicion, List<int> originales)
        {
            this.solicitudesOrdenadas = ordenada;
            this.solicitudesOriginales = originales;
            this.mov = movTot;
            this.posInicial = posicion;
            InitializeComponent();
        }

        private void FormCSCAN_Load(object sender, EventArgs e)
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
            foreach (var solicitud in solicitudesOrdenadas)
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
