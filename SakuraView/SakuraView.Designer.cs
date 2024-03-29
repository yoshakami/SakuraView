﻿using System.Drawing.Drawing2D;
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
            this.SakuraMetadata = new System.Windows.Forms.Label();
            this.SakuraUnseen = new System.Windows.Forms.Label();
            this.SakuraCkLoop = new System.Windows.Forms.CheckBox();
            this.SakuraCkAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.SakuraCkBanner = new System.Windows.Forms.CheckBox();
            this.SakuraCkConsole = new System.Windows.Forms.CheckBox();
            this.SakuraCkInfo = new System.Windows.Forms.CheckBox();
            this.SakuraCkHelp = new System.Windows.Forms.CheckBox();
            this.SakuraCkSubFolders = new System.Windows.Forms.CheckBox();
            this.SakuraCkDuplicates = new System.Windows.Forms.CheckBox();
            this.SakuraButtonEmpty = new System.Windows.Forms.Button();
            this.SakuraButtonOpenFiles = new System.Windows.Forms.Button();
            this.SakuraButtonGithub = new System.Windows.Forms.Button();
            this.SakuraButtonClearConsole = new System.Windows.Forms.Button();
            this.SakuraButtonDirectory = new System.Windows.Forms.Button();
            this.SakuraButton10Lines = new System.Windows.Forms.Button();
            this.SakuraButtonRotate = new System.Windows.Forms.Button();
            this.SakuraButtonSave = new System.Windows.Forms.Button();
            this.SakuraButtonSwapV = new System.Windows.Forms.Button();
            this.SakuraButtonSwapH = new System.Windows.Forms.Button();
            this.SakuraZoomNumeric = new System.Windows.Forms.NumericUpDown();
            this.SakuraZoomTrackBar = new System.Windows.Forms.TrackBar();
            this.SakuraZoomLabel = new System.Windows.Forms.Label();
            this.SakuraImgcvtLabel = new System.Windows.Forms.Label();
            this.SakuraImgcvt = new System.Windows.Forms.TextBox();
            this.SakuraTextColorLabel = new System.Windows.Forms.Label();
            this.SakuraTextColor = new System.Windows.Forms.ComboBox();
            this.SakuraBgColor = new System.Windows.Forms.ComboBox();
            this.SakuraBgColorLabel = new System.Windows.Forms.Label();
            this.SakuraButtonHideSettings = new System.Windows.Forms.Button();
            this.SakuraMaxNumLabel = new System.Windows.Forms.Label();
            this.SakuraMaxNum = new System.Windows.Forms.NumericUpDown();
            this.SakuraZoomIncrementLabel = new System.Windows.Forms.Label();
            this.SakuraZoomIncrement = new System.Windows.Forms.NumericUpDown();
            this.SakuraPlt0Textbox = new System.Windows.Forms.TextBox();
            this.SakuraPlt0Label = new System.Windows.Forms.Label();
            this.SakuraConvert = new System.Windows.Forms.ComboBox();
            this.SakuraConvertLabel = new System.Windows.Forms.Label();
            this.SakuraTo = new System.Windows.Forms.ComboBox();
            this.SakuraToLabel = new System.Windows.Forms.Label();
            this.SakuraMetadataLengthNumeric = new System.Windows.Forms.NumericUpDown();
            this.SakuraMetadataLengthLabel = new System.Windows.Forms.Label();
            this.SakuraBox = new PictureBoxWithInterpolationMode();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraZoomNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraZoomTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraMaxNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraZoomIncrement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraMetadataLengthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SakuraInfo
            // 
            this.SakuraInfo.AllowDrop = true;
            this.SakuraInfo.AutoSize = true;
            this.SakuraInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraInfo.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraInfo.Location = new System.Drawing.Point(9, 613);
            this.SakuraInfo.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraInfo.Name = "SakuraInfo";
            this.SakuraInfo.Size = new System.Drawing.Size(100, 21);
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
            this.SakuraSideHelp.Location = new System.Drawing.Point(1055, 0);
            this.SakuraSideHelp.Name = "SakuraSideHelp";
            this.SakuraSideHelp.Size = new System.Drawing.Size(345, 1365);
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
            this.SakuraHelp.Location = new System.Drawing.Point(13, 709);
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
            this.SakuraHidden.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraHidden.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraHidden.Location = new System.Drawing.Point(838, 180);
            this.SakuraHidden.Name = "SakuraHidden";
            this.SakuraHidden.Size = new System.Drawing.Size(118, 21);
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
            this.textBox1.Location = new System.Drawing.Point(266, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 22);
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
            this.textBox2.Location = new System.Drawing.Point(475, 10);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 22);
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
            this.textBox3.Location = new System.Drawing.Point(633, 10);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(127, 22);
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
            this.textBox4.Location = new System.Drawing.Point(784, 10);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(152, 22);
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
            this.SakuraConsole.Location = new System.Drawing.Point(688, 242);
            this.SakuraConsole.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraConsole.Name = "SakuraConsole";
            this.SakuraConsole.Size = new System.Drawing.Size(119, 21);
            this.SakuraConsole.TabIndex = 14;
            this.SakuraConsole.Text = "Console output:";
            this.SakuraConsole.Visible = false;
            this.SakuraConsole.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SakuraConsole_MouseDown);
            this.SakuraConsole.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SakuraConsole_MouseMove);
            // 
            // SakuraMetadata
            // 
            this.SakuraMetadata.AllowDrop = true;
            this.SakuraMetadata.AutoSize = true;
            this.SakuraMetadata.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraMetadata.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraMetadata.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraMetadata.Location = new System.Drawing.Point(638, 72);
            this.SakuraMetadata.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraMetadata.Name = "SakuraMetadata";
            this.SakuraMetadata.Size = new System.Drawing.Size(123, 21);
            this.SakuraMetadata.TabIndex = 15;
            this.SakuraMetadata.Text = "SakuraMetadata";
            this.SakuraMetadata.Visible = false;
            this.SakuraMetadata.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SakuraMetadata_MouseDown);
            this.SakuraMetadata.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SakuraMetadata_MouseMove);
            // 
            // SakuraUnseen
            // 
            this.SakuraUnseen.AllowDrop = true;
            this.SakuraUnseen.AutoSize = true;
            this.SakuraUnseen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraUnseen.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraUnseen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraUnseen.Location = new System.Drawing.Point(638, 153);
            this.SakuraUnseen.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraUnseen.Name = "SakuraUnseen";
            this.SakuraUnseen.Size = new System.Drawing.Size(110, 21);
            this.SakuraUnseen.TabIndex = 16;
            this.SakuraUnseen.Text = "SakuraUnseen";
            this.SakuraUnseen.Visible = false;
            // 
            // SakuraCkLoop
            // 
            this.SakuraCkLoop.AutoSize = true;
            this.SakuraCkLoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraCkLoop.ForeColor = System.Drawing.Color.White;
            this.SakuraCkLoop.Location = new System.Drawing.Point(315, 253);
            this.SakuraCkLoop.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraCkLoop.Name = "SakuraCkLoop";
            this.SakuraCkLoop.Size = new System.Drawing.Size(54, 21);
            this.SakuraCkLoop.TabIndex = 17;
            this.SakuraCkLoop.Text = "loop";
            this.SakuraCkLoop.UseVisualStyleBackColor = true;
            this.SakuraCkLoop.CheckedChanged += new System.EventHandler(this.SakuraCkLoop_CheckedChanged);
            this.SakuraCkLoop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SakuraView_KeyDown);
            // 
            // SakuraCkAlwaysOnTop
            // 
            this.SakuraCkAlwaysOnTop.AutoSize = true;
            this.SakuraCkAlwaysOnTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraCkAlwaysOnTop.ForeColor = System.Drawing.Color.White;
            this.SakuraCkAlwaysOnTop.Location = new System.Drawing.Point(315, 106);
            this.SakuraCkAlwaysOnTop.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraCkAlwaysOnTop.Name = "SakuraCkAlwaysOnTop";
            this.SakuraCkAlwaysOnTop.Size = new System.Drawing.Size(113, 21);
            this.SakuraCkAlwaysOnTop.TabIndex = 19;
            this.SakuraCkAlwaysOnTop.Text = "always on top";
            this.SakuraCkAlwaysOnTop.UseVisualStyleBackColor = true;
            this.SakuraCkAlwaysOnTop.CheckedChanged += new System.EventHandler(this.SakuraCkAlwaysOnTop_CheckedChanged);
            this.SakuraCkAlwaysOnTop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SakuraView_KeyDown);
            // 
            // SakuraCkBanner
            // 
            this.SakuraCkBanner.AutoSize = true;
            this.SakuraCkBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraCkBanner.ForeColor = System.Drawing.Color.White;
            this.SakuraCkBanner.Location = new System.Drawing.Point(315, 131);
            this.SakuraCkBanner.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraCkBanner.Name = "SakuraCkBanner";
            this.SakuraCkBanner.Size = new System.Drawing.Size(72, 21);
            this.SakuraCkBanner.TabIndex = 20;
            this.SakuraCkBanner.Text = "banner";
            this.SakuraCkBanner.UseVisualStyleBackColor = true;
            this.SakuraCkBanner.CheckedChanged += new System.EventHandler(this.SakuraCkBanner_CheckedChanged);
            this.SakuraCkBanner.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SakuraView_KeyDown);
            // 
            // SakuraCkConsole
            // 
            this.SakuraCkConsole.AutoSize = true;
            this.SakuraCkConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraCkConsole.ForeColor = System.Drawing.Color.White;
            this.SakuraCkConsole.Location = new System.Drawing.Point(315, 155);
            this.SakuraCkConsole.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraCkConsole.Name = "SakuraCkConsole";
            this.SakuraCkConsole.Size = new System.Drawing.Size(76, 21);
            this.SakuraCkConsole.TabIndex = 21;
            this.SakuraCkConsole.Text = "console";
            this.SakuraCkConsole.UseVisualStyleBackColor = true;
            this.SakuraCkConsole.CheckedChanged += new System.EventHandler(this.SakuraCkConsole_CheckedChanged);
            this.SakuraCkConsole.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SakuraView_KeyDown);
            // 
            // SakuraCkInfo
            // 
            this.SakuraCkInfo.AutoSize = true;
            this.SakuraCkInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraCkInfo.ForeColor = System.Drawing.Color.White;
            this.SakuraCkInfo.Location = new System.Drawing.Point(315, 228);
            this.SakuraCkInfo.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraCkInfo.Name = "SakuraCkInfo";
            this.SakuraCkInfo.Size = new System.Drawing.Size(50, 21);
            this.SakuraCkInfo.TabIndex = 23;
            this.SakuraCkInfo.Text = "info";
            this.SakuraCkInfo.UseVisualStyleBackColor = true;
            this.SakuraCkInfo.CheckedChanged += new System.EventHandler(this.SakuraCkInfo_CheckedChanged);
            this.SakuraCkInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SakuraView_KeyDown);
            // 
            // SakuraCkHelp
            // 
            this.SakuraCkHelp.AutoSize = true;
            this.SakuraCkHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraCkHelp.ForeColor = System.Drawing.Color.White;
            this.SakuraCkHelp.Location = new System.Drawing.Point(315, 204);
            this.SakuraCkHelp.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraCkHelp.Name = "SakuraCkHelp";
            this.SakuraCkHelp.Size = new System.Drawing.Size(54, 21);
            this.SakuraCkHelp.TabIndex = 24;
            this.SakuraCkHelp.Text = "help";
            this.SakuraCkHelp.UseVisualStyleBackColor = true;
            this.SakuraCkHelp.CheckedChanged += new System.EventHandler(this.SakuraCkHelp_CheckedChanged);
            this.SakuraCkHelp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SakuraView_KeyDown);
            // 
            // SakuraCkSubFolders
            // 
            this.SakuraCkSubFolders.AutoSize = true;
            this.SakuraCkSubFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraCkSubFolders.ForeColor = System.Drawing.Color.White;
            this.SakuraCkSubFolders.Location = new System.Drawing.Point(315, 278);
            this.SakuraCkSubFolders.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraCkSubFolders.Name = "SakuraCkSubFolders";
            this.SakuraCkSubFolders.Size = new System.Drawing.Size(171, 21);
            this.SakuraCkSubFolders.TabIndex = 25;
            this.SakuraCkSubFolders.Text = "sub-folders processing";
            this.SakuraCkSubFolders.UseVisualStyleBackColor = true;
            this.SakuraCkSubFolders.CheckedChanged += new System.EventHandler(this.SakuraCkSubFolders_CheckedChanged);
            this.SakuraCkSubFolders.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SakuraView_KeyDown);
            // 
            // SakuraCkDuplicates
            // 
            this.SakuraCkDuplicates.AutoSize = true;
            this.SakuraCkDuplicates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraCkDuplicates.ForeColor = System.Drawing.Color.White;
            this.SakuraCkDuplicates.Location = new System.Drawing.Point(315, 180);
            this.SakuraCkDuplicates.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraCkDuplicates.Name = "SakuraCkDuplicates";
            this.SakuraCkDuplicates.Size = new System.Drawing.Size(91, 21);
            this.SakuraCkDuplicates.TabIndex = 26;
            this.SakuraCkDuplicates.Text = "duplicates";
            this.SakuraCkDuplicates.UseVisualStyleBackColor = true;
            this.SakuraCkDuplicates.CheckedChanged += new System.EventHandler(this.SakuraCkDuplicates_CheckedChanged);
            this.SakuraCkDuplicates.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SakuraView_KeyDown);
            // 
            // SakuraButtonEmpty
            // 
            this.SakuraButtonEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraButtonEmpty.Location = new System.Drawing.Point(15, 106);
            this.SakuraButtonEmpty.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraButtonEmpty.Name = "SakuraButtonEmpty";
            this.SakuraButtonEmpty.Size = new System.Drawing.Size(116, 44);
            this.SakuraButtonEmpty.TabIndex = 27;
            this.SakuraButtonEmpty.Text = "Empty List";
            this.SakuraButtonEmpty.UseVisualStyleBackColor = true;
            this.SakuraButtonEmpty.Click += new System.EventHandler(this.SakuraButtonEmpty_Click);
            this.SakuraButtonEmpty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SakuraView_KeyDown);
            // 
            // SakuraButtonOpenFiles
            // 
            this.SakuraButtonOpenFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraButtonOpenFiles.Location = new System.Drawing.Point(15, 155);
            this.SakuraButtonOpenFiles.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraButtonOpenFiles.Name = "SakuraButtonOpenFiles";
            this.SakuraButtonOpenFiles.Size = new System.Drawing.Size(116, 44);
            this.SakuraButtonOpenFiles.TabIndex = 28;
            this.SakuraButtonOpenFiles.Text = "Open Files";
            this.SakuraButtonOpenFiles.UseVisualStyleBackColor = true;
            this.SakuraButtonOpenFiles.Click += new System.EventHandler(this.SakuraButtonOpenFiles_Click);
            this.SakuraButtonOpenFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SakuraView_KeyDown);
            // 
            // SakuraButtonGithub
            // 
            this.SakuraButtonGithub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraButtonGithub.Location = new System.Drawing.Point(15, 204);
            this.SakuraButtonGithub.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraButtonGithub.Name = "SakuraButtonGithub";
            this.SakuraButtonGithub.Size = new System.Drawing.Size(116, 44);
            this.SakuraButtonGithub.TabIndex = 29;
            this.SakuraButtonGithub.Text = "Github Releases";
            this.SakuraButtonGithub.UseVisualStyleBackColor = true;
            this.SakuraButtonGithub.Click += new System.EventHandler(this.SakuraButtonGithub_Click);
            this.SakuraButtonGithub.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SakuraView_KeyDown);
            // 
            // SakuraButtonClearConsole
            // 
            this.SakuraButtonClearConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraButtonClearConsole.Location = new System.Drawing.Point(15, 253);
            this.SakuraButtonClearConsole.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraButtonClearConsole.Name = "SakuraButtonClearConsole";
            this.SakuraButtonClearConsole.Size = new System.Drawing.Size(116, 44);
            this.SakuraButtonClearConsole.TabIndex = 30;
            this.SakuraButtonClearConsole.Text = "Clear Console";
            this.SakuraButtonClearConsole.UseVisualStyleBackColor = true;
            this.SakuraButtonClearConsole.Click += new System.EventHandler(this.SakuraButtonClearConsole_Click);
            this.SakuraButtonClearConsole.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SakuraView_KeyDown);
            // 
            // SakuraButtonDirectory
            // 
            this.SakuraButtonDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraButtonDirectory.Location = new System.Drawing.Point(15, 301);
            this.SakuraButtonDirectory.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraButtonDirectory.Name = "SakuraButtonDirectory";
            this.SakuraButtonDirectory.Size = new System.Drawing.Size(116, 44);
            this.SakuraButtonDirectory.TabIndex = 31;
            this.SakuraButtonDirectory.Text = "Open Directory";
            this.SakuraButtonDirectory.UseVisualStyleBackColor = true;
            this.SakuraButtonDirectory.Click += new System.EventHandler(this.SakuraButtonDirectory_Click);
            this.SakuraButtonDirectory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SakuraView_KeyDown);
            // 
            // SakuraButton10Lines
            // 
            this.SakuraButton10Lines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraButton10Lines.Location = new System.Drawing.Point(161, 106);
            this.SakuraButton10Lines.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraButton10Lines.Name = "SakuraButton10Lines";
            this.SakuraButton10Lines.Size = new System.Drawing.Size(116, 44);
            this.SakuraButton10Lines.TabIndex = 32;
            this.SakuraButton10Lines.Text = "Remove 10 lines off the console";
            this.SakuraButton10Lines.UseVisualStyleBackColor = true;
            this.SakuraButton10Lines.Click += new System.EventHandler(this.SakuraButton10Lines_Click);
            this.SakuraButton10Lines.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SakuraView_KeyDown);
            // 
            // SakuraButtonRotate
            // 
            this.SakuraButtonRotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraButtonRotate.Location = new System.Drawing.Point(161, 155);
            this.SakuraButtonRotate.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraButtonRotate.Name = "SakuraButtonRotate";
            this.SakuraButtonRotate.Size = new System.Drawing.Size(116, 44);
            this.SakuraButtonRotate.TabIndex = 33;
            this.SakuraButtonRotate.Text = "Rotate";
            this.SakuraButtonRotate.UseVisualStyleBackColor = true;
            this.SakuraButtonRotate.Click += new System.EventHandler(this.SakuraButtonRotate_Click);
            this.SakuraButtonRotate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SakuraView_KeyDown);
            // 
            // SakuraButtonSave
            // 
            this.SakuraButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraButtonSave.Location = new System.Drawing.Point(494, 483);
            this.SakuraButtonSave.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraButtonSave.Name = "SakuraButtonSave";
            this.SakuraButtonSave.Size = new System.Drawing.Size(116, 44);
            this.SakuraButtonSave.TabIndex = 34;
            this.SakuraButtonSave.Text = "Save Config";
            this.SakuraButtonSave.UseVisualStyleBackColor = true;
            this.SakuraButtonSave.Click += new System.EventHandler(this.SakuraButtonSave_Click);
            this.SakuraButtonSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SakuraView_KeyDown);
            // 
            // SakuraButtonSwapV
            // 
            this.SakuraButtonSwapV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraButtonSwapV.Location = new System.Drawing.Point(161, 204);
            this.SakuraButtonSwapV.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraButtonSwapV.Name = "SakuraButtonSwapV";
            this.SakuraButtonSwapV.Size = new System.Drawing.Size(116, 44);
            this.SakuraButtonSwapV.TabIndex = 35;
            this.SakuraButtonSwapV.Text = "Swap Vertically";
            this.SakuraButtonSwapV.UseVisualStyleBackColor = true;
            this.SakuraButtonSwapV.Click += new System.EventHandler(this.SakuraButtonSwapV_Click);
            this.SakuraButtonSwapV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SakuraView_KeyDown);
            // 
            // SakuraButtonSwapH
            // 
            this.SakuraButtonSwapH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraButtonSwapH.Location = new System.Drawing.Point(161, 253);
            this.SakuraButtonSwapH.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraButtonSwapH.Name = "SakuraButtonSwapH";
            this.SakuraButtonSwapH.Size = new System.Drawing.Size(116, 44);
            this.SakuraButtonSwapH.TabIndex = 36;
            this.SakuraButtonSwapH.Text = "Swap Horizontally";
            this.SakuraButtonSwapH.UseVisualStyleBackColor = true;
            this.SakuraButtonSwapH.Click += new System.EventHandler(this.SakuraButtonSwapH_Click);
            this.SakuraButtonSwapH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SakuraView_KeyDown);
            // 
            // SakuraZoomNumeric
            // 
            this.SakuraZoomNumeric.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.SakuraZoomNumeric.Location = new System.Drawing.Point(315, 73);
            this.SakuraZoomNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraZoomNumeric.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.SakuraZoomNumeric.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.SakuraZoomNumeric.Name = "SakuraZoomNumeric";
            this.SakuraZoomNumeric.Size = new System.Drawing.Size(90, 20);
            this.SakuraZoomNumeric.TabIndex = 38;
            this.SakuraZoomNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.SakuraZoomNumeric.ValueChanged += new System.EventHandler(this.SakuraZoomNumeric_ValueChanged);
            this.SakuraZoomNumeric.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SakuraView_KeyDown);
            // 
            // SakuraZoomTrackBar
            // 
            this.SakuraZoomTrackBar.Location = new System.Drawing.Point(16, 46);
            this.SakuraZoomTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraZoomTrackBar.Name = "SakuraZoomTrackBar";
            this.SakuraZoomTrackBar.Size = new System.Drawing.Size(262, 45);
            this.SakuraZoomTrackBar.TabIndex = 39;
            this.SakuraZoomTrackBar.Scroll += new System.EventHandler(this.SakuraZoomTrackBar_Scroll);
            this.SakuraZoomTrackBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SakuraView_KeyDown);
            // 
            // SakuraZoomLabel
            // 
            this.SakuraZoomLabel.AllowDrop = true;
            this.SakuraZoomLabel.AutoSize = true;
            this.SakuraZoomLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraZoomLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraZoomLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraZoomLabel.Location = new System.Drawing.Point(311, 46);
            this.SakuraZoomLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraZoomLabel.Name = "SakuraZoomLabel";
            this.SakuraZoomLabel.Size = new System.Drawing.Size(100, 21);
            this.SakuraZoomLabel.TabIndex = 40;
            this.SakuraZoomLabel.Text = "<-- zoom --v";
            // 
            // SakuraImgcvtLabel
            // 
            this.SakuraImgcvtLabel.AllowDrop = true;
            this.SakuraImgcvtLabel.AutoSize = true;
            this.SakuraImgcvtLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraImgcvtLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraImgcvtLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraImgcvtLabel.Location = new System.Drawing.Point(21, 424);
            this.SakuraImgcvtLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraImgcvtLabel.Name = "SakuraImgcvtLabel";
            this.SakuraImgcvtLabel.Size = new System.Drawing.Size(118, 21);
            this.SakuraImgcvtLabel.TabIndex = 41;
            this.SakuraImgcvtLabel.Text = "imgcvt.exe path";
            // 
            // SakuraImgcvt
            // 
            this.SakuraImgcvt.BackColor = System.Drawing.Color.Black;
            this.SakuraImgcvt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SakuraImgcvt.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraImgcvt.ForeColor = System.Drawing.Color.Silver;
            this.SakuraImgcvt.Location = new System.Drawing.Point(19, 456);
            this.SakuraImgcvt.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraImgcvt.Name = "SakuraImgcvt";
            this.SakuraImgcvt.Size = new System.Drawing.Size(449, 22);
            this.SakuraImgcvt.TabIndex = 42;
            this.SakuraImgcvt.Text = "C:\\Program Files\\Autodesk\\Maya2018\\bin\\imgcvt.exe";
            // 
            // SakuraTextColorLabel
            // 
            this.SakuraTextColorLabel.AllowDrop = true;
            this.SakuraTextColorLabel.AutoSize = true;
            this.SakuraTextColorLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraTextColorLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraTextColorLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraTextColorLabel.Location = new System.Drawing.Point(509, 106);
            this.SakuraTextColorLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraTextColorLabel.Name = "SakuraTextColorLabel";
            this.SakuraTextColorLabel.Size = new System.Drawing.Size(78, 21);
            this.SakuraTextColorLabel.TabIndex = 43;
            this.SakuraTextColorLabel.Text = "Text Color";
            // 
            // SakuraTextColor
            // 
            this.SakuraTextColor.FormattingEnabled = true;
            this.SakuraTextColor.Location = new System.Drawing.Point(489, 131);
            this.SakuraTextColor.Name = "SakuraTextColor";
            this.SakuraTextColor.Size = new System.Drawing.Size(121, 21);
            this.SakuraTextColor.TabIndex = 44;
            this.SakuraTextColor.SelectedIndexChanged += new System.EventHandler(this.SakuraTextColor_SelectedIndexChanged);
            // 
            // SakuraBgColor
            // 
            this.SakuraBgColor.FormattingEnabled = true;
            this.SakuraBgColor.Location = new System.Drawing.Point(489, 194);
            this.SakuraBgColor.Name = "SakuraBgColor";
            this.SakuraBgColor.Size = new System.Drawing.Size(121, 21);
            this.SakuraBgColor.TabIndex = 46;
            this.SakuraBgColor.SelectedIndexChanged += new System.EventHandler(this.SakuraBgColor_SelectedIndexChanged);
            // 
            // SakuraBgColorLabel
            // 
            this.SakuraBgColorLabel.AllowDrop = true;
            this.SakuraBgColorLabel.AutoSize = true;
            this.SakuraBgColorLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraBgColorLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraBgColorLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraBgColorLabel.Location = new System.Drawing.Point(485, 167);
            this.SakuraBgColorLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBgColorLabel.Name = "SakuraBgColorLabel";
            this.SakuraBgColorLabel.Size = new System.Drawing.Size(135, 21);
            this.SakuraBgColorLabel.TabIndex = 45;
            this.SakuraBgColorLabel.Text = "Background Color";
            // 
            // SakuraButtonHideSettings
            // 
            this.SakuraButtonHideSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraButtonHideSettings.Location = new System.Drawing.Point(161, 303);
            this.SakuraButtonHideSettings.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraButtonHideSettings.Name = "SakuraButtonHideSettings";
            this.SakuraButtonHideSettings.Size = new System.Drawing.Size(116, 44);
            this.SakuraButtonHideSettings.TabIndex = 47;
            this.SakuraButtonHideSettings.Text = "Hide Settings";
            this.SakuraButtonHideSettings.UseVisualStyleBackColor = true;
            this.SakuraButtonHideSettings.Click += new System.EventHandler(this.SakuraButtonHideSettings_Click);
            // 
            // SakuraMaxNumLabel
            // 
            this.SakuraMaxNumLabel.AllowDrop = true;
            this.SakuraMaxNumLabel.AutoSize = true;
            this.SakuraMaxNumLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraMaxNumLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraMaxNumLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraMaxNumLabel.Location = new System.Drawing.Point(477, 230);
            this.SakuraMaxNumLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraMaxNumLabel.Name = "SakuraMaxNumLabel";
            this.SakuraMaxNumLabel.Size = new System.Drawing.Size(152, 21);
            this.SakuraMaxNumLabel.TabIndex = 49;
            this.SakuraMaxNumLabel.Text = "Max images number";
            // 
            // SakuraMaxNum
            // 
            this.SakuraMaxNum.Location = new System.Drawing.Point(494, 258);
            this.SakuraMaxNum.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraMaxNum.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.SakuraMaxNum.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.SakuraMaxNum.Name = "SakuraMaxNum";
            this.SakuraMaxNum.Size = new System.Drawing.Size(116, 20);
            this.SakuraMaxNum.TabIndex = 48;
            this.SakuraMaxNum.ValueChanged += new System.EventHandler(this.SakuraMaxNum_ValueChanged);
            // 
            // SakuraZoomIncrementLabel
            // 
            this.SakuraZoomIncrementLabel.AllowDrop = true;
            this.SakuraZoomIncrementLabel.AutoSize = true;
            this.SakuraZoomIncrementLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraZoomIncrementLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraZoomIncrementLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraZoomIncrementLabel.Location = new System.Drawing.Point(485, 46);
            this.SakuraZoomIncrementLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraZoomIncrementLabel.Name = "SakuraZoomIncrementLabel";
            this.SakuraZoomIncrementLabel.Size = new System.Drawing.Size(123, 21);
            this.SakuraZoomIncrementLabel.TabIndex = 51;
            this.SakuraZoomIncrementLabel.Text = "zoom increment";
            // 
            // SakuraZoomIncrement
            // 
            this.SakuraZoomIncrement.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.SakuraZoomIncrement.Location = new System.Drawing.Point(489, 73);
            this.SakuraZoomIncrement.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraZoomIncrement.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.SakuraZoomIncrement.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.SakuraZoomIncrement.Name = "SakuraZoomIncrement";
            this.SakuraZoomIncrement.Size = new System.Drawing.Size(121, 20);
            this.SakuraZoomIncrement.TabIndex = 50;
            this.SakuraZoomIncrement.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.SakuraZoomIncrement.ValueChanged += new System.EventHandler(this.SakuraZoomIncrement_ValueChanged);
            // 
            // SakuraPlt0Textbox
            // 
            this.SakuraPlt0Textbox.BackColor = System.Drawing.Color.Black;
            this.SakuraPlt0Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SakuraPlt0Textbox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraPlt0Textbox.ForeColor = System.Drawing.Color.Silver;
            this.SakuraPlt0Textbox.Location = new System.Drawing.Point(19, 526);
            this.SakuraPlt0Textbox.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraPlt0Textbox.Name = "SakuraPlt0Textbox";
            this.SakuraPlt0Textbox.Size = new System.Drawing.Size(449, 22);
            this.SakuraPlt0Textbox.TabIndex = 53;
            this.SakuraPlt0Textbox.Text = "C:\\C#\\plt0\\plt0.exe";
            // 
            // SakuraPlt0Label
            // 
            this.SakuraPlt0Label.AllowDrop = true;
            this.SakuraPlt0Label.AutoSize = true;
            this.SakuraPlt0Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraPlt0Label.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraPlt0Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraPlt0Label.Location = new System.Drawing.Point(21, 494);
            this.SakuraPlt0Label.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraPlt0Label.Name = "SakuraPlt0Label";
            this.SakuraPlt0Label.Size = new System.Drawing.Size(98, 21);
            this.SakuraPlt0Label.TabIndex = 52;
            this.SakuraPlt0Label.Text = "plt0.exe path";
            // 
            // SakuraConvert
            // 
            this.SakuraConvert.FormattingEnabled = true;
            this.SakuraConvert.Location = new System.Drawing.Point(18, 383);
            this.SakuraConvert.Name = "SakuraConvert";
            this.SakuraConvert.Size = new System.Drawing.Size(121, 21);
            this.SakuraConvert.TabIndex = 55;
            // 
            // SakuraConvertLabel
            // 
            this.SakuraConvertLabel.AllowDrop = true;
            this.SakuraConvertLabel.AutoSize = true;
            this.SakuraConvertLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraConvertLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraConvertLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraConvertLabel.Location = new System.Drawing.Point(44, 359);
            this.SakuraConvertLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraConvertLabel.Name = "SakuraConvertLabel";
            this.SakuraConvertLabel.Size = new System.Drawing.Size(65, 21);
            this.SakuraConvertLabel.TabIndex = 54;
            this.SakuraConvertLabel.Text = "Convert";
            // 
            // SakuraTo
            // 
            this.SakuraTo.FormattingEnabled = true;
            this.SakuraTo.Location = new System.Drawing.Point(161, 383);
            this.SakuraTo.Name = "SakuraTo";
            this.SakuraTo.Size = new System.Drawing.Size(121, 21);
            this.SakuraTo.TabIndex = 57;
            // 
            // SakuraToLabel
            // 
            this.SakuraToLabel.AllowDrop = true;
            this.SakuraToLabel.AutoSize = true;
            this.SakuraToLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraToLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraToLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraToLabel.Location = new System.Drawing.Point(208, 359);
            this.SakuraToLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraToLabel.Name = "SakuraToLabel";
            this.SakuraToLabel.Size = new System.Drawing.Size(25, 21);
            this.SakuraToLabel.TabIndex = 56;
            this.SakuraToLabel.Text = "To";
            // 
            // SakuraMetadataLengthNumeric
            // 
            this.SakuraMetadataLengthNumeric.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.SakuraMetadataLengthNumeric.Location = new System.Drawing.Point(486, 382);
            this.SakuraMetadataLengthNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraMetadataLengthNumeric.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.SakuraMetadataLengthNumeric.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.SakuraMetadataLengthNumeric.Name = "SakuraMetadataLengthNumeric";
            this.SakuraMetadataLengthNumeric.Size = new System.Drawing.Size(121, 20);
            this.SakuraMetadataLengthNumeric.TabIndex = 58;
            this.SakuraMetadataLengthNumeric.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.SakuraMetadataLengthNumeric.ValueChanged += new System.EventHandler(this.SakuraMetadataLengthNumeric_ValueChanged);
            // 
            // SakuraMetadataLengthLabel
            // 
            this.SakuraMetadataLengthLabel.AllowDrop = true;
            this.SakuraMetadataLengthLabel.AutoSize = true;
            this.SakuraMetadataLengthLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraMetadataLengthLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraMetadataLengthLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraMetadataLengthLabel.Location = new System.Drawing.Point(469, 350);
            this.SakuraMetadataLengthLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraMetadataLengthLabel.Name = "SakuraMetadataLengthLabel";
            this.SakuraMetadataLengthLabel.Size = new System.Drawing.Size(160, 21);
            this.SakuraMetadataLengthLabel.TabIndex = 59;
            this.SakuraMetadataLengthLabel.Text = "Metadata Line Length";
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
            this.SakuraBox.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox.TabIndex = 0;
            this.SakuraBox.TabStop = false;
            this.SakuraBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SakuraBox_MouseDown);
            this.SakuraBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SakuraBox_MouseMove);
            // 
            // SakuraView
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1245, 760);
            this.Controls.Add(this.SakuraMetadataLengthLabel);
            this.Controls.Add(this.SakuraMetadataLengthNumeric);
            this.Controls.Add(this.SakuraTo);
            this.Controls.Add(this.SakuraToLabel);
            this.Controls.Add(this.SakuraConvert);
            this.Controls.Add(this.SakuraConvertLabel);
            this.Controls.Add(this.SakuraPlt0Textbox);
            this.Controls.Add(this.SakuraPlt0Label);
            this.Controls.Add(this.SakuraZoomIncrementLabel);
            this.Controls.Add(this.SakuraZoomIncrement);
            this.Controls.Add(this.SakuraMaxNumLabel);
            this.Controls.Add(this.SakuraMaxNum);
            this.Controls.Add(this.SakuraButtonHideSettings);
            this.Controls.Add(this.SakuraBgColor);
            this.Controls.Add(this.SakuraBgColorLabel);
            this.Controls.Add(this.SakuraTextColor);
            this.Controls.Add(this.SakuraTextColorLabel);
            this.Controls.Add(this.SakuraImgcvt);
            this.Controls.Add(this.SakuraImgcvtLabel);
            this.Controls.Add(this.SakuraZoomLabel);
            this.Controls.Add(this.SakuraZoomTrackBar);
            this.Controls.Add(this.SakuraZoomNumeric);
            this.Controls.Add(this.SakuraButtonSwapH);
            this.Controls.Add(this.SakuraButtonSwapV);
            this.Controls.Add(this.SakuraButtonSave);
            this.Controls.Add(this.SakuraButtonRotate);
            this.Controls.Add(this.SakuraButton10Lines);
            this.Controls.Add(this.SakuraButtonDirectory);
            this.Controls.Add(this.SakuraButtonClearConsole);
            this.Controls.Add(this.SakuraButtonGithub);
            this.Controls.Add(this.SakuraButtonOpenFiles);
            this.Controls.Add(this.SakuraButtonEmpty);
            this.Controls.Add(this.SakuraCkDuplicates);
            this.Controls.Add(this.SakuraCkSubFolders);
            this.Controls.Add(this.SakuraCkHelp);
            this.Controls.Add(this.SakuraCkInfo);
            this.Controls.Add(this.SakuraCkConsole);
            this.Controls.Add(this.SakuraCkBanner);
            this.Controls.Add(this.SakuraCkAlwaysOnTop);
            this.Controls.Add(this.SakuraCkLoop);
            this.Controls.Add(this.SakuraUnseen);
            this.Controls.Add(this.SakuraMetadata);
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
            this.MinimumSize = new System.Drawing.Size(18, 45);
            this.Name = "SakuraView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SakuraView";
            this.ClientSizeChanged += new System.EventHandler(this.SakuraView_ClientSizeChanged);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.SakuraViewClass_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SakuraViewClass_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SakuraView_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SakuraBox_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SakuraBox_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.SakuraZoomNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraZoomTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraMaxNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraZoomIncrement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraMetadataLengthNumeric)).EndInit();
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
        private Label SakuraMetadata;
        private Label SakuraUnseen;
        private CheckBox SakuraCkLoop;
        private CheckBox SakuraCkAlwaysOnTop;
        private CheckBox SakuraCkBanner;
        private CheckBox SakuraCkConsole;
        private CheckBox SakuraCkInfo;
        private CheckBox SakuraCkHelp;
        private CheckBox SakuraCkSubFolders;
        private CheckBox SakuraCkDuplicates;
        private Button SakuraButtonEmpty;
        private Button SakuraButtonOpenFiles;
        private Button SakuraButtonGithub;
        private Button SakuraButtonClearConsole;
        private Button SakuraButtonDirectory;
        private Button SakuraButton10Lines;
        private Button SakuraButtonRotate;
        private Button SakuraButtonSave;
        private Button SakuraButtonSwapV;
        private Button SakuraButtonSwapH;
        private NumericUpDown SakuraZoomNumeric;
        private TrackBar SakuraZoomTrackBar;
        private Label SakuraZoomLabel;
        private Label SakuraImgcvtLabel;
        private TextBox SakuraImgcvt;
        private Label SakuraTextColorLabel;
        private ComboBox SakuraTextColor;
        private ComboBox SakuraBgColor;
        private Label SakuraBgColorLabel;
        private Button SakuraButtonHideSettings;
        private Label SakuraMaxNumLabel;
        private NumericUpDown SakuraMaxNum;
        private Label SakuraZoomIncrementLabel;
        private NumericUpDown SakuraZoomIncrement;
        private TextBox SakuraPlt0Textbox;
        private Label SakuraPlt0Label;
        private ComboBox SakuraConvert;
        private Label SakuraConvertLabel;
        private ComboBox SakuraTo;
        private Label SakuraToLabel;
        private NumericUpDown SakuraMetadataLengthNumeric;
        private Label SakuraMetadataLengthLabel;
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