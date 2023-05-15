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
            if (System.IO.File.Exists(execPath + "SakuraView.txt"))
            {
                string[] config = System.IO.File.ReadAllLines(execPath + "SakuraView.txt");
                SetAlgorithm(config[2]);
                SetWindowPosition(config[6]);
                upscaleMode = config[4].ToLower();

            }
            else
            {
                string[] new_lines = { "SakuraView v1.0", "Scale Algorithm {Bicubic, Bilinear, Default, High, HighQualityBicubic, HighQualityBilinear, Invalid, Low, NearestNeighbor}", "High", "Scale mode {Fill, Fit, Stretch, VanillaFit, VanillaFill, None", "VanillaFit", "Window Location (\"Minimized\", \"Normal\", \"Maximized\", \"Bottom_left\", \"Left\", \"Top_left\", \"Top\", \"Top_right\", \"Right\", \"Bottom_right\", \"Bottom\")", "Normal", "Banner {View, Hide}", "Hide" };
                upscaleMode = "vanilla";
                this.WindowState = FormWindowState.Normal;
                System.IO.File.WriteAllLines(execPath + "SakuraView.txt", new_lines);
            }
            InitializeComponent();
            string[] args = Environment.GetCommandLineArgs();
            Console.WriteLine(args);
            if (args.Length > 1)
            {
                LoadImage(args[1]);
            }

        }
        private void SetAlgorithm(string upscaleAlgorithm)
        {
            switch (upscaleAlgorithm.ToLower())
            {
                case "bicubic":
                    pictureBox1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bicubic;
                    break;
                case "bilinear":
                    pictureBox1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bilinear;
                    break;
                case "default":
                    pictureBox1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;
                    break;
                case "high":
                    pictureBox1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
                    break;
                case "highqualitybicubic":
                    pictureBox1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    break;
                case "highqualitybilinear":
                    pictureBox1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
                    break;
                case "invalid":
                    pictureBox1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Invalid;
                    break;
                case "low":
                    pictureBox1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;
                    break;
                case "nearestneighbor":
                    pictureBox1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                    break;
            }
        }
        private void SetWindowPosition(string windowPosition)
        {
            switch (windowPosition.ToUpper())
            {
                case "MINIMIZED":
                    this.WindowState = FormWindowState.Minimized;
                    break;
                case "MAXIMIZED":
                    this.WindowState = FormWindowState.Maximized;
                    break;
                case "NORMAL":
                    this.WindowState = FormWindowState.Normal;
                    break;
                case "LEFT":
                    for (byte i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        if (Screen.AllScreens[i].Bounds.X == 0)
                        {
                            this.Size = new Size(Screen.AllScreens[i].Bounds.Width / 2, Screen.AllScreens[i].Bounds.Height);
                            this.Location = Screen.AllScreens[i].Bounds.Location;
                        }
                    }
                    break;
                case "TOP_LEFT":
                    for (byte i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        if (Screen.AllScreens[i].Bounds.X == 0)
                        {
                            this.Size = new Size(Screen.AllScreens[i].Bounds.Width / 2, Screen.AllScreens[i].Bounds.Height / 2);
                            this.Location = Screen.AllScreens[i].Bounds.Location;
                        }
                    }
                    break;
                case "TOP":
                    for (byte i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        if (Screen.AllScreens[i].Bounds.X == 0)
                        {
                            this.Size = new Size(Screen.AllScreens[i].Bounds.Width, Screen.AllScreens[i].Bounds.Height / 2);
                            this.Location = Screen.AllScreens[i].Bounds.Location;
                        }
                    }
                    break;
                case "TOP_RIGHT":
                    for (byte i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        if (Screen.AllScreens[i].Bounds.X == 0)
                        {
                            this.Size = new Size(Screen.AllScreens[i].Bounds.Width / 2, Screen.AllScreens[i].Bounds.Height / 2);
                            this.Location = new Point(Screen.AllScreens[i].Bounds.X + Screen.AllScreens[i].Bounds.Width / 2, Screen.AllScreens[i].Bounds.Y);
                        }
                    }
                    break;
                case "RIGHT":
                    for (byte i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        if (Screen.AllScreens[i].Bounds.X == 0)
                        {
                            this.Size = new Size(Screen.AllScreens[i].Bounds.Width / 2, Screen.AllScreens[i].Bounds.Height);
                            this.Location = new Point(Screen.AllScreens[i].Bounds.X + Screen.AllScreens[i].Bounds.Width / 2, Screen.AllScreens[i].Bounds.Y);
                        }
                    }
                    break;
                case "BOTTOM_RIGHT":
                    for (byte i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        if (Screen.AllScreens[i].Bounds.X == 0)
                        {
                            this.Size = new Size(Screen.AllScreens[i].Bounds.Width / 2, Screen.AllScreens[i].Bounds.Height / 2);
                            this.Location = new Point(Screen.AllScreens[i].Bounds.X + Screen.AllScreens[i].Bounds.Width / 2, Screen.AllScreens[i].Bounds.Y + Screen.AllScreens[i].Bounds.Height / 2);
                        }
                    }
                    break;
                case "BOTTOM":
                    for (byte i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        if (Screen.AllScreens[i].Bounds.X == 0)
                        {
                            this.Size = new Size(Screen.AllScreens[i].Bounds.Width, Screen.AllScreens[i].Bounds.Height / 2);
                            this.Location = new Point(Screen.AllScreens[i].Bounds.X, Screen.AllScreens[i].Bounds.Y + Screen.AllScreens[i].Bounds.Height / 2);
                        }
                    }
                    break;
                case "BOTTOM_LEFT":
                    for (byte i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        if (Screen.AllScreens[i].Bounds.X == 0)
                        {
                            this.Size = new Size(Screen.AllScreens[i].Bounds.Width / 2, Screen.AllScreens[i].Bounds.Height / 2);
                            this.Location = new Point(Screen.AllScreens[i].Bounds.X, Screen.AllScreens[i].Bounds.Y + Screen.AllScreens[i].Bounds.Height / 2);
                        }
                    }
                    break;
                case "1080P":
                    for (byte i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        if (Screen.AllScreens[i].Bounds.X == 0)
                        {
                            this.Size = new Size(1920, 1080);
                            this.Location = Screen.AllScreens[i].Bounds.Location;
                        }
                    }
                    break;
                case "SCREEN2_LEFT":
                    for (byte i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        if (Screen.AllScreens[i].Bounds.X != 0)
                        {
                            this.Size = new Size(Screen.AllScreens[i].Bounds.Width / 2, Screen.AllScreens[i].Bounds.Height);
                            this.Location = Screen.AllScreens[i].Bounds.Location;
                        }
                    }
                    break;
                case "SCREEN2_TOP_LEFT":
                    for (byte i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        if (Screen.AllScreens[i].Bounds.X != 0)
                        {
                            this.Size = new Size(Screen.AllScreens[i].Bounds.Width / 2, Screen.AllScreens[i].Bounds.Height / 2);
                            this.Location = Screen.AllScreens[i].Bounds.Location;
                        }
                    }
                    break;
                case "SCREEN2_TOP":
                    for (byte i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        if (Screen.AllScreens[i].Bounds.X != 0)
                        {
                            this.Size = new Size(Screen.AllScreens[i].Bounds.Width, Screen.AllScreens[i].Bounds.Height / 2);
                            this.Location = Screen.AllScreens[i].Bounds.Location;
                        }
                    }
                    break;
                case "SCREEN2_TOP_RIGHT":
                    for (byte i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        if (Screen.AllScreens[i].Bounds.X != 0)
                        {
                            this.Size = new Size(Screen.AllScreens[i].Bounds.Width / 2, Screen.AllScreens[i].Bounds.Height / 2);
                            this.Location = new Point(Screen.AllScreens[i].Bounds.X + Screen.AllScreens[i].Bounds.Width / 2, Screen.AllScreens[i].Bounds.Y);
                        }
                    }
                    break;
                case "SCREEN2_RIGHT":
                    for (byte i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        if (Screen.AllScreens[i].Bounds.X != 0)
                        {
                            this.Size = new Size(Screen.AllScreens[i].Bounds.Width / 2, Screen.AllScreens[i].Bounds.Height);
                            this.Location = new Point(Screen.AllScreens[i].Bounds.X + Screen.AllScreens[i].Bounds.Width / 2, Screen.AllScreens[i].Bounds.Y);
                        }
                    }
                    break;
                case "SCREEN2_BOTTOM_RIGHT":
                    for (byte i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        if (Screen.AllScreens[i].Bounds.X != 0)
                        {
                            this.Size = new Size(Screen.AllScreens[i].Bounds.Width / 2, Screen.AllScreens[i].Bounds.Height / 2);
                            this.Location = new Point(Screen.AllScreens[i].Bounds.X + Screen.AllScreens[i].Bounds.Width / 2, Screen.AllScreens[i].Bounds.Y + Screen.AllScreens[i].Bounds.Height / 2);
                        }
                    }
                    break;
                case "SCREEN2_BOTTOM":
                    for (byte i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        if (Screen.AllScreens[i].Bounds.X != 0)
                        {
                            this.Size = new Size(Screen.AllScreens[i].Bounds.Width, Screen.AllScreens[i].Bounds.Height / 2);
                            this.Location = new Point(Screen.AllScreens[i].Bounds.X, Screen.AllScreens[i].Bounds.Y + Screen.AllScreens[i].Bounds.Height / 2);
                        }
                    }
                    break;
                case "SCREEN2_BOTTOM_LEFT":
                    for (byte i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        if (Screen.AllScreens[i].Bounds.X != 0)
                        {
                            this.Size = new Size(Screen.AllScreens[i].Bounds.Width / 2, Screen.AllScreens[i].Bounds.Height / 2);
                            this.Location = new Point(Screen.AllScreens[i].Bounds.X, Screen.AllScreens[i].Bounds.Y + Screen.AllScreens[i].Bounds.Height / 2);
                        }
                    }
                    break;
                case "SCREEN2_1080P":
                    for (byte i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        if (Screen.AllScreens[i].Bounds.X != 0)
                        {
                            this.Size = new Size(1920, 1080);
                            this.Location = Screen.AllScreens[i].Bounds.Location;
                        }
                    }
                    break;
            }
        }
        private void LoadImage(String filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower();
            pictureBox1.Image = Image.FromFile(filePath);
            width = pictureBox1.Image.Size.Width;
            height = pictureBox1.Image.Size.Height;
            widthSpan = 0;
            heightSpan = 0;
            for (byte i = 0; i < Screen.AllScreens.Length; i++)
            {
                if (Screen.AllScreens[i].Bounds.X == 0)
                {
                    if (upscaleMode == "fill")
                    {
                        Fill();
                    }
                    else if (upscaleMode == "fit")  // the highest value becomes the screen bounds
                    {
                        Fit();
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
                            Fill();
                        }
                        if (upscaleMode == "vanillafit")
                        {
                            Fit();
                        }
                    }
                    pictureBox1.Location = new Point(Screen.AllScreens[i].Bounds.Location.X + widthSpan, Screen.AllScreens[i].Bounds.Location.Y + heightSpan);
                    break;
                }
            }
            pictureBox1.Size = new System.Drawing.Size(width, height);
        }
        private void Fill(int ScreenWidth, int ScreenHeight)
        {
            if (width < height)
            {
                decimal ratio = width / Screen.AllScreens[i].Bounds.Width;
                width = Screen.AllScreens[i].Bounds.Width;
                heightSpan = height;
                height = (int)(height * ratio);
                heightSpan = Math.Abs(heightSpan - height) >> 1;
            }
            else
            {
                decimal ratio = height / Screen.AllScreens[i].Bounds.Height;
                height = Screen.AllScreens[i].Bounds.Height;
                widthSpan = width;
                width = (int)(width * ratio);
                widthSpan = Math.Abs(widthSpan - width) >> 1;
            }
        }
        private void Fit(int ScreenWidth, int ScreenHeight)
        {
            if (width > height)
            {
                decimal ratio = width / Screen.AllScreens[i].Bounds.Width;
                width = Screen.AllScreens[i].Bounds.Width;
                height = (int)(height * ratio);
            }
            else
            {
                decimal ratio = height / Screen.AllScreens[i].Bounds.Height;
                height = Screen.AllScreens[i].Bounds.Height;
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