using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Reflection;

namespace Auto_Steam_Fix
{
    public partial class MainForm : Form
    {

        //public delegate void AddListItem();
       //public AddListItem myDelegate;

        public MainForm()
        {
            InitializeComponent();
            //this.Load += load_function;
            //Task.Factory.StartNew(waiting_function);
            //myDelegate = new AddListItem(AddListItemMethod);
        }

        //Removing this entire update check region since the server used to host the check logic isn't up anymore.
        //The loading splash screen with my amazing design has accidently been deleted as well :(
        #region Update Check
        
        /*public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }

        public void AddListItemMethod()
        {
            splash1.Visible = false;
        }

        bool isLoaded = false; 

        void load_function(object sender, EventArgs e)
        {
            isLoaded = true;
        }

        void waiting_function()
        {
            while (!isLoaded)
                continue; //UpdateCheck();          
        }

        public void UpdateCheck()
        {           
            bool internet = CheckForInternetConnection();            

            if (internet == true)
            {
                WebRequest wr = WebRequest.Create(new Uri("https://piratehub.ga/autosteamfix/version.txt"));
                WebResponse ws = wr.GetResponse();
                StreamReader sr = new StreamReader(ws.GetResponseStream());

                string PresentVersion = "2.1.0";                string LatestVersion = sr.ReadToEnd();

                if (PresentVersion.Contains(LatestVersion))
                {
                    Invoke(myDelegate);
                }

                else
                {
                    DialogResult res = MessageBox.Show(" New Version of the Tool is Available!\n Current Version: " + PresentVersion + "\n LatestVersion: " + LatestVersion + "\n\n It is recommended that you update to the latest version.", "NEW UPDATE IS AVAILABLE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (res == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("https://piratehub.ga/forum/index.php?threads/auto-steam-fix-tool-v2-0-0.242/");
                    }

                    else
                    {
                        Invoke(myDelegate);
                    }
                }
            }

            else
            {
                Invoke(myDelegate);
            }     
        }

        void GuiLoadWait()
        {
            while (!isLoaded); 
        }
        */
        #endregion

        #region UI Events

        private void Exit1_MouseEnter(object sender, EventArgs e)
        {
            Exit1.Visible = false;
            Exit2.Visible = true;
        }

        private void Exit2_MouseLeave(object sender, EventArgs e)
        {
            Exit1.Visible = true;
            Exit2.Visible = false;
        }

        private void Exit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {


            if (SideMenu.Width == 51)
            {
                SideMenu.BackColor = Color.FromArgb(26, 32, 40);
                CreditMain.Visible = true;
                
                Discord.Visible = true;
                Forum.Visible = true;
                bunifuFlatButton1.Visible = true;
                SideMenu.Visible = false;
                SideMenu.Width = 240;
                bunifuTransition1.ShowSync(SideMenu);
            }

            else
            {
                
                SideMenu.BackColor = Color.FromArgb(37, 46, 59);
                CreditMain.Visible = false;
                
                bunifuFlatButton1.Visible = false;
                Discord.Visible = false;
                Forum.Visible = false;
                SideMenu.Visible = false;
                SideMenu.Width = 51;
                bunifuTransition2.ShowSync(SideMenu);
            }
        }

        private void SteamFix_Click(object sender, EventArgs e)
        {       
            steamFix1.Visible = true;
            bunifuImageButton1.Visible = true;    
        }

        private void Discord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/c5qAVpY");
        }

        private void Forum_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://piratehub.ga/forum/index.php");
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/c/ManiacKnight");
        }

        private void DLCUIcon_Click(object sender, EventArgs e)
        {
            dlcUnlocker1.Visible = true;
            DLCBack.Visible = true;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            steamFix1.Visible = false;
            bunifuImageButton1.Visible = false;
        }

        private void DLCBack_Click(object sender, EventArgs e)
        {
            dlcUnlocker1.Visible = false;
            DLCBack.Visible = false;
        }

        private void dlcUnlocker1_Load(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
