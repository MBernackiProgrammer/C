using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompanyRegister;
using System.IO;

namespace CompanyRegister.Menu.WorkerCameToWork
{
    public partial class WorkerCame : Form
    {
        public string WorkerID;
        public WorkerCame()
        {
            InitializeComponent();
        }

        private void WorkerCame_Load(object sender, EventArgs e)
        {
            string Path1 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            Path1 = Path1 + "\\TestCard";

            string[] AllIDs = File.ReadAllLines(Path1 + SaveFilesNames.WorkerIDSave);

            bool SearchedID = false;
            int IDIndex = -1; 

            for(int i = 0; i > AllIDs.Length; i++)
            {
                if(AllIDs[i] == WorkerID)
                {
                    SearchedID = true;
                    IDIndex = i;
                    break;
                }
            }

            if(SearchedID == true)
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
