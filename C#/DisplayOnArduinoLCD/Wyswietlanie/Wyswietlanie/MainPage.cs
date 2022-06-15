//Wrote by Mateusz Bernacki 
//All rights belong to MBernackiProgrammer (GitHub)
using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Wyswietlanie
{
    //Main class of the program 
    public partial class MainPage : Form
    {
        //Was Com selected ?
        bool COMselected = false;
        public MainPage()
        {
            InitializeComponent();
        }

        //Reload comboBox_1
        private void comboBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //Get all ports
            String[] AllPorts; //Tab ports 
            AllPorts = SerialPort.GetPortNames();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(AllPorts);
        }

        //Set text to arduino
        private void SendTextToCOM(object sender, EventArgs e)
        {
            //Is connected 
            if(COMselected)
            {
                //Was SerialPort opened
                if(serialPort1.IsOpen)
                {
                    //Show error
                    COMError ComError = new COMError();
                    ComError.ErrorText = "COM jest już wykorzystywany przez inną aplikację";
                    ComError.ShowDialog();
                }
                //Wasn't SerialPort opened 
                else
                {
                    serialPort1.Open();
                    serialPort1.Write(textBox1.Text);
                    serialPort1.Close();
                } 
            }
            //Wasn't connected
            else
            {
                //Show error
                COMError ComError = new COMError();
                ComError.ErrorText = "Wybierz port COM i go zatwierdź";
                ComError.ShowDialog();
            }
        }

        //select COM port 
        private void SelectCOM(object sender, EventArgs e)
        {
            //ComboBox have value 
            //Empty
            if(comboBox1.Text != "")
            {
                //Set port name 
                serialPort1.PortName = comboBox1.Text;
                //Change value 
                COMselected = true;                 
            }
            //Not empty
            else
            {
                //Show error 
                COMError ComError = new COMError();
                ComError.ErrorText = "Wybierz odpowiedni port COM";
                ComError.ShowDialog();
            }
        }

        //On press Enter in TextBlock
        private void ByKeyPrintLCDText(object sender, KeyEventArgs e)
        {
            if(e.KeyValue.ToString() == "13")
            {
                B_ShowText.Select();
            }

            if(textBox1.Text == null)
            {
                //Show error 
                COMError ComError = new COMError();
                ComError.ErrorText = "Wpisz tekst do pola";
                ComError.ShowDialog();
            }
        }
    }
}