using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using System.IO;


using CompanyRegister.Menu.Settings;
using CompanyRegister.Menu;


namespace CompanyRegister
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string Path1 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            Path1 = Path1 + "\\TestCard";

            bool IsSaveFileExisting = File.Exists(Path1 + "\\COMSave.txt");
            bool LastIsExisting = false;
            String[] AllPorts = SerialPort.GetPortNames();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (IsSaveFileExisting)
            {
                string[] AllLines = File.ReadAllLines(Path1 + "\\COMSave.txt");
                for (int i = 0; i < AllPorts.Length; i++)
                {
                    if(AllLines[0] == AllPorts[i])
                    {
                        LastIsExisting = true;
                    }
                }
                
                if(LastIsExisting)
                {
                    Application.Run(new MenuGL());
                }
                else
                {
                    Application.Run(new SettingsCOM());
                }
                
            }
            else
            {
                Application.Run(new SettingsCOM());
            }

            
            
            
        }
    }
}
