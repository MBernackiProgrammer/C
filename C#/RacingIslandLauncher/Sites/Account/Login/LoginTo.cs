using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Racing_Island_Lancher.Sites.Account.CreateAccount;
using Racing_Island_Lancher.Sites.Account.LoginWithOutMGS;
using Racing_Island_Lancher.Sites.MainPage;

using System.IO;

namespace Racing_Island_Lancher.Sites.Account.Login
{
    public partial class LoginTo : Form
    {
        
        public LoginTo()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = String.Empty;

            string Path1 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            Path1 = Path1 + "\\RacingIslandLauncher";
            string ModLoc = Path1 + "\\UserDatas";

            string[] AllLines;

            if (Directory.Exists(ModLoc + "\\UserLoginDatas.txt") == true)
            {
                AllLines = File.ReadAllLines((ModLoc + "\\UserLoginDatas.txt"));
                Login.Text = AllLines[0];
                Passworld.Text = AllLines[1];
            }
            
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void B_CreateAccount_Click(object sender, EventArgs e)
        {
            CreateLauncherAccount CreareAccount = new CreateLauncherAccount();

            double WidthNew = (float)Screen.PrimaryScreen.Bounds.Width;
            double HeightNew = (float)Screen.PrimaryScreen.Bounds.Height;

            double SetWidthNew = WidthNew / 3.5;
            double SetHeightNew = HeightNew / 1.5;

            double test = WidthNew / 2;
            double testdwa = HeightNew / 2;
            test = test - (SetWidthNew / 2);
            testdwa = testdwa - (SetHeightNew / 2);

            CreareAccount.Size = new Size(((int)SetWidthNew), ((int)SetHeightNew));
            CreareAccount.StartPosition = FormStartPosition.Manual;
            CreareAccount.Left = (int)test;
            CreareAccount.Top = (int)testdwa;

            CreareAccount.ShowDialog();
        }

        private void LoginTo_Load(object sender, EventArgs e)
        {

        }

        private void B_Quite_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void B_Login_Click(object sender, EventArgs e)
        {
            LauncherMainPage form2 = new LauncherMainPage();
            form2.StartPosition = FormStartPosition.Manual;
            form2.Size = new Size(this.Width, this.Height);
            form2.Left = this.Left;
            form2.Top = this.Top;

            string Path2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            Path2 = Path2 + "\\RacingIslandLauncher";

            string ModLoc = Path2 + "\\UserDatas";
            Directory.CreateDirectory(ModLoc);
            StreamWriter A = new StreamWriter(ModLoc + "\\UserLoginDatas.txt");
            A.WriteLine(Login.Text);
            A.WriteLine(Passworld.Text);
            A.Close();


            //form2.PlayerNick = Login.Text;
            form2.RestartInterface();

            form2.ShowDialog();
            this.Visible = false;
            //form2.Visible = true;
            //this.Visible = false;
            //this.WindowState = FormWindowState.Minimized;
            //this.WindowState = FormWindowState.Maximized;
            //this.ControlBox = false;
            //this.Text = String.Empty;

        }

        private void B_LoginWitoutMGSAccount_Click(object sender, EventArgs e)
        {
            LoginWithoutMGSAccount CreareAccount = new LoginWithoutMGSAccount();

            double WidthNew = (float)Screen.PrimaryScreen.Bounds.Width;
            double HeightNew = (float)Screen.PrimaryScreen.Bounds.Height;

            double SetWidthNew = WidthNew / 3.5;
            double SetHeightNew = HeightNew / 1.5;

            double test = WidthNew / 2;
            double testdwa = HeightNew / 2;
            test = test - (SetWidthNew / 2);
            testdwa = testdwa - (SetHeightNew / 2);

            CreareAccount.Size = new Size(((int)SetWidthNew), ((int)SetHeightNew));
            CreareAccount.StartPosition = FormStartPosition.Manual;
            CreareAccount.Left = (int)test;
            CreareAccount.Top = (int)testdwa;

            CreareAccount.ShowDialog();
        }

        private void B_Minimalize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void B_FullScreen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //this.ControlBox = false;
            //this.Text = String.Empty;
        }
    }
}
