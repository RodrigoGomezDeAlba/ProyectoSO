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
        //List<int> solicitudesOrdenadas;    //se declara el arreglo que almacenara las solicitudes aleatorias
        int posInicial = 0;
        List<int> solicitudesOriginales;
        int totalSolicitudes = 0;
        List<int> solicitudes = new List<int>();
        int posicionActual; // Posición actual del cabezal para animación
        int indiceSolicitud = 0; // Índice de la solicitud actual
        System.Windows.Forms.Timer timerMovimiento; // Temporizador para animación

        public FormCSCAN()
        {
            InitializeComponent();
        }

        public FormCSCAN(List<int> ordenada, int movTot, int posicion, int[] originales)
        {

            this.solicitudes = ordenada;
            this.solicitudesOriginales = originales.ToList();
            this.mov = movTot;
            this.posInicial = posicion;

            movTot += Math.Abs(posicion - ordenada[0]); // Movimiento inicial
            for (int i = 0; i < ordenada.Count - 1; i++)
            {
                movTot += Math.Abs(ordenada[i] - ordenada[i + 1]); // Distancia entre solicitudes consecutivas
            }


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

            //timer de la animacion
            timerMovimiento = new System.Windows.Forms.Timer();
            timerMovimiento.Interval = 2000; // 1000 ms por paso
            timerMovimiento.Tick += timer1_Tick;

            // Iniciar animación al cargar el formulario
            timerMovimiento.Start();
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
            // Mostrar la posicion actual del cabezal
            labelPosActual.Text = "Posición actual del cabezal: " + posInicial.ToString();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int radioBase = 50;
            int incrementoRadio = 50;

            //tamano del panel
            int panelWidth = panel2.Width;
            int panelHeight = panel2.Height;

            //centro del panel
            int centroX = panelWidth / 2;
            int centroY = panelHeight / 2;

            //radio mas grande
            int radio = 250;

            //se declara el numero de circulos, cada circulo son 500 cilindros
            int numCirculos = 10;

            //se calcula cuanto va a disminuir cada circulo
            int disminucion = radio / numCirculos;

            //se declara un vector de diez colores para que los circulos sean de distinto color
            System.Drawing.Color[] colores =
            {
                //System.Drawing.Color.FromArgb(200,108, 161, 158),
                System.Drawing.Color.FromArgb(255, 132, 171, 170),
                System.Drawing.Color.FromArgb(255, 222, 209, 182),
               // System.Drawing.Color.FromArgb(200, 109, 153, 122),
            };

            //dibuja el disco con sus 10 bloques de 500 cilindros
            for (int i = 0; i < numCirculos; i++)
            {
                //se calcula el radio del circulo actual, esto se hace restandole al radio mas grande, la disminucion correspondiente al circulo que se dibuje
                int radioActual = radio - (i * disminucion);

                //se calculan las coordenadas del circulo actual
                int x = centroX - (radioActual / 2);
                int y = centroY - (radioActual / 2);

                //para ciclar el vector de colores
                System.Drawing.Color colorAct = colores[i % colores.Length];
                Brush relleno = new SolidBrush(colorAct);
                g.FillEllipse(relleno, x, y, radioActual, radioActual);
            }
            int radioCabezal = 0;
            // Dibujar el cabezal
            if (posicionActual < 500)
            {
                radioCabezal = 0;
            }
            else if (posicionActual >= 500 && posicionActual < 1000)
            {
                radioCabezal = 25;
            }
            else if (posicionActual >= 1000 && posicionActual < 1500)
            {
                radioCabezal = 35;
            }
            else if (posicionActual >= 1500 && posicionActual < 2000)
            {
                radioCabezal = 50;
            }
            else if (posicionActual >= 2000 && posicionActual < 2500)
            {
                radioCabezal = 62;
            }
            else if (posicionActual >= 2500 && posicionActual < 3000)
            {
                radioCabezal = 75;
            }
            else if (posicionActual >= 3000 && posicionActual < 3500)
            {
                radioCabezal = 87;
            }
            else if (posicionActual >= 3500 && posicionActual < 4000)
            {
                radioCabezal = 99;
            }
            else if (posicionActual >= 4000 && posicionActual < 4500)
            {
                radioCabezal = 112;
            }
            else if (posicionActual >= 4500 && posicionActual < 5000)
            {
                radioCabezal = 125;
            }


            g.FillRectangle(Brushes.Red, centroX - radioCabezal, centroY - 5, 10, 10);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Si hay solicitudes pendientes
            if (indiceSolicitud < solicitudes.Count)
            {
                // Mover el cabezal hacia la próxima solicitud
                posicionActual = solicitudes[indiceSolicitud];
                indiceSolicitud++;

                // Actualizar el texto del Label
                labelPosActual.Text = "Posición actual del cabezal: " + posicionActual.ToString();

                // Redibujar el panel
                panel2.Invalidate();
            }
            else
            {
                // Detener el temporizador cuando termine
                timerMovimiento.Stop();
                labelPosActual.Text = "Movimiento finalizado.";
            }
        }
    }
}
