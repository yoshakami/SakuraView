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
            this.SakuraBox = new PictureBoxWithInterpolationMode();
            this.SakuraName = new System.Windows.Forms.Label();
            this.SakuraIndex = new System.Windows.Forms.Label();
            this.SakuraDate = new System.Windows.Forms.Label();
            this.SakuraDimensions = new System.Windows.Forms.Label();
            this.SakuraDepth = new System.Windows.Forms.Label();
            this.SakuraSize = new System.Windows.Forms.Label();
            this.SakuraHelp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SakuraBox
            // 
            this.SakuraBox.Enabled = false;
            this.SakuraBox.ErrorImage = null;
            this.SakuraBox.InitialImage = null;
            this.SakuraBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox.Location = new System.Drawing.Point(0, 0);
            this.SakuraBox.Name = "SakuraBox";
            this.SakuraBox.Size = new System.Drawing.Size(50, 50);
            this.SakuraBox.TabIndex = 0;
            this.SakuraBox.TabStop = false;
            // 
            // SakuraName
            // 
            this.SakuraName.AllowDrop = true;
            this.SakuraName.AutoSize = true;
            this.SakuraName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraName.Location = new System.Drawing.Point(12, 420);
            this.SakuraName.Name = "SakuraName";
            this.SakuraName.Size = new System.Drawing.Size(93, 21);
            this.SakuraName.TabIndex = 1;
            this.SakuraName.Text = "Sakura.bmp";
            this.SakuraName.DragDrop += new System.Windows.Forms.DragEventHandler(this.SakuraViewClass_DragDrop);
            this.SakuraName.DragEnter += new System.Windows.Forms.DragEventHandler(this.SakuraViewClass_DragEnter);
            // 
            // SakuraIndex
            // 
            this.SakuraIndex.AllowDrop = true;
            this.SakuraIndex.AutoSize = true;
            this.SakuraIndex.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraIndex.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraIndex.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraIndex.Location = new System.Drawing.Point(1182, 420);
            this.SakuraIndex.Name = "SakuraIndex";
            this.SakuraIndex.Size = new System.Drawing.Size(51, 21);
            this.SakuraIndex.TabIndex = 2;
            this.SakuraIndex.Text = "1 / 10";
            this.SakuraIndex.DragDrop += new System.Windows.Forms.DragEventHandler(this.SakuraViewClass_DragDrop);
            this.SakuraIndex.DragEnter += new System.Windows.Forms.DragEventHandler(this.SakuraViewClass_DragEnter);
            // 
            // SakuraDate
            // 
            this.SakuraDate.AllowDrop = true;
            this.SakuraDate.AutoSize = true;
            this.SakuraDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraDate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraDate.Location = new System.Drawing.Point(948, 420);
            this.SakuraDate.Name = "SakuraDate";
            this.SakuraDate.Size = new System.Drawing.Size(94, 21);
            this.SakuraDate.TabIndex = 3;
            this.SakuraDate.Text = "15/05/2023";
            this.SakuraDate.DragDrop += new System.Windows.Forms.DragEventHandler(this.SakuraViewClass_DragDrop);
            this.SakuraDate.DragEnter += new System.Windows.Forms.DragEventHandler(this.SakuraViewClass_DragEnter);
            // 
            // SakuraDimensions
            // 
            this.SakuraDimensions.AllowDrop = true;
            this.SakuraDimensions.AutoSize = true;
            this.SakuraDimensions.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraDimensions.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraDimensions.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraDimensions.Location = new System.Drawing.Point(704, 420);
            this.SakuraDimensions.Name = "SakuraDimensions";
            this.SakuraDimensions.Size = new System.Drawing.Size(89, 21);
            this.SakuraDimensions.TabIndex = 4;
            this.SakuraDimensions.Text = "2160x3840";
            this.SakuraDimensions.DragDrop += new System.Windows.Forms.DragEventHandler(this.SakuraViewClass_DragDrop);
            this.SakuraDimensions.DragEnter += new System.Windows.Forms.DragEventHandler(this.SakuraViewClass_DragEnter);
            // 
            // SakuraDepth
            // 
            this.SakuraDepth.AllowDrop = true;
            this.SakuraDepth.AutoSize = true;
            this.SakuraDepth.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraDepth.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraDepth.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraDepth.Location = new System.Drawing.Point(498, 420);
            this.SakuraDepth.Name = "SakuraDepth";
            this.SakuraDepth.Size = new System.Drawing.Size(52, 21);
            this.SakuraDepth.TabIndex = 5;
            this.SakuraDepth.Text = "24-bit";
            this.SakuraDepth.DragDrop += new System.Windows.Forms.DragEventHandler(this.SakuraViewClass_DragDrop);
            this.SakuraDepth.DragEnter += new System.Windows.Forms.DragEventHandler(this.SakuraViewClass_DragEnter);
            // 
            // SakuraSize
            // 
            this.SakuraSize.AllowDrop = true;
            this.SakuraSize.AutoSize = true;
            this.SakuraSize.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraSize.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraSize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraSize.Location = new System.Drawing.Point(285, 420);
            this.SakuraSize.Name = "SakuraSize";
            this.SakuraSize.Size = new System.Drawing.Size(54, 21);
            this.SakuraSize.TabIndex = 6;
            this.SakuraSize.Text = "256kb";
            this.SakuraSize.DragDrop += new System.Windows.Forms.DragEventHandler(this.SakuraViewClass_DragDrop);
            this.SakuraSize.DragEnter += new System.Windows.Forms.DragEventHandler(this.SakuraViewClass_DragEnter);
            // 
            // SakuraHelp
            // 
            this.SakuraHelp.AllowDrop = true;
            this.SakuraHelp.AutoSize = true;
            this.SakuraHelp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraHelp.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraHelp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraHelp.Location = new System.Drawing.Point(12, 220);
            this.SakuraHelp.Name = "SakuraHelp";
            this.SakuraHelp.Size = new System.Drawing.Size(1233, 147);
            this.SakuraHelp.TabIndex = 7;
            this.SakuraHelp.Text = resources.GetString("SakuraHelp.Text");
            this.SakuraHelp.DragDrop += new System.Windows.Forms.DragEventHandler(this.SakuraViewClass_DragDrop);
            this.SakuraHelp.DragEnter += new System.Windows.Forms.DragEventHandler(this.SakuraViewClass_DragEnter);
            // 
            // SakuraView
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1245, 450);
            this.Controls.Add(this.SakuraHelp);
            this.Controls.Add(this.SakuraSize);
            this.Controls.Add(this.SakuraDepth);
            this.Controls.Add(this.SakuraDimensions);
            this.Controls.Add(this.SakuraDate);
            this.Controls.Add(this.SakuraIndex);
            this.Controls.Add(this.SakuraName);
            this.Controls.Add(this.SakuraBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SakuraView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SakuraView";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.SakuraViewClass_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SakuraViewClass_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SakuraView_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBoxWithInterpolationMode SakuraBox;
        private Label SakuraName;
        private Label SakuraIndex;
        private Label SakuraDate;
        private Label SakuraDimensions;
        private Label SakuraDepth;
        private Label SakuraSize;
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