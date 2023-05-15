using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

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
        // when escape is pressed 
        // Environment.Exit(0);
        public SakuraView()
        {
            InitializeComponent();
            if (System.IO.File.Exists(execPath + "SakuraView.txt"))
            {
                string[] config = System.IO.File.ReadAllLines(execPath + "SakuraView.txt");
                SetAlgorithm(config[2]);
                upscaleMode = config[4].ToLower();
                SetWindowPosition(config[6]);
                SetBanner(config[8]);

            }
            else
            {
                string[] new_lines = { "SakuraView v1.0", "Scale Algorithm {Bicubic, Bilinear, Default, High, HighQualityBicubic, HighQualityBilinear, Invalid, Low, NearestNeighbor}", "High", "Scale mode {Fill, Fit, Stretch, VanillaFit, VanillaFill, None", "VanillaFit", "Window Location Window Location (\"Minimized\", \"Normal\", \"Maximized\", \"Normal2\", \"Maximized2\")", "Normal", "Banner {View, Hide}", "Hide" };
                upscaleMode = "vanilla";
                FormBorderStyle = FormBorderStyle.None;
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
        private void SetBanner (string banner)
        {
            if (banner.ToLower() == "hide")
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
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
                case "invalid":
                    SakuraBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Invalid;
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
                case "maximized":
                    WindowState = FormWindowState.Maximized;
                    break;
                case "normal":
                    for (byte i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        if (Screen.AllScreens[i].Bounds.X == 0)
                        {
                            this.Location = Screen.AllScreens[i].Bounds.Location;
                            break;
                        }
                    }
                    break;
                case "normal2":
                    for (byte i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        if (Screen.AllScreens[i].Bounds.X != 0)
                        {
                            this.Location = Screen.AllScreens[i].Bounds.Location;
                        }
                    }
                    break;
                case "maximized2":
                    for (byte i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        if (Screen.AllScreens[i].Bounds.X != 0)
                        {
                            this.Location = Screen.AllScreens[i].Bounds.Location;
                        }
                    }
                    WindowState = FormWindowState.Maximized;
                    break;
            }
        }
        private void LoadImage(String filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower();
            SakuraBox.Image = Image.FromFile(filePath);
            ScaleImage();
        }
        private void ScaleImage()
        {
            width = SakuraBox.Image.Size.Width;
            height = SakuraBox.Image.Size.Height;
            widthSpan = 0;
            heightSpan = 0;
            for (byte i = 0; i < Screen.AllScreens.Length; i++)
            {
                if (Screen.AllScreens[i].Bounds.X == 0)
                {
                    if (upscaleMode == "fill")
                    {
                        Fill(Screen.AllScreens[i].Bounds.Width, Screen.AllScreens[i].Bounds.Height);
                    }
                    else if (upscaleMode == "fit")  // the highest value becomes the screen bounds
                    {
                        Fit(Screen.AllScreens[i].Bounds.Width, Screen.AllScreens[i].Bounds.Height);
                    }
                    else if (upscaleMode == "stretch")
                    {
                        width = Screen.AllScreens[i].Bounds.Width;
                        height = Screen.AllScreens[i].Bounds.Height;
                    }
                    else if (upscaleMode != "none" && (width > Screen.AllScreens[i].Bounds.Width || height > Screen.AllScreens[i].Bounds.Height))
                    { // upscaleMode == "none" - we downscale the image to the "fit" algorithm
                        if (upscaleMode == "vanillafill")
                        {
                            Fill(Screen.AllScreens[i].Bounds.Width, Screen.AllScreens[i].Bounds.Height);
                        }
                        if (upscaleMode == "vanillafit")
                        {
                            Fit(Screen.AllScreens[i].Bounds.Width, Screen.AllScreens[i].Bounds.Height);
                        }
                    }
                    SakuraBox.Location = new Point(Screen.AllScreens[i].Bounds.Location.X + widthSpan, Screen.AllScreens[i].Bounds.Location.Y + heightSpan);
                    break;
                }
            }
            this.Size = new System.Drawing.Size(width, height);
            SakuraBox.Size = this.Size;
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
    }
}