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
            this.SakuraInfo = new System.Windows.Forms.Label();
            this.SakuraSideHelp = new System.Windows.Forms.Label();
            this.SakuraHelp = new System.Windows.Forms.Label();
            this.SakuraBox = new PictureBoxWithInterpolationMode();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SakuraInfo
            // 
            this.SakuraInfo.AllowDrop = true;
            this.SakuraInfo.AutoSize = true;
            this.SakuraInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraInfo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraInfo.Location = new System.Drawing.Point(16, 517);
            this.SakuraInfo.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraInfo.Name = "SakuraInfo";
            this.SakuraInfo.Size = new System.Drawing.Size(93, 21);
            this.SakuraInfo.TabIndex = 1;
            this.SakuraInfo.Text = "Sakura.bmp";
            this.SakuraInfo.DragDrop += new System.Windows.Forms.DragEventHandler(this.SakuraViewClass_DragDrop);
            this.SakuraInfo.DragEnter += new System.Windows.Forms.DragEventHandler(this.SakuraViewClass_DragEnter);
            // 
            // SakuraSideHelp
            // 
            this.SakuraSideHelp.AllowDrop = true;
            this.SakuraSideHelp.AutoSize = true;
            this.SakuraSideHelp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraSideHelp.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraSideHelp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraSideHelp.Location = new System.Drawing.Point(1407, 0);
            this.SakuraSideHelp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SakuraSideHelp.Name = "SakuraSideHelp";
            this.SakuraSideHelp.Size = new System.Drawing.Size(178, 1008);
            this.SakuraSideHelp.TabIndex = 7;
            this.SakuraSideHelp.Text = resources.GetString("SakuraSideHelp.Text");
            this.SakuraSideHelp.DragDrop += new System.Windows.Forms.DragEventHandler(this.SakuraViewClass_DragDrop);
            this.SakuraSideHelp.DragEnter += new System.Windows.Forms.DragEventHandler(this.SakuraViewClass_DragEnter);
            // 
            // SakuraHelp
            // 
            this.SakuraHelp.AllowDrop = true;
            this.SakuraHelp.AutoSize = true;
            this.SakuraHelp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraHelp.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraHelp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraHelp.Location = new System.Drawing.Point(16, 446);
            this.SakuraHelp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SakuraHelp.Name = "SakuraHelp";
            this.SakuraHelp.Size = new System.Drawing.Size(1079, 42);
            this.SakuraHelp.TabIndex = 8;
            this.SakuraHelp.Text = resources.GetString("SakuraHelp.Text");
            // 
            // SakuraBox
            // 
            this.SakuraBox.Enabled = false;
            this.SakuraBox.ErrorImage = null;
            this.SakuraBox.InitialImage = null;
            this.SakuraBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox.Location = new System.Drawing.Point(0, 0);
            this.SakuraBox.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox.Name = "SakuraBox";
            this.SakuraBox.Size = new System.Drawing.Size(67, 62);
            this.SakuraBox.TabIndex = 0;
            this.SakuraBox.TabStop = false;
            // 
            // SakuraView
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1660, 554);
            this.Controls.Add(this.SakuraHelp);
            this.Controls.Add(this.SakuraSideHelp);
            this.Controls.Add(this.SakuraInfo);
            this.Controls.Add(this.SakuraBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1, 1);
            this.Name = "SakuraView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SakuraView";
            this.ClientSizeChanged += new System.EventHandler(this.SakuraView_ClientSizeChanged);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.SakuraViewClass_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SakuraViewClass_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SakuraView_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBoxWithInterpolationMode SakuraBox;
        private Label SakuraInfo;
        private Label SakuraSideHelp;
        private Label SakuraHelp;
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