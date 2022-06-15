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

using CompanyRegister.Menu;


namespace CompanyRegister.Menu.SearchForNew
{
    public partial class SearchedInfo : Form
    {
        public const string WorkerIDSave = "\\WorkerIDSave.txt";
        public const string WorkerNameSave = "\\WorkerNameSave.txt";
        public const string WorkerSurnameSave = "\\WorkerSurnameSave.txt";
        public const string WorkerRoomSave = "\\WorkerRoomSave.txt";
        public const string WorkerPhoneNumber = "\\WorkerPhoneNumberSave.txt";

        public string ID = "";
        public SearchedInfo()
        {
            InitializeComponent();
        }

        private void SearchedInfo_Load(object sender, EventArgs e)
        {
            label1.Text = ID;
        }

        private void b_Save_Click(object sender, EventArgs e)
        {
            string Path1 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            Path1 = Path1 + "\\TestCard";


            
            //Save names
            string[] AllIDs = File.ReadAllLines(Path1 + WorkerIDSave);
            StreamWriter SaveWorkerIDs = new StreamWriter(Path1 + WorkerIDSave);
            for (int i = 0; i < AllIDs.Length; i++)
            {
                SaveWorkerIDs.WriteLine(AllIDs[i]);
            }
            
            SaveWorkerIDs.WriteLine(ID);
            SaveWorkerIDs.Close();

            //Save names
            string[] AllNames = File.ReadAllLines(Path1 + WorkerNameSave);
            StreamWriter SaveWorkerName = new StreamWriter(Path1 + WorkerNameSave);
            for (int i = 0; i < AllNames.Length; i++)
            {
                SaveWorkerName.WriteLine(AllNames[i]);
            }
            SaveWorkerName.WriteLine(TB_Name.Text);
            SaveWorkerName.Close();

            //Save surname
            string[] AllSurnames = File.ReadAllLines(Path1 + WorkerSurnameSave);
            StreamWriter SaveWorkerSurnames = new StreamWriter(Path1 + WorkerSurnameSave);
            for (int i = 0; i < AllSurnames.Length; i++)
            {
                SaveWorkerSurnames.WriteLine(AllSurnames[i]);
            }
            SaveWorkerSurnames.WriteLine(TB_Surname.Text);
            SaveWorkerSurnames.Close();

            //Save room save
            string[] AllRooms = File.ReadAllLines(Path1 + WorkerRoomSave);
            StreamWriter SaveWorkerRoom = new StreamWriter(Path1 + WorkerRoomSave);
            for (int i = 0; i < AllRooms.Length; i++)
            {
                SaveWorkerRoom.WriteLine(AllRooms[i]);
            }
            SaveWorkerRoom.WriteLine(TB_Room.Text);
            SaveWorkerRoom.Close();

            //Save Phone number
            string[] AllPhonesNumbers = File.ReadAllLines(Path1 + WorkerPhoneNumber);
            StreamWriter SaveWorkerPhoneNumbers = new StreamWriter(Path1 + WorkerPhoneNumber);
            for (int i = 0; i < AllRooms.Length; i++)
            {
                SaveWorkerPhoneNumbers.WriteLine(AllPhonesNumbers[i]);
            }
            SaveWorkerPhoneNumbers.WriteLine(TB_PhoneNumber.Text);
            SaveWorkerPhoneNumbers.Close();




            this.Hide();
            MenuGL Menu = new MenuGL();
            Menu.ShowDialog();
        }
    }
}
