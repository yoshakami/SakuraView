﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Webp;  // Webp.cs

/* vanilla usings:
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using Webp;  // Webp.cs
using System.Threading.Tasks;
using System.Globalization;
using System.Linq; */

namespace SakuraView
{
    public partial class SakuraView : Form
    {
        static readonly string execPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\", "/");
        static string upscaleMode = "fit";
        static string windowPosition = "normal";
        static int width;
        static int height;
        static string upscaleAlgorithm = "high";
        static decimal widthRatio;
        static decimal heightRatio;
        static int widthSpan;
        static int heightSpan;
        static int bottomSpace = 0;
        static int rightSpace = 0;
        static int screenWidth;
        static int screenHeight;
        static int currentImage;
        static int mouse_x;
        static int mouse_y;
        static byte layout = 1;  // 0 = Project Miku,  1 = SakuraView
        static byte i;
        static byte j;
        static int x;
        static int y;
        static int z;
        static long fileSize;
        static ushort metadataLength = 200;
        static bool windowFound;
        static bool help = true;
        static bool info = true;
        static bool banner = true;
        static bool loadImage;
        static bool prevent_execution;
        static bool duplicate = false;
        static bool loadSubFolders = true;
        static bool counter = true;
        static bool loop = true;
        static bool console = false;
        static bool metadata = false;
        static byte fixed_padding = 0;
        static byte mode = 0; // 0 = ImageViewer; 1 = ImageExplorer; 2 = TextViewer; 3 = TextExplorer; 4 = TextEditor; 5 = Settings; 6 = SongExplorer
        static byte currentScreen = 0;
        static byte padding = 30;
        static string currentInfo;
        static string text;
        static Color color;
        static string specifier = "F";
        static string[] pngMetadata = { "Prompt: ", "Negative Prompt: ", "Steps: ", "Sampler: ", "CFG Scale: ", "Seed: ", "Width: ", "Height: ", "Subseed: ", "Subseed Strength: ", "Model: ", "Lora: " };
        static CultureInfo culture = CultureInfo.CreateSpecificCulture("en-CA");
        static List<Image> images = new List<Image>();
        static List<string> imagesPath = new List<string>();
        static List<string[]> imagesInfo = new List<string[]>();
        static List<string[]> imagesMetadata = new List<string[]>();
        static List<byte> imagesType = new List<byte>();
        /* 0 png  -  1 jpeg  -  2 webp  -  3 ico  -  4 tiff  -  5 bmp
           6 gif  -  7 bti   -  8 tpl   -  9 tex0 - 10 heic  - 11 pdf
          12 bmd  - 13 brres - 14 u8    - 15 pix  - 16 dds   - 17 cin
          18 iff  - 19 eps   - 20 yuv   - 21 rgb  - 22 pic   - 23 tim
          24 tga  - 25 rla   - 26 xpm   - 27 hdr  - 28 apng  - 29 rgb565 */
        static List<Object> imageViewerComponents = new List<Object>();
        static List<TextBox> file_browser_list = new List<TextBox>();
        Point consoleLocation = new Point(0, 0);
        Point metadataLocation = new Point(100, 100);
        static string[] txt;
        // when escape is pressed 
        // Environment.Exit(0);
        public SakuraView()
        {
            SetTxt();
            InitializeComponent();
            imageViewerComponents.Add(SakuraBox);
            imageViewerComponents.Add(SakuraHelp);
            imageViewerComponents.Add(SakuraInfo);
            imageViewerComponents.Add(SakuraSideHelp);
            imageViewerComponents.Add(SakuraBox);
            imageViewerComponents.Add(SakuraBox);
            imageViewerComponents.Add(SakuraBox);
            file_browser_list.Add(textBox1);
            file_browser_list.Add(textBox2);
            file_browser_list.Add(textBox3);
            file_browser_list.Add(textBox4);
            foreach (TextBox e in file_browser_list)
            {
                e.Visible = false;
            }
            try
            {
                // read the config file
                txt = System.IO.File.ReadAllLines(execPath + "SakuraView.txt");
                upscaleAlgorithm = txt[2].ToLower();
                upscaleMode = txt[4].ToLower();
                windowPosition = txt[6].ToLower();
                SetAlgorithm();
                SetSizeMode();
                SetTextColour(txt[8]);
                SetBackgroundColour(txt[10]);
                SakuraTextColor.Text = txt[8];
                SakuraBgColor.Text = txt[10];
                fixed_padding = padding = byte.Parse(txt[12]);
                mode = byte.Parse(txt[14]);
                metadataLength = ushort.Parse(txt[16]);
                SakuraImgcvt.Text = txt[18];
                this.TopMost = txt[20].ToLower() == "true";
                banner = txt[22].ToLower() == "view";
                this.SakuraConsole.Visible = console = txt[24].ToLower() == "view";
                duplicate = txt[26].ToLower() == "true";
                help = txt[28].ToLower() == "view";
                info = txt[30].ToLower() == "view";
                loop = txt[32].ToLower() == "true";
                metadata = txt[34].ToLower() == "view";
                loadSubFolders = txt[36].ToLower() == "true";
                counter = txt[38].ToLower() == "true";
                SetBanner();
                SetHelp(true);
                SetInfo(true);
                SetWindowPosition();
            }
            catch
            {
                // if the program doesn't have the rights to read, then load default config
                // this.WindowState = FormWindowState.Normal;
                SetTxt();
                SetAlgorithm();
                SetSizeMode();
            }
            string[] args = Environment.GetCommandLineArgs();
            foreach (string arg in args)
            {
                SakuraConsole.Text += "\n" + arg;
            }
            if (args.Length > 1)
            {
                if (AddImage(args[1]))
                {
                    LoadImage(args[1]); // arg 1 is never a duplicate
                }

            }
            for (z = 2; z < args.Length; z++)
            {
                if (!duplicate)
                {
                    if (!imagesPath.Contains(args[z]))
                    {
                        AddImage(args[z]);
                    }
                }
                else
                {
                    AddImage(args[z]);
                }
            }
            SetMode();
            SakuraView_ClientSizeChanged(null, null);
            foreach (KnownColor knownColor in Enum.GetValues(typeof(KnownColor)))
            {
                Color color = Color.FromKnownColor(knownColor);
                SakuraBgColor.Items.Add(color.Name);
                SakuraTextColor.Items.Add(color.Name);
            }
            SakuraBgColor.SelectedIndex = Array.IndexOf(Enum.GetValues(typeof(KnownColor)), this.BackColor); ;
            SakuraTextColor.SelectedIndex = Array.IndexOf(Enum.GetValues(typeof(KnownColor)), SakuraInfo.ForeColor);
            if (this.TopMost)
            {
                this.TopMost = false;
                SakuraCkAlwaysOnTop.Checked = true;
            }
            if (banner)
            {
                banner = false;
                SakuraCkBanner.Checked = true;
            }
            if (console)
            {
                console = false;
                SakuraCkConsole.Checked = true;
            }
            if (duplicate)
            {
                duplicate = false;
                SakuraCkDuplicates.Checked = true;
            }
            if (help)
            {
                help = false;
                SakuraCkHelp.Checked = true;
            }
            if (info)
            {
                info = false;
                SakuraCkInfo.Checked = true;
            }
            if (loop)
            {
                loop = false;
                SakuraCkLoop.Checked = true;
            }
            if (metadata)
            {
                metadata = false;
                SakuraCkMetadata.Checked = true;
            }
            if (loadSubFolders)
            {
                loadSubFolders = false;
                SakuraCkSubFolders.Checked = true;
            }
            if (counter)
            {
                counter = false;
                SakuraCkCounter.Checked = true;
            }
            SakuraButton10Lines.Visible = false;
            SakuraButtonClearConsole.Visible = false;
            SakuraButtonDirectory.Visible = false;
            SakuraButtonEmpty.Visible = false;
            SakuraButtonGithub.Visible = false;
            SakuraButtonOpenFiles.Visible = false;
            SakuraButtonRotate.Visible = false;
            SakuraButtonSave.Visible = false;
            SakuraButtonSwapH.Visible = false;
            SakuraButtonSwapV.Visible = false;
            SakuraCkAlwaysOnTop.Visible = false;
            SakuraCkBanner.Visible = false;
            SakuraCkConsole.Visible = false;
            SakuraCkCounter.Visible = false;
            SakuraCkDuplicates.Visible = false;
            SakuraCkHelp.Visible = false;
            SakuraCkInfo.Visible = false;
            SakuraCkLoop.Visible = false;
            SakuraCkMetadata.Visible = false;
            SakuraCkSubFolders.Visible = false;
            SakuraZoomLabel.Visible = false;
            SakuraZoomNumeric.Visible = false;
            SakuraZoomTrackBar.Visible = false;
            SakuraBgColor.Visible = false;
            SakuraBgColorLabel.Visible = false;
            SakuraTextColor.Visible = false;
            SakuraTextColorLabel.Visible = false;
            SakuraImgcvtLabel.Visible = false;
            SakuraImgcvt.Visible = false;
            SakuraButtonHideSettings.Visible = false;
            if (fixed_padding == 0 && imagesInfo.Count > 0)
            {
                padding = 15;
                ScaleInfo(true);
                SakuraInfo.Text = SakuraHidden.Text;
            }

        }
        private void SetTxt()
        {
            txt = new string[] {
                "SakuraView v0.2", "Scale Algorithm {Bicubic, Bilinear, Default, High, HighQualityBicubic, HighQualityBilinear, Low, NearestNeighbor}", "High",  // config[2]
            "Scale mode {Fill, Fit, Stretch, VanillaFit, LeftFit, Center}","Fit",  // config[4]
            "Window Location Window Location {Minimized, Normal, Maximized, Normal2, Maximized2}", "Normal",  // config[6]
            "Text Colour (System.Drawing.Color)", "White",  // config[8]
            "Background Colour", "Black",  // config[10]
            "Fixed Padding (0 = disable)", "0", // config[12]
            "Mode {0, 1, 2, 3, 4, 5, 6}", "0", // config[14]
            "Metadata Length (in character count per line)", "200", // config[16]
            "imgcvt.exe path", "C:\\Program Files\\Autodesk\\Maya2018\\bin\\imgcvt.exe", // config[18]
            "Always On Top {True, False}", "False", // config[20]
            "Banner {View, Hide}", "View",  // config[22]
            "Console {View, Hide}", "Hide",  // config[24]
            "Duplicates {True, False}", "False", // config[26]
            "Help {View, Hide}", "View",  // config[28]
            "Info {View, Hide}", "View",  // config[30]
            "Loop {True, False}", "True", // config[32]
            "Metadata {View, Hide}", "True", // config[34]
            "Load sub-folders {True, False}", "True", // config[36]
            "Counter {True, False}", "True", // config[38]
             };
        }
        private void SetMode()
        {
            if (mode == 0) // ImageViewer
            {

            }
        }
        private void SetBackgroundColour(string backgroundColour)
        {
            color = System.Drawing.Color.FromName(backgroundColour);
            this.BackColor = color;
            SakuraBox.BackColor = color;
            SakuraZoomLabel.BackColor = color;
            SakuraImgcvtLabel.BackColor = color;
            SakuraTextColorLabel.BackColor = color;
            SakuraBgColorLabel.BackColor = color;
            SakuraSideHelp.BackColor = color;
            SakuraHelp.BackColor = color;
            SakuraImgcvt.BackColor = color;
            SakuraInfo.BackColor = color;
            SakuraButtonEmpty.BackColor = color;
            SakuraButtonGithub.BackColor = color;
            SakuraButtonOpenFiles.BackColor = color;
            SakuraButtonClearConsole.BackColor = color;
            SakuraButtonDirectory.BackColor = color;
            SakuraButton10Lines.BackColor = color;
            SakuraButtonRotate.BackColor = color;
            SakuraButtonSwapH.BackColor = color;
            SakuraButtonSwapV.BackColor = color;
            SakuraButtonSave.BackColor = color;
            SakuraZoomNumeric.BackColor = color;
            SakuraBgColor.BackColor = color;
            SakuraTextColor.BackColor = color;
            SakuraButtonHideSettings.BackColor = color;
        }
        private void SetTextColour(string textColour)
        {
            color = System.Drawing.Color.FromName(textColour);
            this.ForeColor = color;
            SakuraZoomLabel.ForeColor = color;
            SakuraImgcvtLabel.ForeColor = color;
            SakuraTextColorLabel.ForeColor = color;
            SakuraBgColorLabel.ForeColor = color;
            SakuraSideHelp.ForeColor = color;
            SakuraHelp.ForeColor = color;
            SakuraImgcvt.ForeColor = color;
            SakuraInfo.ForeColor = color;
            SakuraButtonEmpty.ForeColor = color;
            SakuraButtonGithub.ForeColor = color;
            SakuraButtonOpenFiles.ForeColor = color;
            SakuraButtonClearConsole.ForeColor = color;
            SakuraButtonDirectory.ForeColor = color;
            SakuraButton10Lines.ForeColor = color;
            SakuraButtonRotate.ForeColor = color;
            SakuraButtonSwapH.ForeColor = color;
            SakuraButtonSwapV.ForeColor = color;
            SakuraButtonSave.ForeColor = color;
            SakuraZoomNumeric.ForeColor = color;
            SakuraBgColor.ForeColor = color;
            SakuraTextColor.ForeColor = color;
            SakuraCkAlwaysOnTop.ForeColor = color;
            SakuraCkBanner.ForeColor = color;
            SakuraCkConsole.ForeColor = color;
            SakuraCkDuplicates.ForeColor = color;
            SakuraCkHelp.ForeColor = color;
            SakuraCkInfo.ForeColor = color;
            SakuraCkLoop.ForeColor = color;
            SakuraCkMetadata.ForeColor = color;
            SakuraCkSubFolders.ForeColor = color;
            SakuraCkCounter.ForeColor = color;
            SakuraButtonHideSettings.ForeColor = color;
        }
        private void SetBanner()
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            if (banner)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.None;
            }
            ScaleImage();
        }
        private void SetHelp(bool init = false)
        {
            if (help)
            {
                SakuraSideHelp.Visible = true;
                SakuraHelp.Visible = true;
                bottomSpace = SakuraInfo.Height + SakuraHelp.Height + 35;  // add the height of SakuraHelp + padding
                rightSpace += SakuraSideHelp.Width;
            }
            else
            {
                SakuraSideHelp.Visible = false;
                SakuraHelp.Visible = false;
                if (!init)
                {
                    bottomSpace = SakuraInfo.Height;  // sub the height of SakuraHelp + padding
                    rightSpace -= SakuraSideHelp.Width;
                    if (!info)
                        bottomSpace = 0;
                }
            }
            ScaleImage();
        }
        private void SetInfo(bool init = false)
        {
            if (info)
            {
                SakuraInfo.Visible = true;
                if (!help)
                    bottomSpace += SakuraInfo.Height;
            }
            else
            {
                SakuraInfo.Visible = false;
                if (!init && !help)
                {
                    bottomSpace -= SakuraInfo.Height;
                }
            }
            ScaleImage();
        }
        private void SetAlgorithm()
        {
            switch (upscaleAlgorithm)
            {
                case "bicubic":
                    SakuraBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bicubic;
                    break;
                case "bilinear":
                    SakuraBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bilinear;
                    break;
                case "default":
                    SakuraBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;
                    break;
                case "high":
                    SakuraBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
                    break;
                case "highqualitybicubic":
                    SakuraBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    break;
                case "highqualitybilinear":
                    SakuraBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
                    break;
                case "low":
                    SakuraBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;
                    break;
                case "nearestneighbor":
                    SakuraBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                    break;
            }
            if (currentImage < imagesInfo.Count)
            {
                imagesInfo[currentImage][6] = upscaleAlgorithm;
                LoadInfo();
            }
        }
        private void SetWindowPosition()
        {
            switch (windowPosition.ToLower())
            {
                case "minimized":
                    this.WindowState = FormWindowState.Minimized;
                    break;
                case "normal":
                    WindowState = FormWindowState.Normal;
                    for (i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        if (Screen.AllScreens[i].Bounds.X == 0)
                        {
                            this.Location = Screen.AllScreens[i].Bounds.Location;
                            currentScreen = i;
                            break;
                        }
                    }
                    break;
                case "normal2":
                    WindowState = FormWindowState.Normal;
                    for (i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        if (Screen.AllScreens[i].Bounds.X != 0)
                        {
                            this.Location = Screen.AllScreens[i].Bounds.Location;
                            currentScreen = i;
                            break;
                        }
                    }
                    break;
                case "maximized":
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        windowPosition = "normal";
                        SetWindowPosition();
                        return;
                    }
                    for (i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        if (Screen.AllScreens[i].Bounds.X == 0)
                        {
                            currentScreen = i;
                            break;
                        }
                    }
                    WindowState = FormWindowState.Maximized;
                    break;
                case "maximized2":
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        windowPosition = "normal2";
                        SetWindowPosition();
                        return;
                    }
                    for (i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        if (Screen.AllScreens[i].Bounds.X != 0)
                        {
                            currentScreen = i;
                            break;
                        }
                    }
                    WindowState = FormWindowState.Maximized;
                    break;
            }
        }
        private void LoadMetadata(int imageNumber)
        {
            SakuraMetadata.Text = "";
            if (!counter || imagesType[imageNumber] == 0) // png
            {
                string[] output = new string[13];

                try
                {
                    using (FileStream png = new FileStream(imagesPath[imageNumber], FileMode.Open, FileAccess.Read))
                    {
                        byte[] textBytes = new byte[8192];
                        int bytesRead = png.Read(textBytes, 0, 8192);
                        if (!ByteArrayEquals(textBytes.Take(4).ToArray(), new byte[] { 0x89, 0x50, 0x4E, 0x47 }))
                        {
                            SakuraConsole.Text += $"\n{imagesPath[imageNumber]} is not a PNG file";
                            imagesMetadata.Add(null);
                            return;
                        }
                        x = (textBytes[0x21] << 24) | (textBytes[0x22] << 16) | (textBytes[0x23] << 8) | textBytes[0x24];

                        if (!ByteArrayEquals(textBytes.Skip(0x25).Take(14).ToArray(), Encoding.ASCII.GetBytes("tEXtparameters")))
                        {
                            if (!ByteArrayEquals(textBytes.Skip(0x25).Take(4).ToArray(), Encoding.ASCII.GetBytes("tEXt")))
                            {
                                SakuraConsole.Text += $"\n{imagesPath[imageNumber]} has no png metadata";
                                imagesMetadata.Add(null);
                                return;
                            }
                            SakuraConsole.Text += $"\n{imagesPath[imageNumber]} is not a AI Generated PNG file";
                            SakuraMetadata.Text = Encoding.UTF8.GetString(textBytes, 0x29, x).Replace('\0', ':');
                            y = 0x29 + 8 + x;
                            while (ByteArrayEquals(textBytes.Skip(y).Take(4).ToArray(), Encoding.ASCII.GetBytes("tEXt")))
                            {
                                x = (textBytes[0x2D + x] << 24) | (textBytes[0x2E + x] << 16) | (textBytes[0x2F + x] << 8) | textBytes[0x30 + x];
                                SakuraMetadata.Text += "\n" + Encoding.UTF8.GetString(textBytes, y + 4, x).Replace('\0', ':');
                                y += x + 12;
                            }
                            return;
                        }
                        string text = Encoding.UTF8.GetString(textBytes, 0x34, x).Trim();
                        text = text.Split('\x00')[0].Trim();

                        string[] textLines = text.Split(new[] { "Negative prompt: " }, StringSplitOptions.None);

                        if (textLines.Length == 1)  // there's no negative prompt
                        {
                            string[] promptParts = textLines[0].Split(new[] { "Steps: " }, StringSplitOptions.RemoveEmptyEntries);

                            if (promptParts.Length == 2)  // if there's a prompt
                            {
                                output[0] += promptParts[0].Substring(0, promptParts[0].Length - 1);  //  prompt
                            }
                        }
                        else if (textLines.Length == 2)  // there's a negative prompt
                        {
                            if (textLines[0] != "")  // if there's a prompt
                            {
                                output[0] += textLines[0].Substring(0, textLines[0].Length - 1);  // prompt
                            }
                            string[] stepsParts = textLines[1].Split(new[] { "Steps: " }, StringSplitOptions.None);
                            output[1] += stepsParts[0].Substring(0, stepsParts[0].Length - 1).Replace("\\n", "\n");  // negative prompt
                        }
                        textLines = text.Split('\n');
                        y = textLines.Length - 1;
                        /*
                        
                        j = 0;
                        if (textLines.Length == 2)  // either the prompt or the negative is not there
                        {
                            if (textLines[0].StartsWith("Negative prompt: "))
                            {
                                output[1] = textLines[0].Substring(17);  // negative prompt
                            }
                            else
                            {
                                output[0] = textLines[0];  // prompt
                            }
                            textLines = new string[] { "", textLines[0] };
                            j = 1;
                        }
                        else if (textLines.Length == 3)  // both are there
                        {
                            output[0] = textLines[0].TrimEnd();  // prompt
                            output[1] = textLines[1].Substring(17);  // negative prompt
                            j = 2;
                        }*/
                        output[2] = GetParamValue(textLines[y], "Steps:");
                        output[3] = GetParamValue(textLines[y], "Sampler:");
                        output[4] = GetParamValue(textLines[y], "CFG scale:");
                        output[5] = GetParamValue(textLines[y], "Seed:");

                        text = GetParamValue(textLines[y], "Size:");
                        if (text.Contains("x"))
                        {
                            string[] dimensions = text.Split('x');
                            output[6] = dimensions[0];  // width
                            output[7] = dimensions[1];  // height
                        }
                        text = GetParamValue(textLines[y], "Variation seed:");
                        if (!string.IsNullOrEmpty(text))
                        {
                            output[8] = text;  // subseed
                        }
                        text = GetParamValue(textLines[y], "Variation seed strength:");
                        if (!string.IsNullOrEmpty(text))
                        {
                            output[9] = text;  // subseed strength between 0.0 and 1.0
                        }
                        output[10] = GetParamValue(textLines[y], "Model:");
                        string[] loraSplit = textLines[y].Split(new string[] { "Lora hashes: \"" }, StringSplitOptions.None);
                        if (loraSplit.Length > 1)
                        {
                            text = loraSplit[1].Split(':')[0].Trim();
                            output[11] = text;  // lora
                        }
                    }
                }
                catch (Exception ex)
                {
                    SakuraConsole.Text += $"\nError parsing PNG file: {ex.Message}";
                    imagesMetadata.Add(null);
                    return;
                }
                imagesMetadata.Add(output);
                PlaceMetadata();
            }
            else { imagesMetadata.Add(null); }
        }
        private void UpPlaceMetadata()
        {
            if (imagesMetadata.Count <= currentImage)
                return;
            SakuraMetadata.Text = "";
            if (imagesMetadata[currentImage] == null)
                return;
            FillMetadata();
            while (SakuraMetadata.Location.X + SakuraUnseen.Width > screenWidth && metadataLength > 20)
            {
                metadataLength -= 5;
                FillMetadata();
            }
            SakuraMetadata.Text = SakuraUnseen.Text;
        }
        private void PlaceMetadata()
        {
            metadataLength = ushort.Parse(txt[16]);
            UpPlaceMetadata();
        }
        private void FillMetadata()
        {
            SakuraUnseen.Text = "";
            for (i = 0; i < 2; i++)
            {
                if (!string.IsNullOrEmpty(imagesMetadata[currentImage][i]))
                    SakuraUnseen.Text += pngMetadata[i] + "\n" + WrapText(imagesMetadata[currentImage][i], metadataLength) + "\n\n";
            }
            for (; i < imagesMetadata[currentImage].Length - 1; i++)
            {
                if (!string.IsNullOrEmpty(imagesMetadata[currentImage][i]))
                    SakuraUnseen.Text += pngMetadata[i] + imagesMetadata[currentImage][i] + "\n";
            }
            if (!string.IsNullOrEmpty(imagesMetadata[currentImage][i]))
                SakuraUnseen.Text += pngMetadata[i] + imagesMetadata[currentImage][i] + "\n"; // for the last one I won't put a new line at the end
        }
        public static string WrapText(string input, int maxLength)
        {
            StringBuilder sb = new StringBuilder();

            while (input.Length > maxLength)
            {
                int spaceIndex = input.LastIndexOf(' ', maxLength);

                if (spaceIndex == -1)
                {
                    // No space found, just break at the maxLength
                    sb.AppendLine(input.Substring(0, maxLength));
                    input = input.Substring(maxLength);
                }
                else
                {
                    // Break at the last space before maxLength
                    sb.AppendLine(input.Substring(0, spaceIndex));
                    input = input.Substring(spaceIndex + 1);
                }
            }

            sb.Append(input); // Append the remaining text
            return sb.ToString();
        }

        private bool ByteArrayEquals(byte[] a1, byte[] a2)
        {
            if (a1.Length != a2.Length)
                return false;

            for (int i = 0; i < a1.Length; i++)
            {
                if (a1[i] != a2[i])
                    return false;
            }

            return true;
        }

        private string GetParamValue(string text, string paramName)
        {
            string pattern = $"{paramName}([^,]+)";
            Match match = Regex.Match(text, pattern);

            return match.Success ? $"{match.Groups[1].Value.Trim()}" : "";
        }
        private void LoadImage(String filePath)
        {
            if (System.IO.File.Exists(filePath))
            {
                try
                {
                    byte[] id = new byte[4];
                    using (System.IO.FileStream file = System.IO.File.Open(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        file.Position = 0x08;
                        file.Read(id, 0, 4);
                    }
                    if (id[0] == 87 && id[1] == 69 && id[2] == 66 && id[3] == 80) // Webp
                    {
                        using (WebP webp = new WebP())
                        {
                            SakuraBox.Image = webp.Load(filePath);
                        }
                    }
                    else
                    {
                        SakuraBox.Image = LoadImageFromFile(filePath);
                    }
                    while (images.Count < currentImage)
                    {
                        images.Add(null);
                        imagesInfo.Add(null);
                        imagesMetadata.Add(null);
                    }
                    string[] pictureInfo = { "" + (currentImage + 1), GetFileSize(), GetPixelFormat(), SakuraBox.Image.Width + "x" + SakuraBox.Image.Height, File.GetCreationTime(filePath).ToString(), upscaleMode, upscaleAlgorithm, Path.GetFileName(filePath) };
                    if (counter)
                    {
                        pictureInfo[0] += " / " + imagesPath.Count;
                    }
                    if (SakuraMetadata.Visible)
                    {
                        if (imagesMetadata.Count == currentImage)
                            LoadMetadata(currentImage);
                        else if (imagesMetadata[currentImage] == null)
                            LoadMetadata(currentImage);
                    }
                    else
                    {
                        imagesMetadata.Add(null);
                    }
                    if (currentImage < images.Count)
                    {
                        images[currentImage] = SakuraBox.Image;
                        imagesInfo[currentImage] = pictureInfo;
                    }
                    else
                    {
                        images.Add(SakuraBox.Image);
                        imagesInfo.Add(pictureInfo);
                    }
                }
                catch (Exception e)
                {
                    //Console.WriteLine("Invalid input Image -> " + filePath);
                    SakuraConsole.Text += "\nInvalid input Image -> " + filePath;
                    imagesPath.Remove(filePath);
                    return;
                    // throw e;
                }
            }
            else
            {

                SakuraConsole.Text += "\nImage doesn't exist -> " + filePath;
                //Console.WriteLine("Image doesn't exist -> " + filePath);
                imagesPath.Remove(filePath);
                return;
            }
            //string extension = Path.GetExtension(filePath).ToLower();
            //string baseName = Path.GetFileNameWithoutExtension(filePath);
            // Extract icon from executable and set as picture box image
            //Icon icon = Icon.ExtractAssociatedIcon(filePath);
            //SakuraBox.Image = icon.ToBitmap();

            // Load cursor into picture box using IconLib library
            /*
            using (IconReader iconReader = new IconReader())
            {
                IconInfo cursorInfo = iconReader.ReadIcon(filePath, IconReaderFormat.DEFAULT, false)[0];
                pictureBox1.Image = cursorInfo.ToBitmap();
            }*/ /*
            Dynamicweb.Imaging.PdfImageConverter pdf = new Dynamicweb.Imaging.PdfImageConverter();
            IEnumerable<byte[]> imageCollection = pdf.ConvertToImages(filePath);
            foreach (byte[] image in imageCollection)
            {
                SakuraBox.Image = byteArrayToImage(image);
            }*/

            // Load image
            // SakuraBox.Image = Image.FromFile(baseName + ".png");

            // Load WebP image into picture box using Google.Webp decoder library
            //SixLabors.ImageSharp.Image.Load(filePath);
            /*
            Aspose.Imaging.Image image = Aspose.Imaging.Image.Load(filePath);
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, new PngOptions());
                SakuraBox.Image = Image.FromStream(ms);
            }*/
            ScaleImage();
        }
        private string GetPixelFormat()
        {
            return SakuraBox.Image.PixelFormat.ToString().Replace("Format", "").Replace("bpp", "-bit ");
        }
        private string GetFileSize()
        {
            if ((fileSize >> 10) == 0)
                return fileSize + " b";
            else if ((fileSize >> 20) == 0)
                return ((double)fileSize / 1024.0).ToString(specifier, culture) + " KB";
            else if ((fileSize >> 30) == 0)
                return ((double)fileSize / 1048576.0).ToString(specifier, culture) + " MB";
            else if ((fileSize >> 40) == 0)
                return ((double)fileSize / 1073741824.0).ToString(specifier, culture) + " GB";
            else
                return ((double)fileSize / 1099511627776.0).ToString(specifier, culture) + " TB";
        }
        private string Fill(string word, byte number)
        {
            z = (number - word.Length) >> 1;
            text = "";
            for (i = 0; i < z; i++)
            {
                text += " ";
            }
            y = number - word.Length - text.Length;
            word = text + word;
            for (i = 0; i < y; i++)
            {
                word += " ";
            }
            return word;
        }
        private void ScaleInfo(bool init=false)
        {
            if (currentImage > imagesInfo.Count)
                currentImage = imagesInfo.Count - 1;
            SakuraHidden.Text = "";
            for (int i = 0; i < imagesInfo[currentImage].Length - 1; i++)
            {
                SakuraHidden.Text += Fill(imagesInfo[currentImage][i], padding);
            }
            SakuraHidden.Text += imagesInfo[currentImage][imagesInfo[currentImage].Length - 1];
            if (SakuraHidden.Width > ClientSize.Width && padding != 1 && fixed_padding == 0 && !init)
            {
                padding--;
                ScaleInfo();
            }
        }
        private void LoadInfo()
        {
            ScaleInfo();
            SakuraInfo.Text = SakuraHidden.Text;
            if (imagesMetadata[currentImage] == null)
                LoadMetadata(currentImage);
            else
                PlaceMetadata();
        }
        private Image LoadImageFromFile(string path)  // allows the image not to be locked by the program
        {
            byte[] bytes = File.ReadAllBytes(path);
            fileSize = bytes.LongLength;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }
        private void SetSizeMode()
        {
            if (upscaleMode == "fill" || upscaleMode == "stretch")
            {
                SakuraBox.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            else if (upscaleMode == "fit" || upscaleMode == "vanillafit" || upscaleMode == "leftfit")
            {
                SakuraBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                SakuraBox.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            if (currentImage < imagesInfo.Count)
            {
                imagesInfo[currentImage][5] = upscaleMode;
                LoadInfo();
            }
        }
        private void ScaleImage()
        {
            windowFound = false;
            if (this.WindowState == FormWindowState.Maximized)
            {

                for (i = 0; i < Screen.AllScreens.Length; i++)
                {
                    screenWidth = Screen.AllScreens[i].Bounds.Width;
                    screenHeight = Screen.AllScreens[i].Bounds.Height;
                    x = Screen.AllScreens[i].Bounds.Location.X;
                    y = Screen.AllScreens[i].Bounds.Location.Y;
                    if (x <= this.Location.X && this.Location.X <= (x + screenWidth) && y <= this.Location.Y && this.Location.Y <= (y + screenHeight))  // finds the screen boundaries the window is currently in
                    {
                        currentScreen = i;
                        windowFound = true;
                        break;
                    }
                }
                if (!windowFound)
                {
                    screenWidth = this.ClientSize.Width;
                    screenHeight = this.ClientSize.Height;
                    // x = Screen.AllScreens[currentScreen].Bounds.Location.X;
                    // y = Screen.AllScreens[currentScreen].Bounds.Location.Y;
                }
            }
            for (i = 0; i < Screen.AllScreens.Length; i++)
            {
                screenWidth = this.ClientSize.Width;
                screenHeight = this.ClientSize.Height;
                x = Screen.AllScreens[i].Bounds.Location.X;
                y = Screen.AllScreens[i].Bounds.Location.Y;
                if (x <= this.Location.X && this.Location.X <= (x + screenWidth) && y <= this.Location.Y && this.Location.Y <= (y + screenHeight))  // finds the screen boundaries the window is currently in
                {
                    currentScreen = i;
                    windowFound = true;
                    break;
                }
            }
            if (!windowFound)
            {
                screenWidth = this.ClientSize.Width;
                screenHeight = this.ClientSize.Height;
                // x = Screen.AllScreens[currentScreen].Bounds.Location.X;
                // y = Screen.AllScreens[currentScreen].Bounds.Location.Y;
            }
            if (SakuraBox.Image == null || imagesPath.Count == 0)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    width = Screen.AllScreens[currentScreen].Bounds.Width - SakuraSideHelp.Width;
                    height = Screen.AllScreens[currentScreen].Bounds.Height - SakuraHelp.Height;
                }
                else
                {
                    width = this.ClientSize.Width - SakuraSideHelp.Width;
                    height = this.ClientSize.Height - SakuraHelp.Height;
                }
                SakuraSideHelp.Location = new Point(width, 0);
                SakuraHelp.Location = new Point(0, height);
                SakuraInfo.Location = new Point(0, height + bottomSpace - SakuraInfo.Height);
                return;
            }
            LoadInfo();
            width = SakuraBox.Image.Size.Width;
            height = SakuraBox.Image.Size.Height;
            widthSpan = 0;
            heightSpan = 0;
            if (upscaleMode == "fill")
            {
                setImageBounds();
                Fill();
            }
            else if (upscaleMode == "fit")  // the highest value becomes the screen bounds
            {
                setImageBounds();
                Fit();
            }
            else if (upscaleMode == "leftfit")  // the highest value becomes the screen bounds
            {
                setImageBounds();
                VanillaFit();
            }
            else if (upscaleMode == "stretch" || upscaleMode == "center")
            {
                setImageBounds();
                height = screenHeight;
                width = screenWidth;
            }
            else if (upscaleMode != "none" && (width > screenWidth || height > screenHeight - bottomSpace))
            { // upscaleMode == "none" - we downscale the image to the "fit" algorithm
                if (upscaleMode == "vanillafit")
                {
                    setImageBounds();
                    VanillaFit();
                }
            }
            SakuraBox.Location = new Point(-widthSpan, -heightSpan);
            SakuraBox.Size = new System.Drawing.Size(width + 1, height + 1);  // for some reason there's a pixel of margin.
            //Console.WriteLine(SakuraBox.Size);
            //Console.WriteLine(SakuraBox.Location);
            if (this.WindowState != FormWindowState.Maximized)
            {
                UpdateLayout();
            }
            else
            {
                UpdateLayoutMaximized();
            }
        }
        private void setImageBounds()
        {
            screenHeight -= bottomSpace;
            screenWidth -= rightSpace;

            widthRatio = (decimal)screenWidth / (decimal)width;
            heightRatio = (decimal)screenHeight / (decimal)height;
        }
        private void UpdateLayout()
        {
            SakuraSideHelp.Location = new Point(width, 0);
            SakuraHelp.Location = new Point(0, height);
            SakuraInfo.Location = new Point(0, height + bottomSpace - SakuraInfo.Height);
        }
        private void UpdateLayoutMaximized()
        {
            this.Location = Screen.AllScreens[currentScreen].Bounds.Location;
            SakuraHelp.Location = new Point(0, this.ClientSize.Height - SakuraInfo.Height - 35 - SakuraHelp.Height);
            SakuraInfo.Location = new Point(0, this.ClientSize.Height - SakuraInfo.Height);
            SakuraSideHelp.Location = new Point(this.ClientSize.Width - SakuraSideHelp.Width, 0);
        }
        private void Fill()
        {
            if (widthRatio < heightRatio)
            {
                height = screenHeight;
                widthSpan = width;
                width = (int)(width * heightRatio);
                widthSpan = Math.Abs(widthSpan - width) >> 1;
            }
            else
            {
                width = screenWidth;
                heightSpan = height;
                height = (int)(height * widthRatio);
                heightSpan = Math.Abs(heightSpan - height) >> 1;
            }
        }
        private void Fit()
        {
            if (widthRatio < heightRatio)
            {
                height = screenHeight;
                width = (int)(width * widthRatio);
            }
            else
            {
                width = screenWidth;
                height = (int)(height * heightRatio);
            }
        }
        private void VanillaFit()
        {
            if (widthRatio < heightRatio)
            {
                height = (int)(height * widthRatio);
                width = (int)(width * widthRatio);
            }
            else
            {
                width = (int)(width * heightRatio);
                height = (int)(height * heightRatio);
            }
        }
        private bool AddImage(string filepath)
        {
            if (!counter)
            {
                imagesPath.Add(filepath);
                return true;
            }
            byte[] id = new byte[12];
            try
            {
                using (System.IO.FileStream file = System.IO.File.Open(filepath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                {
                    file.Read(id, 0, 12);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Substring(0, 34) == "The process cannot access the file")  // because it is being used by another process
                {
                    SakuraConsole.Text += "\n" + filepath + " is used by another process. therefore this program can't read that file.";
                }
                return false;
            }
            if (id[0] == 0x89 && id[1] == 0x50 && id[2] == 0x4E && id[3] == 0x47) // ‰PNG
            { imagesType.Add(0); }
            else if (id[0] == 0x47 && id[1] == 0x49 && id[2] == 0x46 && id[3] == 0x38) // GIF8
            { imagesType.Add(6); }
            else if (id[0] == 0xff && id[1] == 0xd8 && id[2] == 0xff) // jpeg
            { imagesType.Add(1); }
            else if (id[0] == 0x42 && id[1] == 0x4D) // BM => bmp
            { imagesType.Add(5); }
            else if (id[0] == 0x49 && id[1] == 0x49 && id[2] == 0x2a && id[3] == 0x00) // tiff
            { imagesType.Add(4); }
            else if (id[0] == 0x4d && id[1] == 0x4d && id[2] == 0x00 && id[3] == 0x2a) // tiff <- another header
            { imagesType.Add(4); }
            else if (id[0] == 0x52 && id[1] == 0x49 && id[2] == 0x46 && id[3] == 0x46 && id[8] == 0x57 && id[9] == 0x45 && id[10] == 0x42 && id[11] == 0x50) // RIFF WEBP
            { imagesType.Add(2); }
            else if (id[0] == 0 && id[1] == 0 && id[2] == 1 && id[3] == 0) // ico
            { imagesType.Add(3); }
            else if (id[0] == 84 && id[1] == 69 && id[2] == 88 && id[3] == 48) // TEX0
            { imagesType.Add(9); }
            else if (id[0] == 0 && id[1] == 32 && id[2] == 0xaf && id[3] == 48)  // tpl file header
            { imagesType.Add(8); }
            else if (id[0] < 15 && id[6] < 3 && id[7] < 3)  // rough bti check
            { imagesType.Add(7); }
            else
            { return false; }
            imagesPath.Add(filepath);
            return true;
        }
        private void SakuraViewClass_DragDrop(object sender, DragEventArgs e)
        {
            bool done = false;
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);  // gets all the files or folders name that were dragged in an array, but I'll only use the first
            if (file != null) // prevent crashes if it's for example a google chrome favourite that was dragged
            {
                for (z = 0; z < file.Length; z++)
                {
                    if (System.IO.File.GetAttributes(file[z]).HasFlag(System.IO.FileAttributes.Directory))
                    {
                        LoadFolder(file[z]);
                        continue;
                    }
                    else  // that means it's a file.
                    {
                        if (!duplicate)
                        {
                            if (!imagesPath.Contains(file[z]))
                            {
                                AddImage(file[z]);
                            }
                        }
                        else
                        {
                            AddImage(file[z]);
                        }
                    }
                }
                if (!done)
                {
                    done = true;
                    currentImage = imagesPath.IndexOf(file[0]);
                    LoadImage(file[0]);
                }
            }
        }

        private void SakuraViewClass_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void UpscaleImage()
        {

        }
        private void DownscaleImage()
        {

        }
        private void ViewImage(int imageNumber)
        {
            if (imageNumber < 0)
            {
                if (images.Count > 0)
                {
                    if (loop)
                    {
                        currentImage = imagesPath.Count - 1;
                        imageNumber = currentImage;
                        if (images[imageNumber] != null)
                        {
                            currentImage = imageNumber;
                            SakuraBox.Image = images[currentImage];
                            imagesInfo[imageNumber][0] = (imageNumber + 1) + " / " + imagesPath.Count;
                            imagesInfo[imageNumber][5] = upscaleMode;
                            LoadInfo();
                        }
                        else if (imageNumber < imagesPath.Count)
                        {
                            currentImage = imageNumber;
                            LoadImage(imagesPath[imageNumber]);
                        }
                    }
                    else if (currentImage != 0)
                    {
                        currentImage = 0;
                        SakuraBox.Image = images[currentImage];
                        imagesInfo[0][0] = "1 / " + imagesPath.Count;
                        imagesInfo[0][5] = upscaleMode;
                        LoadInfo();
                    }
                }
            }
            else if (imageNumber < images.Count)
            {
                if (images[imageNumber] != null)
                {
                    currentImage = imageNumber;
                    SakuraBox.Image = images[currentImage];
                    imagesInfo[imageNumber][0] = (imageNumber + 1) + " / " + imagesPath.Count;
                    imagesInfo[imageNumber][5] = upscaleMode;
                    LoadInfo();
                }
                else if (imageNumber < imagesPath.Count)
                {
                    currentImage = imageNumber;
                    LoadImage(imagesPath[imageNumber]);
                }
            }
            else if (imageNumber < imagesPath.Count)
            {
                currentImage = imageNumber;
                LoadImage(imagesPath[imageNumber]);
            }
            else
            {
                if (loop)
                {
                    if (images.Count > 1 && currentImage != 0)
                    {
                        currentImage = 0;
                        SakuraBox.Image = images[currentImage];
                        imagesInfo[0][0] = "1 / " + imagesPath.Count;
                        imagesInfo[0][5] = upscaleMode;
                        LoadInfo();
                    }
                }
                else
                {
                    LoadFolder(Environment.CurrentDirectory);
                }
            }
            if (upscaleMode != "fit" && upscaleMode != "stretch" && upscaleMode != "center")
            {
                ScaleImage();
            }
        }
        private void LoadFiles(string[] files)
        {
            foreach (string fileItem in files)
            {
                if (!duplicate)
                {
                    if (!imagesPath.Contains(fileItem))
                    {

                        AddImage(fileItem);
                    }
                }
                else
                {
                    AddImage(fileItem);
                }
            }
            currentImage = imagesPath.IndexOf(files[0]);
            LoadImage(files[0]);
        }

        private void LoadFolder(string currentDirectory)
        {
            string[] file;
            try { file = Directory.GetFiles(currentDirectory); }
            catch { return; }
            if (loadSubFolders)
            {
                string[] folders = Directory.GetDirectories(currentDirectory);
                foreach (string folder in folders)
                {
                    LoadFolder(folder);
                }
            }
            foreach (string fileItem in file)
            {

                if (!duplicate)
                {
                    if (!imagesPath.Contains(fileItem))
                    {

                        AddImage(fileItem);
                    }
                }
                else
                {
                    AddImage(fileItem);
                }
            }
            foreach (string fileItem in file)
            {
                currentImage = imagesPath.IndexOf(file[0]);
                if (currentImage != -1)
                    break;
            }
            if (currentImage == -1)
                currentImage = 0;
            ViewImage(currentImage);
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        private void SakuraView_KeyDown(object sender, KeyEventArgs e)
        {
            //Console.WriteLine("Keydown!" + e.KeyCode);
            // SakuraConsole.Text += "\nKeydown!" + e.KeyCode;
            if (e.KeyCode == Keys.D1) { ViewImage(imagesPath.Count / 10); }
            else if (e.KeyCode == Keys.D2) { ViewImage(imagesPath.Count / 5); }
            else if (e.KeyCode == Keys.D3) { ViewImage(imagesPath.Count * 3 / 10); }
            else if (e.KeyCode == Keys.D4) { ViewImage((imagesPath.Count << 2) / 10); }
            else if (e.KeyCode == Keys.D5) { ViewImage(imagesPath.Count >> 1); }
            else if (e.KeyCode == Keys.D6) { ViewImage((imagesPath.Count << 1) * 3 / 10); }
            else if (e.KeyCode == Keys.D7) { ViewImage(imagesPath.Count * 7 / 10); }
            else if (e.KeyCode == Keys.D8) { ViewImage((imagesPath.Count << 3) / 10); }
            else if (e.KeyCode == Keys.D9) { ViewImage(imagesPath.Count * 9 / 10); }
            else if (e.KeyCode == Keys.D0) { ViewImage(0); }
            else if (e.KeyCode == Keys.F1)
            {
                SakuraCkHelp.Checked = !help;
            }
            else if (e.KeyCode == Keys.F2)
            {
                upscaleMode = "fill";
                SetSizeMode();
                ScaleImage();
            }
            else if (e.KeyCode == Keys.F3)
            {
                upscaleMode = "fit";
                SetSizeMode();
                ScaleImage();
            }
            else if (e.KeyCode == Keys.F4)
            {
                upscaleMode = "stretch";
                SetSizeMode();
                ScaleImage();
            }
            else if (e.KeyCode == Keys.F5)
            {
                upscaleMode = "vanillafit";
                SetSizeMode();
                ScaleImage();
            }
            else if (e.KeyCode == Keys.F6)
            {
                upscaleMode = "leftfit";
                SetSizeMode();
                ScaleImage();
            }
            else if (e.KeyCode == Keys.F7)
            {
                upscaleMode = "center";
                SetSizeMode();
                ScaleImage();
            }
            else if (e.KeyCode == Keys.F8)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (e.KeyCode == Keys.F9)
            {
                windowPosition = "normal";
                SetWindowPosition();
            }
            else if (e.KeyCode == Keys.F10)
            {
                windowPosition = "normal2";
                SetWindowPosition();
            }
            else if (e.KeyCode == Keys.F11)
            {
                windowPosition = "maximized";
                SetWindowPosition();
            }
            else if (e.KeyCode == Keys.F12)
            {
                windowPosition = "maximized2";
                SetWindowPosition();
            }
            else if (e.KeyCode == Keys.B)
            {
                upscaleAlgorithm = "bicubic";
                SetAlgorithm();
                SakuraBox.Refresh();
            }
            else if (e.KeyCode == Keys.M)
            {
                upscaleAlgorithm = "bilinear";
                SetAlgorithm();
                SakuraBox.Refresh();
            }
            else if (e.KeyCode == Keys.W)
            {
                upscaleAlgorithm = "default";
                SetAlgorithm();
                SakuraBox.Refresh();
            }
            else if (e.KeyCode == Keys.H)
            {
                upscaleAlgorithm = "high";
                SetAlgorithm();
                SakuraBox.Refresh();
            }
            else if (e.KeyCode == Keys.J)
            {
                upscaleAlgorithm = "highqualitybicubic";
                SetAlgorithm();
                SakuraBox.Refresh();
            }
            else if (e.KeyCode == Keys.V)
            {
                upscaleAlgorithm = "highqualitybilinear";
                SetAlgorithm();
                SakuraBox.Refresh();

            }
            else if (e.KeyCode == Keys.L)
            {
                upscaleAlgorithm = "low";
                SetAlgorithm();
                SakuraBox.Refresh();
            }
            else if (e.KeyCode == Keys.N)
            {
                upscaleAlgorithm = "nearestneighbor";
                SetAlgorithm();
                SakuraBox.Refresh();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Environment.Exit(0);
            }
            else if (e.KeyCode == Keys.E)
            {
                SakuraButtonEmpty_Click(null, null);
            }
            else if (e.KeyCode == Keys.T)
            {
                SakuraCkBanner.Checked = !banner;
            }
            else if (e.KeyCode == Keys.I)
            {
                SakuraCkInfo.Checked = !info;
            }
            else if (e.KeyCode == Keys.Q)
            {
                SakuraCkSubFolders.Checked = !loadSubFolders;
            }
            else if (e.KeyCode == Keys.U)
            {
                SakuraCkCounter.Checked = !counter;
            }
            else if (e.KeyCode == Keys.D)
            {
                SakuraCkDuplicates.Checked = !duplicate;
            }
            else if (e.KeyCode == Keys.A)
            {
                SakuraCkAlwaysOnTop.Checked = !this.TopMost;
            }
            else if (e.KeyCode == Keys.Oemcomma)
            {
                ToggleSettings();
            }
            else if (e.KeyCode == Keys.OemBackslash)
            {
                SakuraCkLoop.Checked = !loop;
            }
            else if (e.KeyCode == Keys.Oem7)
            {
                SakuraCkMetadata.Checked = !metadata;
            }
            else if (e.KeyCode == Keys.C)
            {
                SakuraCkConsole.Checked = !console;
            }
            else if (e.KeyCode == Keys.K)
            {
                SakuraButtonClearConsole_Click(null, null);
            }
            else if (e.KeyCode == Keys.P)
            {
                SakuraButton10Lines_Click(null, null);
            }
            else if (e.KeyCode == Keys.O)
            {
                SakuraButtonDirectory_Click(null, null);
            }
            else if (e.KeyCode == Keys.F)
            {
                SakuraButtonOpenFiles_Click(null, null);
            }
            else if (e.KeyCode == Keys.X)
            {
                SakuraButtonSwapH_Click(null,null);
            }
            else if (e.KeyCode == Keys.Y)
            {
                SakuraButtonSwapV_Click(null, null);
            }
            else if (e.KeyCode == Keys.R)
            {
                SakuraButtonRotate_Click(null, null);
            }
            else if (e.KeyCode == Keys.G)
            {
                SakuraButtonGithub_Click(null, null);
            }
            else if (e.KeyCode == Keys.S)
            {
                SakuraButtonSave_Click(null, null);
            }
            else if (e.KeyCode == Keys.Left)
            {
                ViewImage(currentImage - 1);
            }
            else if (e.KeyCode == Keys.Right)
            {
                ViewImage(currentImage + 1);
            }
            else if (e.KeyCode == Keys.Up)
            {
                ViewImage(0);
            }
            else if (e.KeyCode == Keys.Down)
            {
                ViewImage(imagesPath.Count - 1);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                ScaleImage();
            }
            else if (e.KeyCode == Keys.Oemplus || e.KeyCode == Keys.Add)
            {
                UpscaleImage();
            }
            else if (e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract)
            {
                DownscaleImage();
            }
            else if (e.KeyCode == Keys.Z)
            {
                ScaleImage(); // TODO
            }
        }

        private void SakuraView_ClientSizeChanged(object sender, EventArgs e)
        {
            if (prevent_execution || this.WindowState == FormWindowState.Minimized)
                return;
            prevent_execution = true;
            ScaleImage();
            if (SakuraInfo.Width > ClientSize.Width)
            {
                ScaleInfo();
                SakuraInfo.Text = SakuraHidden.Text;
            }
            else if (fixed_padding == 0 && SakuraInfo.Width > ClientSize.Width >> 1)
            {
                padding = 30;
                ScaleInfo();
                SakuraInfo.Text = SakuraHidden.Text;
            }
            Task.Delay(20).ContinueWith(t => endthis());
        }

        public void endthis()
        {
            prevent_execution = false;
        }
        public void addPictureBox()
        {
            this.SuspendLayout();
            PictureBoxWithInterpolationMode NewSakuraBox;
            // 
            // SakuraBox
            //
            NewSakuraBox = new PictureBoxWithInterpolationMode();
            ((System.ComponentModel.ISupportInitialize)(NewSakuraBox)).BeginInit();

            NewSakuraBox.Enabled = false;
            NewSakuraBox.ErrorImage = null;
            NewSakuraBox.InitialImage = null;
            NewSakuraBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            NewSakuraBox.Location = new System.Drawing.Point(0, 0);
            NewSakuraBox.Margin = new System.Windows.Forms.Padding(0);
            NewSakuraBox.Name = "SakuraBox";
            NewSakuraBox.Size = new System.Drawing.Size(67, 62);
            NewSakuraBox.TabIndex = 0;
            NewSakuraBox.TabStop = false;




            ((System.ComponentModel.ISupportInitialize)(NewSakuraBox)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void SakuraMetadata_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                metadataLocation.X += e.X - mouse_x;
                metadataLocation.Y += e.Y - mouse_y;
                SakuraMetadata.Location = metadataLocation;
                if (prevent_execution || this.WindowState == FormWindowState.Minimized)
                    return;
                prevent_execution = true;
                PlaceMetadata();
                Task.Delay(500).ContinueWith(t => endthis());
            }
            else if (e.Button == MouseButtons.Right)
            {
                metadataLocation.X += e.X - mouse_x;
                metadataLocation.Y += e.Y - mouse_y;
                SakuraMetadata.Location = metadataLocation;
                if (prevent_execution || this.WindowState == FormWindowState.Minimized)
                    return;
                prevent_execution = true;
                UpPlaceMetadata();
                Task.Delay(500).ContinueWith(t => endthis());
            }

        }

        private void SakuraConsole_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                consoleLocation.X += e.X - mouse_x;
                consoleLocation.Y += e.Y - mouse_y;
                SakuraConsole.Location = consoleLocation;
            }
        }

        private void SakuraMetadata_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void SakuraConsole_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void ToggleSettings()
        {
            SakuraZoomLabel.Visible = !SakuraZoomLabel.Visible;
            SakuraZoomNumeric.Visible = !SakuraZoomNumeric.Visible;
            SakuraZoomTrackBar.Visible = !SakuraZoomTrackBar.Visible;
            SakuraButton10Lines.Visible = !SakuraButton10Lines.Visible;
            SakuraButtonClearConsole.Visible = !SakuraButtonClearConsole.Visible;
            SakuraButtonDirectory.Visible = !SakuraButtonDirectory.Visible;
            SakuraButtonEmpty.Visible = !SakuraButtonEmpty.Visible;
            SakuraButtonGithub.Visible = !SakuraButtonGithub.Visible;
            SakuraButtonOpenFiles.Visible = !SakuraButtonOpenFiles.Visible;
            SakuraButtonRotate.Visible = !SakuraButtonRotate.Visible;
            SakuraButtonSave.Visible = !SakuraButtonSave.Visible;
            SakuraButtonSwapH.Visible = !SakuraButtonSwapH.Visible;
            SakuraButtonSwapV.Visible = !SakuraButtonSwapV.Visible;
            SakuraButtonHideSettings.Visible = !SakuraButtonHideSettings.Visible;
            SakuraCkAlwaysOnTop.Visible = !SakuraCkAlwaysOnTop.Visible;
            SakuraCkBanner.Visible = !SakuraCkBanner.Visible;
            SakuraCkConsole.Visible = !SakuraCkConsole.Visible;
            SakuraCkCounter.Visible = !SakuraCkCounter.Visible;
            SakuraCkDuplicates.Visible = !SakuraCkDuplicates.Visible;
            SakuraCkHelp.Visible = !SakuraCkHelp.Visible;
            SakuraCkInfo.Visible = !SakuraCkInfo.Visible;
            SakuraCkLoop.Visible = !SakuraCkLoop.Visible;
            SakuraCkMetadata.Visible = !SakuraCkMetadata.Visible;
            SakuraCkSubFolders.Visible = !SakuraCkSubFolders.Visible;
            SakuraBgColor.Visible = !SakuraBgColor.Visible;
            SakuraBgColorLabel.Visible = !SakuraBgColorLabel.Visible;
            SakuraTextColor.Visible = !SakuraTextColor.Visible;
            SakuraTextColorLabel.Visible = !SakuraTextColorLabel.Visible;
            SakuraImgcvtLabel.Visible = !SakuraImgcvtLabel.Visible;
            SakuraImgcvt.Visible = !SakuraImgcvt.Visible;
            this.Focus();
        }

        private void SakuraButtonEmpty_Click(object sender, EventArgs e)
        {
            images.Clear();
            imagesPath.Clear();
            imagesInfo.Clear();
            imagesType.Clear();
            imagesMetadata.Clear();
            SakuraInfo.Text = "";
            GC.Collect(2, GCCollectionMode.Forced, false, false);
        }

        private void SakuraButtonOpenFiles_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new OpenFileDialog
            {
                Title = "Select some pictures",
                Filter = "Picture|*.bmp;*.png;*.jfif;*.jpg;*.jpeg;*.jpg;*.ico;*.gif;*.tif;*.tiff;*.rle;*.dib|Texture|*.bti;*.tex0;*.tpl|All files (*.*)|*.*",
                RestoreDirectory = true,
                CheckFileExists = true,
                CheckPathExists = true,
                InitialDirectory = Environment.CurrentDirectory,
                Multiselect = true
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                LoadFiles(dialog.FileNames);
                //LoadFolder(dialog.FileName.Replace("\\", "/"));
                Environment.CurrentDirectory = Path.GetDirectoryName(dialog.FileName.Replace("\\", "/"));
            }
        }

        private void SakuraButtonGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.github.com/yoshkami/SakuraView/releases/latest");
        }

        private void SakuraButtonClearConsole_Click(object sender, EventArgs e)
        {
            this.SakuraConsole.Text = "";
        }

        private void SakuraButtonDirectory_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    LoadFolder(fbd.SelectedPath);
                    Environment.CurrentDirectory = fbd.SelectedPath;
                }
            }
        }

        private void SakuraButton10Lines_Click(object sender, EventArgs e)
        {
            string[] lines = this.SakuraConsole.Text.Split('\n');

            // Check if there are at least 10 lines
            if (lines.Length > 10)
            {
                // Join lines starting from the 11th line
                this.SakuraConsole.Text = string.Join("\n", lines.Skip(10));

                // Now, textAfter10thLine contains the text after the 10th line separator
            }
            else
            {
                // Handle the case where there are not enough lines
                this.SakuraConsole.Text = "";
            }
        }

        private void SakuraButtonRotate_Click(object sender, EventArgs e)
        {
            SakuraBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            SakuraBox.Refresh();
        }

        private void SakuraButtonSwapV_Click(object sender, EventArgs e)
        {
            SakuraBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            SakuraBox.Refresh();
        }

        private void SakuraButtonSwapH_Click(object sender, EventArgs e)
        {
            SakuraBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            SakuraBox.Refresh();
        }

        private void SakuraButtonSave_Click(object sender, EventArgs e)
        {
            txt[2] = upscaleAlgorithm;
            txt[4] = upscaleMode;
            txt[6] = windowPosition;
            txt[8] = SakuraTextColor.Text;
            txt[10] = SakuraBgColor.Text;
            txt[12] = fixed_padding.ToString();
            txt[14] = mode.ToString();
            txt[16] = metadataLength.ToString();
            txt[18] = SakuraImgcvt.Text;
            if (this.TopMost) { txt[20] = "true"; } else { txt[20] = "false"; }
            if (banner) { txt[22] = "view"; } else { txt[22] = "hide"; }
            if (this.SakuraConsole.Visible) { txt[24] = "view"; } else { txt[24] = "hide"; }
            if (duplicate) { txt[26] = "true"; } else { txt[26] = "false"; }
            if (help) { txt[28] = "view"; } else { txt[28] = "hide"; }
            if (info) { txt[30] = "view"; } else { txt[30] = "hide"; }
            if (loop) { txt[32] = "true"; } else { txt[32] = "false"; }
            if (metadata) { txt[34] = "view"; } else { txt[34] = "hide"; }
            if (loadSubFolders) { txt[36] = "true"; } else { txt[36] = "false"; }
            if (counter) { txt[38] = "true"; } else { txt[38] = "false"; }
            try { System.IO.File.WriteAllLines(execPath + "SakuraView.txt", txt); }
            catch { } // continue execution without saving
        }

        private void SakuraCkAlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = this.TopMost != true;
            SakuraConsole.Text += "\nthis.TopMost = " + this.TopMost;
        }

        private void SakuraCkBanner_CheckedChanged(object sender, EventArgs e)
        {
            banner = !banner;
            SetBanner();
        }

        private void SakuraCkConsole_CheckedChanged(object sender, EventArgs e)
        {
            console = !console;
            this.SakuraConsole.Visible = this.SakuraConsole.Visible != true;
        }

        private void SakuraCkDuplicates_CheckedChanged(object sender, EventArgs e)
        {
            duplicate = duplicate != true;
            SakuraConsole.Text += "\nduplicate = " + duplicate;
        }

        private void SakuraCkHelp_CheckedChanged(object sender, EventArgs e)
        {
            help = help != true;
            SetHelp();
        }

        private void SakuraCkInfo_CheckedChanged(object sender, EventArgs e)
        {
            info = info != true;
            SetInfo();
        }

        private void SakuraCkLoop_CheckedChanged(object sender, EventArgs e)
        {
            loop = loop != true;
            SakuraConsole.Text += "\nloop = " + loop;
        }

        private void SakuraCkMetadata_CheckedChanged(object sender, EventArgs e)
        {
            metadata = !metadata;
            SakuraMetadata.Visible = metadata;
            SakuraConsole.Text += "\nmetadata = " + metadata;
        }

        private void SakuraCkSubFolders_CheckedChanged(object sender, EventArgs e)
        {
            loadSubFolders = loadSubFolders != true;
            SakuraConsole.Text += "\nloadSubFolders = " + loadSubFolders;
        }

        private void SakuraCkCounter_CheckedChanged(object sender, EventArgs e)
        {
            counter = counter != true;
            SakuraConsole.Text += "\ncounter = " + counter;
        }

        private void SakuraZoomTrackBar_Scroll(object sender, EventArgs e)
        {

        }

        private void SakuraZoomNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SakuraTextColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTextColour(SakuraTextColor.Text);
        }

        private void SakuraBgColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetBackgroundColour(SakuraBgColor.Text);
        }

        private void SakuraButtonHideSettings_Click(object sender, EventArgs e)
        {
            ToggleSettings();
        }
    }
}