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

        public Interfaz()
        {
            InitializeComponent();
        }

        private void Interfaz_Load(object sender, EventArgs e)
        {
          
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

        }

        private void puertoComunicacion_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Obtenemos el puerto serie que lanza el evento
            SerialPort currentSerialPort = (SerialPort)sender;

            // Leemos el dato recibido del puerto serie
            Debug.WriteLine($"Dato recibido: {currentSerialPort.ReadLine()}");
        }
    }
}
