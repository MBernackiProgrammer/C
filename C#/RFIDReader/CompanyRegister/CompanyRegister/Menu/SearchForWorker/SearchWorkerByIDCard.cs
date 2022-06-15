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
using System.IO;
using System.Diagnostics;

using CompanyRegister;

namespace CompanyRegister.Menu.SearchForWorker
{
    public partial class SearchWorkerByIDCard : Form
    {
        public SearchWorkerByIDCard()
        {
            InitializeComponent();

            string Path1 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            Path1 = Path1 + "\\TestCard";

            bool IsSaveFileExisting = File.Exists(Path1 + "\\COMSave.txt");
            bool LastIsExisting = false;
            String[] AllPorts = SerialPort.GetPortNames();

            String COMport = "";
            if (COMAvailableChecker.CheckIsCOMAvailable(""))
            {
                
            }
            serialPort1.PortName = "";
        }

        private void SearchForWorker_Load(object sender, EventArgs e)
        {

        }
    }
}
