using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INIReader;
using System.IO;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json.Linq;


namespace Auto_Steam_Fix
{
    public partial class SteamFix : UserControl
    {
        public SteamFix()
        {
            InitializeComponent();
        }

        private string TrimStartt(string source, string toTrim)
        {
            string s = source;
            while (s.StartsWith(toTrim))
            {
                s = s.Substring(toTrim.Length - 1);
            }
            return s;
        }

        private void BrowseB_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Browser = new FolderBrowserDialog();
            if (Browser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                FolderT.Text = (Browser.SelectedPath);
        }

         private void Btn_Apply_Click(object sender, EventArgs e)
        {

            if (TestBox.Text == string.Empty)
                return;

            string resultString = Regex.Match(TestBox.Text, @"\d+").Value;
            int AppID = Int32.Parse(resultString);
            string GameURL = "https://store.steampowered.com/api/appdetails/?appids=" + AppID;

            HttpWebRequest getRequest = (HttpWebRequest)WebRequest.Create(GameURL);
            var getResponse = (HttpWebResponse)getRequest.GetResponse();
            Stream newStream = getResponse.GetResponseStream();
            StreamReader sr = new StreamReader(newStream);
            var result = sr.ReadToEnd();

            JObject JO = JsonConvert.DeserializeObject<JObject>(result);
            var List = JO.Properties().ToList();
            var item = List[0];
            item.Replace(new JProperty("Root", item.Value));
            var rootObj = JsonConvert.DeserializeObject<SteamData.RootObject>(JO.ToString());

            List<int> ListDLC = rootObj.Root.data.dlc;

            string INILoc = @"AutoSteamFix\SteamFix\CreamApi\creamapi.ini";
            string OapiLoc = @"AutoSteamFix\SteamFix\CreamApi\steamapi.dll";
            string Oapi64Loc = @"AutoSteamFix\SteamFix\CreamApi\steamapi64.dll";


            EventLog_Animation.ShowSync(Event_Logger);
            Event_Logger.Visible = true;

            string[] creamo = Directory.GetFiles(FolderT.Text,
            "cream_api.ini",
            SearchOption.AllDirectories);

            if (creamo is null || creamo.Length == 0)
            {
                EventLog_Animation.ShowSync(Searching32_Log);
            Searching32_Log.Visible = true;

            string[] steamapi = Directory.GetFiles(FolderT.Text,
            "steam_api.dll",
            SearchOption.AllDirectories);
            if (steamapi is null || steamapi.Length == 0)
            {

                EventLog_Animation.ShowSync(apiNotFound_Log);
                apiNotFound_Log.Visible = true;             
            }

            else
            {
                EventLog_Animation.ShowSync(apiFound_log);
                apiFound_log.Visible = true;   
            }

            string[] steamapi64 = Directory.GetFiles(FolderT.Text,
            "steam_api64.dll",
            SearchOption.AllDirectories);

            EventLog_Animation.ShowSync(Searching64_log);
            Searching64_log.Visible = true;
            

            if (steamapi64 is null || steamapi64.Length == 0)
            {
                EventLog_Animation.ShowSync(api64NotFound_Log);
                api64NotFound_Log.Visible = true;     
            }

            else
            {
                EventLog_Animation.ShowSync(api64Found_Log);
                api64Found_Log.Visible = true;   
            }

                if (steamapi64.Length == 0 && steamapi.Length == 0)
                {
                    EventLog_Animation.ShowSync(Failed_Log);
                    Failed_Log.Visible = true;
                }

                else
                {
                    
                    EventLog_Animation.ShowSync(Replacing_Log);
                    Replacing_Log.Visible = true;

                    Directory.CreateDirectory(FolderT.Text + @"\AutoSteamFix\SteamFix\OriginalFiles");
                    string SAfolder = FolderT.Text + @"\AutoSteamFix\SteamFix\OriginalFiles\steam_api_o.dll";
                    string oSAfolder = FolderT.Text + @"\AutoSteamFix\SteamFix\OriginalFiles\steamapi.dll";
                    string oSAfolder64 = FolderT.Text + @"\AutoSteamFix\SteamFix\OriginalFiles\steamapi64.dll";
                    string SAfolder64 = FolderT.Text + @"\AutoSteamFix\SteamFix\OriginalFiles\steam_api64_o.dll";
                    string SAfolderINI = FolderT.Text + @"\AutoSteamFix\SteamFix\OriginalFiles\cream_api.ini";                 
                    string GeneratedFix = FolderT.Text + @"\GeneratedFix";
                    

                    foreach (string api in steamapi)
                    {
                        string cApi = api.Substring(0, api.Length - 13);

                        File.Move(api, cApi + "steam_api_o.dll");        
                        File.Copy(cApi + "steam_api_o.dll", SAfolder, true);
                        
                        File.Copy(OapiLoc, cApi + "steam_api.dll");               
                        File.Copy(OapiLoc, oSAfolder, true);
                       
                        File.Copy(INILoc, cApi + "cream_api.ini", true);

                        Directory.CreateDirectory(GeneratedFix + cApi.Remove(0, FolderT.Text.Length));
                        File.Copy(api, GeneratedFix + cApi.Remove(0, FolderT.Text.Length) + "steam_api_o.dll");
                        File.Copy(INILoc, GeneratedFix + cApi.Remove(0, FolderT.Text.Length) + "cream_api.ini", true);
                        File.Copy(OapiLoc, GeneratedFix + cApi.Remove(0, FolderT.Text.Length) + "steam_api.dll");

                    }

                    foreach (string api64 in steamapi64)
                    {
                        string cApi64 = api64.Substring(0, api64.Length - 15);

                        File.Move(api64, cApi64 + "steam_api64_o.dll");
                        File.Copy(cApi64 + "steam_api64_o.dll", SAfolder64, true);

                        File.Copy(Oapi64Loc, cApi64 + "steam_api64.dll");
                        File.Copy(Oapi64Loc, oSAfolder64, true);
                
                        File.Copy(INILoc, cApi64 + "cream_api.ini", true);

                        Directory.CreateDirectory(GeneratedFix + cApi64.Remove(0, FolderT.Text.Length));
                        File.Copy(api64, GeneratedFix + cApi64.Remove(0, FolderT.Text.Length) + "steam_api64_o.dll");
                        File.Copy(Oapi64Loc, GeneratedFix + cApi64.Remove(0, FolderT.Text.Length) + "steam_api64.dll");
                        File.Copy(INILoc, GeneratedFix + cApi64.Remove(0, FolderT.Text.Length) + "cream_api.ini", true);
                    }


                    string[] creamapi = Directory.GetFiles(FolderT.Text,
                    "cream_api.ini",
                    SearchOption.AllDirectories);

                    foreach (string cream in creamapi)
                    {
                        var MyIni = new IniFile(cream);

                        MyIni.Write("appid", new string(' ', 1) + AppID, "steam"); //AppID

                        MyIni.Write("newappid", new string(' ', 1) + FKAppIDText.Text, "steam_wrapper"); //FakeAppId

                        foreach (int DLC in ListDLC)
                        {

                            string dlcURL = "https://store.steampowered.com/api/appdetails/?appids=" + DLC;

                            HttpWebRequest getRequest2 = (HttpWebRequest)WebRequest.Create(dlcURL);
                            var getResponse2 = (HttpWebResponse)getRequest2.GetResponse();
                            Stream newStream2 = getResponse2.GetResponseStream();
                            StreamReader sr2 = new StreamReader(newStream2);
                            var result2 = sr2.ReadToEnd();

                            JObject JO2 = JsonConvert.DeserializeObject<JObject>(result2);
                            var List2 = JO2.Properties().ToList();
                            var item2 = List2[0];
                            item2.Replace(new JProperty("Root", item2.Value));
                            var rootObj2 = JsonConvert.DeserializeObject<SteamData.RootObject>(JO2.ToString());

                            string fileName = cream; //DLC Struct
                            bool aboveBelow = true;
                            string lineToSearch = "[dlc]";
                            string lineToAdd = DLC + " = " + rootObj2.Root.data.name;

                            var txtLines = File.ReadAllLines(fileName).ToList(); //Writing DLC
                            int index = aboveBelow ? txtLines.IndexOf(lineToSearch) + 1 : txtLines.IndexOf(lineToSearch);
                            if (index > 0)
                            {
                                txtLines.Insert(index, lineToAdd);
                                File.WriteAllLines(fileName, txtLines);
                            }
                        }

                        File.Copy(cream, SAfolderINI, true);  
                    }             

                    EventLog_Animation.ShowSync(Success_Log);
                    Success_Log.Visible = true;                    
                    btn_ApplyDone.Visible = true;

                }
            }

            else
            {
                EventLog_Animation.ShowSync(AlreadyApplied);
                AlreadyApplied.Visible = true;
                btn_ApplyDone.Visible = true;
            }

            

        }

        private void Btn_browseEdit_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Browser = new FolderBrowserDialog();
            if (Browser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                Edit1.Text = (Browser.SelectedPath);
        }



         private async void btn_Edit_Click(object sender, EventArgs e)
        {
            string[] creamapi = Directory.GetFiles(Edit1.Text,
                        "cream_api.ini",
                        SearchOption.AllDirectories);

            if (creamapi.Length == 0)
            {
                EventLog_Animation.ShowSync(Label2);
                Label2.Visible = true;
                await Task.Delay(1000);
                EventLog_Animation.ShowSync(Label2);
                Label2.Visible = false;
            }

            else
            {
                foreach (string cream in creamapi)
                {

                    string INILoc = @"AutoSteamFix\SteamFix\CreamApi\creamapi.ini";
                    var MyIni = new IniFile(cream);

                    MyIni.Write("appid", new string(' ', 1) + Edit2.Text, "steam");
                    MyIni.Write("newappid", new string(' ', 1) + Edit3.Text, "steam_wrapper");

                    string[] liness = File.ReadAllLines(INILoc);
                    StringBuilder newText = new StringBuilder();
                    

                    foreach (string line in liness)
                    {
                        newText.Append(line);
                        newText.Append(Environment.NewLine);


                        if (line.Contains("[dlc]"))
                            break;

                    }

                    File.WriteAllText(INILoc, newText.ToString());

                    string fileName = cream;

                    bool aboveBelow = true;
                    string lineToSearch = "[dlc]";
                    string lineToAdd = Edit4.Text;

                    var txtLines = File.ReadAllLines(fileName).ToList();
                    int index = aboveBelow ? txtLines.IndexOf(lineToSearch) + 1 : txtLines.IndexOf(lineToSearch);
                    if (index > 0)
                    {
                        txtLines.Insert(index, lineToAdd);
                        File.WriteAllLines(fileName, txtLines);
                    }
                }



                EventLog_Animation.ShowSync(Label1);
                Label1.Visible = true;
                await Task.Delay(1000);
                Label1.Visible = false;
            }
        }

        private void btn_ApplyDone_Click(object sender, EventArgs e)
        {
            Searching32_Log.Visible = false;
            Searching64_log.Visible = false;
            apiFound_log.Visible = false;
            apiNotFound_Log.Visible = false;
            api64Found_Log.Visible = false;
            api64NotFound_Log.Visible = false;
            Failed_Log.Visible = false;
            Success_Log.Visible = false;
            Replacing_Log.Visible = false;
            btn_ApplyDone.Visible = false;
            Event_Logger.Visible = false;
            AlreadyApplied.Visible = false;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            OpenFileDialog Browser = new OpenFileDialog
            {
                Title = "Select Game Executable",
                Filter = "Game Executable (*.exe) | *.exe",
                Multiselect = false
            };

            if (Browser.ShowDialog() == DialogResult.OK)
            {
                Misc_Browse.Text = Path.GetDirectoryName(Browser.FileName);
            }
           
        }

        private async void Btn_Mis1_Click(object sender, EventArgs e)
        {

            string txt32 = @"AutoSteamFix\SteamFix\CODEX\x32\dlllist.txt";
            string dll32 = @"AutoSteamFix\SteamFix\CODEX\x32\SteamOverlay32.dll";
            string winm32 = @"AutoSteamFix\SteamFix\CODEX\x32\winmm.dll";

            string txt64 = @"AutoSteamFix\SteamFix\CODEX\x64\dlllist.txt";
            string dll64 = @"AutoSteamFix\SteamFix\CODEX\x64\SteamOverlay64.dll";
            string winm64 = @"AutoSteamFix\SteamFix\CODEX\x64\winmm.dll";

            if (x32.Checked)
            {
                string[] DLL = Directory.GetFiles(Misc_Browse.Text, "dlllist.txt");

                if (DLL.Length != 0)
                {
                    foreach (string DLLOL in DLL)
                    {
                        File.AppendAllLines(DLLOL, new string[] { "\nSteamOverlay32.dll" });
                    }
                }

                else
                {
                    File.Copy(txt32, Misc_Browse.Text + @"\dlllist.txt");
                }

                File.Copy(dll32, Misc_Browse.Text + @"\SteamOverlay32.dll");
                File.Copy(winm32, Misc_Browse.Text + @"\winmm.dll", true);
            }

            if (x64.Checked)
            {
                string[] DLL = Directory.GetFiles(Misc_Browse.Text, "dlllist.txt");

                if (DLL.Length != 0)
                {
                    foreach (string DLLOL in DLL)
                    {
                        File.AppendAllLines(DLLOL, new string[] { "\nSteamOverlay64.dll" });
                    }
                }

                else
                {
                    File.Copy(txt64, Misc_Browse.Text + @"\dlllist.txt");
                }

                File.Copy(dll64, Misc_Browse.Text + @"\SteamOverlay64.dll");
                File.Copy(winm64, Misc_Browse.Text + @"\winmm.dll", true);
            }

            EventLog_Animation.ShowSync(Misc1Suc);
            Misc1Suc.Visible = true;
            await Task.Delay(1000);
            Overlay_Panel.Visible = false;
            Misc1Suc.Visible = false;
        }

        private void Btn_Misc1_Click(object sender, EventArgs e)
        {
            Overlay_Panel.Visible = true;
        }

        

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Overlay_Panel.Visible = false;
        }

        private async void Btn_ConfigDone_Click(object sender, EventArgs e)
        {
            string INILoc = Config_Text.Text + @"\AutoSteamFix\SteamFix\OriginalFiles\cream_api.ini";
            string OapiLoc = @"AutoSteamFix\SteamFix\CreamApi\steamapi.dll";
            string Oapi64Loc = @"AutoSteamFix\SteamFix\CreamApi\steamapi64.dll";
            string SAfolder = Config_Text.Text +  @"\AutoSteamFix\SteamFix\OriginalFiles\steam_api_o.dll";
            string oSAfolder = Config_Text.Text + @"\AutoSteamFix\SteamFix\OriginalFiles\steamapi.dll";
            string oSAfolder64 = Config_Text.Text + @"\AutoSteamFix\SteamFix\OriginalFiles\steamapi64.dll";
            string SAfolder64 = Config_Text.Text + @"\AutoSteamFix\SteamFix\OriginalFiles\steam_api64_o.dll";
            string SAfolderINI = Config_Text.Text + @"\AutoSteamFix\SteamFix\OriginalFiles\cream_api.ini";

            string[] GameExe = Directory.GetFiles(Config_Text.Text, "*.EXE",
                SearchOption.AllDirectories);

            foreach (string exe in GameExe)
            {
                string exeLoc = Path.GetDirectoryName(exe);

                File.Copy(INILoc, exeLoc + @"\cream_api.ini", true);

                if (File.Exists(SAfolder))
                {
                    File.Copy(SAfolder, exeLoc + @"\steam_api_o.dll", true);
                    File.Copy(OapiLoc, exeLoc + @"\steam_api.dll", true);
                }

                else if (File.Exists(SAfolder64))
                {
                    File.Copy(SAfolder64, exeLoc + @"\steam_api64_o.dll", true);
                    File.Copy(Oapi64Loc, exeLoc + @"\steam_api64.dll", true);
                }

                else if (!File.Exists(SAfolder))
                {
                    string[] x32 = Directory.GetFiles(Config_Text.Text, "steam_api_o.dll",
                         SearchOption.AllDirectories);

                    foreach (string xx32 in x32)
                    {
                        string Loc32 = Path.GetDirectoryName(xx32);

                        File.Copy(Loc32, exeLoc + "steam_api_o.dll", true);
                        File.Copy(OapiLoc, exeLoc + @"\steam_api.dll", true);
                    } 
                }

                else if (!File.Exists(SAfolder64))
                {

                    string[] x64 = Directory.GetFiles(Config_Text.Text, "steam_api64_o.dll",
                         SearchOption.AllDirectories);

                    foreach (string xx64 in x64)
                    {
                        string Loc64 = Path.GetDirectoryName(xx64);

                        File.Copy(Loc64, exeLoc + "steam_api64_o.dll", true);
                        File.Copy(Oapi64Loc, exeLoc + @"\steam_api64.dll", true);
                    }
                }
            }


            EventLog_Animation.ShowSync(ConfigSuccess);
            ConfigSuccess.Visible = true;
            await Task.Delay(1000);
            Overlay_Panel.Visible = false;
            panel1.Visible = false;
            ConfigSuccess.Visible = false;

        }

        private void btn_Misc2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btn_Misc3_Click(object sender, EventArgs e)
        {
            StubDRM_Panel.Visible = true;
        }

        private void ConfigBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Browser = new FolderBrowserDialog();
            if (Browser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                Config_Text.Text = (Browser.SelectedPath);
        }
                
        

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {           
            RevertP.Visible = true;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Browser = new FolderBrowserDialog();
            if (Browser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                RevertPath.Text = (Browser.SelectedPath);
        }

        private void RevertButton_Click(object sender, EventArgs e)
        {
            string ogFolder = RevertPath.Text + @"\AutoSteamFix\SteamFix\OriginalFiles";
            int FilesNotDetected = 0;

            string[] apiFind = Directory.GetFiles(RevertPath.Text,
            "steam_api.dll",
            SearchOption.AllDirectories);

            string[] api64Find = Directory.GetFiles(RevertPath.Text,
           "steam_api64.dll",
           SearchOption.AllDirectories);

            string[] cream = Directory.GetFiles(RevertPath.Text,
            "cream_api.ini",
            SearchOption.AllDirectories);

            string[] apio = Directory.GetFiles(RevertPath.Text,
           "steam_api_o.dll",
           SearchOption.AllDirectories);

            string[] api64o = Directory.GetFiles(RevertPath.Text,
           "steam_api64_o.dll",
           SearchOption.AllDirectories);




            if (apio.Length != 0 && apiFind.Length != 0  )
            {
                foreach (string apiF in apiFind)
                {
                    string cApi = apiF.Substring(0, apiF.Length - 13);            

                    foreach (string apioF in apio)
                    {
                        File.Delete(apiF);
                        File.Move(apioF, cApi + "steam_api.dll");
                    }
                }
            }

            else
            {
                FilesNotDetected = +1; //1
            }
            

            if (api64o.Length != 0 && api64Find.Length != 0) 
            {
                foreach (string api64F in api64Find)
                {
                    
                    string cApi64 = api64F.Substring(0, api64F.Length - 15);
                    
                    foreach (string api64oF in api64o)
                    {
                        File.Delete(api64F);
                        File.Move(api64oF, cApi64 + "steam_api64.dll");
                    }
                }                
            }

            else
            {
                FilesNotDetected = +1; //2
            }
            

            if (cream != null || cream.Length != 0)
            {
                foreach (string creamF in cream)
                {
                    File.Delete(creamF);
                }
            }

            else
            {
                FilesNotDetected = +1; //3
            }

            Directory.Delete(ogFolder, true);

            if (FilesNotDetected == 0)
            {
                EventLog_Animation.ShowSync(Revert_Success);
                Revert_Success.Visible = true;
            }

            else if (FilesNotDetected == 1)
            {
                EventLog_Animation.ShowSync(Revert_Success);
                Revert_Success.Visible = true;
            }

            else if (FilesNotDetected == 2)
            {
                EventLog_Animation.ShowSync(NoneFound);
                NoneFound.Visible = true;
            }

            else if (FilesNotDetected == 3)
            {
                EventLog_Animation.ShowSync(NoFilePresent);
                NoFilePresent.Visible = true;
            }
         
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            
            RevertP.Visible = false;
            NoFilePresent.Visible = false;
            NoneFound.Visible = false;
            Revert_Success.Visible = false;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            OpenFileDialog Browser = new OpenFileDialog
            {
                Title = "Select Game Executable",
                Filter = "Game Executable (*.exe) | *.exe",
                Multiselect = false
            };

            if (Browser.ShowDialog() == DialogResult.OK)
            {
                StubTXT.Text = Path.GetDirectoryName(Browser.FileName);
            }
        }

        private void StubDone_Click(object sender, EventArgs e)
        {
            string x64 = @"AutoSteamFix\SteamFix\CoopLand\StubDRM\x64\";
            string x32 = @"AutoSteamFix\SteamFix\CoopLand\StubDRM\x32\";

            if (Stub32.Checked)
            {
                string[] DLL = Directory.GetFiles(StubTXT.Text, "dlllist.txt");

                if (DLL.Length != 0)
                {
                    foreach (string DLLOL in DLL)
                    {
                        File.AppendAllLines(DLLOL, new string[] { "\nStubDRM32.dll" });
                    }
                }

                else
                {
                    File.Copy(x32 + "dlllist.txt", StubTXT.Text + @"\dlllist.txt");
                }

                File.Copy(x32 + "StubDRM32.dll", StubTXT.Text + @"\StubDRM32.dll");
                File.Copy(x32 + "winmm.dll", StubTXT.Text + @"\winmm.dll", true);

            }

            if (Stub64.Checked)
            {
                string[] DLL = Directory.GetFiles(StubTXT.Text,
           "dlllist.txt");

                if (DLL.Length != 0)
                {
                    foreach (string DLLOL in DLL)
                    {
                        File.AppendAllLines(DLLOL, new string[] { "\nStubDRM64.dll" });
                    }
                }

                else
                {
                    File.Copy(x64 + "dlllist.txt", StubTXT.Text + @"\dlllist.txt");
                }                   
              
                File.Copy(x64 + "StubDRM64.dll", StubTXT.Text + @"\StubDRM64.dll");
                File.Copy(x64 + "winmm.dll", StubTXT.Text + @"\winmm.dll", true);
            }

            EventLog_Animation.ShowSync(Stub_Suc);
            Stub_Suc.Visible = true;
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {           
            StubDRM_Panel.Visible = false;
            Stub_Suc.Visible = false;
        }
    }
}
