using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using Webp;  // Webp.cs
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Globalization;

/* vanilla usings:
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using WebPWrapper; */

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
        static byte layout = 1;  // 0 = Project Miku,  1 = SakuraView
        static byte i;
        static byte j;
        static int x;
        static int y;
        static int z;
        static long fileSize;
        static bool windowFound;
        static bool help = true;
        static bool info = true;
        static bool banner = true;
        static bool loadImage;
        static bool prevent_execution;
        static bool duplicate = true;
        static byte currentScreen = 0;
        static string padding = "    ";
        static string currentInfo;
        static string specifier = "F";
        static CultureInfo culture = CultureInfo.CreateSpecificCulture("en-CA");
        static List<Image> images = new List<Image>();
        static List<string> imagesPath = new List<string>();
        static List<string[]> imagesInfo = new List<string[]>();

        static string[] txt;
        // when escape is pressed 
        // Environment.Exit(0);
        public SakuraView()
        {
            SetTxt();
            InitializeComponent();
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
                help = txt[14].ToLower() == "view";
                info = txt[16].ToLower() == "view";
                SetBanner();
                SetHelp(true);
                SetInfo(true);
                SetWindowPosition();
                this.TopMost = txt[18].ToLower() == "true";
                duplicate = txt[20].ToLower() == "true";
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
            Console.WriteLine(args);
            if (args.Length > 1)
            {
                imagesPath.Add(args[1]);  // arg 1 is never a duplicate
                LoadImage(args[1]);
            }
            for (z = 2; z < args.Length; z++)
            {
                if (!duplicate)
                {
                    if (!imagesPath.Contains(args[z]))
                    {
                        imagesPath.Add(args[z]);
                    }
                }
                else
                {
                    imagesPath.Add(args[z]);
                }
            }
        }
        private void SetTxt()
        {
            txt = new string[] {
                "SakuraView v1.0", "Scale Algorithm {Bicubic, Bilinear, Default, High, HighQualityBicubic, HighQualityBilinear, Low, NearestNeighbor}", "High",  // config[2]
            "Scale mode {Fill, Fit, Stretch, VanillaFit, VanillaFill, Center}","Fit",  // config[4]
            "Window Location Window Location {Minimized, Normal, Maximized, Normal2, Maximized2}", "Normal",  // config[6]
            "Text Colour (System.Drawing.Color)", "White",  // config[8]
            "Background Colour", "Black",  // config[10]
            "Banner {View, Hide}", "View",  // config[12]
            "Help {View, Hide}", "View",  // config[14]
            "Info {View, Hide}", "View",  // config[16]
            "Always On Top {True, False}", "False", // config[18]
            "Allow Duplicates {True, False}", "True" // config[20]
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
                    }
                    string[] pictureInfo = { Path.GetFileName(filePath), GetFileSize(), GetPixelFormat(), SakuraBox.Image.Width + "x" + SakuraBox.Image.Height, File.GetCreationTime(filePath).ToString(), upscaleMode, upscaleAlgorithm, (currentImage + 1) + " / " + imagesPath.Count };
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
                    Console.WriteLine("Invalid input Image");
                    // throw e;
                }
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


            Console.WriteLine("hello");
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
        private void LoadInfo()
        {
            SakuraHidden.Text = "";
            padding = "";

            while (SakuraHidden.Width < this.ClientSize.Width - 20)
            {
                padding += " ";
                SakuraHidden.Text = "";
                for (int i = 0; i < imagesInfo[currentImage].Length - 1; i++)
                {
                    SakuraHidden.Text += imagesInfo[currentImage][i] + padding;
                }
                SakuraHidden.Text += imagesInfo[currentImage][imagesInfo[currentImage].Length - 1];
            }
            Console.WriteLine(padding.Length);
            SakuraInfo.Text = SakuraHidden.Text;
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
            if (upscaleMode == "fill" || upscaleMode == "stretch" || upscaleMode == "vanillafill")
            {
                SakuraBox.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            else if (upscaleMode == "fit" || upscaleMode == "vanillafit")
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
            if (SakuraBox.Image == null) { return; }
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
            else if (upscaleMode == "stretch" || upscaleMode == "center")
            {
                setImageBounds();
                height = screenHeight;
                width = screenWidth;
            }
            else if (upscaleMode != "none" && (width > screenWidth || height > screenHeight - bottomSpace))
            { // upscaleMode == "none" - we downscale the image to the "fit" algorithm
                if (upscaleMode == "vanillafill")
                {
                    setImageBounds();
                    Fill();
                }
                if (upscaleMode == "vanillafit")
                {
                    setImageBounds();
                    Fit();
                }
            }
            SakuraBox.Location = new Point(-widthSpan, -heightSpan);
            SakuraBox.Size = new System.Drawing.Size(width + 1, height + 1);  // for some reason there's a pixel of margin.
            Console.WriteLine(SakuraBox.Size);
            Console.WriteLine(SakuraBox.Location);
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
        private void SakuraViewClass_DragDrop(object sender, DragEventArgs e)
        {
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);  // gets all the files or folders name that were dragged in an array, but I'll only use the first
            if (file != null) // prevent crashes if it's for example a google chrome favourite that was dragged
            {
                loadImage = false;
                if (!System.IO.File.GetAttributes(file[0]).HasFlag(System.IO.FileAttributes.Directory))
                {
                    loadImage = true;
                }
                for (z = 0; z < file.Length; z++)
                {
                    if (!System.IO.File.GetAttributes(file[z]).HasFlag(System.IO.FileAttributes.Directory))  // that means it's a file.
                    {
                        if (!duplicate)
                        {
                            if (!imagesPath.Contains(file[z]))
                            {

                                imagesPath.Add(file[z]);
                            }
                        }
                        else
                        {
                            imagesPath.Add(file[z]);
                        }
                    }
                }
                if (loadImage)
                {
                    currentImage = imagesPath.IndexOf(file[0]);
                    LoadImage(file[0]);
                }
            }
        }

        private void SakuraViewClass_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void ViewImage(int imageNumber)
        {
            if (imageNumber < 0)
            {
                if (images.Count > 0 && currentImage != 0)
                {
                    currentImage = 0;
                    SakuraBox.Image = images[currentImage];
                    imagesInfo[0][7] = "1 / " + imagesPath.Count;
                    LoadInfo();
                }

            }
            else if (imageNumber < images.Count)
            {
                if (images[imageNumber] != null)
                {
                    currentImage = imageNumber;
                    SakuraBox.Image = images[currentImage];
                    imagesInfo[imageNumber][7] = (imageNumber + 1) + " / " + imagesPath.Count;
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
            Console.WriteLine("Keydown!" + e.KeyCode);
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
                upscaleMode = "vanillafill";
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
            else if (e.KeyCode == Keys.Z)
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
            else if (e.KeyCode == Keys.C)
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
            else if (e.KeyCode == Keys.D)
            {
                duplicate = duplicate != true;
            }
            else if (e.KeyCode == Keys.A)
            {
                this.TopMost = this.TopMost != true;
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
                System.Diagnostics.Process.Start("https://www.github.com/yoshi2999/SakuraView/releases/latest");
            }
            else if (e.KeyCode == Keys.S)
            {
                txt[2] = upscaleAlgorithm;
                txt[4] = upscaleMode;
                txt[6] = windowPosition;
                // txt[8] is only edited through the config
                // txt[10] is only edited through the config
                if (banner) { txt[12] = "view"; } else { txt[12] = "hide"; }
                if (help) { txt[14] = "view"; } else { txt[14] = "hide"; }
                if (info) { txt[16] = "view"; } else { txt[16] = "hide"; }
                if (this.TopMost) { txt[18] = "true"; } else { txt[18] = "false"; }
                if (duplicate) { txt[20] = "true"; } else { txt[20] = "false"; }
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
        }

        private void SakuraView_ClientSizeChanged(object sender, EventArgs e)
        {
            if (prevent_execution)
                return;
            prevent_execution = true;
            ScaleImage();
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
    }
}