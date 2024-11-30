namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        public class ResultadosSCAN
        {
            public List<int> ListaOrdenada { get; set; }
            public int movimientosTotales { get; set; }
        }
        const int limite = 5000;        //se declara el maximo de cilindros que se van a usar
        int solicitudesTot = 0;    //se declara el numero de solicitudes que se haran
        int[] solicitudes = null;    //se declara el arreglo que almacenara las solicitudes aleatorias
        bool arriba = false;    //esta variable es para saber la direccion a donde se movera el cabezal
        int posicion = 0;
        public Form1()
        {
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPosicion_TextChanged(object sender, EventArgs e)
        {

        }

        //metodo para generar solicitudes aleatorias
        static int[] generarAleatorios(int numSolicitudes, int maxCilindros)
        {
            int[] solicitudes = new int[numSolicitudes]; //se crea el arreglo que contendra las solicitudes aleatorias
            Random random = new Random();   // se crea una instancia de random

            for (int i = 0; i < numSolicitudes; i++)
            {
                solicitudes[i] = random.Next(0, maxCilindros);
            }
            return solicitudes; //se retorna el vector ya con valores aleatorios
        }

        //metodo para aplicar el algoritmo SCAN
        public ResultadosSCAN algoritmoSCAN(int posicion, int[] solicitudes, bool direccion, int limite)
        {
            Array.Sort(solicitudes); //Se ordena el arreglo en forma ascendente, para poder realizar el algoritmo de forma correcta

            //Se crean dos listas para poder manipular las solicitudes de mejor manera
            List<int> arriba = new List<int>();
            List<int> abajo = new List<int>();

            //Se acomodan las solicitudes en la lista correspondiente
            foreach (var solicitud in solicitudes)
            {
                if (solicitud < posicion)
                {
                    abajo.Add(solicitud);
                }
                else
                {
                    arriba.Add(solicitud);
                }
            }

            //Se agregan las posiciones de inicio y final del disco para que en la animacion simule correctamente el algoritmo
            if (!abajo.Contains(0))
            {
                abajo.Add(0);
            }
            if (!arriba.Contains(limite - 1))
            {
                arriba.Add(limite - 1);
            }

            //Se acomodan las solicitudes de abajo en forma descendente
            abajo.Sort();
            abajo.Reverse();

            //Se declara una nueva lista donde se almacenaran las dos listas anteriores pero ya ordenadas
            List<int> ordenado = new List<int>();

            //recorrer las solicitudes dependiendo de la direccion seleccionada

            //direccion hacia arriba

            if (direccion)
            {
                ordenado.AddRange(arriba);
                ordenado.AddRange(abajo);

            }
            else
            {
                ordenado.AddRange(abajo);
                ordenado.AddRange(arriba);
            }

            int movTot = Math.Abs(posicion - ordenado[0]);

            for (int i = 0; i < solicitudesTot - 1; i++)
            {
                movTot += Math.Abs(ordenado[i] - ordenado[i + 1]);
            }

            return new ResultadosSCAN { ListaOrdenada = ordenado, movimientosTotales = movTot };
        }

        private void radioButtonArriba_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonEjecutar_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(textBoxPosicion.Text, out posicion))
            {
                MessageBox.Show("Ingresa una posici�n v�lida.");
                return;
            }

            if (posicion < 0 || posicion >= limite)
            {
                MessageBox.Show($"Ingresa una posicion entre 0 y {limite - 1}. ");
                return;
            }

            if (!int.TryParse(textBoxSolicitudes.Text, out solicitudesTot))
            {
                MessageBox.Show("Ingresa un n�mero de solicitudes v�lido.");
                return;
            }

            if (solicitudesTot <= 0 || solicitudesTot > 1000)
            {
                MessageBox.Show("Ingresa una cantidad de solicitudes mayor a 0 y menor o igual a 1000.");
                return;
            }

            solicitudes = new int[solicitudesTot];

            //Se generan las solicitudes aleatorias
            solicitudes = generarAleatorios(solicitudesTot, limite);

            //Comprueba que opcion se eligio en la direccion del cabezal
            if (radioButtonArriba.Checked)
            {
                arriba = true;
            }
            else if (radioButtonAbajo.Checked)
            {
                arriba = false;
            }
            else
            {
                MessageBox.Show("Selecciona una direccion");
                return;
            }

            //Comprueba que algoritmo se eligio
            if (radioButtonFCFS.Checked)
            {
                //aqui se abriria la pantalla de este algoritmo
            }
            else if (radioButtonSCAN.Checked)
            {
                var resultado = algoritmoSCAN(posicion, solicitudes, arriba, limite); //esta linea es para que se haga un tipo de variable para poder pasar los datos
                //aqui se abriria la pantalla de este algoritmo
                FormSCAN Res = new FormSCAN(resultado.ListaOrdenada, resultado.movimientosTotales);
                this.Hide();
                Res.ShowDialog();
                this.Show();


            }
            else if (radioButtonCSCAN.Checked)
            {
                //aqui se abriria la pantalla de este algoritmo
            }
            else
            {
                MessageBox.Show("Selecciona un algoritmo.");
                return;
            }



        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}