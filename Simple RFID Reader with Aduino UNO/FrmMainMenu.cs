using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Simple_RFID_Reader_with_Aduino_UNO
{
    public partial class FrmMainMenu : Form
    {
        static SerialPort _serialPort;

        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            _serialPort = new SerialPort();
            _serialPort.PortName = "COM4";
            _serialPort.BaudRate = 9600;
            _serialPort.Open();
        }

        private void btnDetect_Click(object sender, EventArgs e)
        {
            while (true)
            {
                string a = _serialPort.ReadExisting();
                if (a != "")
                {
                    listBoxOutPut.Items.Add(a);
                    break;
                }
            }
        }
    }
}
