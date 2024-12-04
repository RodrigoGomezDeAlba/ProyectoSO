﻿using System;
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
        //List<int> solicitudesOrdenadas;    //se declara el arreglo que almacenara las solicitudes aleatorias
        int posInicial = 0;
        List<int> solicitudesOriginales;
        int totalSolicitudes = 0;
        List<int> solicitudes = new List<int>();

        public FormCSCAN()
        {
            InitializeComponent();
        }

        public FormCSCAN(List<int> ordenada, int movTot, int posicion, int [] originales)
        {

            this.solicitudes = ordenada;
            this.solicitudesOriginales = originales.ToList();
            this.mov = movTot;
            this.posInicial = posicion;

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
