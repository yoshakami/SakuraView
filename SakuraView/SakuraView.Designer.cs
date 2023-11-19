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
            this.SakuraBox = new PictureBoxWithInterpolationMode();
            this.SakuraCkLoop = new System.Windows.Forms.CheckBox();
            this.SakuraCkCounter = new System.Windows.Forms.CheckBox();
            this.SakuraCkAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.SakuraCkBanner = new System.Windows.Forms.CheckBox();
            this.SakuraCkConsole = new System.Windows.Forms.CheckBox();
            this.SakuraCkMetadata = new System.Windows.Forms.CheckBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraZoomNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraZoomTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // SakuraInfo
            // 
            this.SakuraInfo.AllowDrop = true;
            this.SakuraInfo.AutoSize = true;
            this.SakuraInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraInfo.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraInfo.Location = new System.Drawing.Point(16, 517);
            this.SakuraInfo.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraInfo.Name = "SakuraInfo";
            this.SakuraInfo.Size = new System.Drawing.Size(132, 27);
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
            this.SakuraSideHelp.Size = new System.Drawing.Size(296, 1239);
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
            this.SakuraHidden.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraHidden.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraHidden.Location = new System.Drawing.Point(628, 56);
            this.SakuraHidden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SakuraHidden.Name = "SakuraHidden";
            this.SakuraHidden.Size = new System.Drawing.Size(156, 27);
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
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 22);
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
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.textBox4.Location = new System.Drawing.Point(1045, 12);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(203, 22);
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
            this.SakuraConsole.Location = new System.Drawing.Point(562, 91);
            this.SakuraConsole.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraConsole.Name = "SakuraConsole";
            this.SakuraConsole.Size = new System.Drawing.Size(119, 21);
            this.SakuraConsole.TabIndex = 14;
            this.SakuraConsole.Text = "Console output:";
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
            this.SakuraMetadata.Location = new System.Drawing.Point(766, 91);
            this.SakuraMetadata.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraMetadata.Name = "SakuraMetadata";
            this.SakuraMetadata.Size = new System.Drawing.Size(123, 21);
            this.SakuraMetadata.TabIndex = 15;
            this.SakuraMetadata.Text = "SakuraMetadata";
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
            this.SakuraUnseen.Location = new System.Drawing.Point(840, 62);
            this.SakuraUnseen.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraUnseen.Name = "SakuraUnseen";
            this.SakuraUnseen.Size = new System.Drawing.Size(110, 21);
            this.SakuraUnseen.TabIndex = 16;
            this.SakuraUnseen.Text = "SakuraUnseen";
            this.SakuraUnseen.Visible = false;
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
            this.SakuraBox.Size = new System.Drawing.Size(48, 48);
            this.SakuraBox.TabIndex = 0;
            this.SakuraBox.TabStop = false;
            // 
            // SakuraCkLoop
            // 
            this.SakuraCkLoop.AutoSize = true;
            this.SakuraCkLoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraCkLoop.ForeColor = System.Drawing.Color.White;
            this.SakuraCkLoop.Location = new System.Drawing.Point(420, 311);
            this.SakuraCkLoop.Name = "SakuraCkLoop";
            this.SakuraCkLoop.Size = new System.Drawing.Size(62, 24);
            this.SakuraCkLoop.TabIndex = 17;
            this.SakuraCkLoop.Text = "loop";
            this.SakuraCkLoop.UseVisualStyleBackColor = true;
            this.SakuraCkLoop.CheckedChanged += new System.EventHandler(this.SakuraCkLoop_CheckedChanged);
            // 
            // SakuraCkCounter
            // 
            this.SakuraCkCounter.AutoSize = true;
            this.SakuraCkCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraCkCounter.ForeColor = System.Drawing.Color.White;
            this.SakuraCkCounter.Location = new System.Drawing.Point(420, 401);
            this.SakuraCkCounter.Name = "SakuraCkCounter";
            this.SakuraCkCounter.Size = new System.Drawing.Size(87, 24);
            this.SakuraCkCounter.TabIndex = 18;
            this.SakuraCkCounter.Text = "counter";
            this.SakuraCkCounter.UseVisualStyleBackColor = true;
            this.SakuraCkCounter.CheckedChanged += new System.EventHandler(this.SakuraCkCounter_CheckedChanged);
            // 
            // SakuraCkAlwaysOnTop
            // 
            this.SakuraCkAlwaysOnTop.AutoSize = true;
            this.SakuraCkAlwaysOnTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraCkAlwaysOnTop.ForeColor = System.Drawing.Color.White;
            this.SakuraCkAlwaysOnTop.Location = new System.Drawing.Point(420, 131);
            this.SakuraCkAlwaysOnTop.Name = "SakuraCkAlwaysOnTop";
            this.SakuraCkAlwaysOnTop.Size = new System.Drawing.Size(133, 24);
            this.SakuraCkAlwaysOnTop.TabIndex = 19;
            this.SakuraCkAlwaysOnTop.Text = "always on top";
            this.SakuraCkAlwaysOnTop.UseVisualStyleBackColor = true;
            this.SakuraCkAlwaysOnTop.CheckedChanged += new System.EventHandler(this.SakuraCkAlwaysOnTop_CheckedChanged);
            // 
            // SakuraCkBanner
            // 
            this.SakuraCkBanner.AutoSize = true;
            this.SakuraCkBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraCkBanner.ForeColor = System.Drawing.Color.White;
            this.SakuraCkBanner.Location = new System.Drawing.Point(420, 161);
            this.SakuraCkBanner.Name = "SakuraCkBanner";
            this.SakuraCkBanner.Size = new System.Drawing.Size(82, 24);
            this.SakuraCkBanner.TabIndex = 20;
            this.SakuraCkBanner.Text = "banner";
            this.SakuraCkBanner.UseVisualStyleBackColor = true;
            this.SakuraCkBanner.CheckedChanged += new System.EventHandler(this.SakuraCkBanner_CheckedChanged);
            // 
            // SakuraCkConsole
            // 
            this.SakuraCkConsole.AutoSize = true;
            this.SakuraCkConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraCkConsole.ForeColor = System.Drawing.Color.White;
            this.SakuraCkConsole.Location = new System.Drawing.Point(420, 191);
            this.SakuraCkConsole.Name = "SakuraCkConsole";
            this.SakuraCkConsole.Size = new System.Drawing.Size(89, 24);
            this.SakuraCkConsole.TabIndex = 21;
            this.SakuraCkConsole.Text = "console";
            this.SakuraCkConsole.UseVisualStyleBackColor = true;
            this.SakuraCkConsole.CheckedChanged += new System.EventHandler(this.SakuraCkConsole_CheckedChanged);
            // 
            // SakuraCkMetadata
            // 
            this.SakuraCkMetadata.AutoSize = true;
            this.SakuraCkMetadata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraCkMetadata.ForeColor = System.Drawing.Color.White;
            this.SakuraCkMetadata.Location = new System.Drawing.Point(420, 341);
            this.SakuraCkMetadata.Name = "SakuraCkMetadata";
            this.SakuraCkMetadata.Size = new System.Drawing.Size(100, 24);
            this.SakuraCkMetadata.TabIndex = 22;
            this.SakuraCkMetadata.Text = "metadata";
            this.SakuraCkMetadata.UseVisualStyleBackColor = true;
            this.SakuraCkMetadata.CheckedChanged += new System.EventHandler(this.SakuraCkMetadata_CheckedChanged);
            // 
            // SakuraCkInfo
            // 
            this.SakuraCkInfo.AutoSize = true;
            this.SakuraCkInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraCkInfo.ForeColor = System.Drawing.Color.White;
            this.SakuraCkInfo.Location = new System.Drawing.Point(420, 281);
            this.SakuraCkInfo.Name = "SakuraCkInfo";
            this.SakuraCkInfo.Size = new System.Drawing.Size(58, 24);
            this.SakuraCkInfo.TabIndex = 23;
            this.SakuraCkInfo.Text = "info";
            this.SakuraCkInfo.UseVisualStyleBackColor = true;
            this.SakuraCkInfo.CheckedChanged += new System.EventHandler(this.SakuraCkInfo_CheckedChanged);
            // 
            // SakuraCkHelp
            // 
            this.SakuraCkHelp.AutoSize = true;
            this.SakuraCkHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraCkHelp.ForeColor = System.Drawing.Color.White;
            this.SakuraCkHelp.Location = new System.Drawing.Point(420, 251);
            this.SakuraCkHelp.Name = "SakuraCkHelp";
            this.SakuraCkHelp.Size = new System.Drawing.Size(62, 24);
            this.SakuraCkHelp.TabIndex = 24;
            this.SakuraCkHelp.Text = "help";
            this.SakuraCkHelp.UseVisualStyleBackColor = true;
            this.SakuraCkHelp.CheckedChanged += new System.EventHandler(this.SakuraCkHelp_CheckedChanged);
            // 
            // SakuraCkSubFolders
            // 
            this.SakuraCkSubFolders.AutoSize = true;
            this.SakuraCkSubFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraCkSubFolders.ForeColor = System.Drawing.Color.White;
            this.SakuraCkSubFolders.Location = new System.Drawing.Point(420, 371);
            this.SakuraCkSubFolders.Name = "SakuraCkSubFolders";
            this.SakuraCkSubFolders.Size = new System.Drawing.Size(202, 24);
            this.SakuraCkSubFolders.TabIndex = 25;
            this.SakuraCkSubFolders.Text = "sub-folders processing";
            this.SakuraCkSubFolders.UseVisualStyleBackColor = true;
            this.SakuraCkSubFolders.CheckedChanged += new System.EventHandler(this.SakuraCkSubFolders_CheckedChanged);
            // 
            // SakuraCkDuplicates
            // 
            this.SakuraCkDuplicates.AutoSize = true;
            this.SakuraCkDuplicates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraCkDuplicates.ForeColor = System.Drawing.Color.White;
            this.SakuraCkDuplicates.Location = new System.Drawing.Point(420, 221);
            this.SakuraCkDuplicates.Name = "SakuraCkDuplicates";
            this.SakuraCkDuplicates.Size = new System.Drawing.Size(107, 24);
            this.SakuraCkDuplicates.TabIndex = 26;
            this.SakuraCkDuplicates.Text = "duplicates";
            this.SakuraCkDuplicates.UseVisualStyleBackColor = true;
            this.SakuraCkDuplicates.CheckedChanged += new System.EventHandler(this.SakuraCkDuplicates_CheckedChanged);
            // 
            // SakuraButtonEmpty
            // 
            this.SakuraButtonEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraButtonEmpty.Location = new System.Drawing.Point(20, 131);
            this.SakuraButtonEmpty.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraButtonEmpty.Name = "SakuraButtonEmpty";
            this.SakuraButtonEmpty.Size = new System.Drawing.Size(155, 54);
            this.SakuraButtonEmpty.TabIndex = 27;
            this.SakuraButtonEmpty.Text = "Empty List";
            this.SakuraButtonEmpty.UseVisualStyleBackColor = true;
            this.SakuraButtonEmpty.Click += new System.EventHandler(this.SakuraButtonEmpty_Click);
            // 
            // SakuraButtonOpenFiles
            // 
            this.SakuraButtonOpenFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraButtonOpenFiles.Location = new System.Drawing.Point(20, 191);
            this.SakuraButtonOpenFiles.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraButtonOpenFiles.Name = "SakuraButtonOpenFiles";
            this.SakuraButtonOpenFiles.Size = new System.Drawing.Size(155, 54);
            this.SakuraButtonOpenFiles.TabIndex = 28;
            this.SakuraButtonOpenFiles.Text = "Open Files";
            this.SakuraButtonOpenFiles.UseVisualStyleBackColor = true;
            this.SakuraButtonOpenFiles.Click += new System.EventHandler(this.SakuraButtonOpenFiles_Click);
            // 
            // SakuraButtonGithub
            // 
            this.SakuraButtonGithub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraButtonGithub.Location = new System.Drawing.Point(20, 251);
            this.SakuraButtonGithub.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraButtonGithub.Name = "SakuraButtonGithub";
            this.SakuraButtonGithub.Size = new System.Drawing.Size(155, 54);
            this.SakuraButtonGithub.TabIndex = 29;
            this.SakuraButtonGithub.Text = "Github Releases";
            this.SakuraButtonGithub.UseVisualStyleBackColor = true;
            this.SakuraButtonGithub.Click += new System.EventHandler(this.SakuraButtonGithub_Click);
            // 
            // SakuraButtonClearConsole
            // 
            this.SakuraButtonClearConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraButtonClearConsole.Location = new System.Drawing.Point(20, 311);
            this.SakuraButtonClearConsole.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraButtonClearConsole.Name = "SakuraButtonClearConsole";
            this.SakuraButtonClearConsole.Size = new System.Drawing.Size(155, 54);
            this.SakuraButtonClearConsole.TabIndex = 30;
            this.SakuraButtonClearConsole.Text = "Clear Console";
            this.SakuraButtonClearConsole.UseVisualStyleBackColor = true;
            this.SakuraButtonClearConsole.Click += new System.EventHandler(this.SakuraButtonClearConsole_Click);
            // 
            // SakuraButtonDirectory
            // 
            this.SakuraButtonDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraButtonDirectory.Location = new System.Drawing.Point(20, 371);
            this.SakuraButtonDirectory.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraButtonDirectory.Name = "SakuraButtonDirectory";
            this.SakuraButtonDirectory.Size = new System.Drawing.Size(155, 54);
            this.SakuraButtonDirectory.TabIndex = 31;
            this.SakuraButtonDirectory.Text = "Open Directory";
            this.SakuraButtonDirectory.UseVisualStyleBackColor = true;
            this.SakuraButtonDirectory.Click += new System.EventHandler(this.SakuraButtonDirectory_Click);
            // 
            // SakuraButton10Lines
            // 
            this.SakuraButton10Lines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraButton10Lines.Location = new System.Drawing.Point(215, 131);
            this.SakuraButton10Lines.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraButton10Lines.Name = "SakuraButton10Lines";
            this.SakuraButton10Lines.Size = new System.Drawing.Size(155, 54);
            this.SakuraButton10Lines.TabIndex = 32;
            this.SakuraButton10Lines.Text = "Remove 10 lines off the console";
            this.SakuraButton10Lines.UseVisualStyleBackColor = true;
            this.SakuraButton10Lines.Click += new System.EventHandler(this.SakuraButton10Lines_Click);
            // 
            // SakuraButtonRotate
            // 
            this.SakuraButtonRotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraButtonRotate.Location = new System.Drawing.Point(215, 191);
            this.SakuraButtonRotate.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraButtonRotate.Name = "SakuraButtonRotate";
            this.SakuraButtonRotate.Size = new System.Drawing.Size(155, 54);
            this.SakuraButtonRotate.TabIndex = 33;
            this.SakuraButtonRotate.Text = "Rotate";
            this.SakuraButtonRotate.UseVisualStyleBackColor = true;
            this.SakuraButtonRotate.Click += new System.EventHandler(this.SakuraButtonRotate_Click);
            // 
            // SakuraButtonSave
            // 
            this.SakuraButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraButtonSave.Location = new System.Drawing.Point(215, 371);
            this.SakuraButtonSave.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraButtonSave.Name = "SakuraButtonSave";
            this.SakuraButtonSave.Size = new System.Drawing.Size(155, 54);
            this.SakuraButtonSave.TabIndex = 34;
            this.SakuraButtonSave.Text = "Save Config";
            this.SakuraButtonSave.UseVisualStyleBackColor = true;
            this.SakuraButtonSave.Click += new System.EventHandler(this.SakuraButtonSave_Click);
            // 
            // SakuraButtonSwapV
            // 
            this.SakuraButtonSwapV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraButtonSwapV.Location = new System.Drawing.Point(215, 251);
            this.SakuraButtonSwapV.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraButtonSwapV.Name = "SakuraButtonSwapV";
            this.SakuraButtonSwapV.Size = new System.Drawing.Size(155, 54);
            this.SakuraButtonSwapV.TabIndex = 35;
            this.SakuraButtonSwapV.Text = "Swap Vertically";
            this.SakuraButtonSwapV.UseVisualStyleBackColor = true;
            this.SakuraButtonSwapV.Click += new System.EventHandler(this.SakuraButtonSwapV_Click);
            // 
            // SakuraButtonSwapH
            // 
            this.SakuraButtonSwapH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraButtonSwapH.Location = new System.Drawing.Point(215, 311);
            this.SakuraButtonSwapH.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraButtonSwapH.Name = "SakuraButtonSwapH";
            this.SakuraButtonSwapH.Size = new System.Drawing.Size(155, 54);
            this.SakuraButtonSwapH.TabIndex = 36;
            this.SakuraButtonSwapH.Text = "Swap Horizontally";
            this.SakuraButtonSwapH.UseVisualStyleBackColor = true;
            this.SakuraButtonSwapH.Click += new System.EventHandler(this.SakuraButtonSwapH_Click);
            // 
            // SakuraZoomNumeric
            // 
            this.SakuraZoomNumeric.Location = new System.Drawing.Point(420, 90);
            this.SakuraZoomNumeric.Name = "SakuraZoomNumeric";
            this.SakuraZoomNumeric.Size = new System.Drawing.Size(120, 22);
            this.SakuraZoomNumeric.TabIndex = 38;
            this.SakuraZoomNumeric.ValueChanged += new System.EventHandler(this.SakuraZoomNumeric_ValueChanged);
            // 
            // SakuraZoomTrackBar
            // 
            this.SakuraZoomTrackBar.Location = new System.Drawing.Point(21, 56);
            this.SakuraZoomTrackBar.Name = "SakuraZoomTrackBar";
            this.SakuraZoomTrackBar.Size = new System.Drawing.Size(349, 56);
            this.SakuraZoomTrackBar.TabIndex = 39;
            this.SakuraZoomTrackBar.Scroll += new System.EventHandler(this.SakuraZoomTrackBar_Scroll);
            // 
            // SakuraZoomLabel
            // 
            this.SakuraZoomLabel.AllowDrop = true;
            this.SakuraZoomLabel.AutoSize = true;
            this.SakuraZoomLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraZoomLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraZoomLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraZoomLabel.Location = new System.Drawing.Point(421, 56);
            this.SakuraZoomLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraZoomLabel.Name = "SakuraZoomLabel";
            this.SakuraZoomLabel.Size = new System.Drawing.Size(100, 21);
            this.SakuraZoomLabel.TabIndex = 40;
            this.SakuraZoomLabel.Text = "<-- zoom --v";
            // 
            // SakuraView
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1660, 554);
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
            this.Controls.Add(this.SakuraCkMetadata);
            this.Controls.Add(this.SakuraCkConsole);
            this.Controls.Add(this.SakuraCkBanner);
            this.Controls.Add(this.SakuraCkAlwaysOnTop);
            this.Controls.Add(this.SakuraCkCounter);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(18, 47);
            this.Name = "SakuraView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SakuraView";
            this.ClientSizeChanged += new System.EventHandler(this.SakuraView_ClientSizeChanged);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.SakuraViewClass_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SakuraViewClass_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SakuraView_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraZoomNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraZoomTrackBar)).EndInit();
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
        private CheckBox SakuraCkCounter;
        private CheckBox SakuraCkAlwaysOnTop;
        private CheckBox SakuraCkBanner;
        private CheckBox SakuraCkConsole;
        private CheckBox SakuraCkMetadata;
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