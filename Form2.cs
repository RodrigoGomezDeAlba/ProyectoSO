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
        const int limite = 5000;        //se declara el maximo de cilindros que se van a usar
        int mov = 0;
        List<int> solicitudes = new List<int>();    //se declara el arreglo que almacenara las solicitudes aleatorias

        public FormSCAN()
        {
            InitializeComponent();
        }

        public FormSCAN(List<int> ordenada, int movTot)
        {

            this.solicitudes = ordenada;
            this.mov = movTot;
            InitializeComponent();
            labelMov.Text = "Cantidad total del movimiento del cabezal: " + mov.ToString();
        }

        private void FormSCAN_Load(object sender, EventArgs e)
        {

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
