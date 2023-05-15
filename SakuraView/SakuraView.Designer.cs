using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace SakuraView
{
    partial class SakuraView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SakuraView));
            this.pictureBox1 = new PictureBoxWithInterpolationMode();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SakuraViewClass
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 450);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SakuraViewClass";
            this.Text = "Form1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.SakuraViewClass_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SakuraViewClass_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBoxWithInterpolationMode pictureBox1;
    }
}

// https://stackoverflow.com/questions/29157/how-do-i-make-a-picturebox-use-nearest-neighbor-resampling
/// <summary>
/// Inherits from PictureBox; adds Interpolation Mode Setting
/// </summary>
public class PictureBoxWithInterpolationMode : PictureBox
{
    public InterpolationMode InterpolationMode { get; set; }

    protected override void OnPaint(PaintEventArgs paintEventArgs)
    {
        paintEventArgs.Graphics.InterpolationMode = InterpolationMode;
        paintEventArgs.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
        base.OnPaint(paintEventArgs);
    }

    private void InitializeComponent()
    {
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        this.SuspendLayout();
        // 
        // PictureBoxWithInterpolationMode
        // 
        this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
        this.ResumeLayout(false);
    }
}