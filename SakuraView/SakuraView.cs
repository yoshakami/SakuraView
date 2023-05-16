using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using Webp;  // Webp.cs

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
        static string upscaleMode;
        static int width;
        static int height;
        static int widthSpan;
        static int heightSpan;
        static int bottomSpace = 0;
        static int screenWidth;
        static int screenHeight;
        static int currentImage;
        static int bannerHeight;
        static int topSpace = 0;
        static int x;
        static int y;
        static bool help = false;
        static bool info = false;
        static bool banner = false;
        static List<string> imagePaths = new List<string>();
        static List<Image> images = new List<Image>();
        static string[] new_lines = { "SakuraView v1.0", "Scale Algorithm {Bicubic, Bilinear, Default, High, HighQualityBicubic, HighQualityBilinear, Low, NearestNeighbor}", "High",  // config[2]
            "Scale mode {Fill, Fit, Stretch, VanillaFit, VanillaFill, Center}","VanillaFit",  // config[4]
            "Window Location Window Location {Minimized, Normal, Maximized, Normal2, Maximized2}", "Normal",  // config[6]
            "Text Colour (System.Drawing.Color)", "White",  // config[8]
            "Background Colour", "Black",  // config[10]
            "Banner {View, Hide}", "View",  // config[12]
            "Help {View, Hide}", "View",  // config[14]
            "Info {View, Hide}", "View",  // config[16]
            "Always On Top {True, False}", "False"};  // config[18]
        // when escape is pressed 
        // Environment.Exit(0);
        public SakuraView()
        {
            InitializeComponent();
            try
            {
                bannerHeight = this.Height;
                FormBorderStyle = FormBorderStyle.None;
                bannerHeight -= bannerHeight;
                string[] config = System.IO.File.ReadAllLines(execPath + "SakuraView.txt");
                SetAlgorithm(config[2]);
                upscaleMode = config[4].ToLower();
                SetSizeMode();
                SetWindowPosition(config[6]);
                SetTextColour(config[8]);
                SetBackgroundColour(config[10]);
                banner = config[12].ToLower() == "view";
                SetBanner(true);
                help = config[14].ToLower() == "view";
                SetHelp(true);
                info = config[16].ToLower() == "view";
                SetInfo(true);
                this.TopMost = config[18].ToLower() == "true";
            }
            catch
            {

                upscaleMode = "vanillafit";
                this.WindowState = FormWindowState.Normal;
                System.IO.File.WriteAllLines(execPath + "SakuraView.txt", new_lines);
            }
            string[] args = Environment.GetCommandLineArgs();
            Console.WriteLine(args);
            if (args.Length > 1)
            {
                LoadImage(args[1]);
            }

        }
        private void SetBackgroundColour(string backgroundColour)
        {
            this.BackColor = System.Drawing.Color.FromName(backgroundColour);
            SakuraBox.BackColor = System.Drawing.Color.FromName(backgroundColour);
        }
        private void SetTextColour(string textColour)
        {

            SakuraInfo.ForeColor = System.Drawing.Color.FromName(textColour);
            SakuraHelp.ForeColor = System.Drawing.Color.FromName(textColour);
        }
        private void SetBanner(bool init = false)
        {
            if (banner)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                topSpace += bannerHeight;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.None;
                if (!init)
                {
                    topSpace -= bannerHeight;
                }
            }
        }
        private void SetHelp(bool init = false)
        {
            if (!help)
            {
                SakuraHelp.Visible = false;
                if (!info)
                {
                    bottomSpace += SakuraHelp.Height;  // add the height of SakuraHelp
                } else
                {
                    bottomSpace += SakuraHelp.Height + 50;  // add the height of SakuraHelp + padding

                }
            }
            else
            {
                SakuraHelp.Visible = true;
                if (!init)
                {
                    if (!info)
                    {
                        bottomSpace -= SakuraHelp.Height;  // sub the height of SakuraHelp
                    }
                    else
                    {
                        bottomSpace -= SakuraHelp.Height + 50;  // sub the height of SakuraHelp + padding

                    }
                }
            }
        }
        private void SetInfo(bool init = false)
        {
            if (!info)
            {
                SakuraInfo.Visible = false;
                bottomSpace += SakuraInfo.Height;
            }
            else
            {
                SakuraInfo.Visible = true;
                if (!init)
                {
                    if (help)
                    {
                        bottomSpace -= SakuraInfo.Height + 50;
                    } else
                    {
                        bottomSpace -= SakuraInfo.Height;
                    }
                }
            }
        }
        private void SetAlgorithm(string upscaleAlgorithm)
        {
            switch (upscaleAlgorithm.ToLower())
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
        }
        private void SetWindowPosition(string windowPosition)
        {
            switch (windowPosition.ToLower())
            {
                case "minimized":
                    this.WindowState = FormWindowState.Minimized;
                    break;
                case "normal":
                    WindowState = FormWindowState.Normal;
                    for (byte i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        if (Screen.AllScreens[i].Bounds.X == 0)
                        {
                            this.Location = Screen.AllScreens[i].Bounds.Location;
                            UpdateLayout();
                            break;
                        }
                    }
                    break;
                case "normal2":
                    WindowState = FormWindowState.Normal;
                    for (byte i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        if (Screen.AllScreens[i].Bounds.X != 0)
                        {
                            this.Location = Screen.AllScreens[i].Bounds.Location;
                            UpdateLayout();
                            break;
                        }
                    }
                    break;
                case "maximized":
                    for (byte i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        if (Screen.AllScreens[i].Bounds.X == 0)
                        {
                            this.Location = Screen.AllScreens[i].Bounds.Location;
                            SakuraHelp.Location = new Point(0, Screen.AllScreens[i].Bounds.Height - SakuraInfo.Height - 50 - SakuraHelp.Height);
                            SakuraInfo.Location = new Point(0, Screen.AllScreens[i].Bounds.Height - SakuraInfo.Height);
                            break;
                        }
                    }
                    WindowState = FormWindowState.Maximized;
                    break;
                case "maximized2":
                    for (byte i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        if (Screen.AllScreens[i].Bounds.X != 0)
                        {
                            this.Location = Screen.AllScreens[i].Bounds.Location;
                            SakuraHelp.Location = new Point(0, Screen.AllScreens[i].Bounds.Height - SakuraInfo.Height - 50 - SakuraHelp.Height);
                            SakuraInfo.Location = new Point(0, Screen.AllScreens[i].Bounds.Height - SakuraInfo.Height);
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
                    }
                    images.Add(SakuraBox.Image);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input Image");
                    throw e;
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
            //SakuraBox.Size = this.Size;
            ScaleImage();
        }
        private Image LoadImageFromFile(string path)  // allows the image not to be locked by the program
        {
            byte[] bytes = File.ReadAllBytes(path);
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
        }
        private void ScaleImage()
        {
            if (SakuraBox.Image == null) { return; }
            width = SakuraBox.Image.Size.Width;
            height = SakuraBox.Image.Size.Height;
            widthSpan = 0;
            heightSpan = 0;
            for (byte i = 0; i < Screen.AllScreens.Length; i++)
            {
                screenWidth = Screen.AllScreens[i].Bounds.Width;
                screenHeight = Screen.AllScreens[i].Bounds.Height;
                x = Screen.AllScreens[i].Bounds.Location.X;
                y = Screen.AllScreens[i].Bounds.Location.Y;
                if (x < this.Location.X && this.Location.X < (x + screenWidth) && y < this.Location.Y && this.Location.Y < (y + screenHeight))  // finds the screen boundaries the window is currently in
                {
                    if (upscaleMode == "fill")
                    {
                        Fill(screenWidth, screenHeight);
                    }
                    else if (upscaleMode == "fit")  // the highest value becomes the screen bounds
                    {
                        Fit(screenWidth, screenHeight);
                    }
                    else if (upscaleMode == "stretch")
                    {
                        width = screenWidth;
                        height = screenHeight;
                    }
                    else if (upscaleMode != "none" && (width > screenWidth || height > screenHeight))
                    { // upscaleMode == "none" - we downscale the image to the "fit" algorithm
                        if (upscaleMode == "vanillafill")
                        {
                            Fill(screenWidth, screenHeight);
                        }
                        if (upscaleMode == "vanillafit")
                        {
                            Fit(screenWidth, screenHeight);
                        }
                    }
                    SakuraBox.Location = new Point(Screen.AllScreens[i].Bounds.Location.X + widthSpan, Screen.AllScreens[i].Bounds.Location.Y + heightSpan);
                    break;
                }
            }
            SakuraBox.Size = new System.Drawing.Size(width, height);
            Console.WriteLine(SakuraBox.Size);
            Console.WriteLine(SakuraBox.Location);
            if (this.WindowState != FormWindowState.Maximized)
            {
                UpdateLayout();
            }
        }
        private void UpdateLayout()
        {
            this.Size = new System.Drawing.Size(width, height + topSpace + bottomSpace);
            SakuraHelp.Location = new Point(0, height);
            SakuraInfo.Location = new Point(0, height + bottomSpace - SakuraInfo.Height);
        }
        private void Fill(int ScreenWidth, int ScreenHeight)
        {
            if (width < height)
            {
                decimal ratio = width / ScreenWidth;
                width = ScreenWidth;
                heightSpan = height;
                height = (int)(height * ratio);
                heightSpan = Math.Abs(heightSpan - height) >> 1;
            }
            else
            {
                decimal ratio = height / ScreenHeight;
                height = ScreenHeight;
                widthSpan = width;
                width = (int)(width * ratio);
                widthSpan = Math.Abs(widthSpan - width) >> 1;
            }
        }
        private void Fit(int ScreenWidth, int ScreenHeight)
        {
            if (width > height)
            {
                decimal ratio = width / ScreenWidth;
                width = ScreenWidth;
                height = (int)(height * ratio);
            }
            else
            {
                decimal ratio = height / ScreenHeight;
                height = ScreenHeight;
                width = (int)(width * ratio);
            }
        }
        private void SakuraViewClass_DragDrop(object sender, DragEventArgs e)
        {
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);  // gets all the files or folders name that were dragged in an array, but I'll only use the first
            if (file != null) // prevent crashes if it's for example a google chrome favourite that was dragged
            {
                bool isFolder = System.IO.File.GetAttributes(file[0]).HasFlag(System.IO.FileAttributes.Directory);
                if (!isFolder)  // that means it's a file.
                {
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

        }

        private void SakuraView_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("Keydown!" + e.KeyCode);
            if (e.KeyCode == Keys.D1) { ViewImage(1); }
            else if (e.KeyCode == Keys.D2) { ViewImage(2); }
            else if (e.KeyCode == Keys.D3) { ViewImage(3); }
            else if (e.KeyCode == Keys.D4) { ViewImage(4); }
            else if (e.KeyCode == Keys.D5) { ViewImage(5); }
            else if (e.KeyCode == Keys.D6) { ViewImage(6); }
            else if (e.KeyCode == Keys.D7) { ViewImage(7); }
            else if (e.KeyCode == Keys.D8) { ViewImage(8); }
            else if (e.KeyCode == Keys.D9) { ViewImage(9); }
            else if (e.KeyCode == Keys.D0) { ViewImage(imagePaths.Count >> 1); }
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
                SetWindowPosition("normal");
            }
            else if (e.KeyCode == Keys.F10)
            {
                SetWindowPosition("normal2");
            }
            else if (e.KeyCode == Keys.F11)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (e.KeyCode == Keys.F12)
            {
                SetWindowPosition("maximized2");
            }
            else if (e.KeyCode == Keys.B)
            {
                SetAlgorithm("bicubic");
                SakuraBox.Refresh();
            }
            else if (e.KeyCode == Keys.F)
            {
                SetAlgorithm("bilinear");
                SakuraBox.Refresh();
            }
            else if (e.KeyCode == Keys.D)
            {
                SetAlgorithm("default");
                SakuraBox.Refresh();
            }
            else if (e.KeyCode == Keys.H)
            {
                SetAlgorithm("high");
                SakuraBox.Refresh();
            }
            else if (e.KeyCode == Keys.Q)
            {
                SetAlgorithm("highqualitybicubic");
                SakuraBox.Refresh();
            }
            else if (e.KeyCode == Keys.J)
            {
                SetAlgorithm("highqualitybilinear");
                SakuraBox.Refresh();

            }
            else if (e.KeyCode == Keys.L)
            {
                SetAlgorithm("low");
                SakuraBox.Refresh();
            }
            else if (e.KeyCode == Keys.N)
            {
                SetAlgorithm("nearestneighbor");
                SakuraBox.Refresh();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Environment.Exit(0);
            }
            else if (e.KeyCode == Keys.E)
            {
                images.Clear();
                SakuraInfo.Text = "";
                GC.Collect(2, GCCollectionMode.Forced, false, false);
            }
            else if (e.KeyCode == Keys.T)
            {
                if (!banner)
                {
                    banner = true;
                    SetBanner();
                }
                else
                {
                    banner = false;
                    SetBanner();
                }
            }
            else if (e.KeyCode == Keys.I)
            {
                if (!info)
                {
                    info = true;
                    SetInfo();
                }
                else
                {
                    info = false;
                    SetInfo();
                }
            }
            else if (e.KeyCode == Keys.A)
            {
                if (this.TopMost == true)
                {
                    this.TopMost = false;
                }
                else
                {
                    this.TopMost = true;
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
            else if (e.KeyCode == Keys.S)
            {

            }
            else if (e.KeyCode == Keys.Left)
            {
                ViewImage(currentImage - 1);
            }
            else if (e.KeyCode == Keys.Right)
            {
                ViewImage(currentImage - 1);
            }
            else if (e.KeyCode == Keys.Up)
            {
                ViewImage(1);
            }
            else if (e.KeyCode == Keys.Down)
            {
                ViewImage(imagePaths.Count);
            }
        }
    }
}