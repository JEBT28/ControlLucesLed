using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Arduino
{
    public partial class Interfaz : Form
    {
        private SerialPort puertoComunicacion;

        private string estado = "";

        Timer t = new Timer();

        int Contador = 0;

        
        public Interfaz()
        {
            InitializeComponent();
           
        }

        private void T_Tick(object sender, EventArgs e)
        {         
            Contador++;
            lblContador.Text = Contador.ToString();            
        }

        private void Interfaz_Load(object sender, EventArgs e)
        {
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
            Debug.WriteLine($"Es de {(datoRecibido=="1"?"dia":"noche")}");
            if (datoRecibido.Contains("1"))
            {
                t.Stop();
                Contador = 0;
                lblContador.Text = Contador.ToString(); ;
            }
            else
            {               
                Contador = 0;                
                t.Tick += new EventHandler(T_Tick);
                t.Interval = 1000;
                t.Start();
            }
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
