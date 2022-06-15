using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO.Ports;
using System.IO;
using System.Windows.Forms;

using CompanyRegister.Menu.Settings;

namespace CompanyRegister
{
    class COMAvailableChecker
    {
        static public bool CheckIsCOMAvailable(String Name)
        {
            bool IsAvaible = false;
            String[] AllPorts = SerialPort.GetPortNames();

            for(int i = 0; i > AllPorts.Length; i++)
            {
                if(AllPorts[i] == Name)
                {
                    return true;
                }
            }
            return false;
        }

        static public string GetCOM(Form ThisObj)
        {
            string FirstLine;

            string Path1 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            Path1 = Path1 + "\\TestCard";

            if(Directory.Exists(Path1))
            {
                string[] AllLines = File.ReadAllLines(Path1 + "\\COMSave.txt");

                FirstLine = AllLines[0];
                return FirstLine;
            }
            else
            {
                SettingsCOM Settings = new SettingsCOM();
                Settings.ShowDialog();
                return "";
            }
            
        }
    }
}
