using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Wyswietlanie
{
    public partial class Form1 : Form
    {
        bool COMselected = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_MouseDown(object sender, MouseEventArgs e)
        {
            String[] AllPorts;
            AllPorts = SerialPort.GetPortNames();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(AllPorts);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(COMselected)
            {
                serialPort1.Write(textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
            serialPort1.Open();
            COMselected = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
