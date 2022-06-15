using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using CompanyRegister.Menu.SearchForNew;

namespace CompanyRegister.Menu.SearchForNew
{
    public partial class SearchNewPendant : Form
    {
        String SerialDataIn;

        public SearchNewPendant()
        {
            InitializeComponent();

            

            string Port;

            string Path1 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            Path1 = Path1 + "\\TestCard";

            string[] AllLines = File.ReadAllLines(Path1 + "\\COMSave.txt");

            Port = AllLines[0];

            serialPort1.PortName = Port;

            //serialPort1.Active

            serialPort1.Open();

            

        }

        private void SearchNewPendant_Load(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            SerialDataIn = serialPort1.ReadLine().ToString();
            serialPort1.Close();
            SearchedInfo Znalezione = new SearchedInfo();

            Znalezione.ID = SerialDataIn;
            //this.Hide();
            Znalezione.ShowDialog();

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
