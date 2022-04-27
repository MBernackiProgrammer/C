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

using System.Diagnostics;

namespace Racing_Island_Lancher.Sites.GameSettings
{
    public partial class GameSrttings : Form
    {

        int ViewDistance = 1;
        int AntiAliasing = 1;
        int EffectQuality = 1;
        int ShadingQualiti = 1;
        public GameSrttings()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {

            string Path1 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            Path1 = Path1 + "\\RacingIslandLauncher\\GameLocation\\GamesLocations.txt";

                string[] Lines = File.ReadAllLines(Path1);

            if (File.ReadAllText(Path1) != "")
            {
                for (int i = 0; i < Lines.Length; i++)
                {
                    DirectoryInfo Folder = new DirectoryInfo(Lines[i]);
                    if (Folder.Name == "RacingTown.exe")
                    {
                        string EXELocation = Folder.FullName;
                        EXELocation = Path.GetDirectoryName(EXELocation);

                        
                        string EditFileSettings = EXELocation + "\\RacingTown\\Saved\\Config\\WindowsNoEditor\\GameUserSettings.ini";
                        string[] Lines2 = File.ReadAllLines(EditFileSettings);

                        

                        /*
                        StreamWriter A = new StreamWriter(EditFileSettings);
                        
                        //sg.ViewDistanceQuality
                        Lines2[2] = "sg.ViewDistanceQuality=" + ViewDistance;
                        //sg.AntiAliasingQuality
                        Lines2[3] = "sg.AntiAliasingQuality=" + AntiAliasing;
                        //sg.ShadowQuality = 0
                        Lines2[4] = "sg.ShadowQuality=0";
                        //sg.PostProcessQuality = 5
                        Lines2[5] = "sg.PostProcessQuality=5";
                        //sg.TextureQuality = 1
                        Lines2[6] = "sg.TextureQuality=1";
                        //sg.EffectsQuality
                        Lines2[7] = "sg.EffectsQuality=" + EffectQuality;
                        //sg.FoliageQuality
                        Lines2[8] = "sg.PostProcessQuality=5";
                        //sg.ShadingQuality
                        Lines2[9] = "sg.PostProcessQuality=5";

                        for(int i2 = 0; i > 44; i2++)
                        {
                            A.WriteLine(Lines2[i2]);
                        }
                        A.Close();
                        */
                    }
                    else
                    {

                    }


                }
            }
            this.Close();
        }

        private void B_Near_ViewDistanse_Click(object sender, EventArgs e)
        {
            ViewDistance = 1;
        }

        private void B_Medium_ViewDistanse_Click(object sender, EventArgs e)
        {
            ViewDistance = 2;
        }

        private void B_Far_ViewDistanse_Click(object sender, EventArgs e)
        {
            ViewDistance = 3;
        }

        private void B_Epic_ViewDistanse_Click(object sender, EventArgs e)
        {
            ViewDistance = 4;
        }

        private void B_Low_AntiAliasing_Click(object sender, EventArgs e)
        {
            AntiAliasing = 1;
        }

        private void B_Medium_AntiAliasing_Click(object sender, EventArgs e)
        {
            AntiAliasing = 2;
        }

        private void B_High_AntiAliasing_Click(object sender, EventArgs e)
        {
            AntiAliasing = 3;
        }

        private void B_Epic_AntiAliasing_Click(object sender, EventArgs e)
        {
            AntiAliasing = 4;
        }

        private void B_Low_EffectsQuality_Click(object sender, EventArgs e)
        {
            EffectQuality = 1;
        }

        private void B_Medium_EffectsQuality_Click(object sender, EventArgs e)
        {
            EffectQuality = 2;
        }

        private void B_High_EffectsQuality_Click(object sender, EventArgs e)
        {
            EffectQuality = 3;
        }

        private void B_Epic_EffectsQuality_Click(object sender, EventArgs e)
        {
            EffectQuality = 4;
        }
    }

}