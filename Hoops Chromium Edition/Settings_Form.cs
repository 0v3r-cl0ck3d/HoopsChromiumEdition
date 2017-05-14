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

namespace Hoops_Chromium_Edition
{
    public partial class Settings_Form : Form
    {
        public Settings_Form()
        {
            InitializeComponent();
        }

        private void Settings_Form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //sets up dir string
        string hoops_settings_dir = "C:\\";

        public void Settings_Form_Load(object sender, EventArgs e)
        {
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            String HoopsSettingsDir = userProfile.ToString() + "\\cl0ck\\hoops\\";
            hoops_settings_dir = HoopsSettingsDir;
        }

        


        //Set search to google button
        private void SetSearchtoGoogleButton_Click(object sender, EventArgs e)
        {
            Hoops_Chromium_Edition.Properties.Settings.Default.SearchItUrlString = "https://www.google.co.uk/search?q=";
            Hoops_Chromium_Edition.Properties.Settings.Default.SearchItButtonText = "Google it";

            // Writes settings to file
            using (StreamWriter sw = File.CreateText(hoops_settings_dir + "\\search_box_strings.cfg"))
            {
                sw.WriteLine(Hoops_Chromium_Edition.Properties.Settings.Default.SearchItUrlString.ToString());
            }
            using (StreamWriter sw = File.CreateText(hoops_settings_dir + "\\search_button_strings.cfg"))
            {
                sw.WriteLine(Hoops_Chromium_Edition.Properties.Settings.Default.SearchItButtonText.ToString());
            }
        }

        //Sets search button to Duck Duck go
        private void SetSearchToDuckDuckGoButton_Click(object sender, EventArgs e)
        {
            Hoops_Chromium_Edition.Properties.Settings.Default.SearchItUrlString = "https://www.duckduckgo.com/search?q=";
            Hoops_Chromium_Edition.Properties.Settings.Default.SearchItButtonText = "Duck it!";

            // Writes settings to file
            using (StreamWriter sw = File.CreateText(hoops_settings_dir + "\\search_box_strings.cfg"))
            {
                sw.WriteLine(Hoops_Chromium_Edition.Properties.Settings.Default.SearchItUrlString.ToString());
            }
            using (StreamWriter sw = File.CreateText(hoops_settings_dir + "\\search_button_strings.cfg"))
            {
                sw.WriteLine(Hoops_Chromium_Edition.Properties.Settings.Default.SearchItButtonText.ToString());
            }
        }

        //Sets Search to Bing
        private void SetSearchToBingButton_Click(object sender, EventArgs e)
        {
            Hoops_Chromium_Edition.Properties.Settings.Default.SearchItUrlString = "https://www.bing.com/search?q=";
            Hoops_Chromium_Edition.Properties.Settings.Default.SearchItButtonText = "Bing it";

            // Writes settings to file
            using (StreamWriter sw = File.CreateText(hoops_settings_dir + "\\search_box_strings.cfg"))
            {
                sw.WriteLine(Hoops_Chromium_Edition.Properties.Settings.Default.SearchItUrlString.ToString());
            }
            using (StreamWriter sw = File.CreateText(hoops_settings_dir + "\\search_button_strings.cfg"))
            {
                sw.WriteLine(Hoops_Chromium_Edition.Properties.Settings.Default.SearchItButtonText.ToString());
            }
        }

        //Sets Media Search to YouTube
        private void SetMediaSearchToYoutube_Click(object sender, EventArgs e)
        {
            Hoops_Chromium_Edition.Properties.Settings.Default.MediaItUrlString = "https://www.youtube.com/search?q=";
            Hoops_Chromium_Edition.Properties.Settings.Default.MediaItButtonText = "YouTube it";

            // Writes settings to file
            using (StreamWriter sw = File.CreateText(hoops_settings_dir + "\\media_search_box_strings.cfg"))
            {
                sw.WriteLine(Hoops_Chromium_Edition.Properties.Settings.Default.MediaItUrlString.ToString());
            }
            using (StreamWriter sw = File.CreateText(hoops_settings_dir + "\\media_search_button_strings.cfg"))
            {
                sw.WriteLine(Hoops_Chromium_Edition.Properties.Settings.Default.MediaItButtonText.ToString());
            }
        }

        //Sets Media Search to Imgur
            private void SetMediaSearchToImgur_Click(object sender, EventArgs e)
        {
            Hoops_Chromium_Edition.Properties.Settings.Default.MediaItUrlString = "https://www.imgur.com/search?q=";
            Hoops_Chromium_Edition.Properties.Settings.Default.MediaItButtonText = "Imgur it";

            // Writes settings to file
            using (StreamWriter sw = File.CreateText(hoops_settings_dir + "\\media_search_box_strings.cfg"))
            {
                sw.WriteLine(Hoops_Chromium_Edition.Properties.Settings.Default.MediaItUrlString.ToString());
            }
            using (StreamWriter sw = File.CreateText(hoops_settings_dir + "\\media_search_button_strings.cfg"))
            {
                sw.WriteLine(Hoops_Chromium_Edition.Properties.Settings.Default.MediaItButtonText.ToString());
            }
        }

        //Sets Media Search Button to Reddit
        private void SetMediaSearchToReddit_Click(object sender, EventArgs e)
        {
            Hoops_Chromium_Edition.Properties.Settings.Default.MediaItUrlString = "https://www.reddit.com/search?q=";
            Hoops_Chromium_Edition.Properties.Settings.Default.MediaItButtonText = "Read it";

            // Writes settings to file
            using (StreamWriter sw = File.CreateText(hoops_settings_dir + "\\media_search_box_strings.cfg"))
            {
                sw.WriteLine(Hoops_Chromium_Edition.Properties.Settings.Default.MediaItUrlString.ToString());
            }
            using (StreamWriter sw = File.CreateText(hoops_settings_dir + "\\media_search_button_strings.cfg"))
            {
                sw.WriteLine(Hoops_Chromium_Edition.Properties.Settings.Default.MediaItButtonText.ToString());
            }
        }

        //Sets Custom Title Text String
        private void SetCustomTitleTextStringButton_Click(object sender, EventArgs e)
        {
            Hoops_Chromium_Edition.Properties.Settings.Default.CustomTitleText = SetCustomTitleTextBox.Text.ToString();
            // Writes settings to file
            using (StreamWriter sw = File.CreateText(hoops_settings_dir + "\\CustomTitleText.txt"))
            {
                sw.WriteLine(Hoops_Chromium_Edition.Properties.Settings.Default.CustomTitleText.ToString());
            }
            
        }

        //Saves custom pannels colours
        private void SavePanelColoursButton_Click(object sender, EventArgs e)
        {
            Hoops_Chromium_Edition.Properties.Settings.Default.MainPanelColour_R = Convert.ToInt32(CustomPanelsColourRGB_R.Value);
            Hoops_Chromium_Edition.Properties.Settings.Default.MainPanelColour_G = Convert.ToInt32(CustomPanelsColourRGB_G.Value);
            Hoops_Chromium_Edition.Properties.Settings.Default.MainPanelColour_B = Convert.ToInt32(CustomPanelsColourRGB_B.Value);

            try
            {
                System.IO.File.Create(hoops_settings_dir + "CustomPanelColours.bin");
                //loads bytes into FileBytes Array
                byte[] FileBytes = System.IO.File.ReadAllBytes(hoops_settings_dir + "CustomPanelColours.bin");
                using (var fs = new FileStream("CustomPanelColours.bin",
                                  FileMode.Open,
                                  FileAccess.Write))
                {
                    MessageBox.Show("working");
                    fs.Position = 0x00000;
                    fs.WriteByte(Convert.ToByte(Convert.ToByte(CustomPanelsColourRGB_R.Value)));
                    fs.Position = 0x00001;
                    fs.WriteByte(Convert.ToByte(Convert.ToByte(CustomPanelsColourRGB_G.Value)));
                    fs.Position = 0x00002;
                    fs.WriteByte(Convert.ToByte(Convert.ToByte(CustomPanelsColourRGB_B.Value)));
                }
            }
            catch (Exception)
            {
                //Do Nothing
            }


        }
    }
    }
