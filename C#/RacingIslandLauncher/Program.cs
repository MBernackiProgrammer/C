using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Racing_Island_Lancher.Sites.Account.Login;
using Racing_Island_Lancher.Sites;
using Racing_Island_Lancher.Sites.MainPage;
using System.Diagnostics;
using System.IO;


namespace Racing_Island_Lancher
{
    
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // Program pobiera miesce folderu AppData oraz dodaje moduły(foldery)
            // RacingIslandLauncher - folder podstawowy ustawień lauchera
            // UserDatas - folder danych użytkowników 

            string Path1 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            Path1 = Path1 + "\\RacingIslandLauncher\\UserDatas";

            bool LogedIn = false;

            //Sprawdza czy istnieje ścieżka
            bool Istnieje = File.Exists(Path1 + "\\UserLoginDatas.txt");


            if (Istnieje)
            {   
                string[] AllLines = File.ReadAllLines((Path1 + "\\UserLoginDatas.txt"));
                Debug.Print("1234");

                LogedIn = true;   
            }
            else
            {
                LogedIn = false;

                //Tworzy ścieżkę na podstawie Path1
                Directory.CreateDirectory(Path1);
            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if(LogedIn == true)
            {
                Application.Run(new LauncherMainPage());
            }
            else
            {
                Application.Run(new LoginTo());
            }
            
        }
    }
}
