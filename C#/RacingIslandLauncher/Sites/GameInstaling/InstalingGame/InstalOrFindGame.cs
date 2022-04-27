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
using System.IO;

namespace Racing_Island_Lancher.Sites.GameInstaling.InstalingGame
{
    public partial class InstalOrFindGame : Form
    {

        //Deklaracja zmiennych informacyjnych 
        //LauncherPath = Ścieżka launchera na dysku
        private string LaucherPath;

        public InstalOrFindGame()
        {
            InitializeComponent();

            //Nadawanie wartości (sciezki launchera na dysku) dla LaucherPath 
            LaucherPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\RacingIslandLauncher";
        }

        private void B_FindGame_Click(object sender, EventArgs e)
        {
            /////////////////////////////////////////////////
            
            //Przypadek gdy po naciśnięciu przycisku "Find game"
            //ZADANIA
            //1. Otwieranie okna dialogowego, do wyszukiwania plików
            //2. Utworzenie pliku, bądź dopisanie do niego nowej ścieżki pliku
            //3. Zamknięcie okna
            
            /////////////////////////////////////////////////
            
            //Nadawanie tytułu i filtru dla okna dialogowego
            openFileDialog1.Title = "Find Racing Town Game";
            openFileDialog1.Filter = "exe files (*.exe)|*.exe";

            //Otwieranie okna dialogowego
            openFileDialog1.ShowDialog();
 
            //Pobieranie wartości z okna dialogowego
            string GotPath = openFileDialog1.FileName;

            //Sprawdzanie czy istnieje plik 
            if(File.Exists(LaucherPath + "\\GameLocation\\GamesLocations.txt"))
            {
                /////////////////////////////////////////////////
                
                //Przypadek gdy gracz ma już na dysku inne gry, czyli na dysku ma już plik GameLocations
                //ZADANIA 
                //1. Otworzenie pliku i zebranie danych 
                //2. Ponownie spisanie danych na plik 

                /////////////////////////////////////////////////

                //Zczytywanie danych z pliku GamesLocations.txt do tablicy 
                string[] GamesLocations = File.ReadAllLines(LaucherPath + "\\GameLocation\\GamesLocations.txt");
                GamesLocations[GamesLocations.Length] = GotPath;

                StreamWriter A = new StreamWriter(LaucherPath + "\\GameLocation\\GamesLocations.txt");
                
                //Przepisywanie danych z tablicy do pliku .txt
                for(int i = 0; i < GamesLocations.Length; i++)
                {
                    A.WriteLine(GamesLocations[i]);
                }
                A.Close();
            }
            else
            {
                /////////////////////////////////////////////////
                
                //Przypadek, kiedy gracz nie ma pliku GameLocations.txt na dysku 
                //ZADANIA
                //1. Utworzenie pliku GameLocations.txt na dysku 

                /////////////////////////////////////////////////

                //Tworzenie ścieżki na dysku
                Directory.CreateDirectory(LaucherPath + "\\GameLocation");
                StreamWriter A = new StreamWriter(LaucherPath + "\\GameLocation\\GamesLocations.txt");
                A.WriteLine(GotPath);
                A.Close();
            }

            this.Close();
        }
    }
}
