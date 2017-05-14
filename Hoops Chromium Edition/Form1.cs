using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using Microsoft.Win32;
using System.IO;

namespace Hoops_Chromium_Edition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //InitBrowser();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Sets Main Window Text
            this.Text = "Hoops Chromium Edition | " + ProductVersion.ToString() + " Alpha";
            //Init load settings
            InitLoadSettings();
            //Create first tab
            InitNewTab();
        }



        public void InitLoadSettings()
        {
            //gets path of user profile
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            //Check if hoops dir exists
            if (!Directory.Exists(userProfile.ToString() + "/cl0ck/hoops/"))
            {
                System.IO.Directory.CreateDirectory(userProfile.ToString() + "/cl0ck/hoops/");
                String HoopsSettingsDir = userProfile.ToString() + "/cl0ck/hoops/";
            }
            else
            {
                String HoopsSettingsDir = userProfile.ToString() + "/cl0ck/hoops/";
            }

            //Check if file exists for custom text



            string CustomTitleTextPath = userProfile.ToString() + "/cl0ck/hoops/CustomTitleText.txt";

            string CustomTitleString = null;

            if (!File.Exists(CustomTitleTextPath))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(CustomTitleTextPath))
                {
                    sw.WriteLine("Custom Title String!");
                    CustomTitleString = "Custom Title!";
                }
            }
            else
            {
                using (StreamReader sw = File.OpenText(CustomTitleTextPath))
                {
                    CustomTitleString = sw.ReadToEnd();
                }
            }

            //sets custom title text
            Hoops_Chromium_Edition.Properties.Settings.Default.CustomTitleText = CustomTitleString.ToString();
            this.Text = "Hoops Chromium Edition | " + ProductVersion.ToString() + " Alpha | " + CustomTitleString.ToString();



            //sets custom panel colours
            try
            {
                //Loads CustomPanelColours.bin into PanelByte Array
                byte[] PanelByte = System.IO.File.ReadAllBytes(userProfile.ToString() + "\\cl0ck\\hoops\\CustomPanelColours.bin");
                using (var fs = new FileStream("test.txt",
                              FileMode.Open,
                              FileAccess.Read))
                {
                    fs.Position = 0x00000;
                    Hoops_Chromium_Edition.Properties.Settings.Default.MainPanelColour_R = Convert.ToInt32(fs.ReadByte());
                    fs.Position = 0x00001;
                    Hoops_Chromium_Edition.Properties.Settings.Default.MainPanelColour_G = Convert.ToInt32(fs.ReadByte());
                    fs.Position = 0x00002;
                    Hoops_Chromium_Edition.Properties.Settings.Default.MainPanelColour_B = Convert.ToInt32(fs.ReadByte());
                }







            }
            catch (Exception)
            {

                //do nothing
            }
            




            //sets custom search string
            string search_button_strings_file_path = userProfile.ToString() + "/cl0ck/hoops/search_box_strings.cfg";

            if (!File.Exists(search_button_strings_file_path))
            {
                //does nothing
            }
            else
            {
                using (StreamReader sw = File.OpenText(search_button_strings_file_path.ToString()))
                {
                    string CustomSearchString = null;
                    CustomSearchString = sw.ReadToEnd();
                    Hoops_Chromium_Edition.Properties.Settings.Default.SearchItUrlString = CustomSearchString;
                }
            }

            //Sets media search string
            string media_search_box_strings_file_path = userProfile.ToString() + "/cl0ck/hoops/media_search_box_strings.cfg";

            if (!File.Exists(media_search_box_strings_file_path))
            {
                //does nothing
            }
            else
            {
                using (StreamReader sw = File.OpenText(media_search_box_strings_file_path.ToString()))
                {
                    string CustomMediaSearchString = null;
                    CustomMediaSearchString = sw.ReadToEnd();
                    Hoops_Chromium_Edition.Properties.Settings.Default.MediaItUrlString = CustomMediaSearchString;
                }
            }



            //Sets Search Buttons

            //Sets media search button string
            string media_search_button_strings_file_path = userProfile.ToString() + "/cl0ck/hoops/media_search_button_strings.cfg";

            if (!File.Exists(media_search_button_strings_file_path))
            {
                //does nothing
            }
            else
            {
                using (StreamReader sw = File.OpenText(media_search_button_strings_file_path.ToString()))
                {
                    string CustomMediaButtonString = null;
                    CustomMediaButtonString = sw.ReadToEnd();
                    Hoops_Chromium_Edition.Properties.Settings.Default.MediaItButtonText = CustomMediaButtonString;
                }
            }




            SearchItButton.Text = Hoops_Chromium_Edition.Properties.Settings.Default.SearchItButtonText;
            MediaSearchItButton.Text = Hoops_Chromium_Edition.Properties.Settings.Default.MediaItButtonText;
        }


        /*

        //Create new tab init
        public void InitNewTab()
        {
            //Creates new tab
            BrowserTabControl.TabPages.Add("New Tab");
            //Creates panel to embed browser
            Panel EmbedPanel = new Panel();
            BrowserTabControl.SelectedTab.Controls.Add(EmbedPanel);
            EmbedPanel.Dock = DockStyle.Fill;
            //Adds Browser controll to new tab
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("www.google.com");
            EmbedPanel.Controls.Add(browser);
            //BrowserTabControl.SelectedTab.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }

    */


        public void InitNewTab()
        {
            //Creates new tab
            BrowserTabControl.TabPages.Add("New Tab");
            //Creates panel to embed browser
            Panel EmbedPanel = new Panel();
            BrowserTabControl.SelectTab(BrowserTabControl.TabCount - 1);
            BrowserTabControl.SelectedTab.Controls.Add(EmbedPanel);
            //Gets embed panel after switch
            Panel EmbedPanelInteract = BrowserTabControl.SelectedTab.Controls.OfType<Panel>().First();
            EmbedPanel.Dock = DockStyle.Fill;
            //MessageBox.Show(BrowserTabControl.SelectedTab.Controls.Count.ToString());
            //Adds Browser controll to new tab
            //Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("www.google.com");
            EmbedPanel.Controls.Add(browser);
            //BrowserTabControl.SelectedTab.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
            //gets Browser Interact before invokes
            ChromiumWebBrowser BrowserInteract = EmbedPanelInteract.Controls.OfType<ChromiumWebBrowser>().First();



            //Sets some misc vars
            Label DevIsOpen = new Label();
            EmbedPanelInteract.Controls.Add(DevIsOpen);
            TextBox BrowserSiteTitleBox = new TextBox();
            browser.Controls.Add(BrowserSiteTitleBox);
            BrowserSiteTitleBox.Hide();
            NumericUpDown BrowserIndexId = new NumericUpDown();
            browser.Controls.Add(BrowserIndexId);
            BrowserIndexId.Value = Convert.ToInt32(BrowserTabControl.SelectedIndex);
            BrowserIndexId.Hide();

            //Invoker hooks


            browser.AddressChanged += UrlBoxUpdater;
            browser.TitleChanged += OnBrowserTitleChanged;

        }

        //Update url box when url changes
        public void UrlBoxUpdater(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                browser.Text = e.Address;
                IsNewlyUpdated = true;

            }
            ));
        }

        //Update site title when site title changes
        public void OnBrowserTitleChanged(object sender, TitleChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                TextBox BrowserSiteTitleBox = browser.Controls.OfType<TextBox>().First();
                NumericUpDown BrowserIndexId = browser.Controls.OfType<NumericUpDown>().First();
                BrowserSiteTitleBox.Text = e.Title.ToString();
                //BrowserIndexId.Value = Convert.ToInt32(BrowserTabControl.SelectedIndex);
                NewSiteTitle = true;
            }
            ));
        }




        //Send user to home page
        public void HomeButton_Click(object sender, EventArgs e)
        {
            Panel EmbedPanelInteract = BrowserTabControl.SelectedTab.Controls.OfType<Panel>().First();
            ChromiumWebBrowser BrowserInteract = EmbedPanelInteract.Controls.OfType<ChromiumWebBrowser>().First();
            BrowserInteract.Load("www.google.com");
        }

        //Refresh
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Panel EmbedPanelInteract = BrowserTabControl.SelectedTab.Controls.OfType<Panel>().First();
            ChromiumWebBrowser BrowserInteract = EmbedPanelInteract.Controls.OfType<ChromiumWebBrowser>().First();
            BrowserInteract.Reload();
        }

        //go to url box
        private void UrlGoButton_Click(object sender, EventArgs e)
        {
            Panel EmbedPanelInteract = BrowserTabControl.SelectedTab.Controls.OfType<Panel>().First();
            ChromiumWebBrowser BrowserInteract = EmbedPanelInteract.Controls.OfType<ChromiumWebBrowser>().First();
            //go to url
            try
            {
                BrowserInteract.Load(UrlBox.Text.ToString());
            }
            catch (Exception)
            {
                BrowserInteract.Load("<HTML><P>Error</P></HTML>");
            }
        }

        //New tab button 
        private void NewTabButton_Click(object sender, EventArgs e)
        {
            InitNewTab();
        }

        //Remove tab button
        private void RemoveTabButton_Click(object sender, EventArgs e)
        {
            try
            {
                Panel EmbedPanelInteract = BrowserTabControl.SelectedTab.Controls.OfType<Panel>().First();
                ChromiumWebBrowser BrowserInteract = EmbedPanelInteract.Controls.OfType<ChromiumWebBrowser>().First();
                BrowserInteract.Stop();
                EmbedPanelInteract.Dispose();
                BrowserTabControl.SelectedTab.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Can't remove one tab. Please create a new tab then remove.");
            }

        }

        //Forward Button
        private void ForwardButton_Click(object sender, EventArgs e)
        {
            Panel EmbedPanelInteract = BrowserTabControl.SelectedTab.Controls.OfType<Panel>().First();
            ChromiumWebBrowser BrowserInteract = EmbedPanelInteract.Controls.OfType<ChromiumWebBrowser>().First();
            BrowserInteract.Forward();
        }

        //Back Button
        private void BackButton_Click(object sender, EventArgs e)
        {
            Panel EmbedPanelInteract = BrowserTabControl.SelectedTab.Controls.OfType<Panel>().First();
            ChromiumWebBrowser BrowserInteract = EmbedPanelInteract.Controls.OfType<ChromiumWebBrowser>().First();
            BrowserInteract.Back();
        }



        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Settings_Form SettingsForm = new Settings_Form();
            SettingsForm.Show();
        }

        //var for url updater timer
        int TabIdNum = 0;
        bool IsNewlyUpdated = false;
        //url updater timer
        private void UpdateUrlBoxOnTabChange_Tick(object sender, EventArgs e)
        {
            Panel EmbedPanelInteract = BrowserTabControl.SelectedTab.Controls.OfType<Panel>().First();
            ChromiumWebBrowser BrowserInteract = EmbedPanelInteract.Controls.OfType<ChromiumWebBrowser>().First();

            try
            {
                if (TabIdNum.ToString() != BrowserTabControl.SelectedIndex.ToString())
                {
                    UrlBox.Text = BrowserInteract.Text.ToString();
                }
                TabIdNum = BrowserTabControl.SelectedIndex;
                if (IsNewlyUpdated == true)
                {
                    UrlBox.Text = BrowserInteract.Text.ToString();
                    IsNewlyUpdated = false;
                }
            }
            catch (Exception)
            {
                //do nothing
            }
        }


        bool NewSiteTitle = new bool();
        //Update site title
        private void UpdateSiteTitleTimer_Tick(object sender, EventArgs e)
        {
            if (NewSiteTitle == true)
            {
                try
                {


                    Panel EmbedPanelInteract = BrowserTabControl.SelectedTab.Controls.OfType<Panel>().First();
                    ChromiumWebBrowser BrowserInteract = EmbedPanelInteract.Controls.OfType<ChromiumWebBrowser>().First();
                    NumericUpDown BrowserIndexId = browser.Controls.OfType<NumericUpDown>().First();
                    TextBox BrowserSiteTitleBox = BrowserInteract.Controls.OfType<TextBox>().First();
                    try
                    {
                        TabIdNum = BrowserTabControl.SelectedIndex;
                        if (BrowserTabControl.TabPages[Convert.ToInt32(BrowserIndexId.Value)].Text != BrowserSiteTitleBox.Text.ToString())
                        {
                            BrowserTabControl.TabPages[Convert.ToInt32(BrowserIndexId.Value)].Text = BrowserSiteTitleBox.Text.ToString();
                        }
                    }
                    catch (Exception)
                    {
                        //do nothing
                    }



                    NewSiteTitle = false;
                }
                catch (Exception)
                {

                    //do nothing
                }
            }



            
        }



        //Goes to URL when enter it pressed
        private void UrlBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Panel EmbedPanelInteract = BrowserTabControl.SelectedTab.Controls.OfType<Panel>().First();
                ChromiumWebBrowser BrowserInteract = EmbedPanelInteract.Controls.OfType<ChromiumWebBrowser>().First();
                //go to url
                try
                {
                    BrowserInteract.Load(UrlBox.Text.ToString());
                }
                catch (Exception)
                {
                    BrowserInteract.Load("<HTML><P>Error</P></HTML>");
                }
            }
        }

        //Goes to media when enter is pressed
        private void MediaSearchItBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Panel EmbedPanelInteract = BrowserTabControl.SelectedTab.Controls.OfType<Panel>().First();
                ChromiumWebBrowser BrowserInteract = EmbedPanelInteract.Controls.OfType<ChromiumWebBrowser>().First();
                //go to url
                try
                {
                    BrowserInteract.Load(Hoops_Chromium_Edition.Properties.Settings.Default.MediaItUrlString + MediaSearchItBox.Text.ToString());
                }
                catch (Exception)
                {
                    BrowserInteract.Load("<HTML><P>Error</P></HTML>");
                }
            }
        }

        //Goes to search it when enter is pressed
        private void SearchItBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Panel EmbedPanelInteract = BrowserTabControl.SelectedTab.Controls.OfType<Panel>().First();
                ChromiumWebBrowser BrowserInteract = EmbedPanelInteract.Controls.OfType<ChromiumWebBrowser>().First();
                //go to url
                try
                {
                    BrowserInteract.Load(Hoops_Chromium_Edition.Properties.Settings.Default.MediaItUrlString + SearchItBox.Text.ToString());
                }
                catch (Exception)
                {
                    BrowserInteract.Load("<HTML><P>Error</P></HTML>");
                }
            }
        }


        //Loads Browser Init
        public ChromiumWebBrowser browser;
        public void InitBrowser()
        {
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("www.google.com");
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }

        //Search it button
        private void SearchItButton_Click(object sender, EventArgs e)
        {
            Panel EmbedPanelInteract = BrowserTabControl.SelectedTab.Controls.OfType<Panel>().First();
            ChromiumWebBrowser BrowserInteract = EmbedPanelInteract.Controls.OfType<ChromiumWebBrowser>().First();
            BrowserInteract.Load(Hoops_Chromium_Edition.Properties.Settings.Default.SearchItUrlString + SearchItBox.Text.ToString());
        }

        ////Media search it button
        private void MediaSearchItButton_Click(object sender, EventArgs e)
        {
            Panel EmbedPanelInteract = BrowserTabControl.SelectedTab.Controls.OfType<Panel>().First();
            ChromiumWebBrowser BrowserInteract = EmbedPanelInteract.Controls.OfType<ChromiumWebBrowser>().First();
            BrowserInteract.Load(Hoops_Chromium_Edition.Properties.Settings.Default.MediaItUrlString + MediaSearchItBox.Text.ToString());
        }


        //Enables or disables dev tools
        private void PageSourceEditorButton_Click(object sender, EventArgs e)
        {
            Panel EmbedPanelInteract = BrowserTabControl.SelectedTab.Controls.OfType<Panel>().First();
            ChromiumWebBrowser BrowserInteract = EmbedPanelInteract.Controls.OfType<ChromiumWebBrowser>().First();
            Label DevIsOpen = EmbedPanelInteract.Controls.OfType<Label>().First();

            if (DevIsOpen.Text.ToString() == "yes")
            {
                BrowserInteract.CloseDevTools();
                DevIsOpen.Text = "no";
            }
            else
            {
                BrowserInteract.ShowDevTools();
                DevIsOpen.Text = "yes";
            }
        }


        //Updates Misc Settings
        private void UpdateMiscSettingsTimer_Tick(object sender, EventArgs e)
        {
            //Sets cutom title text
            this.Text = "Hoops Chromium Edition | " + ProductVersion.ToString() + " Alpha | " + Hoops_Chromium_Edition.Properties.Settings.Default.CustomTitleText.ToString();
            //Sets Custom Panels Colours
            ButtonHostPannel.BackColor = Color.FromArgb(Hoops_Chromium_Edition.Properties.Settings.Default.MainPanelColour_R, Hoops_Chromium_Edition.Properties.Settings.Default.MainPanelColour_G, Hoops_Chromium_Edition.Properties.Settings.Default.MainPanelColour_B);
            URLHostPanel.BackColor = Color.FromArgb(Hoops_Chromium_Edition.Properties.Settings.Default.MainPanelColour_R, Hoops_Chromium_Edition.Properties.Settings.Default.MainPanelColour_G, Hoops_Chromium_Edition.Properties.Settings.Default.MainPanelColour_B);
        }

        private void UpdateSearchButtonText_Tick(object sender, EventArgs e)
        {

        }
    }
}
