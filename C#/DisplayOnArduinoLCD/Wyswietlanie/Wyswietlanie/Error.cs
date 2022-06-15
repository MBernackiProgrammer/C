using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace Wyswietlanie
{
    public partial class COMError : Form
    {
        public string ErrorText;
        public COMError()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void COMError_Load(object sender, EventArgs e)
        {
            //Play error sound
            SystemSounds.Hand.Play();

            //Check, is error wrote 
            if (ErrorText == null)
            {
                L_ErrorText.Text = "Nieznany błąd, spróbuj ponownie";
            }
            else
            {
                L_ErrorText.Text = ErrorText;
            }
        }
    }
}
