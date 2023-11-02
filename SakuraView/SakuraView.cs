﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using Webp;  // Webp.cs
using System.Threading.Tasks;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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
        static byte mode = 0; // 0 = ImageViewer; 1 = ImageExplorer; 2 = TextViewer; 3 = TextExplorer; 4 = TextEditor; 5 = Settings; 6 = SongExplorer
        static byte currentScreen = 0;
        static byte padding = 30;
        static string currentInfo;
        static string text;
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
                banner = txt[12].ToLower() == "view";
                this.SakuraConsole.Visible = txt[14].ToLower() == "view";
                help = txt[16].ToLower() == "view";
                info = txt[18].ToLower() == "view";
                SetBanner();
                SetHelp(true);
                SetInfo(true);
                SetWindowPosition();
                this.TopMost = txt[20].ToLower() == "true";
                duplicate = txt[22].ToLower() == "true";
                counter = txt[24].ToLower() == "true";
                loadSubFolders = txt[26].ToLower() == "true";
                loop = txt[28].ToLower() == "true";
                mode = byte.Parse(txt[30]);
                metadataLength = ushort.Parse(txt[32]);
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
        }
        private void SetMode()
        {
            if (mode == 0) // ImageViewer
            {

            }
        }
        private void SetTxt()
        {
            txt = new string[] {
                "SakuraView v1.0", "Scale Algorithm {Bicubic, Bilinear, Default, High, HighQualityBicubic, HighQualityBilinear, Low, NearestNeighbor}", "High",  // config[2]
            "Scale mode {Fill, Fit, Stretch, VanillaFit, LeftFit, Center}","Fit",  // config[4]
            "Window Location Window Location {Minimized, Normal, Maximized, Normal2, Maximized2}", "Normal",  // config[6]
            "Text Colour (System.Drawing.Color)", "White",  // config[8]
            "Background Colour", "Black",  // config[10]
            "Banner {View, Hide}", "View",  // config[12]
            "Console {View, Hide}", "View",  // config[14]
            "Help {View, Hide}", "View",  // config[16]
            "Info {View, Hide}", "View",  // config[18]
            "Always On Top {True, False}", "False", // config[20]
            "Allow Duplicates {True, False}", "False", // config[22]
            "Counter {True, False}", "True", // config[24]
            "Load sub-folders {True, False}", "True", // config[26]
            "Loop {True, False}", "True", // config[28]
            "Mode {0, 1, 2, 3, 4, 5, 6}", "0", // config[30]
            "Metadata Length (in character count per line)", "200", // config[32]
             };
        }
        private void SetBackgroundColour(string backgroundColour)
        {
            this.BackColor = System.Drawing.Color.FromName(backgroundColour);
            SakuraBox.BackColor = System.Drawing.Color.FromName(backgroundColour);
        }
        private void SetTextColour(string textColour)
        {

            SakuraInfo.ForeColor = System.Drawing.Color.FromName(textColour);
            SakuraSideHelp.ForeColor = System.Drawing.Color.FromName(textColour);
            SakuraHelp.ForeColor = System.Drawing.Color.FromName(textColour);
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
            if (imagesType[imageNumber] == 0 || !counter) // png
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
                            SakuraMetadata.Text = SakuraMetadata.Text = Encoding.UTF8.GetString(textBytes, 0x29, x).Replace('\0', '\n');
                            return;
                        }
                        string text = Encoding.UTF8.GetString(textBytes, 0x34, x).Trim();
                        text = text.Split('\x00')[0].Trim();
                        /*
                        string[] textParts = text.Split(new[] { "Negative prompt: " }, StringSplitOptions.RemoveEmptyEntries);

                        if (textParts.Length == 1)
                        {
                            string[] promptParts = textParts[0].Split(new[] { "Steps: " }, StringSplitOptions.RemoveEmptyEntries);

                            if (promptParts.Length > 0 && promptParts[0] != "")
                            {
                                output += " prompt:" + promptParts[0].Substring(0, promptParts[0].Length - 2).Replace("\\n", "\n");
                            }
                        }
                        else
                        {
                            if (textParts[0] != "")
                            {
                                output += " prompt:" + textParts[0].Substring(0, textParts[0].Length - 2).Replace("\\n", "\n");
                            }

                            string[] stepsParts = textParts[1].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                            output += " negative_prompt:" + stepsParts[0].Substring(0, stepsParts[0].Length - 2).Replace("\\n", "\n");
                            string steps = stepsParts[0];
                            output += " steps:" + steps;
                        }  */

                        string[] textLines = text.Split('\n');
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
                        }
                        output[2] = GetParamValue(textLines[j], "Steps:");
                        output[3] = GetParamValue(textLines[j], "Sampler:");
                        output[4] = GetParamValue(textLines[j], "CFG scale:");
                        output[5] = GetParamValue(textLines[j], "Seed:");

                        text = GetParamValue(textLines[j], "Size:");
                        if (text.Contains("x"))
                        {
                            string[] dimensions = text.Split('x');
                            output[6] = dimensions[0];  // width
                            output[7] = dimensions[1];  // height
                        }
                        text = GetParamValue(textLines[j], "Variation seed:");
                        if (!string.IsNullOrEmpty(text))
                        {
                            output[8] = text;  // subseed
                        }
                        text = GetParamValue(textLines[j], "Variation seed strength:");
                        if (!string.IsNullOrEmpty(text))
                        {
                            output[9] = text;  // subseed strength between 0.0 and 1.0
                        }
                        output[10] = GetParamValue(textLines[j], "Model:");
                        string[] loraSplit = textLines[j].Split(new string[] { "Lora hashes: \"" }, StringSplitOptions.None);
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
        private void PlaceMetadata()
        {
            SakuraMetadata.Text = "";
            if (imagesMetadata[currentImage] == null)
                return;
            FillMetadata();
            while (SakuraMetadata.Location.X + SakuraHidden.Width > screenWidth && metadataLength > 20)
            {
                metadataLength -= 5;
                FillMetadata();
            }
            SakuraMetadata.Text = SakuraHidden.Text;
        }
        private void FillMetadata()
        {
            SakuraHidden.Text = "";
            for (i = 0; i < 2; i++)
            {
                if (!string.IsNullOrEmpty(imagesMetadata[currentImage][i]))
                    SakuraHidden.Text += pngMetadata[i] + "\n" + WrapText(imagesMetadata[currentImage][i], metadataLength) + "\n\n";
            }
            for (; i < imagesMetadata[currentImage].Length - 1; i++)
            {
                if (!string.IsNullOrEmpty(imagesMetadata[currentImage][i]))
                    SakuraHidden.Text += pngMetadata[i] + imagesMetadata[currentImage][i] + "\n";
            }
            if (!string.IsNullOrEmpty(imagesMetadata[currentImage][i]))
                SakuraHidden.Text += pngMetadata[i] + imagesMetadata[currentImage][i] + "\n"; // for the last one I won't put a new line at the end
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
        private void ScaleInfo()
        {
            if (currentImage > imagesInfo.Count)
                currentImage = imagesInfo.Count - 1;
            SakuraHidden.Text = "";
            for (int i = 0; i < imagesInfo[currentImage].Length - 1; i++)
            {
                SakuraHidden.Text += Fill(imagesInfo[currentImage][i], padding);
            }
            SakuraHidden.Text += imagesInfo[currentImage][imagesInfo[currentImage].Length - 1];
            if (SakuraHidden.Width > ClientSize.Width && padding != 1)
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
            windowFound = false;
            for (i = 0; i < Screen.AllScreens.Length; i++)
            {
                screenWidth = this.ClientSize.Width;
                screenHeight = this.ClientSize.Height;
                x = Screen.AllScreens[i].Bounds.Location.X;
                y = Screen.AllScreens[i].Bounds.Location.Y;
                if (x <= this.Location.X && this.Location.X <= (x + screenWidth) && y <= this.Location.Y && this.Location.Y <= (y + screenHeight))  // finds the screen boundaries the window is currently in
                {
                    windowFound = true;
                    break;
                }
            }
            if (!windowFound)
            {
                screenWidth = this.ClientSize.Width;
                screenHeight = this.ClientSize.Height;
                x = Screen.AllScreens[currentScreen].Bounds.Location.X;
                y = Screen.AllScreens[currentScreen].Bounds.Location.Y;
            }
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
            string[] file = Directory.GetFiles(currentDirectory);
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
            SakuraConsole.Text += "\nKeydown!" + e.KeyCode;
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
                if (!help)
                {
                    help = true;
                    SetHelp();
                }
                else
                {
                    help = false;
                    SetHelp();
                }
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
                images.Clear();
                imagesPath.Clear();
                imagesInfo.Clear();
                SakuraInfo.Text = "";
                GC.Collect(2, GCCollectionMode.Forced, false, false);
            }
            else if (e.KeyCode == Keys.T)
            {
                banner = banner != true;
                SetBanner();
            }
            else if (e.KeyCode == Keys.I)
            {
                info = info != true;
                SetInfo();
            }
            else if (e.KeyCode == Keys.Q)
            {
                loadSubFolders = loadSubFolders != true;
                SakuraConsole.Text += "\nloadSubFolders = " + loadSubFolders;
            }
            else if (e.KeyCode == Keys.U)
            {
                counter = counter != true;
                SakuraConsole.Text += "\ncounter = " + counter;
            }
            else if (e.KeyCode == Keys.D)
            {
                duplicate = duplicate != true;
                SakuraConsole.Text += "\nduplicate = " + duplicate;
            }
            else if (e.KeyCode == Keys.A)
            {
                this.TopMost = this.TopMost != true;
                SakuraConsole.Text += "\nthis.TopMost = " + this.TopMost;
            }
            else if (e.KeyCode == Keys.OemBackslash)
            {
                loop = loop != true;
                SakuraConsole.Text += "\nloop = " + loop;
            }
            else if (e.KeyCode == Keys.Oem7)
            {
                SakuraMetadata.Visible = SakuraMetadata.Visible != true;
                SakuraConsole.Text += "\nmetadata = " + SakuraMetadata.Visible;
            }
            else if (e.KeyCode == Keys.C)
            {
                this.SakuraConsole.Visible = this.SakuraConsole.Visible != true;
            }
            else if (e.KeyCode == Keys.K)
            {
                this.SakuraConsole.Text = "";
            }
            else if (e.KeyCode == Keys.P)
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
            else if (e.KeyCode == Keys.O)
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
            else if (e.KeyCode == Keys.F)
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
            else if (e.KeyCode == Keys.X)
            {
                SakuraBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                SakuraBox.Refresh();
            }
            else if (e.KeyCode == Keys.Y)
            {
                SakuraBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
                SakuraBox.Refresh();
            }
            else if (e.KeyCode == Keys.R)
            {
                SakuraBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                SakuraBox.Refresh();
            }
            else if (e.KeyCode == Keys.G)
            {
                System.Diagnostics.Process.Start("https://www.github.com/yoshkami/SakuraView/releases/latest");
            }
            else if (e.KeyCode == Keys.S)
            {
                txt[2] = upscaleAlgorithm;
                txt[4] = upscaleMode;
                txt[6] = windowPosition;
                // txt[8] is only edited through the config
                // txt[10] is only edited through the config
                if (banner) { txt[12] = "view"; } else { txt[12] = "hide"; }
                if (this.SakuraConsole.Visible) { txt[14] = "view"; } else { txt[14] = "hide"; }
                if (help) { txt[16] = "view"; } else { txt[16] = "hide"; }
                if (info) { txt[18] = "view"; } else { txt[18] = "hide"; }
                if (this.TopMost) { txt[20] = "true"; } else { txt[20] = "false"; }
                if (duplicate) { txt[22] = "true"; } else { txt[22] = "false"; }
                if (counter) { txt[24] = "true"; } else { txt[24] = "false"; }
                if (loadSubFolders) { txt[26] = "true"; } else { txt[26] = "false"; }
                if (loop) { txt[28] = "true"; } else { txt[28] = "false"; }
                txt[30] = mode.ToString();
                txt[32] = metadataLength.ToString();
                try { System.IO.File.WriteAllLines(execPath + "SakuraView.txt", txt); }
                catch { } // continue execution without saving
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
            else if (SakuraInfo.Width > ClientSize.Width >> 1)
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
    }
}