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
using System.Diagnostics;
using System.IO;


using CompanyRegister.Menu;

namespace CompanyRegister.Menu.Settings
{
    public partial class SettingsCOM : Form
    {
        public SettingsCOM()
        {
            InitializeComponent();

            
        }

        private void B_Save_Click(object sender, EventArgs e)
        {
            string Path1 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            Path1 = Path1 + "\\TestCard";

            Directory.CreateDirectory(Path1);
            
            StreamWriter SaveCOM = new StreamWriter(Path1 + "\\COMSave.txt");
            SaveCOM.WriteLine(comboBox1.Text);
            SaveCOM.Close();

            StreamWriter SaveWorkerName = new StreamWriter(Path1 + "\\WorkerNameSave.txt");

            
            StreamWriter SaveWorkerSurname = new StreamWriter(Path1 + "\\WorkerSurnameSave.txt");
            StreamWriter SaveWorkerRoom = new StreamWriter(Path1 + "\\WorkerRoomSave.txt");
            StreamWriter SaveWorkerID = new StreamWriter(Path1 + "\\WorkerIDSave.txt");
            StreamWriter SaveWorkerPhoneNumber = new StreamWriter(Path1 + "\\WorkerPhoneNumberSave.txt");

            SaveWorkerID.Close();

            MenuGL Menu = new MenuGL();

            this.Hide();
            Menu.ShowDialog();
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            String[] AllPorts;
            AllPorts = SerialPort.GetPortNames();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(AllPorts);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
