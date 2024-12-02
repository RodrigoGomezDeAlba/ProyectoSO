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
    public partial class FCFS : Form
    {
        int mov = 0;
        List<int> solicitudes = new List<int>();
        int posInicial = 0;


        public FCFS()
        {
            InitializeComponent();
        }

        public FCFS(List<int> ordenada, int movTot, int posicion)
        {
            this.solicitudes = ordenada;
            this.mov = movTot;
            this.posInicial = posicion;
            InitializeComponent();
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
