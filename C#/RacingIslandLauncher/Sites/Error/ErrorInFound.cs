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

namespace Racing_Island_Lancher.Sites.Error
{
    public partial class ErrorInFound : Form
    {

        public bool GameSearched = false;
        public string GameName = "";
        public string FolderLocation = "";

        private string LauncherPath = "";

        public ErrorInFound()
        {
            InitializeComponent();

            string Path1 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            Path1 = Path1 + "\\RacingIslandLauncher";
            LauncherPath = Path1;

        }

        private void ErrorInFound_Load(object sender, EventArgs e)
        {
           
        }

        private void B_Localize_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Find Racing Town Game";
            openFileDialog1.Filter = "exe files (*.exe)|*.exe";

            openFileDialog1.ShowDialog();
            GameName = openFileDialog1.FileName;
            string Tag = openFileDialog1.SafeFileName;
            //string Location = openFileDialog1.
            //Tag = openFileDialog1.FileOk;

            if (Tag == "RacingTown.exe")
            {

                string ModLoc = LauncherPath + "\\GameLocation";
                Directory.CreateDirectory(ModLoc);
                //DirectoryInfo Folder = new DirectoryInfo(ModLoc);
                //Folder.Attributes = FileAttributes.Hidden;
                StreamWriter A = new StreamWriter(ModLoc + "\\GamesLocations.txt");
                A.WriteLine(GameName);
                A.Close();


                //string text = File.ReadAllText(ModLoc + "\\GamesLocations.txt");
                //Console.WriteLine(text);
                //directory.Text = text;

                GameSearched = true;


            }
            else
            {
                GameSearched = false;
            }
        }
    }
}
