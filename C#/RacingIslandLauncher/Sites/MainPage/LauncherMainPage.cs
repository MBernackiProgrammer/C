using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Racing_Island_Lancher.Sites.Account.Login;
using Racing_Island_Lancher.Sites.Error;

using Racing_Island_Lancher.Sites.GameSettings;
using Racing_Island_Lancher.Sites.GameInstaling.InstalingGame;

using System.IO;


namespace Racing_Island_Lancher.Sites.MainPage
{
    public partial class LauncherMainPage : Form
    {
        //Deklaracja zmiennych laucherowych 
        //PlayerNick = nazwa gracza
        private string PlayerNick = "";

        //LauncherPath = ścieżka launchera na dysku 
        private string LauncherPath = "";

        //SettingsPath = ścieżka ustawień lauchera na dysku użytkownika
        public string SettingsPath = "";
        
        //GamePath = ścieżka gry na dysku użytkownika 
        private string GamePath = "";
        private bool InstaledGame = false;

        //Funkcja jest wywoływana przy starcie formularza
        public LauncherMainPage()
        {
            InitializeComponent();

            //Nadawanie wartości zmiennym globalnym 

            //SettingsPath 
            //Nadanie wartości dla zmiennej SettingsPath równe %appdata% + "\\RacingIslandLauncher"
            SettingsPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\RacingIslandLauncher";

            //PlayerNick
            //Nadanie wartności dla zmiennej PlayerNick równe danym z pliku 
            //!!! SPRAWDŹ CZY NA DYSKU ZNAJDUJE SIĘ PLIK I FOLDER !!!
            if (File.Exists(SettingsPath + "\\UserDatas\\UserLoginDatas.txt"))
            {
                string[] PlayerAllDatas = File.ReadAllLines(SettingsPath + "\\UserDatas\\UserLoginDatas.txt");
                PlayerNick = PlayerAllDatas[0];
            }

            //LauncherPath 
            //Nadanie wartości dla zmiennej LauncherPath równe ścieżce launchera
            //LauncherPath = "";

            //GamePath
            //Nadanie wartości dla zmiennej GamePath równe ścieżce gry na dysku
            //!!! SPRAWDŹ CZY NA DYSKU ZNAJDUJE SIĘ PLIK I FOLDER !!!
            if (File.Exists(SettingsPath + "\\GameLocation\\GamesLocations.txt"))
            {
                string[] AllGamesFile = File.ReadAllLines(SettingsPath + "\\GameLocation\\GamesLocations.txt");

                for(int i = 0; i < AllGamesFile.Length; i++)
                {
                    DirectoryInfo GameDataFolder = new DirectoryInfo(AllGamesFile[i]);

                    if (GameDataFolder.Name == "RacingTown.exe")
                    {
                        GamePath = AllGamesFile[i];
                        InstaledGame = true;
                        break;
                    }
                }
            }

            string Path1 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            Path1 = Path1 + "\\RacingIslandLauncher";

            bool exist = File.Exists(Path1 + "\\UserLoginDatas.txt");

            if (exist == true)
            {
                LauncherPath = Path1;
            }
            else
            {
                Directory.CreateDirectory(Path1);
                LauncherPath = Path1;
            }

            string SetText = "Welcome back, ";
            SetText = SetText + PlayerNick;
            L_Welcome.Text = SetText;

        }

        private void LauncherMainPage_Load(object sender, EventArgs e)
        {

        }

        public void RestartInterface()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginTo ReLogin = new LoginTo();

            StreamWriter Logout = new StreamWriter(SettingsPath + "\\UserDatas\\UserLoginDatas.txt");
            Logout.WriteLine("");
            Logout.Close();

            //Path Sciezka = new Path(SettingsPath + "\\UserDatas\\UserLoginDatas.txt");
            //Directory Sciezkka = new Directory(SettingsPath + "\\UserDatas\\UserLoginDatas.txt");

            File.Delete(SettingsPath + "\\UserDatas\\UserLoginDatas.txt");
            ReLogin.StartPosition = FormStartPosition.Manual;
            ReLogin.Size = new Size(this.Width, this.Height);
            ReLogin.Top = this.Top;
            ReLogin.Left = this.Left;

            ReLogin.ShowDialog();
            this.Dispose();
            
        }

        //Funkcja sprawdza czy w pliku GameLocations.txt jest zawarta ścieżka do aplikacji exe
        //Jeśli nie jest zawarta, to pobiera informację od gracza czy gra była już instalowana na urządzeniu
                
                //Jeśli była pobrana to alikacja prosi o podanie ścieżki 
                //Jeśli nie była pobrana to aplikacja pobiera grę z chmury

        //Jeśli jest zawarta to otwiera grę
        private void B_PlayGame_Click(object sender, EventArgs e)
        {
            bool ReadyGame = false;
            if (File.Exists(SettingsPath + "\\GameLocation\\GamesLocations.txt"))
            {
                string[] AllGamesFile = File.ReadAllLines(SettingsPath + "\\GameLocation\\GamesLocations.txt");

                for (int i = 0; i < AllGamesFile.Length; i++)
                {
                    DirectoryInfo GameDataFolder = new DirectoryInfo(AllGamesFile[i]);

                    if (GameDataFolder.Name == "RacingTown.exe")
                    {
                        GamePath = AllGamesFile[i];
                        ReadyGame = true;
                        break;
                    }
                }
            }

            if (ReadyGame == true)
            {
                //Tworzenie pliku informacji dla gry
                Directory.CreateDirectory(SettingsPath + "\\GameData");
                //File.Create(SettingsPath + "\\GameData\\GameData.txt");
                StreamWriter FileForGame = new StreamWriter(SettingsPath + "\\GameData\\GameData.txt");
                FileForGame.WriteLine(PlayerNick);
                FileForGame.Close();


                //Otwieranie aplikacji exe
                Process RacingTown = new Process();
                Process Gra = new Process();                       
                Gra.StartInfo.FileName = GamePath;
                Gra.Start();
            }
            else
            {
                InstalOrFindGame FindGame = new InstalOrFindGame();
                FindGame.ShowDialog();
            }

        }
    }
}
