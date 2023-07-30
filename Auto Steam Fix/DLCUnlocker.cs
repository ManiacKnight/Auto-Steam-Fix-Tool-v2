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
    public partial class DLCUnlocker : UserControl
    {
        public DLCUnlocker()
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

        private void SteamFixTab_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void ConfigSuccess_Click(object sender, EventArgs e)
        {

        }

        private void ConfigBrowse_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_ConfigDone_Click(object sender, EventArgs e)
        {

        }

        private void Config_Text_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void NoFilePresent_Click(object sender, EventArgs e)
        {

        }

        private void NoneFound_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void Revert_Success_Click(object sender, EventArgs e)
        {

        }

        private void RevertButton_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void RevertPath_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void GameFolderR_Label_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

        }

        private void RevertP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Stub32_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void Misc1Suc_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Mis1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Slct_Click(object sender, EventArgs e)
        {

        }

        private void x64_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void x32_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Misc3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Misc2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Misc1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void Misc_Browse_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Stub64_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Overlay_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Stub_Suc_Click(object sender, EventArgs e)
        {

        }

        private void StubDRM_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StubDone_Click(object sender, EventArgs e)
        {

        }

        private void BrowseStub_Btn_Click(object sender, EventArgs e)
        {

        }

        private void StubTXT_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel10_Click(object sender, EventArgs e)
        {

        }

        private void FolderT_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void FolderL_Click(object sender, EventArgs e)
        {

        }

        private void AlreadyApplied_Click(object sender, EventArgs e)
        {

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

        private void Success_Log_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void api64NotFound_Log_Click(object sender, EventArgs e)
        {

        }

        private void apiNotFound_Log_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Apply_Click(object sender, EventArgs e)
        {
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

            string INILoc = @"AutoSteamFix\DLCUnlocker\CreamApi\creamapi.ini";
            string OapiLoc = @"AutoSteamFix\DLCUnlocker\CreamApi\steamapi.dll";
            string Oapi64Loc = @"AutoSteamFix\DLCUnlocker\CreamApi\steamapi64.dll";


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

                    Directory.CreateDirectory(FolderT.Text + @"\AutoSteamFix\DLCUnlocker\OriginalFiles");
                    string SAfolder = FolderT.Text + @"\AutoSteamFix\DLCUnlocker\OriginalFiles\steam_api_o.dll";
                    string oSAfolder = FolderT.Text + @"\AutoSteamFix\DLCUnlocker\OriginalFiles\steamapi.dll";
                    string oSAfolder64 = FolderT.Text + @"\AutoSteamFix\DLCUnlocker\OriginalFiles\steamapi64.dll";
                    string SAfolder64 = FolderT.Text + @"\AutoSteamFix\DLCUnlocker\OriginalFiles\steam_api64_o.dll";
                    string SAfolderINI = FolderT.Text + @"\AutoSteamFix\DLCUnlocker\OriginalFiles\cream_api.ini";
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

        private void Searching64_log_Click(object sender, EventArgs e)
        {

        }

        private void apiFound_log_Click(object sender, EventArgs e)
        {

        }

        private void api64Found_Log_Click(object sender, EventArgs e)
        {

        }

        private void Failed_Log_Click(object sender, EventArgs e)
        {

        }

        private void Replacing_Log_Click(object sender, EventArgs e)
        {

        }

        private void Event_Logger_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Searching32_Log_Click(object sender, EventArgs e)
        {

        }

        private void FKAppIDText_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void SteamFixTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FakeAppIDL_Click(object sender, EventArgs e)
        {

        }

        private void BrowseB_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Browser = new FolderBrowserDialog();
            if (Browser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                FolderT.Text = (Browser.SelectedPath);
        }

        private void TestBox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void ReEdit_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {

        }

        private void Btn_browseEdit_Click(object sender, EventArgs e)
        {

        }

        private void Edit1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel12_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel13_Click(object sender, EventArgs e)
        {

        }

        private void Edit4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Edit3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel14_Click(object sender, EventArgs e)
        {

        }

        private void Edit2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel15_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void MiscOpt_Click(object sender, EventArgs e)
        {

        }

        private void FolderT_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void StubDone_Click_1(object sender, EventArgs e)
        {

        }

        private void BrowseStub_Btn_Click_1(object sender, EventArgs e)
        {

        }

        private void StubTXT_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel9_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel10_Click_1(object sender, EventArgs e)
        {

        }

        private void FolderT_OnValueChanged_2(object sender, EventArgs e)
        {

        }

        private void FolderL_Click_1(object sender, EventArgs e)
        {

        }
    }
}
