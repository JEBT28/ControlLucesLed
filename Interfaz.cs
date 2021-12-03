using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Arduino
{
    public partial class Interfaz : Form
    {
        private SerialPort puertoComunicacion;

        private string estado = "";

         System.Windows.Forms.Timer t;

        int Contador = 0;


        public delegate void actualizarLabel(string s,Label l);

        public static void actualizar(string str,Label lbl)
        {
            lbl.Text = str;
        }

        public Interfaz()
        {
            InitializeComponent();           
        }

        

        private void Interfaz_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            chkDiasValidos.DataSource = Enum.GetValues(typeof(DayOfWeek));
            cmbDiaActual.DataSource = Enum.GetValues(typeof(DayOfWeek));
        }

        private void LeerPuertosSeriales()
        {
            cmbPuertosSeriales.Items.Clear();
            Debug.WriteLine(String.Join(" ,",SerialPort.GetPortNames()));
            cmbPuertosSeriales.Items.AddRange(SerialPort.GetPortNames());
        }

        private void btnCargarSP_Click(object sender, EventArgs e)
        {
            LeerPuertosSeriales();
        }

        private void Conectar(string puerto)
        {
            puertoComunicacion = new SerialPort();

            puertoComunicacion.BaudRate = 9600;
            puertoComunicacion.PortName = puerto;

            puertoComunicacion.DataReceived += new SerialDataReceivedEventHandler(puertoComunicacion_DataReceived);

            // Controlamos que el puerto indicado esté operativo
            try
            {
                // Abrimos el puerto serie
                puertoComunicacion.Open();
                Debug.WriteLine($"Puerto abierto: {puerto}");
            }
            catch
            {
                MessageBox.Show("El puerto indicado no se puede abrir");
            }

        }

        private void puertoComunicacion_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Obtenemos el puerto serie que lanza el evento
            SerialPort currentSerialPort = (SerialPort)sender;

            string datoRecibido = currentSerialPort.ReadExisting().Trim().Replace("\n","");

            // Leemos el dato recibido del puerto serie
            Debug.WriteLine(datoRecibido);
            if (datoRecibido.ToString().Contains("1"))
            {
                t.Stop();
                Contador = 0;
                lblContador.Text = Contador.ToString(); ;
            }
            else
            {               
                Contador = 0;
                iniciarConteo();
            }
        }

        public void iniciarConteo()
        {
            t = new System.Windows.Forms.Timer();
            
            t.Tick += new EventHandler(tick);

            t.Interval = 1000;
            
            t.Start();            
        }


        public void detenerConteo()
        {
            t.Stop();

            Contador = 0;

            lblContador.Text = Contador.ToString();
        
        }

        private void tick(object sender,EventArgs e)
        {
            Contador++;
            actualizarLabel act  = new actualizarLabel(actualizar);
            act(Contador.ToString(), lblContador);
            
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(cmbPuertosSeriales.SelectedText))
            {
                MessageBox.Show("No hay ningun puerto seleccionaado");
                return;
            }
            Conectar(cmbPuertosSeriales.SelectedText);
        }

    }
}
