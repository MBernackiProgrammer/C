using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompanyRegister.Menu.AllWorkers;

using CompanyRegister.Menu.SearchForNew;
using CompanyRegister.Menu.WorkerCameToWork;
using CompanyRegister.Menu.SearchForWorker;
using CompanyRegister.Menu.SeatchForWorkerByID;

using CompanyRegister;

using CompanyRegister.Menu.Settings;

namespace CompanyRegister.Menu
{
    public partial class MenuGL : Form
    {
        public MenuGL()
        {
            InitializeComponent();

            if(COMAvailableChecker.CheckIsCOMAvailable(COMAvailableChecker.GetCOM(this)))
            { 
                this.Hide();
                
                SettingsCOM COMSettings = new SettingsCOM();
                COMSettings.ShowDialog();

                this.Close();
            } 
        }

        private void B_Search_Click(object sender, EventArgs e)
        {
            SearchNewPendant SearchFor = new SearchNewPendant();
            SearchFor.ShowDialog();
            if (COMAvailableChecker.CheckIsCOMAvailable(COMAvailableChecker.GetCOM(this)))
            {
                
            }   
        }

        private void B_ShowAllWorkers_Click(object sender, EventArgs e)
        {
            AllCompanyWorkers AllWorkers = new AllCompanyWorkers();
            AllWorkers.ShowDialog();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            String DataRecive = serialPort1.ReadLine().ToString();
            WorkerCame Window = new WorkerCame();
            Window.WorkerID = DataRecive;
            Window.ShowDialog();
        }

        private void B_SearchWorkerByIDCard_Click(object sender, EventArgs e)
        {
            SearchWorkerByIDCard WorkerWidget = new SearchWorkerByIDCard();
            WorkerWidget.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SWorkerByID SearchWorkerByID = new SWorkerByID();
            SearchWorkerByID.ShowDialog();
        }
    }
}
