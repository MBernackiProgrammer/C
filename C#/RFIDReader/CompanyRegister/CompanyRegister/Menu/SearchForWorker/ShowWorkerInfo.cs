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

namespace CompanyRegister.Menu.SearchForWorker
{
    public partial class ShowWorkerInfo : Form
    {
        public string WorkerID;
        public ShowWorkerInfo()
        {
            InitializeComponent();
        }

        private void ShowWorkerInfo_Load(object sender, EventArgs e)
        {
            string Path1 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            Path1 = Path1 + "\\TestCard";

            string[] AllIDs = File.ReadAllLines(Path1 + SaveFilesNames.WorkerIDSave);

            bool SearchedID = false;
            int IDIndex = -1;

            for (int i = 0; i > AllIDs.Length; i++)
            {
                if (AllIDs[i] == WorkerID)
                {
                    SearchedID = true;
                    IDIndex = i;
                    break;
                }
            }

            if (SearchedID == true)
            {
                string[] AllNames = File.ReadAllLines(Path1 + SaveFilesNames.WorkerNameSave);
                string[] AllSurnames = File.ReadAllLines(Path1 + SaveFilesNames.WorkerSurnameSave);
                string[] AllPhoneNumbers = File.ReadAllLines(Path1 + SaveFilesNames.WorkerPhoneNumber);
                string[] AllRoomNumber = File.ReadAllLines(Path1 + SaveFilesNames.WorkerRoomSave);

                L_Name.Text = AllNames[IDIndex];
                L_Surname.Text = AllSurnames[IDIndex];
                L_RoomNumber.Text = AllRoomNumber[IDIndex];
                L_PhoneNumber.Text = AllPhoneNumbers[IDIndex];
            }
        }
    }
}
