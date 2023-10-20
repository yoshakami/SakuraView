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
            this.SakuraHidden = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SakuraConsole = new System.Windows.Forms.Label();
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
            this.SakuraSideHelp.Size = new System.Drawing.Size(178, 1134);
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
            this.SakuraHelp.Size = new System.Drawing.Size(1118, 42);
            this.SakuraHelp.TabIndex = 8;
            this.SakuraHelp.Text = resources.GetString("SakuraHelp.Text");
            this.SakuraHelp.DragDrop += new System.Windows.Forms.DragEventHandler(this.SakuraViewClass_DragDrop);
            this.SakuraHelp.DragEnter += new System.Windows.Forms.DragEventHandler(this.SakuraViewClass_DragEnter);
            // 
            // SakuraHidden
            // 
            this.SakuraHidden.AllowDrop = true;
            this.SakuraHidden.AutoSize = true;
            this.SakuraHidden.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraHidden.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraHidden.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraHidden.Location = new System.Drawing.Point(365, 41);
            this.SakuraHidden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SakuraHidden.Name = "SakuraHidden";
            this.SakuraHidden.Size = new System.Drawing.Size(108, 21);
            this.SakuraHidden.TabIndex = 9;
            this.SakuraHidden.Text = "SakuraHidden";
            this.SakuraHidden.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(355, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Search Current Directory";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Silver;
            this.textBox2.Location = new System.Drawing.Point(633, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 22);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Search Files";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Black;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Silver;
            this.textBox3.Location = new System.Drawing.Point(844, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 22);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "Search Folders";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Black;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Silver;
            this.textBox4.Location = new System.Drawing.Point(1046, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(202, 22);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "Search All";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SakuraConsole
            // 
            this.SakuraConsole.AllowDrop = true;
            this.SakuraConsole.AutoSize = true;
            this.SakuraConsole.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraConsole.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraConsole.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraConsole.Location = new System.Drawing.Point(56, 74);
            this.SakuraConsole.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraConsole.Name = "SakuraConsole";
            this.SakuraConsole.Size = new System.Drawing.Size(119, 21);
            this.SakuraConsole.TabIndex = 14;
            this.SakuraConsole.Text = "Console output:";
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
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1660, 554);
            this.Controls.Add(this.SakuraConsole);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SakuraHidden);
            this.Controls.Add(this.SakuraHelp);
            this.Controls.Add(this.SakuraSideHelp);
            this.Controls.Add(this.SakuraInfo);
            this.Controls.Add(this.SakuraBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(18, 47);
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
        private Label SakuraHidden;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label SakuraConsole;
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