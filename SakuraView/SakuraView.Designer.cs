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
            this.SakuraMetadata = new System.Windows.Forms.Label();
            this.SakuraUnseen = new System.Windows.Forms.Label();
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
            this.SakuraCkSkip = new System.Windows.Forms.CheckBox();
            this.SakuraDisplayLabel = new System.Windows.Forms.Label();
            this.SakuraDisplayTrackBar = new System.Windows.Forms.TrackBar();
            this.SakuraDisplayNumeric = new System.Windows.Forms.NumericUpDown();
            this.SakuraLayout = new System.Windows.Forms.ComboBox();
            this.SakuraLayoutLabel = new System.Windows.Forms.Label();
            this.SakuraStyleLabel = new System.Windows.Forms.Label();
            this.SakuraStyleTrackBar = new System.Windows.Forms.TrackBar();
            this.SakuraLayoutTrackBar = new System.Windows.Forms.TrackBar();
            this.SakuraUnsavedChanges = new System.Windows.Forms.Label();
            this.SakuraText = new System.Windows.Forms.Label();
            this.SakuraText1 = new System.Windows.Forms.Label();
            this.SakuraText15 = new System.Windows.Forms.Label();
            this.SakuraText16 = new System.Windows.Forms.Label();
            this.SakuraText17 = new System.Windows.Forms.Label();
            this.SakuraText18 = new System.Windows.Forms.Label();
            this.SakuraText19 = new System.Windows.Forms.Label();
            this.SakuraText20 = new System.Windows.Forms.Label();
            this.SakuraText21 = new System.Windows.Forms.Label();
            this.SakuraText22 = new System.Windows.Forms.Label();
            this.SakuraText23 = new System.Windows.Forms.Label();
            this.SakuraText31 = new System.Windows.Forms.Label();
            this.SakuraText30 = new System.Windows.Forms.Label();
            this.SakuraText29 = new System.Windows.Forms.Label();
            this.SakuraText28 = new System.Windows.Forms.Label();
            this.SakuraText27 = new System.Windows.Forms.Label();
            this.SakuraText26 = new System.Windows.Forms.Label();
            this.SakuraText25 = new System.Windows.Forms.Label();
            this.SakuraText24 = new System.Windows.Forms.Label();
            this.SakuraText4 = new System.Windows.Forms.Label();
            this.SakuraText3 = new System.Windows.Forms.Label();
            this.SakuraText2 = new System.Windows.Forms.Label();
            this.SakuraText59 = new System.Windows.Forms.Label();
            this.SakuraText60 = new System.Windows.Forms.Label();
            this.SakuraText61 = new System.Windows.Forms.Label();
            this.SakuraText62 = new System.Windows.Forms.Label();
            this.SakuraText63 = new System.Windows.Forms.Label();
            this.SakuraText5 = new System.Windows.Forms.Label();
            this.SakuraText6 = new System.Windows.Forms.Label();
            this.SakuraText7 = new System.Windows.Forms.Label();
            this.SakuraText8 = new System.Windows.Forms.Label();
            this.SakuraText9 = new System.Windows.Forms.Label();
            this.SakuraText10 = new System.Windows.Forms.Label();
            this.SakuraText11 = new System.Windows.Forms.Label();
            this.SakuraText12 = new System.Windows.Forms.Label();
            this.SakuraText13 = new System.Windows.Forms.Label();
            this.SakuraText14 = new System.Windows.Forms.Label();
            this.SakuraText47 = new System.Windows.Forms.Label();
            this.SakuraText48 = new System.Windows.Forms.Label();
            this.SakuraText49 = new System.Windows.Forms.Label();
            this.SakuraText50 = new System.Windows.Forms.Label();
            this.SakuraText51 = new System.Windows.Forms.Label();
            this.SakuraText52 = new System.Windows.Forms.Label();
            this.SakuraText53 = new System.Windows.Forms.Label();
            this.SakuraText54 = new System.Windows.Forms.Label();
            this.SakuraText55 = new System.Windows.Forms.Label();
            this.SakuraText56 = new System.Windows.Forms.Label();
            this.SakuraText57 = new System.Windows.Forms.Label();
            this.SakuraText58 = new System.Windows.Forms.Label();
            this.SakuraText39 = new System.Windows.Forms.Label();
            this.SakuraText40 = new System.Windows.Forms.Label();
            this.SakuraText41 = new System.Windows.Forms.Label();
            this.SakuraText42 = new System.Windows.Forms.Label();
            this.SakuraText43 = new System.Windows.Forms.Label();
            this.SakuraText44 = new System.Windows.Forms.Label();
            this.SakuraText45 = new System.Windows.Forms.Label();
            this.SakuraText46 = new System.Windows.Forms.Label();
            this.SakuraText32 = new System.Windows.Forms.Label();
            this.SakuraText33 = new System.Windows.Forms.Label();
            this.SakuraText34 = new System.Windows.Forms.Label();
            this.SakuraText35 = new System.Windows.Forms.Label();
            this.SakuraText36 = new System.Windows.Forms.Label();
            this.SakuraText37 = new System.Windows.Forms.Label();
            this.SakuraText38 = new System.Windows.Forms.Label();
            this.SakuraBorderTrackBar = new System.Windows.Forms.TrackBar();
            this.SakuraBorderNumeric = new System.Windows.Forms.NumericUpDown();
            this.SakuraBorderLabel = new System.Windows.Forms.Label();
            this.SakuraWidthTrackBar = new System.Windows.Forms.TrackBar();
            this.SakuraWidthNumeric = new System.Windows.Forms.NumericUpDown();
            this.SakuraWidthLabel = new System.Windows.Forms.Label();
            this.SakuraCkVariableWidth = new System.Windows.Forms.CheckBox();
            this.SakuraCkVariableHeight = new System.Windows.Forms.CheckBox();
            this.SakuraHeightTrackBar = new System.Windows.Forms.TrackBar();
            this.SakuraHeightNumeric = new System.Windows.Forms.NumericUpDown();
            this.SakuraHeightLabel = new System.Windows.Forms.Label();
            this.SakuraStyle = new System.Windows.Forms.ComboBox();
            this.SakuraBox52 = new PictureBoxWithInterpolationMode();
            this.SakuraBox53 = new PictureBoxWithInterpolationMode();
            this.SakuraBox54 = new PictureBoxWithInterpolationMode();
            this.SakuraBox55 = new PictureBoxWithInterpolationMode();
            this.SakuraBox56 = new PictureBoxWithInterpolationMode();
            this.SakuraBox57 = new PictureBoxWithInterpolationMode();
            this.SakuraBox58 = new PictureBoxWithInterpolationMode();
            this.SakuraBox59 = new PictureBoxWithInterpolationMode();
            this.SakuraBox60 = new PictureBoxWithInterpolationMode();
            this.SakuraBox61 = new PictureBoxWithInterpolationMode();
            this.SakuraBox62 = new PictureBoxWithInterpolationMode();
            this.SakuraBox63 = new PictureBoxWithInterpolationMode();
            this.SakuraBox1 = new PictureBoxWithInterpolationMode();
            this.SakuraBox34 = new PictureBoxWithInterpolationMode();
            this.SakuraBox35 = new PictureBoxWithInterpolationMode();
            this.SakuraBox36 = new PictureBoxWithInterpolationMode();
            this.SakuraBox37 = new PictureBoxWithInterpolationMode();
            this.SakuraBox38 = new PictureBoxWithInterpolationMode();
            this.SakuraBox39 = new PictureBoxWithInterpolationMode();
            this.SakuraBox40 = new PictureBoxWithInterpolationMode();
            this.SakuraBox41 = new PictureBoxWithInterpolationMode();
            this.SakuraBox42 = new PictureBoxWithInterpolationMode();
            this.SakuraBox43 = new PictureBoxWithInterpolationMode();
            this.SakuraBox44 = new PictureBoxWithInterpolationMode();
            this.SakuraBox45 = new PictureBoxWithInterpolationMode();
            this.SakuraBox46 = new PictureBoxWithInterpolationMode();
            this.SakuraBox47 = new PictureBoxWithInterpolationMode();
            this.SakuraBox48 = new PictureBoxWithInterpolationMode();
            this.SakuraBox49 = new PictureBoxWithInterpolationMode();
            this.SakuraBox50 = new PictureBoxWithInterpolationMode();
            this.SakuraBox51 = new PictureBoxWithInterpolationMode();
            this.SakuraBox33 = new PictureBoxWithInterpolationMode();
            this.SakuraBox20 = new PictureBoxWithInterpolationMode();
            this.SakuraBox21 = new PictureBoxWithInterpolationMode();
            this.SakuraBox22 = new PictureBoxWithInterpolationMode();
            this.SakuraBox23 = new PictureBoxWithInterpolationMode();
            this.SakuraBox24 = new PictureBoxWithInterpolationMode();
            this.SakuraBox25 = new PictureBoxWithInterpolationMode();
            this.SakuraBox26 = new PictureBoxWithInterpolationMode();
            this.SakuraBox27 = new PictureBoxWithInterpolationMode();
            this.SakuraBox28 = new PictureBoxWithInterpolationMode();
            this.SakuraBox29 = new PictureBoxWithInterpolationMode();
            this.SakuraBox30 = new PictureBoxWithInterpolationMode();
            this.SakuraBox31 = new PictureBoxWithInterpolationMode();
            this.SakuraBox32 = new PictureBoxWithInterpolationMode();
            this.SakuraBox2 = new PictureBoxWithInterpolationMode();
            this.SakuraBox3 = new PictureBoxWithInterpolationMode();
            this.SakuraBox4 = new PictureBoxWithInterpolationMode();
            this.SakuraBox5 = new PictureBoxWithInterpolationMode();
            this.SakuraBox6 = new PictureBoxWithInterpolationMode();
            this.SakuraBox7 = new PictureBoxWithInterpolationMode();
            this.SakuraBox8 = new PictureBoxWithInterpolationMode();
            this.SakuraBox9 = new PictureBoxWithInterpolationMode();
            this.SakuraBox10 = new PictureBoxWithInterpolationMode();
            this.SakuraBox11 = new PictureBoxWithInterpolationMode();
            this.SakuraBox12 = new PictureBoxWithInterpolationMode();
            this.SakuraBox13 = new PictureBoxWithInterpolationMode();
            this.SakuraBox14 = new PictureBoxWithInterpolationMode();
            this.SakuraBox15 = new PictureBoxWithInterpolationMode();
            this.SakuraBox16 = new PictureBoxWithInterpolationMode();
            this.SakuraBox17 = new PictureBoxWithInterpolationMode();
            this.SakuraBox18 = new PictureBoxWithInterpolationMode();
            this.SakuraBox19 = new PictureBoxWithInterpolationMode();
            this.SakuraBox = new PictureBoxWithInterpolationMode();
            this.SakuraInfoPaddingLabel = new System.Windows.Forms.Label();
            this.SakuraInfoPaddingNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraZoomNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraZoomTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraMaxNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraZoomIncrement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraDisplayTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraDisplayNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraStyleTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraLayoutTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBorderTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBorderNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraWidthTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraWidthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraHeightTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraHeightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox58)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox62)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraInfoPaddingNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // SakuraInfo
            // 
            this.SakuraInfo.AllowDrop = true;
            this.SakuraInfo.AutoSize = true;
            this.SakuraInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraInfo.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraInfo.Location = new System.Drawing.Point(7, 674);
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
            this.SakuraSideHelp.Location = new System.Drawing.Point(1269, 0);
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
            this.SakuraHelp.Location = new System.Drawing.Point(-4, 835);
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
            this.SakuraHidden.Location = new System.Drawing.Point(850, 623);
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
            this.SakuraConsole.Location = new System.Drawing.Point(641, 511);
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
            this.SakuraMetadata.Location = new System.Drawing.Point(650, 644);
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
            this.SakuraUnseen.Location = new System.Drawing.Point(650, 596);
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
            this.SakuraCkLoop.Location = new System.Drawing.Point(313, 220);
            this.SakuraCkLoop.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraCkLoop.Name = "SakuraCkLoop";
            this.SakuraCkLoop.Size = new System.Drawing.Size(54, 21);
            this.SakuraCkLoop.TabIndex = 17;
            this.SakuraCkLoop.Text = "loop";
            this.SakuraCkLoop.UseVisualStyleBackColor = true;
            this.SakuraCkLoop.CheckedChanged += new System.EventHandler(this.SakuraCkLoop_CheckedChanged);
            this.SakuraCkLoop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SakuraView_KeyDown);
            // 
            // SakuraCkCounter
            // 
            this.SakuraCkCounter.AutoSize = true;
            this.SakuraCkCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraCkCounter.ForeColor = System.Drawing.Color.White;
            this.SakuraCkCounter.Location = new System.Drawing.Point(313, 293);
            this.SakuraCkCounter.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraCkCounter.Name = "SakuraCkCounter";
            this.SakuraCkCounter.Size = new System.Drawing.Size(75, 21);
            this.SakuraCkCounter.TabIndex = 18;
            this.SakuraCkCounter.Text = "counter";
            this.SakuraCkCounter.UseVisualStyleBackColor = true;
            this.SakuraCkCounter.CheckedChanged += new System.EventHandler(this.SakuraCkCounter_CheckedChanged);
            this.SakuraCkCounter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SakuraView_KeyDown);
            // 
            // SakuraCkAlwaysOnTop
            // 
            this.SakuraCkAlwaysOnTop.AutoSize = true;
            this.SakuraCkAlwaysOnTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraCkAlwaysOnTop.ForeColor = System.Drawing.Color.White;
            this.SakuraCkAlwaysOnTop.Location = new System.Drawing.Point(313, 73);
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
            this.SakuraCkBanner.Location = new System.Drawing.Point(313, 98);
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
            this.SakuraCkConsole.Location = new System.Drawing.Point(313, 122);
            this.SakuraCkConsole.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraCkConsole.Name = "SakuraCkConsole";
            this.SakuraCkConsole.Size = new System.Drawing.Size(76, 21);
            this.SakuraCkConsole.TabIndex = 21;
            this.SakuraCkConsole.Text = "console";
            this.SakuraCkConsole.UseVisualStyleBackColor = true;
            this.SakuraCkConsole.CheckedChanged += new System.EventHandler(this.SakuraCkConsole_CheckedChanged);
            this.SakuraCkConsole.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SakuraView_KeyDown);
            // 
            // SakuraCkMetadata
            // 
            this.SakuraCkMetadata.AutoSize = true;
            this.SakuraCkMetadata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraCkMetadata.ForeColor = System.Drawing.Color.White;
            this.SakuraCkMetadata.Location = new System.Drawing.Point(313, 244);
            this.SakuraCkMetadata.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraCkMetadata.Name = "SakuraCkMetadata";
            this.SakuraCkMetadata.Size = new System.Drawing.Size(86, 21);
            this.SakuraCkMetadata.TabIndex = 22;
            this.SakuraCkMetadata.Text = "metadata";
            this.SakuraCkMetadata.UseVisualStyleBackColor = true;
            this.SakuraCkMetadata.CheckedChanged += new System.EventHandler(this.SakuraCkMetadata_CheckedChanged);
            this.SakuraCkMetadata.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SakuraView_KeyDown);
            // 
            // SakuraCkInfo
            // 
            this.SakuraCkInfo.AutoSize = true;
            this.SakuraCkInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraCkInfo.ForeColor = System.Drawing.Color.White;
            this.SakuraCkInfo.Location = new System.Drawing.Point(313, 195);
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
            this.SakuraCkHelp.Location = new System.Drawing.Point(313, 171);
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
            this.SakuraCkSubFolders.Location = new System.Drawing.Point(313, 268);
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
            this.SakuraCkDuplicates.Location = new System.Drawing.Point(313, 147);
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
            this.SakuraButtonEmpty.Location = new System.Drawing.Point(13, 73);
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
            this.SakuraButtonOpenFiles.Location = new System.Drawing.Point(13, 122);
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
            this.SakuraButtonGithub.Location = new System.Drawing.Point(13, 171);
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
            this.SakuraButtonClearConsole.Location = new System.Drawing.Point(13, 220);
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
            this.SakuraButtonDirectory.Location = new System.Drawing.Point(13, 268);
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
            this.SakuraButton10Lines.Location = new System.Drawing.Point(159, 73);
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
            this.SakuraButtonRotate.Location = new System.Drawing.Point(159, 122);
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
            this.SakuraButtonSave.Location = new System.Drawing.Point(494, 386);
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
            this.SakuraButtonSwapV.Location = new System.Drawing.Point(159, 171);
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
            this.SakuraButtonSwapH.Location = new System.Drawing.Point(159, 220);
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
            this.SakuraZoomNumeric.Location = new System.Drawing.Point(836, 75);
            this.SakuraZoomNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraZoomNumeric.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.SakuraZoomNumeric.Name = "SakuraZoomNumeric";
            this.SakuraZoomNumeric.Size = new System.Drawing.Size(97, 20);
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
            this.SakuraZoomTrackBar.Location = new System.Drawing.Point(971, 71);
            this.SakuraZoomTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraZoomTrackBar.Name = "SakuraZoomTrackBar";
            this.SakuraZoomTrackBar.Size = new System.Drawing.Size(221, 45);
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
            this.SakuraZoomLabel.Location = new System.Drawing.Point(716, 74);
            this.SakuraZoomLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraZoomLabel.Name = "SakuraZoomLabel";
            this.SakuraZoomLabel.Size = new System.Drawing.Size(49, 21);
            this.SakuraZoomLabel.TabIndex = 40;
            this.SakuraZoomLabel.Text = "zoom";
            // 
            // SakuraImgcvtLabel
            // 
            this.SakuraImgcvtLabel.AllowDrop = true;
            this.SakuraImgcvtLabel.AutoSize = true;
            this.SakuraImgcvtLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraImgcvtLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraImgcvtLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraImgcvtLabel.Location = new System.Drawing.Point(15, 441);
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
            this.SakuraImgcvt.Location = new System.Drawing.Point(13, 473);
            this.SakuraImgcvt.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraImgcvt.Name = "SakuraImgcvt";
            this.SakuraImgcvt.Size = new System.Drawing.Size(475, 22);
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
            this.SakuraButtonHideSettings.Location = new System.Drawing.Point(159, 270);
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
            this.SakuraPlt0Textbox.Location = new System.Drawing.Point(13, 543);
            this.SakuraPlt0Textbox.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraPlt0Textbox.Name = "SakuraPlt0Textbox";
            this.SakuraPlt0Textbox.Size = new System.Drawing.Size(475, 22);
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
            this.SakuraPlt0Label.Location = new System.Drawing.Point(15, 511);
            this.SakuraPlt0Label.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraPlt0Label.Name = "SakuraPlt0Label";
            this.SakuraPlt0Label.Size = new System.Drawing.Size(98, 21);
            this.SakuraPlt0Label.TabIndex = 52;
            this.SakuraPlt0Label.Text = "plt0.exe path";
            // 
            // SakuraConvert
            // 
            this.SakuraConvert.FormattingEnabled = true;
            this.SakuraConvert.Location = new System.Drawing.Point(18, 609);
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
            this.SakuraConvertLabel.Location = new System.Drawing.Point(44, 585);
            this.SakuraConvertLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraConvertLabel.Name = "SakuraConvertLabel";
            this.SakuraConvertLabel.Size = new System.Drawing.Size(65, 21);
            this.SakuraConvertLabel.TabIndex = 54;
            this.SakuraConvertLabel.Text = "Convert";
            // 
            // SakuraTo
            // 
            this.SakuraTo.FormattingEnabled = true;
            this.SakuraTo.Location = new System.Drawing.Point(161, 609);
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
            this.SakuraToLabel.Location = new System.Drawing.Point(208, 585);
            this.SakuraToLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraToLabel.Name = "SakuraToLabel";
            this.SakuraToLabel.Size = new System.Drawing.Size(25, 21);
            this.SakuraToLabel.TabIndex = 56;
            this.SakuraToLabel.Text = "To";
            // 
            // SakuraCkSkip
            // 
            this.SakuraCkSkip.AutoSize = true;
            this.SakuraCkSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraCkSkip.ForeColor = System.Drawing.Color.White;
            this.SakuraCkSkip.Location = new System.Drawing.Point(313, 318);
            this.SakuraCkSkip.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraCkSkip.Name = "SakuraCkSkip";
            this.SakuraCkSkip.Size = new System.Drawing.Size(150, 21);
            this.SakuraCkSkip.TabIndex = 58;
            this.SakuraCkSkip.Text = "skip unknown types";
            this.SakuraCkSkip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SakuraCkSkip.UseVisualStyleBackColor = true;
            // 
            // SakuraDisplayLabel
            // 
            this.SakuraDisplayLabel.AllowDrop = true;
            this.SakuraDisplayLabel.AutoSize = true;
            this.SakuraDisplayLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraDisplayLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraDisplayLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraDisplayLabel.Location = new System.Drawing.Point(688, 131);
            this.SakuraDisplayLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraDisplayLabel.Name = "SakuraDisplayLabel";
            this.SakuraDisplayLabel.Size = new System.Drawing.Size(115, 21);
            this.SakuraDisplayLabel.TabIndex = 59;
            this.SakuraDisplayLabel.Text = "Display images";
            // 
            // SakuraDisplayTrackBar
            // 
            this.SakuraDisplayTrackBar.Location = new System.Drawing.Point(971, 124);
            this.SakuraDisplayTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraDisplayTrackBar.Name = "SakuraDisplayTrackBar";
            this.SakuraDisplayTrackBar.Size = new System.Drawing.Size(221, 45);
            this.SakuraDisplayTrackBar.TabIndex = 61;
            // 
            // SakuraDisplayNumeric
            // 
            this.SakuraDisplayNumeric.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.SakuraDisplayNumeric.Location = new System.Drawing.Point(836, 129);
            this.SakuraDisplayNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraDisplayNumeric.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.SakuraDisplayNumeric.Name = "SakuraDisplayNumeric";
            this.SakuraDisplayNumeric.Size = new System.Drawing.Size(97, 20);
            this.SakuraDisplayNumeric.TabIndex = 62;
            this.SakuraDisplayNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SakuraLayout
            // 
            this.SakuraLayout.FormattingEnabled = true;
            this.SakuraLayout.Location = new System.Drawing.Point(837, 463);
            this.SakuraLayout.Name = "SakuraLayout";
            this.SakuraLayout.Size = new System.Drawing.Size(97, 21);
            this.SakuraLayout.TabIndex = 63;
            // 
            // SakuraLayoutLabel
            // 
            this.SakuraLayoutLabel.AllowDrop = true;
            this.SakuraLayoutLabel.AutoSize = true;
            this.SakuraLayoutLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraLayoutLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraLayoutLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraLayoutLabel.Location = new System.Drawing.Point(718, 463);
            this.SakuraLayoutLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraLayoutLabel.Name = "SakuraLayoutLabel";
            this.SakuraLayoutLabel.Size = new System.Drawing.Size(57, 21);
            this.SakuraLayoutLabel.TabIndex = 64;
            this.SakuraLayoutLabel.Text = "Layout";
            // 
            // SakuraStyleLabel
            // 
            this.SakuraStyleLabel.AllowDrop = true;
            this.SakuraStyleLabel.AutoSize = true;
            this.SakuraStyleLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraStyleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraStyleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraStyleLabel.Location = new System.Drawing.Point(724, 391);
            this.SakuraStyleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraStyleLabel.Name = "SakuraStyleLabel";
            this.SakuraStyleLabel.Size = new System.Drawing.Size(43, 21);
            this.SakuraStyleLabel.TabIndex = 67;
            this.SakuraStyleLabel.Text = "Style";
            // 
            // SakuraStyleTrackBar
            // 
            this.SakuraStyleTrackBar.Location = new System.Drawing.Point(973, 386);
            this.SakuraStyleTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraStyleTrackBar.Name = "SakuraStyleTrackBar";
            this.SakuraStyleTrackBar.Size = new System.Drawing.Size(221, 45);
            this.SakuraStyleTrackBar.TabIndex = 69;
            // 
            // SakuraLayoutTrackBar
            // 
            this.SakuraLayoutTrackBar.Location = new System.Drawing.Point(973, 459);
            this.SakuraLayoutTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraLayoutTrackBar.Name = "SakuraLayoutTrackBar";
            this.SakuraLayoutTrackBar.Size = new System.Drawing.Size(221, 45);
            this.SakuraLayoutTrackBar.TabIndex = 70;
            // 
            // SakuraUnsavedChanges
            // 
            this.SakuraUnsavedChanges.AllowDrop = true;
            this.SakuraUnsavedChanges.AutoSize = true;
            this.SakuraUnsavedChanges.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraUnsavedChanges.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraUnsavedChanges.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraUnsavedChanges.Location = new System.Drawing.Point(486, 442);
            this.SakuraUnsavedChanges.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraUnsavedChanges.Name = "SakuraUnsavedChanges";
            this.SakuraUnsavedChanges.Size = new System.Drawing.Size(134, 21);
            this.SakuraUnsavedChanges.TabIndex = 71;
            this.SakuraUnsavedChanges.Text = "Unsaved Changes";
            this.SakuraUnsavedChanges.Visible = false;
            // 
            // SakuraText
            // 
            this.SakuraText.AllowDrop = true;
            this.SakuraText.AutoSize = true;
            this.SakuraText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText.Location = new System.Drawing.Point(1, 706);
            this.SakuraText.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText.Name = "SakuraText";
            this.SakuraText.Size = new System.Drawing.Size(19, 21);
            this.SakuraText.TabIndex = 135;
            this.SakuraText.Text = "0";
            // 
            // SakuraText1
            // 
            this.SakuraText1.AllowDrop = true;
            this.SakuraText1.AutoSize = true;
            this.SakuraText1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText1.Location = new System.Drawing.Point(36, 706);
            this.SakuraText1.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText1.Name = "SakuraText1";
            this.SakuraText1.Size = new System.Drawing.Size(19, 21);
            this.SakuraText1.TabIndex = 136;
            this.SakuraText1.Text = "1";
            // 
            // SakuraText15
            // 
            this.SakuraText15.AllowDrop = true;
            this.SakuraText15.AutoSize = true;
            this.SakuraText15.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText15.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText15.Location = new System.Drawing.Point(537, 706);
            this.SakuraText15.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText15.Name = "SakuraText15";
            this.SakuraText15.Size = new System.Drawing.Size(28, 21);
            this.SakuraText15.TabIndex = 137;
            this.SakuraText15.Text = "15";
            // 
            // SakuraText16
            // 
            this.SakuraText16.AllowDrop = true;
            this.SakuraText16.AutoSize = true;
            this.SakuraText16.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText16.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText16.Location = new System.Drawing.Point(575, 706);
            this.SakuraText16.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText16.Name = "SakuraText16";
            this.SakuraText16.Size = new System.Drawing.Size(28, 21);
            this.SakuraText16.TabIndex = 138;
            this.SakuraText16.Text = "16";
            // 
            // SakuraText17
            // 
            this.SakuraText17.AllowDrop = true;
            this.SakuraText17.AutoSize = true;
            this.SakuraText17.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText17.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText17.Location = new System.Drawing.Point(609, 706);
            this.SakuraText17.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText17.Name = "SakuraText17";
            this.SakuraText17.Size = new System.Drawing.Size(28, 21);
            this.SakuraText17.TabIndex = 139;
            this.SakuraText17.Text = "17";
            // 
            // SakuraText18
            // 
            this.SakuraText18.AllowDrop = true;
            this.SakuraText18.AutoSize = true;
            this.SakuraText18.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText18.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText18.Location = new System.Drawing.Point(648, 706);
            this.SakuraText18.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText18.Name = "SakuraText18";
            this.SakuraText18.Size = new System.Drawing.Size(28, 21);
            this.SakuraText18.TabIndex = 140;
            this.SakuraText18.Text = "18";
            // 
            // SakuraText19
            // 
            this.SakuraText19.AllowDrop = true;
            this.SakuraText19.AutoSize = true;
            this.SakuraText19.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText19.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText19.Location = new System.Drawing.Point(683, 706);
            this.SakuraText19.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText19.Name = "SakuraText19";
            this.SakuraText19.Size = new System.Drawing.Size(28, 21);
            this.SakuraText19.TabIndex = 141;
            this.SakuraText19.Text = "19";
            // 
            // SakuraText20
            // 
            this.SakuraText20.AllowDrop = true;
            this.SakuraText20.AutoSize = true;
            this.SakuraText20.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText20.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText20.Location = new System.Drawing.Point(717, 706);
            this.SakuraText20.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText20.Name = "SakuraText20";
            this.SakuraText20.Size = new System.Drawing.Size(28, 21);
            this.SakuraText20.TabIndex = 142;
            this.SakuraText20.Text = "20";
            // 
            // SakuraText21
            // 
            this.SakuraText21.AllowDrop = true;
            this.SakuraText21.AutoSize = true;
            this.SakuraText21.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText21.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText21.Location = new System.Drawing.Point(753, 706);
            this.SakuraText21.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText21.Name = "SakuraText21";
            this.SakuraText21.Size = new System.Drawing.Size(28, 21);
            this.SakuraText21.TabIndex = 143;
            this.SakuraText21.Text = "21";
            // 
            // SakuraText22
            // 
            this.SakuraText22.AllowDrop = true;
            this.SakuraText22.AutoSize = true;
            this.SakuraText22.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText22.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText22.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText22.Location = new System.Drawing.Point(788, 706);
            this.SakuraText22.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText22.Name = "SakuraText22";
            this.SakuraText22.Size = new System.Drawing.Size(28, 21);
            this.SakuraText22.TabIndex = 144;
            this.SakuraText22.Text = "22";
            // 
            // SakuraText23
            // 
            this.SakuraText23.AllowDrop = true;
            this.SakuraText23.AutoSize = true;
            this.SakuraText23.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText23.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText23.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText23.Location = new System.Drawing.Point(825, 706);
            this.SakuraText23.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText23.Name = "SakuraText23";
            this.SakuraText23.Size = new System.Drawing.Size(28, 21);
            this.SakuraText23.TabIndex = 145;
            this.SakuraText23.Text = "23";
            // 
            // SakuraText31
            // 
            this.SakuraText31.AllowDrop = true;
            this.SakuraText31.AutoSize = true;
            this.SakuraText31.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText31.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText31.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText31.Location = new System.Drawing.Point(1111, 706);
            this.SakuraText31.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText31.Name = "SakuraText31";
            this.SakuraText31.Size = new System.Drawing.Size(28, 21);
            this.SakuraText31.TabIndex = 146;
            this.SakuraText31.Text = "31";
            // 
            // SakuraText30
            // 
            this.SakuraText30.AllowDrop = true;
            this.SakuraText30.AutoSize = true;
            this.SakuraText30.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText30.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText30.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText30.Location = new System.Drawing.Point(1076, 706);
            this.SakuraText30.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText30.Name = "SakuraText30";
            this.SakuraText30.Size = new System.Drawing.Size(28, 21);
            this.SakuraText30.TabIndex = 147;
            this.SakuraText30.Text = "30";
            // 
            // SakuraText29
            // 
            this.SakuraText29.AllowDrop = true;
            this.SakuraText29.AutoSize = true;
            this.SakuraText29.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText29.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText29.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText29.Location = new System.Drawing.Point(1039, 706);
            this.SakuraText29.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText29.Name = "SakuraText29";
            this.SakuraText29.Size = new System.Drawing.Size(28, 21);
            this.SakuraText29.TabIndex = 148;
            this.SakuraText29.Text = "29";
            // 
            // SakuraText28
            // 
            this.SakuraText28.AllowDrop = true;
            this.SakuraText28.AutoSize = true;
            this.SakuraText28.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText28.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText28.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText28.Location = new System.Drawing.Point(1004, 706);
            this.SakuraText28.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText28.Name = "SakuraText28";
            this.SakuraText28.Size = new System.Drawing.Size(28, 21);
            this.SakuraText28.TabIndex = 149;
            this.SakuraText28.Text = "28";
            // 
            // SakuraText27
            // 
            this.SakuraText27.AllowDrop = true;
            this.SakuraText27.AutoSize = true;
            this.SakuraText27.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText27.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText27.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText27.Location = new System.Drawing.Point(968, 706);
            this.SakuraText27.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText27.Name = "SakuraText27";
            this.SakuraText27.Size = new System.Drawing.Size(28, 21);
            this.SakuraText27.TabIndex = 150;
            this.SakuraText27.Text = "27";
            // 
            // SakuraText26
            // 
            this.SakuraText26.AllowDrop = true;
            this.SakuraText26.AutoSize = true;
            this.SakuraText26.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText26.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText26.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText26.Location = new System.Drawing.Point(933, 706);
            this.SakuraText26.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText26.Name = "SakuraText26";
            this.SakuraText26.Size = new System.Drawing.Size(28, 21);
            this.SakuraText26.TabIndex = 151;
            this.SakuraText26.Text = "26";
            // 
            // SakuraText25
            // 
            this.SakuraText25.AllowDrop = true;
            this.SakuraText25.AutoSize = true;
            this.SakuraText25.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText25.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText25.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText25.Location = new System.Drawing.Point(895, 706);
            this.SakuraText25.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText25.Name = "SakuraText25";
            this.SakuraText25.Size = new System.Drawing.Size(28, 21);
            this.SakuraText25.TabIndex = 152;
            this.SakuraText25.Text = "25";
            // 
            // SakuraText24
            // 
            this.SakuraText24.AllowDrop = true;
            this.SakuraText24.AutoSize = true;
            this.SakuraText24.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText24.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText24.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText24.Location = new System.Drawing.Point(860, 706);
            this.SakuraText24.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText24.Name = "SakuraText24";
            this.SakuraText24.Size = new System.Drawing.Size(28, 21);
            this.SakuraText24.TabIndex = 153;
            this.SakuraText24.Text = "24";
            // 
            // SakuraText4
            // 
            this.SakuraText4.AllowDrop = true;
            this.SakuraText4.AutoSize = true;
            this.SakuraText4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText4.Location = new System.Drawing.Point(143, 706);
            this.SakuraText4.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText4.Name = "SakuraText4";
            this.SakuraText4.Size = new System.Drawing.Size(19, 21);
            this.SakuraText4.TabIndex = 154;
            this.SakuraText4.Text = "4";
            // 
            // SakuraText3
            // 
            this.SakuraText3.AllowDrop = true;
            this.SakuraText3.AutoSize = true;
            this.SakuraText3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText3.Location = new System.Drawing.Point(108, 706);
            this.SakuraText3.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText3.Name = "SakuraText3";
            this.SakuraText3.Size = new System.Drawing.Size(19, 21);
            this.SakuraText3.TabIndex = 155;
            this.SakuraText3.Text = "3";
            // 
            // SakuraText2
            // 
            this.SakuraText2.AllowDrop = true;
            this.SakuraText2.AutoSize = true;
            this.SakuraText2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText2.Location = new System.Drawing.Point(72, 706);
            this.SakuraText2.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText2.Name = "SakuraText2";
            this.SakuraText2.Size = new System.Drawing.Size(19, 21);
            this.SakuraText2.TabIndex = 156;
            this.SakuraText2.Text = "2";
            // 
            // SakuraText59
            // 
            this.SakuraText59.AllowDrop = true;
            this.SakuraText59.AutoSize = true;
            this.SakuraText59.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText59.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText59.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText59.Location = new System.Drawing.Point(970, 805);
            this.SakuraText59.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText59.Name = "SakuraText59";
            this.SakuraText59.Size = new System.Drawing.Size(35, 21);
            this.SakuraText59.TabIndex = 157;
            this.SakuraText59.Text = "Box";
            // 
            // SakuraText60
            // 
            this.SakuraText60.AllowDrop = true;
            this.SakuraText60.AutoSize = true;
            this.SakuraText60.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText60.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText60.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText60.Location = new System.Drawing.Point(1005, 805);
            this.SakuraText60.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText60.Name = "SakuraText60";
            this.SakuraText60.Size = new System.Drawing.Size(35, 21);
            this.SakuraText60.TabIndex = 158;
            this.SakuraText60.Text = "Box";
            // 
            // SakuraText61
            // 
            this.SakuraText61.AllowDrop = true;
            this.SakuraText61.AutoSize = true;
            this.SakuraText61.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText61.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText61.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText61.Location = new System.Drawing.Point(1040, 805);
            this.SakuraText61.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText61.Name = "SakuraText61";
            this.SakuraText61.Size = new System.Drawing.Size(35, 21);
            this.SakuraText61.TabIndex = 159;
            this.SakuraText61.Text = "Box";
            // 
            // SakuraText62
            // 
            this.SakuraText62.AllowDrop = true;
            this.SakuraText62.AutoSize = true;
            this.SakuraText62.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText62.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText62.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText62.Location = new System.Drawing.Point(1074, 805);
            this.SakuraText62.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText62.Name = "SakuraText62";
            this.SakuraText62.Size = new System.Drawing.Size(35, 21);
            this.SakuraText62.TabIndex = 160;
            this.SakuraText62.Text = "Box";
            // 
            // SakuraText63
            // 
            this.SakuraText63.AllowDrop = true;
            this.SakuraText63.AutoSize = true;
            this.SakuraText63.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText63.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText63.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText63.Location = new System.Drawing.Point(1111, 805);
            this.SakuraText63.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText63.Name = "SakuraText63";
            this.SakuraText63.Size = new System.Drawing.Size(35, 21);
            this.SakuraText63.TabIndex = 161;
            this.SakuraText63.Text = "Box";
            // 
            // SakuraText5
            // 
            this.SakuraText5.AllowDrop = true;
            this.SakuraText5.AutoSize = true;
            this.SakuraText5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText5.Location = new System.Drawing.Point(180, 706);
            this.SakuraText5.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText5.Name = "SakuraText5";
            this.SakuraText5.Size = new System.Drawing.Size(19, 21);
            this.SakuraText5.TabIndex = 162;
            this.SakuraText5.Text = "5";
            // 
            // SakuraText6
            // 
            this.SakuraText6.AllowDrop = true;
            this.SakuraText6.AutoSize = true;
            this.SakuraText6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText6.Location = new System.Drawing.Point(213, 706);
            this.SakuraText6.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText6.Name = "SakuraText6";
            this.SakuraText6.Size = new System.Drawing.Size(19, 21);
            this.SakuraText6.TabIndex = 163;
            this.SakuraText6.Text = "6";
            // 
            // SakuraText7
            // 
            this.SakuraText7.AllowDrop = true;
            this.SakuraText7.AutoSize = true;
            this.SakuraText7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText7.Location = new System.Drawing.Point(247, 706);
            this.SakuraText7.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText7.Name = "SakuraText7";
            this.SakuraText7.Size = new System.Drawing.Size(19, 21);
            this.SakuraText7.TabIndex = 164;
            this.SakuraText7.Text = "7";
            // 
            // SakuraText8
            // 
            this.SakuraText8.AllowDrop = true;
            this.SakuraText8.AutoSize = true;
            this.SakuraText8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText8.Location = new System.Drawing.Point(285, 706);
            this.SakuraText8.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText8.Name = "SakuraText8";
            this.SakuraText8.Size = new System.Drawing.Size(19, 21);
            this.SakuraText8.TabIndex = 165;
            this.SakuraText8.Text = "8";
            // 
            // SakuraText9
            // 
            this.SakuraText9.AllowDrop = true;
            this.SakuraText9.AutoSize = true;
            this.SakuraText9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText9.Location = new System.Drawing.Point(321, 706);
            this.SakuraText9.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText9.Name = "SakuraText9";
            this.SakuraText9.Size = new System.Drawing.Size(19, 21);
            this.SakuraText9.TabIndex = 166;
            this.SakuraText9.Text = "9";
            // 
            // SakuraText10
            // 
            this.SakuraText10.AllowDrop = true;
            this.SakuraText10.AutoSize = true;
            this.SakuraText10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText10.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText10.Location = new System.Drawing.Point(357, 706);
            this.SakuraText10.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText10.Name = "SakuraText10";
            this.SakuraText10.Size = new System.Drawing.Size(28, 21);
            this.SakuraText10.TabIndex = 167;
            this.SakuraText10.Text = "10";
            // 
            // SakuraText11
            // 
            this.SakuraText11.AllowDrop = true;
            this.SakuraText11.AutoSize = true;
            this.SakuraText11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText11.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText11.Location = new System.Drawing.Point(393, 706);
            this.SakuraText11.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText11.Name = "SakuraText11";
            this.SakuraText11.Size = new System.Drawing.Size(28, 21);
            this.SakuraText11.TabIndex = 168;
            this.SakuraText11.Text = "11";
            // 
            // SakuraText12
            // 
            this.SakuraText12.AllowDrop = true;
            this.SakuraText12.AutoSize = true;
            this.SakuraText12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText12.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText12.Location = new System.Drawing.Point(430, 706);
            this.SakuraText12.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText12.Name = "SakuraText12";
            this.SakuraText12.Size = new System.Drawing.Size(28, 21);
            this.SakuraText12.TabIndex = 169;
            this.SakuraText12.Text = "12";
            // 
            // SakuraText13
            // 
            this.SakuraText13.AllowDrop = true;
            this.SakuraText13.AutoSize = true;
            this.SakuraText13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText13.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText13.Location = new System.Drawing.Point(465, 706);
            this.SakuraText13.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText13.Name = "SakuraText13";
            this.SakuraText13.Size = new System.Drawing.Size(28, 21);
            this.SakuraText13.TabIndex = 170;
            this.SakuraText13.Text = "13";
            // 
            // SakuraText14
            // 
            this.SakuraText14.AllowDrop = true;
            this.SakuraText14.AutoSize = true;
            this.SakuraText14.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText14.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText14.Location = new System.Drawing.Point(501, 706);
            this.SakuraText14.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText14.Name = "SakuraText14";
            this.SakuraText14.Size = new System.Drawing.Size(28, 21);
            this.SakuraText14.TabIndex = 171;
            this.SakuraText14.Text = "14";
            // 
            // SakuraText47
            // 
            this.SakuraText47.AllowDrop = true;
            this.SakuraText47.AutoSize = true;
            this.SakuraText47.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText47.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText47.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText47.Location = new System.Drawing.Point(537, 805);
            this.SakuraText47.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText47.Name = "SakuraText47";
            this.SakuraText47.Size = new System.Drawing.Size(35, 21);
            this.SakuraText47.TabIndex = 172;
            this.SakuraText47.Text = "Box";
            // 
            // SakuraText48
            // 
            this.SakuraText48.AllowDrop = true;
            this.SakuraText48.AutoSize = true;
            this.SakuraText48.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText48.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText48.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText48.Location = new System.Drawing.Point(573, 805);
            this.SakuraText48.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText48.Name = "SakuraText48";
            this.SakuraText48.Size = new System.Drawing.Size(35, 21);
            this.SakuraText48.TabIndex = 173;
            this.SakuraText48.Text = "Box";
            // 
            // SakuraText49
            // 
            this.SakuraText49.AllowDrop = true;
            this.SakuraText49.AutoSize = true;
            this.SakuraText49.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText49.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText49.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText49.Location = new System.Drawing.Point(613, 805);
            this.SakuraText49.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText49.Name = "SakuraText49";
            this.SakuraText49.Size = new System.Drawing.Size(35, 21);
            this.SakuraText49.TabIndex = 174;
            this.SakuraText49.Text = "Box";
            // 
            // SakuraText50
            // 
            this.SakuraText50.AllowDrop = true;
            this.SakuraText50.AutoSize = true;
            this.SakuraText50.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText50.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText50.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText50.Location = new System.Drawing.Point(648, 805);
            this.SakuraText50.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText50.Name = "SakuraText50";
            this.SakuraText50.Size = new System.Drawing.Size(35, 21);
            this.SakuraText50.TabIndex = 175;
            this.SakuraText50.Text = "Box";
            // 
            // SakuraText51
            // 
            this.SakuraText51.AllowDrop = true;
            this.SakuraText51.AutoSize = true;
            this.SakuraText51.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText51.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText51.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText51.Location = new System.Drawing.Point(680, 805);
            this.SakuraText51.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText51.Name = "SakuraText51";
            this.SakuraText51.Size = new System.Drawing.Size(35, 21);
            this.SakuraText51.TabIndex = 176;
            this.SakuraText51.Text = "Box";
            // 
            // SakuraText52
            // 
            this.SakuraText52.AllowDrop = true;
            this.SakuraText52.AutoSize = true;
            this.SakuraText52.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText52.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText52.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText52.Location = new System.Drawing.Point(712, 805);
            this.SakuraText52.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText52.Name = "SakuraText52";
            this.SakuraText52.Size = new System.Drawing.Size(35, 21);
            this.SakuraText52.TabIndex = 177;
            this.SakuraText52.Text = "Box";
            // 
            // SakuraText53
            // 
            this.SakuraText53.AllowDrop = true;
            this.SakuraText53.AutoSize = true;
            this.SakuraText53.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText53.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText53.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText53.Location = new System.Drawing.Point(753, 805);
            this.SakuraText53.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText53.Name = "SakuraText53";
            this.SakuraText53.Size = new System.Drawing.Size(35, 21);
            this.SakuraText53.TabIndex = 178;
            this.SakuraText53.Text = "Box";
            // 
            // SakuraText54
            // 
            this.SakuraText54.AllowDrop = true;
            this.SakuraText54.AutoSize = true;
            this.SakuraText54.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText54.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText54.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText54.Location = new System.Drawing.Point(785, 805);
            this.SakuraText54.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText54.Name = "SakuraText54";
            this.SakuraText54.Size = new System.Drawing.Size(35, 21);
            this.SakuraText54.TabIndex = 179;
            this.SakuraText54.Text = "Box";
            // 
            // SakuraText55
            // 
            this.SakuraText55.AllowDrop = true;
            this.SakuraText55.AutoSize = true;
            this.SakuraText55.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText55.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText55.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText55.Location = new System.Drawing.Point(824, 805);
            this.SakuraText55.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText55.Name = "SakuraText55";
            this.SakuraText55.Size = new System.Drawing.Size(35, 21);
            this.SakuraText55.TabIndex = 180;
            this.SakuraText55.Text = "Box";
            // 
            // SakuraText56
            // 
            this.SakuraText56.AllowDrop = true;
            this.SakuraText56.AutoSize = true;
            this.SakuraText56.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText56.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText56.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText56.Location = new System.Drawing.Point(861, 805);
            this.SakuraText56.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText56.Name = "SakuraText56";
            this.SakuraText56.Size = new System.Drawing.Size(35, 21);
            this.SakuraText56.TabIndex = 181;
            this.SakuraText56.Text = "Box";
            // 
            // SakuraText57
            // 
            this.SakuraText57.AllowDrop = true;
            this.SakuraText57.AutoSize = true;
            this.SakuraText57.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText57.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText57.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText57.Location = new System.Drawing.Point(896, 805);
            this.SakuraText57.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText57.Name = "SakuraText57";
            this.SakuraText57.Size = new System.Drawing.Size(35, 21);
            this.SakuraText57.TabIndex = 182;
            this.SakuraText57.Text = "Box";
            // 
            // SakuraText58
            // 
            this.SakuraText58.AllowDrop = true;
            this.SakuraText58.AutoSize = true;
            this.SakuraText58.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText58.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText58.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText58.Location = new System.Drawing.Point(931, 805);
            this.SakuraText58.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText58.Name = "SakuraText58";
            this.SakuraText58.Size = new System.Drawing.Size(35, 21);
            this.SakuraText58.TabIndex = 183;
            this.SakuraText58.Text = "Box";
            // 
            // SakuraText39
            // 
            this.SakuraText39.AllowDrop = true;
            this.SakuraText39.AutoSize = true;
            this.SakuraText39.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText39.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText39.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText39.Location = new System.Drawing.Point(249, 805);
            this.SakuraText39.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText39.Name = "SakuraText39";
            this.SakuraText39.Size = new System.Drawing.Size(35, 21);
            this.SakuraText39.TabIndex = 185;
            this.SakuraText39.Text = "Box";
            // 
            // SakuraText40
            // 
            this.SakuraText40.AllowDrop = true;
            this.SakuraText40.AutoSize = true;
            this.SakuraText40.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText40.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText40.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText40.Location = new System.Drawing.Point(284, 805);
            this.SakuraText40.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText40.Name = "SakuraText40";
            this.SakuraText40.Size = new System.Drawing.Size(35, 21);
            this.SakuraText40.TabIndex = 186;
            this.SakuraText40.Text = "Box";
            // 
            // SakuraText41
            // 
            this.SakuraText41.AllowDrop = true;
            this.SakuraText41.AutoSize = true;
            this.SakuraText41.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText41.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText41.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText41.Location = new System.Drawing.Point(320, 805);
            this.SakuraText41.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText41.Name = "SakuraText41";
            this.SakuraText41.Size = new System.Drawing.Size(35, 21);
            this.SakuraText41.TabIndex = 187;
            this.SakuraText41.Text = "Box";
            // 
            // SakuraText42
            // 
            this.SakuraText42.AllowDrop = true;
            this.SakuraText42.AutoSize = true;
            this.SakuraText42.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText42.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText42.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText42.Location = new System.Drawing.Point(356, 805);
            this.SakuraText42.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText42.Name = "SakuraText42";
            this.SakuraText42.Size = new System.Drawing.Size(35, 21);
            this.SakuraText42.TabIndex = 188;
            this.SakuraText42.Text = "Box";
            // 
            // SakuraText43
            // 
            this.SakuraText43.AllowDrop = true;
            this.SakuraText43.AutoSize = true;
            this.SakuraText43.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText43.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText43.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText43.Location = new System.Drawing.Point(393, 805);
            this.SakuraText43.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText43.Name = "SakuraText43";
            this.SakuraText43.Size = new System.Drawing.Size(35, 21);
            this.SakuraText43.TabIndex = 189;
            this.SakuraText43.Text = "Box";
            // 
            // SakuraText44
            // 
            this.SakuraText44.AllowDrop = true;
            this.SakuraText44.AutoSize = true;
            this.SakuraText44.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText44.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText44.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText44.Location = new System.Drawing.Point(428, 805);
            this.SakuraText44.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText44.Name = "SakuraText44";
            this.SakuraText44.Size = new System.Drawing.Size(35, 21);
            this.SakuraText44.TabIndex = 190;
            this.SakuraText44.Text = "Box";
            // 
            // SakuraText45
            // 
            this.SakuraText45.AllowDrop = true;
            this.SakuraText45.AutoSize = true;
            this.SakuraText45.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText45.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText45.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText45.Location = new System.Drawing.Point(465, 805);
            this.SakuraText45.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText45.Name = "SakuraText45";
            this.SakuraText45.Size = new System.Drawing.Size(35, 21);
            this.SakuraText45.TabIndex = 191;
            this.SakuraText45.Text = "Box";
            // 
            // SakuraText46
            // 
            this.SakuraText46.AllowDrop = true;
            this.SakuraText46.AutoSize = true;
            this.SakuraText46.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText46.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText46.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText46.Location = new System.Drawing.Point(500, 805);
            this.SakuraText46.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText46.Name = "SakuraText46";
            this.SakuraText46.Size = new System.Drawing.Size(35, 21);
            this.SakuraText46.TabIndex = 192;
            this.SakuraText46.Text = "Box";
            // 
            // SakuraText32
            // 
            this.SakuraText32.AllowDrop = true;
            this.SakuraText32.AutoSize = true;
            this.SakuraText32.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText32.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText32.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText32.Location = new System.Drawing.Point(1, 805);
            this.SakuraText32.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText32.Name = "SakuraText32";
            this.SakuraText32.Size = new System.Drawing.Size(28, 21);
            this.SakuraText32.TabIndex = 193;
            this.SakuraText32.Text = "32";
            // 
            // SakuraText33
            // 
            this.SakuraText33.AllowDrop = true;
            this.SakuraText33.AutoSize = true;
            this.SakuraText33.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText33.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText33.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText33.Location = new System.Drawing.Point(36, 805);
            this.SakuraText33.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText33.Name = "SakuraText33";
            this.SakuraText33.Size = new System.Drawing.Size(28, 21);
            this.SakuraText33.TabIndex = 194;
            this.SakuraText33.Text = "33";
            // 
            // SakuraText34
            // 
            this.SakuraText34.AllowDrop = true;
            this.SakuraText34.AutoSize = true;
            this.SakuraText34.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText34.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText34.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText34.Location = new System.Drawing.Point(72, 805);
            this.SakuraText34.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText34.Name = "SakuraText34";
            this.SakuraText34.Size = new System.Drawing.Size(35, 21);
            this.SakuraText34.TabIndex = 195;
            this.SakuraText34.Text = "Box";
            // 
            // SakuraText35
            // 
            this.SakuraText35.AllowDrop = true;
            this.SakuraText35.AutoSize = true;
            this.SakuraText35.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText35.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText35.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText35.Location = new System.Drawing.Point(108, 805);
            this.SakuraText35.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText35.Name = "SakuraText35";
            this.SakuraText35.Size = new System.Drawing.Size(35, 21);
            this.SakuraText35.TabIndex = 196;
            this.SakuraText35.Text = "Box";
            // 
            // SakuraText36
            // 
            this.SakuraText36.AllowDrop = true;
            this.SakuraText36.AutoSize = true;
            this.SakuraText36.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText36.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText36.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText36.Location = new System.Drawing.Point(144, 805);
            this.SakuraText36.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText36.Name = "SakuraText36";
            this.SakuraText36.Size = new System.Drawing.Size(35, 21);
            this.SakuraText36.TabIndex = 197;
            this.SakuraText36.Text = "Box";
            // 
            // SakuraText37
            // 
            this.SakuraText37.AllowDrop = true;
            this.SakuraText37.AutoSize = true;
            this.SakuraText37.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText37.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText37.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText37.Location = new System.Drawing.Point(174, 805);
            this.SakuraText37.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText37.Name = "SakuraText37";
            this.SakuraText37.Size = new System.Drawing.Size(35, 21);
            this.SakuraText37.TabIndex = 198;
            this.SakuraText37.Text = "Box";
            // 
            // SakuraText38
            // 
            this.SakuraText38.AllowDrop = true;
            this.SakuraText38.AutoSize = true;
            this.SakuraText38.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraText38.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraText38.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraText38.Location = new System.Drawing.Point(214, 805);
            this.SakuraText38.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraText38.Name = "SakuraText38";
            this.SakuraText38.Size = new System.Drawing.Size(35, 21);
            this.SakuraText38.TabIndex = 199;
            this.SakuraText38.Text = "Box";
            // 
            // SakuraBorderTrackBar
            // 
            this.SakuraBorderTrackBar.Location = new System.Drawing.Point(972, 190);
            this.SakuraBorderTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraBorderTrackBar.Name = "SakuraBorderTrackBar";
            this.SakuraBorderTrackBar.Size = new System.Drawing.Size(221, 45);
            this.SakuraBorderTrackBar.TabIndex = 202;
            // 
            // SakuraBorderNumeric
            // 
            this.SakuraBorderNumeric.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.SakuraBorderNumeric.Location = new System.Drawing.Point(837, 195);
            this.SakuraBorderNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraBorderNumeric.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.SakuraBorderNumeric.Name = "SakuraBorderNumeric";
            this.SakuraBorderNumeric.Size = new System.Drawing.Size(97, 20);
            this.SakuraBorderNumeric.TabIndex = 201;
            this.SakuraBorderNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SakuraBorderLabel
            // 
            this.SakuraBorderLabel.AllowDrop = true;
            this.SakuraBorderLabel.AutoSize = true;
            this.SakuraBorderLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraBorderLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraBorderLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraBorderLabel.Location = new System.Drawing.Point(717, 195);
            this.SakuraBorderLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBorderLabel.Name = "SakuraBorderLabel";
            this.SakuraBorderLabel.Size = new System.Drawing.Size(57, 21);
            this.SakuraBorderLabel.TabIndex = 200;
            this.SakuraBorderLabel.Text = "Border";
            // 
            // SakuraWidthTrackBar
            // 
            this.SakuraWidthTrackBar.Location = new System.Drawing.Point(971, 320);
            this.SakuraWidthTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraWidthTrackBar.Name = "SakuraWidthTrackBar";
            this.SakuraWidthTrackBar.Size = new System.Drawing.Size(221, 45);
            this.SakuraWidthTrackBar.TabIndex = 205;
            // 
            // SakuraWidthNumeric
            // 
            this.SakuraWidthNumeric.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.SakuraWidthNumeric.Location = new System.Drawing.Point(836, 325);
            this.SakuraWidthNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraWidthNumeric.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.SakuraWidthNumeric.Name = "SakuraWidthNumeric";
            this.SakuraWidthNumeric.Size = new System.Drawing.Size(97, 20);
            this.SakuraWidthNumeric.TabIndex = 204;
            this.SakuraWidthNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SakuraWidthLabel
            // 
            this.SakuraWidthLabel.AllowDrop = true;
            this.SakuraWidthLabel.AutoSize = true;
            this.SakuraWidthLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraWidthLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraWidthLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraWidthLabel.Location = new System.Drawing.Point(677, 324);
            this.SakuraWidthLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraWidthLabel.Name = "SakuraWidthLabel";
            this.SakuraWidthLabel.Size = new System.Drawing.Size(136, 21);
            this.SakuraWidthLabel.TabIndex = 203;
            this.SakuraWidthLabel.Text = "Fixed image width";
            // 
            // SakuraCkVariableWidth
            // 
            this.SakuraCkVariableWidth.AutoSize = true;
            this.SakuraCkVariableWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraCkVariableWidth.ForeColor = System.Drawing.Color.White;
            this.SakuraCkVariableWidth.Location = new System.Drawing.Point(313, 372);
            this.SakuraCkVariableWidth.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraCkVariableWidth.Name = "SakuraCkVariableWidth";
            this.SakuraCkVariableWidth.Size = new System.Drawing.Size(113, 21);
            this.SakuraCkVariableWidth.TabIndex = 206;
            this.SakuraCkVariableWidth.Text = "variable width";
            this.SakuraCkVariableWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SakuraCkVariableWidth.UseVisualStyleBackColor = true;
            // 
            // SakuraCkVariableHeight
            // 
            this.SakuraCkVariableHeight.AutoSize = true;
            this.SakuraCkVariableHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakuraCkVariableHeight.ForeColor = System.Drawing.Color.White;
            this.SakuraCkVariableHeight.Location = new System.Drawing.Point(313, 345);
            this.SakuraCkVariableHeight.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraCkVariableHeight.Name = "SakuraCkVariableHeight";
            this.SakuraCkVariableHeight.Size = new System.Drawing.Size(120, 21);
            this.SakuraCkVariableHeight.TabIndex = 207;
            this.SakuraCkVariableHeight.Text = "variable height";
            this.SakuraCkVariableHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SakuraCkVariableHeight.UseVisualStyleBackColor = true;
            // 
            // SakuraHeightTrackBar
            // 
            this.SakuraHeightTrackBar.Location = new System.Drawing.Point(971, 253);
            this.SakuraHeightTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraHeightTrackBar.Name = "SakuraHeightTrackBar";
            this.SakuraHeightTrackBar.Size = new System.Drawing.Size(221, 45);
            this.SakuraHeightTrackBar.TabIndex = 210;
            // 
            // SakuraHeightNumeric
            // 
            this.SakuraHeightNumeric.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.SakuraHeightNumeric.Location = new System.Drawing.Point(836, 258);
            this.SakuraHeightNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraHeightNumeric.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.SakuraHeightNumeric.Name = "SakuraHeightNumeric";
            this.SakuraHeightNumeric.Size = new System.Drawing.Size(97, 20);
            this.SakuraHeightNumeric.TabIndex = 209;
            this.SakuraHeightNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SakuraHeightLabel
            // 
            this.SakuraHeightLabel.AllowDrop = true;
            this.SakuraHeightLabel.AutoSize = true;
            this.SakuraHeightLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraHeightLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraHeightLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraHeightLabel.Location = new System.Drawing.Point(677, 257);
            this.SakuraHeightLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraHeightLabel.Name = "SakuraHeightLabel";
            this.SakuraHeightLabel.Size = new System.Drawing.Size(141, 21);
            this.SakuraHeightLabel.TabIndex = 208;
            this.SakuraHeightLabel.Text = "Fixed image height";
            // 
            // SakuraStyle
            // 
            this.SakuraStyle.FormattingEnabled = true;
            this.SakuraStyle.Location = new System.Drawing.Point(836, 386);
            this.SakuraStyle.Name = "SakuraStyle";
            this.SakuraStyle.Size = new System.Drawing.Size(97, 21);
            this.SakuraStyle.TabIndex = 211;
            // 
            // SakuraBox52
            // 
            this.SakuraBox52.Enabled = false;
            this.SakuraBox52.ErrorImage = null;
            this.SakuraBox52.InitialImage = null;
            this.SakuraBox52.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox52.Location = new System.Drawing.Point(716, 766);
            this.SakuraBox52.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox52.Name = "SakuraBox52";
            this.SakuraBox52.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox52.TabIndex = 134;
            this.SakuraBox52.TabStop = false;
            // 
            // SakuraBox53
            // 
            this.SakuraBox53.Enabled = false;
            this.SakuraBox53.ErrorImage = null;
            this.SakuraBox53.InitialImage = null;
            this.SakuraBox53.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox53.Location = new System.Drawing.Point(752, 766);
            this.SakuraBox53.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox53.Name = "SakuraBox53";
            this.SakuraBox53.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox53.TabIndex = 133;
            this.SakuraBox53.TabStop = false;
            // 
            // SakuraBox54
            // 
            this.SakuraBox54.Enabled = false;
            this.SakuraBox54.ErrorImage = null;
            this.SakuraBox54.InitialImage = null;
            this.SakuraBox54.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox54.Location = new System.Drawing.Point(788, 766);
            this.SakuraBox54.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox54.Name = "SakuraBox54";
            this.SakuraBox54.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox54.TabIndex = 132;
            this.SakuraBox54.TabStop = false;
            // 
            // SakuraBox55
            // 
            this.SakuraBox55.Enabled = false;
            this.SakuraBox55.ErrorImage = null;
            this.SakuraBox55.InitialImage = null;
            this.SakuraBox55.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox55.Location = new System.Drawing.Point(823, 766);
            this.SakuraBox55.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox55.Name = "SakuraBox55";
            this.SakuraBox55.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox55.TabIndex = 131;
            this.SakuraBox55.TabStop = false;
            // 
            // SakuraBox56
            // 
            this.SakuraBox56.Enabled = false;
            this.SakuraBox56.ErrorImage = null;
            this.SakuraBox56.InitialImage = null;
            this.SakuraBox56.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox56.Location = new System.Drawing.Point(859, 766);
            this.SakuraBox56.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox56.Name = "SakuraBox56";
            this.SakuraBox56.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox56.TabIndex = 130;
            this.SakuraBox56.TabStop = false;
            // 
            // SakuraBox57
            // 
            this.SakuraBox57.Enabled = false;
            this.SakuraBox57.ErrorImage = null;
            this.SakuraBox57.InitialImage = null;
            this.SakuraBox57.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox57.Location = new System.Drawing.Point(895, 766);
            this.SakuraBox57.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox57.Name = "SakuraBox57";
            this.SakuraBox57.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox57.TabIndex = 129;
            this.SakuraBox57.TabStop = false;
            // 
            // SakuraBox58
            // 
            this.SakuraBox58.Enabled = false;
            this.SakuraBox58.ErrorImage = null;
            this.SakuraBox58.InitialImage = null;
            this.SakuraBox58.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox58.Location = new System.Drawing.Point(931, 766);
            this.SakuraBox58.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox58.Name = "SakuraBox58";
            this.SakuraBox58.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox58.TabIndex = 128;
            this.SakuraBox58.TabStop = false;
            // 
            // SakuraBox59
            // 
            this.SakuraBox59.Enabled = false;
            this.SakuraBox59.ErrorImage = null;
            this.SakuraBox59.InitialImage = null;
            this.SakuraBox59.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox59.Location = new System.Drawing.Point(967, 766);
            this.SakuraBox59.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox59.Name = "SakuraBox59";
            this.SakuraBox59.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox59.TabIndex = 127;
            this.SakuraBox59.TabStop = false;
            // 
            // SakuraBox60
            // 
            this.SakuraBox60.Enabled = false;
            this.SakuraBox60.ErrorImage = null;
            this.SakuraBox60.InitialImage = null;
            this.SakuraBox60.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox60.Location = new System.Drawing.Point(1003, 766);
            this.SakuraBox60.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox60.Name = "SakuraBox60";
            this.SakuraBox60.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox60.TabIndex = 126;
            this.SakuraBox60.TabStop = false;
            // 
            // SakuraBox61
            // 
            this.SakuraBox61.Enabled = false;
            this.SakuraBox61.ErrorImage = null;
            this.SakuraBox61.InitialImage = null;
            this.SakuraBox61.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox61.Location = new System.Drawing.Point(1039, 766);
            this.SakuraBox61.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox61.Name = "SakuraBox61";
            this.SakuraBox61.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox61.TabIndex = 125;
            this.SakuraBox61.TabStop = false;
            // 
            // SakuraBox62
            // 
            this.SakuraBox62.Enabled = false;
            this.SakuraBox62.ErrorImage = null;
            this.SakuraBox62.InitialImage = null;
            this.SakuraBox62.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox62.Location = new System.Drawing.Point(1075, 766);
            this.SakuraBox62.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox62.Name = "SakuraBox62";
            this.SakuraBox62.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox62.TabIndex = 124;
            this.SakuraBox62.TabStop = false;
            // 
            // SakuraBox63
            // 
            this.SakuraBox63.Enabled = false;
            this.SakuraBox63.ErrorImage = null;
            this.SakuraBox63.InitialImage = null;
            this.SakuraBox63.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox63.Location = new System.Drawing.Point(1111, 766);
            this.SakuraBox63.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox63.Name = "SakuraBox63";
            this.SakuraBox63.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox63.TabIndex = 123;
            this.SakuraBox63.TabStop = false;
            // 
            // SakuraBox1
            // 
            this.SakuraBox1.Enabled = false;
            this.SakuraBox1.ErrorImage = null;
            this.SakuraBox1.InitialImage = null;
            this.SakuraBox1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox1.Location = new System.Drawing.Point(35, 727);
            this.SakuraBox1.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox1.Name = "SakuraBox1";
            this.SakuraBox1.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox1.TabIndex = 122;
            this.SakuraBox1.TabStop = false;
            // 
            // SakuraBox34
            // 
            this.SakuraBox34.Enabled = false;
            this.SakuraBox34.ErrorImage = null;
            this.SakuraBox34.InitialImage = null;
            this.SakuraBox34.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox34.Location = new System.Drawing.Point(72, 766);
            this.SakuraBox34.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox34.Name = "SakuraBox34";
            this.SakuraBox34.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox34.TabIndex = 121;
            this.SakuraBox34.TabStop = false;
            // 
            // SakuraBox35
            // 
            this.SakuraBox35.Enabled = false;
            this.SakuraBox35.ErrorImage = null;
            this.SakuraBox35.InitialImage = null;
            this.SakuraBox35.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox35.Location = new System.Drawing.Point(107, 766);
            this.SakuraBox35.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox35.Name = "SakuraBox35";
            this.SakuraBox35.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox35.TabIndex = 120;
            this.SakuraBox35.TabStop = false;
            // 
            // SakuraBox36
            // 
            this.SakuraBox36.Enabled = false;
            this.SakuraBox36.ErrorImage = null;
            this.SakuraBox36.InitialImage = null;
            this.SakuraBox36.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox36.Location = new System.Drawing.Point(143, 766);
            this.SakuraBox36.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox36.Name = "SakuraBox36";
            this.SakuraBox36.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox36.TabIndex = 119;
            this.SakuraBox36.TabStop = false;
            // 
            // SakuraBox37
            // 
            this.SakuraBox37.Enabled = false;
            this.SakuraBox37.ErrorImage = null;
            this.SakuraBox37.InitialImage = null;
            this.SakuraBox37.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox37.Location = new System.Drawing.Point(179, 766);
            this.SakuraBox37.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox37.Name = "SakuraBox37";
            this.SakuraBox37.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox37.TabIndex = 118;
            this.SakuraBox37.TabStop = false;
            // 
            // SakuraBox38
            // 
            this.SakuraBox38.Enabled = false;
            this.SakuraBox38.ErrorImage = null;
            this.SakuraBox38.InitialImage = null;
            this.SakuraBox38.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox38.Location = new System.Drawing.Point(215, 766);
            this.SakuraBox38.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox38.Name = "SakuraBox38";
            this.SakuraBox38.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox38.TabIndex = 117;
            this.SakuraBox38.TabStop = false;
            // 
            // SakuraBox39
            // 
            this.SakuraBox39.Enabled = false;
            this.SakuraBox39.ErrorImage = null;
            this.SakuraBox39.InitialImage = null;
            this.SakuraBox39.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox39.Location = new System.Drawing.Point(248, 766);
            this.SakuraBox39.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox39.Name = "SakuraBox39";
            this.SakuraBox39.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox39.TabIndex = 116;
            this.SakuraBox39.TabStop = false;
            // 
            // SakuraBox40
            // 
            this.SakuraBox40.Enabled = false;
            this.SakuraBox40.ErrorImage = null;
            this.SakuraBox40.InitialImage = null;
            this.SakuraBox40.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox40.Location = new System.Drawing.Point(284, 766);
            this.SakuraBox40.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox40.Name = "SakuraBox40";
            this.SakuraBox40.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox40.TabIndex = 115;
            this.SakuraBox40.TabStop = false;
            // 
            // SakuraBox41
            // 
            this.SakuraBox41.Enabled = false;
            this.SakuraBox41.ErrorImage = null;
            this.SakuraBox41.InitialImage = null;
            this.SakuraBox41.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox41.Location = new System.Drawing.Point(320, 766);
            this.SakuraBox41.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox41.Name = "SakuraBox41";
            this.SakuraBox41.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox41.TabIndex = 114;
            this.SakuraBox41.TabStop = false;
            // 
            // SakuraBox42
            // 
            this.SakuraBox42.Enabled = false;
            this.SakuraBox42.ErrorImage = null;
            this.SakuraBox42.InitialImage = null;
            this.SakuraBox42.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox42.Location = new System.Drawing.Point(356, 766);
            this.SakuraBox42.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox42.Name = "SakuraBox42";
            this.SakuraBox42.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox42.TabIndex = 113;
            this.SakuraBox42.TabStop = false;
            // 
            // SakuraBox43
            // 
            this.SakuraBox43.Enabled = false;
            this.SakuraBox43.ErrorImage = null;
            this.SakuraBox43.InitialImage = null;
            this.SakuraBox43.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox43.Location = new System.Drawing.Point(392, 766);
            this.SakuraBox43.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox43.Name = "SakuraBox43";
            this.SakuraBox43.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox43.TabIndex = 112;
            this.SakuraBox43.TabStop = false;
            // 
            // SakuraBox44
            // 
            this.SakuraBox44.Enabled = false;
            this.SakuraBox44.ErrorImage = null;
            this.SakuraBox44.InitialImage = null;
            this.SakuraBox44.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox44.Location = new System.Drawing.Point(428, 766);
            this.SakuraBox44.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox44.Name = "SakuraBox44";
            this.SakuraBox44.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox44.TabIndex = 111;
            this.SakuraBox44.TabStop = false;
            // 
            // SakuraBox45
            // 
            this.SakuraBox45.Enabled = false;
            this.SakuraBox45.ErrorImage = null;
            this.SakuraBox45.InitialImage = null;
            this.SakuraBox45.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox45.Location = new System.Drawing.Point(464, 766);
            this.SakuraBox45.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox45.Name = "SakuraBox45";
            this.SakuraBox45.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox45.TabIndex = 110;
            this.SakuraBox45.TabStop = false;
            // 
            // SakuraBox46
            // 
            this.SakuraBox46.Enabled = false;
            this.SakuraBox46.ErrorImage = null;
            this.SakuraBox46.InitialImage = null;
            this.SakuraBox46.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox46.Location = new System.Drawing.Point(500, 766);
            this.SakuraBox46.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox46.Name = "SakuraBox46";
            this.SakuraBox46.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox46.TabIndex = 109;
            this.SakuraBox46.TabStop = false;
            // 
            // SakuraBox47
            // 
            this.SakuraBox47.Enabled = false;
            this.SakuraBox47.ErrorImage = null;
            this.SakuraBox47.InitialImage = null;
            this.SakuraBox47.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox47.Location = new System.Drawing.Point(536, 766);
            this.SakuraBox47.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox47.Name = "SakuraBox47";
            this.SakuraBox47.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox47.TabIndex = 108;
            this.SakuraBox47.TabStop = false;
            // 
            // SakuraBox48
            // 
            this.SakuraBox48.Enabled = false;
            this.SakuraBox48.ErrorImage = null;
            this.SakuraBox48.InitialImage = null;
            this.SakuraBox48.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox48.Location = new System.Drawing.Point(572, 766);
            this.SakuraBox48.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox48.Name = "SakuraBox48";
            this.SakuraBox48.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox48.TabIndex = 107;
            this.SakuraBox48.TabStop = false;
            // 
            // SakuraBox49
            // 
            this.SakuraBox49.Enabled = false;
            this.SakuraBox49.ErrorImage = null;
            this.SakuraBox49.InitialImage = null;
            this.SakuraBox49.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox49.Location = new System.Drawing.Point(608, 766);
            this.SakuraBox49.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox49.Name = "SakuraBox49";
            this.SakuraBox49.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox49.TabIndex = 106;
            this.SakuraBox49.TabStop = false;
            // 
            // SakuraBox50
            // 
            this.SakuraBox50.Enabled = false;
            this.SakuraBox50.ErrorImage = null;
            this.SakuraBox50.InitialImage = null;
            this.SakuraBox50.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox50.Location = new System.Drawing.Point(644, 766);
            this.SakuraBox50.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox50.Name = "SakuraBox50";
            this.SakuraBox50.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox50.TabIndex = 105;
            this.SakuraBox50.TabStop = false;
            // 
            // SakuraBox51
            // 
            this.SakuraBox51.Enabled = false;
            this.SakuraBox51.ErrorImage = null;
            this.SakuraBox51.InitialImage = null;
            this.SakuraBox51.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox51.Location = new System.Drawing.Point(680, 766);
            this.SakuraBox51.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox51.Name = "SakuraBox51";
            this.SakuraBox51.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox51.TabIndex = 104;
            this.SakuraBox51.TabStop = false;
            // 
            // SakuraBox33
            // 
            this.SakuraBox33.Enabled = false;
            this.SakuraBox33.ErrorImage = null;
            this.SakuraBox33.InitialImage = null;
            this.SakuraBox33.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox33.Location = new System.Drawing.Point(36, 766);
            this.SakuraBox33.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox33.Name = "SakuraBox33";
            this.SakuraBox33.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox33.TabIndex = 103;
            this.SakuraBox33.TabStop = false;
            // 
            // SakuraBox20
            // 
            this.SakuraBox20.Enabled = false;
            this.SakuraBox20.ErrorImage = null;
            this.SakuraBox20.InitialImage = null;
            this.SakuraBox20.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox20.Location = new System.Drawing.Point(715, 727);
            this.SakuraBox20.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox20.Name = "SakuraBox20";
            this.SakuraBox20.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox20.TabIndex = 102;
            this.SakuraBox20.TabStop = false;
            // 
            // SakuraBox21
            // 
            this.SakuraBox21.Enabled = false;
            this.SakuraBox21.ErrorImage = null;
            this.SakuraBox21.InitialImage = null;
            this.SakuraBox21.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox21.Location = new System.Drawing.Point(751, 727);
            this.SakuraBox21.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox21.Name = "SakuraBox21";
            this.SakuraBox21.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox21.TabIndex = 101;
            this.SakuraBox21.TabStop = false;
            // 
            // SakuraBox22
            // 
            this.SakuraBox22.Enabled = false;
            this.SakuraBox22.ErrorImage = null;
            this.SakuraBox22.InitialImage = null;
            this.SakuraBox22.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox22.Location = new System.Drawing.Point(787, 727);
            this.SakuraBox22.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox22.Name = "SakuraBox22";
            this.SakuraBox22.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox22.TabIndex = 100;
            this.SakuraBox22.TabStop = false;
            // 
            // SakuraBox23
            // 
            this.SakuraBox23.Enabled = false;
            this.SakuraBox23.ErrorImage = null;
            this.SakuraBox23.InitialImage = null;
            this.SakuraBox23.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox23.Location = new System.Drawing.Point(822, 727);
            this.SakuraBox23.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox23.Name = "SakuraBox23";
            this.SakuraBox23.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox23.TabIndex = 99;
            this.SakuraBox23.TabStop = false;
            // 
            // SakuraBox24
            // 
            this.SakuraBox24.Enabled = false;
            this.SakuraBox24.ErrorImage = null;
            this.SakuraBox24.InitialImage = null;
            this.SakuraBox24.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox24.Location = new System.Drawing.Point(858, 727);
            this.SakuraBox24.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox24.Name = "SakuraBox24";
            this.SakuraBox24.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox24.TabIndex = 98;
            this.SakuraBox24.TabStop = false;
            // 
            // SakuraBox25
            // 
            this.SakuraBox25.Enabled = false;
            this.SakuraBox25.ErrorImage = null;
            this.SakuraBox25.InitialImage = null;
            this.SakuraBox25.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox25.Location = new System.Drawing.Point(894, 727);
            this.SakuraBox25.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox25.Name = "SakuraBox25";
            this.SakuraBox25.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox25.TabIndex = 97;
            this.SakuraBox25.TabStop = false;
            // 
            // SakuraBox26
            // 
            this.SakuraBox26.Enabled = false;
            this.SakuraBox26.ErrorImage = null;
            this.SakuraBox26.InitialImage = null;
            this.SakuraBox26.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox26.Location = new System.Drawing.Point(930, 727);
            this.SakuraBox26.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox26.Name = "SakuraBox26";
            this.SakuraBox26.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox26.TabIndex = 96;
            this.SakuraBox26.TabStop = false;
            // 
            // SakuraBox27
            // 
            this.SakuraBox27.Enabled = false;
            this.SakuraBox27.ErrorImage = null;
            this.SakuraBox27.InitialImage = null;
            this.SakuraBox27.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox27.Location = new System.Drawing.Point(966, 727);
            this.SakuraBox27.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox27.Name = "SakuraBox27";
            this.SakuraBox27.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox27.TabIndex = 95;
            this.SakuraBox27.TabStop = false;
            // 
            // SakuraBox28
            // 
            this.SakuraBox28.Enabled = false;
            this.SakuraBox28.ErrorImage = null;
            this.SakuraBox28.InitialImage = null;
            this.SakuraBox28.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox28.Location = new System.Drawing.Point(1002, 727);
            this.SakuraBox28.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox28.Name = "SakuraBox28";
            this.SakuraBox28.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox28.TabIndex = 94;
            this.SakuraBox28.TabStop = false;
            // 
            // SakuraBox29
            // 
            this.SakuraBox29.Enabled = false;
            this.SakuraBox29.ErrorImage = null;
            this.SakuraBox29.InitialImage = null;
            this.SakuraBox29.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox29.Location = new System.Drawing.Point(1038, 727);
            this.SakuraBox29.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox29.Name = "SakuraBox29";
            this.SakuraBox29.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox29.TabIndex = 93;
            this.SakuraBox29.TabStop = false;
            // 
            // SakuraBox30
            // 
            this.SakuraBox30.Enabled = false;
            this.SakuraBox30.ErrorImage = null;
            this.SakuraBox30.InitialImage = null;
            this.SakuraBox30.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox30.Location = new System.Drawing.Point(1074, 727);
            this.SakuraBox30.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox30.Name = "SakuraBox30";
            this.SakuraBox30.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox30.TabIndex = 92;
            this.SakuraBox30.TabStop = false;
            // 
            // SakuraBox31
            // 
            this.SakuraBox31.Enabled = false;
            this.SakuraBox31.ErrorImage = null;
            this.SakuraBox31.InitialImage = null;
            this.SakuraBox31.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox31.Location = new System.Drawing.Point(1110, 727);
            this.SakuraBox31.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox31.Name = "SakuraBox31";
            this.SakuraBox31.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox31.TabIndex = 91;
            this.SakuraBox31.TabStop = false;
            // 
            // SakuraBox32
            // 
            this.SakuraBox32.Enabled = false;
            this.SakuraBox32.ErrorImage = null;
            this.SakuraBox32.InitialImage = null;
            this.SakuraBox32.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox32.Location = new System.Drawing.Point(0, 766);
            this.SakuraBox32.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox32.Name = "SakuraBox32";
            this.SakuraBox32.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox32.TabIndex = 90;
            this.SakuraBox32.TabStop = false;
            // 
            // SakuraBox2
            // 
            this.SakuraBox2.Enabled = false;
            this.SakuraBox2.ErrorImage = null;
            this.SakuraBox2.InitialImage = null;
            this.SakuraBox2.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox2.Location = new System.Drawing.Point(71, 727);
            this.SakuraBox2.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox2.Name = "SakuraBox2";
            this.SakuraBox2.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox2.TabIndex = 89;
            this.SakuraBox2.TabStop = false;
            // 
            // SakuraBox3
            // 
            this.SakuraBox3.Enabled = false;
            this.SakuraBox3.ErrorImage = null;
            this.SakuraBox3.InitialImage = null;
            this.SakuraBox3.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox3.Location = new System.Drawing.Point(106, 727);
            this.SakuraBox3.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox3.Name = "SakuraBox3";
            this.SakuraBox3.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox3.TabIndex = 88;
            this.SakuraBox3.TabStop = false;
            // 
            // SakuraBox4
            // 
            this.SakuraBox4.Enabled = false;
            this.SakuraBox4.ErrorImage = null;
            this.SakuraBox4.InitialImage = null;
            this.SakuraBox4.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox4.Location = new System.Drawing.Point(142, 727);
            this.SakuraBox4.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox4.Name = "SakuraBox4";
            this.SakuraBox4.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox4.TabIndex = 87;
            this.SakuraBox4.TabStop = false;
            // 
            // SakuraBox5
            // 
            this.SakuraBox5.Enabled = false;
            this.SakuraBox5.ErrorImage = null;
            this.SakuraBox5.InitialImage = null;
            this.SakuraBox5.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox5.Location = new System.Drawing.Point(178, 727);
            this.SakuraBox5.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox5.Name = "SakuraBox5";
            this.SakuraBox5.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox5.TabIndex = 86;
            this.SakuraBox5.TabStop = false;
            // 
            // SakuraBox6
            // 
            this.SakuraBox6.Enabled = false;
            this.SakuraBox6.ErrorImage = null;
            this.SakuraBox6.InitialImage = null;
            this.SakuraBox6.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox6.Location = new System.Drawing.Point(214, 727);
            this.SakuraBox6.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox6.Name = "SakuraBox6";
            this.SakuraBox6.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox6.TabIndex = 85;
            this.SakuraBox6.TabStop = false;
            // 
            // SakuraBox7
            // 
            this.SakuraBox7.Enabled = false;
            this.SakuraBox7.ErrorImage = null;
            this.SakuraBox7.InitialImage = null;
            this.SakuraBox7.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox7.Location = new System.Drawing.Point(247, 727);
            this.SakuraBox7.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox7.Name = "SakuraBox7";
            this.SakuraBox7.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox7.TabIndex = 84;
            this.SakuraBox7.TabStop = false;
            // 
            // SakuraBox8
            // 
            this.SakuraBox8.Enabled = false;
            this.SakuraBox8.ErrorImage = null;
            this.SakuraBox8.InitialImage = null;
            this.SakuraBox8.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox8.Location = new System.Drawing.Point(283, 727);
            this.SakuraBox8.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox8.Name = "SakuraBox8";
            this.SakuraBox8.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox8.TabIndex = 83;
            this.SakuraBox8.TabStop = false;
            // 
            // SakuraBox9
            // 
            this.SakuraBox9.Enabled = false;
            this.SakuraBox9.ErrorImage = null;
            this.SakuraBox9.InitialImage = null;
            this.SakuraBox9.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox9.Location = new System.Drawing.Point(319, 727);
            this.SakuraBox9.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox9.Name = "SakuraBox9";
            this.SakuraBox9.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox9.TabIndex = 82;
            this.SakuraBox9.TabStop = false;
            // 
            // SakuraBox10
            // 
            this.SakuraBox10.Enabled = false;
            this.SakuraBox10.ErrorImage = null;
            this.SakuraBox10.InitialImage = null;
            this.SakuraBox10.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox10.Location = new System.Drawing.Point(355, 727);
            this.SakuraBox10.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox10.Name = "SakuraBox10";
            this.SakuraBox10.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox10.TabIndex = 81;
            this.SakuraBox10.TabStop = false;
            // 
            // SakuraBox11
            // 
            this.SakuraBox11.Enabled = false;
            this.SakuraBox11.ErrorImage = null;
            this.SakuraBox11.InitialImage = null;
            this.SakuraBox11.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox11.Location = new System.Drawing.Point(391, 727);
            this.SakuraBox11.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox11.Name = "SakuraBox11";
            this.SakuraBox11.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox11.TabIndex = 80;
            this.SakuraBox11.TabStop = false;
            // 
            // SakuraBox12
            // 
            this.SakuraBox12.Enabled = false;
            this.SakuraBox12.ErrorImage = null;
            this.SakuraBox12.InitialImage = null;
            this.SakuraBox12.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox12.Location = new System.Drawing.Point(427, 727);
            this.SakuraBox12.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox12.Name = "SakuraBox12";
            this.SakuraBox12.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox12.TabIndex = 79;
            this.SakuraBox12.TabStop = false;
            // 
            // SakuraBox13
            // 
            this.SakuraBox13.Enabled = false;
            this.SakuraBox13.ErrorImage = null;
            this.SakuraBox13.InitialImage = null;
            this.SakuraBox13.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox13.Location = new System.Drawing.Point(463, 727);
            this.SakuraBox13.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox13.Name = "SakuraBox13";
            this.SakuraBox13.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox13.TabIndex = 78;
            this.SakuraBox13.TabStop = false;
            // 
            // SakuraBox14
            // 
            this.SakuraBox14.Enabled = false;
            this.SakuraBox14.ErrorImage = null;
            this.SakuraBox14.InitialImage = null;
            this.SakuraBox14.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox14.Location = new System.Drawing.Point(499, 727);
            this.SakuraBox14.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox14.Name = "SakuraBox14";
            this.SakuraBox14.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox14.TabIndex = 77;
            this.SakuraBox14.TabStop = false;
            // 
            // SakuraBox15
            // 
            this.SakuraBox15.Enabled = false;
            this.SakuraBox15.ErrorImage = null;
            this.SakuraBox15.InitialImage = null;
            this.SakuraBox15.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox15.Location = new System.Drawing.Point(535, 727);
            this.SakuraBox15.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox15.Name = "SakuraBox15";
            this.SakuraBox15.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox15.TabIndex = 76;
            this.SakuraBox15.TabStop = false;
            // 
            // SakuraBox16
            // 
            this.SakuraBox16.Enabled = false;
            this.SakuraBox16.ErrorImage = null;
            this.SakuraBox16.InitialImage = null;
            this.SakuraBox16.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox16.Location = new System.Drawing.Point(571, 727);
            this.SakuraBox16.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox16.Name = "SakuraBox16";
            this.SakuraBox16.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox16.TabIndex = 75;
            this.SakuraBox16.TabStop = false;
            // 
            // SakuraBox17
            // 
            this.SakuraBox17.Enabled = false;
            this.SakuraBox17.ErrorImage = null;
            this.SakuraBox17.InitialImage = null;
            this.SakuraBox17.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox17.Location = new System.Drawing.Point(607, 727);
            this.SakuraBox17.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox17.Name = "SakuraBox17";
            this.SakuraBox17.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox17.TabIndex = 74;
            this.SakuraBox17.TabStop = false;
            // 
            // SakuraBox18
            // 
            this.SakuraBox18.Enabled = false;
            this.SakuraBox18.ErrorImage = null;
            this.SakuraBox18.InitialImage = null;
            this.SakuraBox18.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox18.Location = new System.Drawing.Point(643, 727);
            this.SakuraBox18.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox18.Name = "SakuraBox18";
            this.SakuraBox18.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox18.TabIndex = 73;
            this.SakuraBox18.TabStop = false;
            // 
            // SakuraBox19
            // 
            this.SakuraBox19.Enabled = false;
            this.SakuraBox19.ErrorImage = null;
            this.SakuraBox19.InitialImage = null;
            this.SakuraBox19.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox19.Location = new System.Drawing.Point(679, 727);
            this.SakuraBox19.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox19.Name = "SakuraBox19";
            this.SakuraBox19.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox19.TabIndex = 72;
            this.SakuraBox19.TabStop = false;
            // 
            // SakuraBox
            // 
            this.SakuraBox.Enabled = false;
            this.SakuraBox.ErrorImage = null;
            this.SakuraBox.InitialImage = null;
            this.SakuraBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.SakuraBox.Location = new System.Drawing.Point(0, 727);
            this.SakuraBox.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraBox.Name = "SakuraBox";
            this.SakuraBox.Size = new System.Drawing.Size(36, 39);
            this.SakuraBox.TabIndex = 0;
            this.SakuraBox.TabStop = false;
            this.SakuraBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SakuraBox_MouseDown);
            this.SakuraBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SakuraBox_MouseMove);
            // 
            // SakuraInfoPaddingLabel
            // 
            this.SakuraInfoPaddingLabel.AllowDrop = true;
            this.SakuraInfoPaddingLabel.AutoSize = true;
            this.SakuraInfoPaddingLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SakuraInfoPaddingLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SakuraInfoPaddingLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SakuraInfoPaddingLabel.Location = new System.Drawing.Point(498, 300);
            this.SakuraInfoPaddingLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SakuraInfoPaddingLabel.Name = "SakuraInfoPaddingLabel";
            this.SakuraInfoPaddingLabel.Size = new System.Drawing.Size(97, 21);
            this.SakuraInfoPaddingLabel.TabIndex = 213;
            this.SakuraInfoPaddingLabel.Text = "Info Padding";
            // 
            // SakuraInfoPaddingNumeric
            // 
            this.SakuraInfoPaddingNumeric.Location = new System.Drawing.Point(491, 328);
            this.SakuraInfoPaddingNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.SakuraInfoPaddingNumeric.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.SakuraInfoPaddingNumeric.Name = "SakuraInfoPaddingNumeric";
            this.SakuraInfoPaddingNumeric.Size = new System.Drawing.Size(116, 20);
            this.SakuraInfoPaddingNumeric.TabIndex = 212;
            // 
            // SakuraView
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1611, 886);
            this.Controls.Add(this.SakuraInfoPaddingLabel);
            this.Controls.Add(this.SakuraInfoPaddingNumeric);
            this.Controls.Add(this.SakuraStyle);
            this.Controls.Add(this.SakuraHeightTrackBar);
            this.Controls.Add(this.SakuraHeightNumeric);
            this.Controls.Add(this.SakuraHeightLabel);
            this.Controls.Add(this.SakuraCkVariableHeight);
            this.Controls.Add(this.SakuraCkVariableWidth);
            this.Controls.Add(this.SakuraWidthTrackBar);
            this.Controls.Add(this.SakuraWidthNumeric);
            this.Controls.Add(this.SakuraWidthLabel);
            this.Controls.Add(this.SakuraBorderTrackBar);
            this.Controls.Add(this.SakuraBorderNumeric);
            this.Controls.Add(this.SakuraBorderLabel);
            this.Controls.Add(this.SakuraText38);
            this.Controls.Add(this.SakuraText37);
            this.Controls.Add(this.SakuraText36);
            this.Controls.Add(this.SakuraText35);
            this.Controls.Add(this.SakuraText34);
            this.Controls.Add(this.SakuraText33);
            this.Controls.Add(this.SakuraText32);
            this.Controls.Add(this.SakuraText46);
            this.Controls.Add(this.SakuraText45);
            this.Controls.Add(this.SakuraText44);
            this.Controls.Add(this.SakuraText43);
            this.Controls.Add(this.SakuraText42);
            this.Controls.Add(this.SakuraText41);
            this.Controls.Add(this.SakuraText40);
            this.Controls.Add(this.SakuraText39);
            this.Controls.Add(this.SakuraText58);
            this.Controls.Add(this.SakuraText57);
            this.Controls.Add(this.SakuraText56);
            this.Controls.Add(this.SakuraText55);
            this.Controls.Add(this.SakuraText54);
            this.Controls.Add(this.SakuraText53);
            this.Controls.Add(this.SakuraText52);
            this.Controls.Add(this.SakuraText51);
            this.Controls.Add(this.SakuraText50);
            this.Controls.Add(this.SakuraText49);
            this.Controls.Add(this.SakuraText48);
            this.Controls.Add(this.SakuraText47);
            this.Controls.Add(this.SakuraText14);
            this.Controls.Add(this.SakuraText13);
            this.Controls.Add(this.SakuraText12);
            this.Controls.Add(this.SakuraText11);
            this.Controls.Add(this.SakuraText10);
            this.Controls.Add(this.SakuraText9);
            this.Controls.Add(this.SakuraText8);
            this.Controls.Add(this.SakuraText7);
            this.Controls.Add(this.SakuraText6);
            this.Controls.Add(this.SakuraText5);
            this.Controls.Add(this.SakuraText63);
            this.Controls.Add(this.SakuraText62);
            this.Controls.Add(this.SakuraText61);
            this.Controls.Add(this.SakuraText60);
            this.Controls.Add(this.SakuraText59);
            this.Controls.Add(this.SakuraText2);
            this.Controls.Add(this.SakuraText3);
            this.Controls.Add(this.SakuraText4);
            this.Controls.Add(this.SakuraText24);
            this.Controls.Add(this.SakuraText25);
            this.Controls.Add(this.SakuraText26);
            this.Controls.Add(this.SakuraText27);
            this.Controls.Add(this.SakuraText28);
            this.Controls.Add(this.SakuraText29);
            this.Controls.Add(this.SakuraText30);
            this.Controls.Add(this.SakuraText31);
            this.Controls.Add(this.SakuraText23);
            this.Controls.Add(this.SakuraText22);
            this.Controls.Add(this.SakuraText21);
            this.Controls.Add(this.SakuraText20);
            this.Controls.Add(this.SakuraText19);
            this.Controls.Add(this.SakuraText18);
            this.Controls.Add(this.SakuraText17);
            this.Controls.Add(this.SakuraText16);
            this.Controls.Add(this.SakuraText15);
            this.Controls.Add(this.SakuraText1);
            this.Controls.Add(this.SakuraText);
            this.Controls.Add(this.SakuraBox52);
            this.Controls.Add(this.SakuraBox53);
            this.Controls.Add(this.SakuraBox54);
            this.Controls.Add(this.SakuraBox55);
            this.Controls.Add(this.SakuraBox56);
            this.Controls.Add(this.SakuraBox57);
            this.Controls.Add(this.SakuraBox58);
            this.Controls.Add(this.SakuraBox59);
            this.Controls.Add(this.SakuraBox60);
            this.Controls.Add(this.SakuraBox61);
            this.Controls.Add(this.SakuraBox62);
            this.Controls.Add(this.SakuraBox63);
            this.Controls.Add(this.SakuraBox1);
            this.Controls.Add(this.SakuraBox34);
            this.Controls.Add(this.SakuraBox35);
            this.Controls.Add(this.SakuraBox36);
            this.Controls.Add(this.SakuraBox37);
            this.Controls.Add(this.SakuraBox38);
            this.Controls.Add(this.SakuraBox39);
            this.Controls.Add(this.SakuraBox40);
            this.Controls.Add(this.SakuraBox41);
            this.Controls.Add(this.SakuraBox42);
            this.Controls.Add(this.SakuraBox43);
            this.Controls.Add(this.SakuraBox44);
            this.Controls.Add(this.SakuraBox45);
            this.Controls.Add(this.SakuraBox46);
            this.Controls.Add(this.SakuraBox47);
            this.Controls.Add(this.SakuraBox48);
            this.Controls.Add(this.SakuraBox49);
            this.Controls.Add(this.SakuraBox50);
            this.Controls.Add(this.SakuraBox51);
            this.Controls.Add(this.SakuraBox33);
            this.Controls.Add(this.SakuraBox20);
            this.Controls.Add(this.SakuraBox21);
            this.Controls.Add(this.SakuraBox22);
            this.Controls.Add(this.SakuraBox23);
            this.Controls.Add(this.SakuraBox24);
            this.Controls.Add(this.SakuraBox25);
            this.Controls.Add(this.SakuraBox26);
            this.Controls.Add(this.SakuraBox27);
            this.Controls.Add(this.SakuraBox28);
            this.Controls.Add(this.SakuraBox29);
            this.Controls.Add(this.SakuraBox30);
            this.Controls.Add(this.SakuraBox31);
            this.Controls.Add(this.SakuraBox32);
            this.Controls.Add(this.SakuraBox2);
            this.Controls.Add(this.SakuraBox3);
            this.Controls.Add(this.SakuraBox4);
            this.Controls.Add(this.SakuraBox5);
            this.Controls.Add(this.SakuraBox6);
            this.Controls.Add(this.SakuraBox7);
            this.Controls.Add(this.SakuraBox8);
            this.Controls.Add(this.SakuraBox9);
            this.Controls.Add(this.SakuraBox10);
            this.Controls.Add(this.SakuraBox11);
            this.Controls.Add(this.SakuraBox12);
            this.Controls.Add(this.SakuraBox13);
            this.Controls.Add(this.SakuraBox14);
            this.Controls.Add(this.SakuraBox15);
            this.Controls.Add(this.SakuraBox16);
            this.Controls.Add(this.SakuraBox17);
            this.Controls.Add(this.SakuraBox18);
            this.Controls.Add(this.SakuraBox19);
            this.Controls.Add(this.SakuraUnsavedChanges);
            this.Controls.Add(this.SakuraLayoutTrackBar);
            this.Controls.Add(this.SakuraStyleTrackBar);
            this.Controls.Add(this.SakuraStyleLabel);
            this.Controls.Add(this.SakuraLayoutLabel);
            this.Controls.Add(this.SakuraLayout);
            this.Controls.Add(this.SakuraDisplayNumeric);
            this.Controls.Add(this.SakuraDisplayTrackBar);
            this.Controls.Add(this.SakuraDisplayLabel);
            this.Controls.Add(this.SakuraCkSkip);
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
            ((System.ComponentModel.ISupportInitialize)(this.SakuraDisplayTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraDisplayNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraStyleTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraLayoutTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBorderTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBorderNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraWidthTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraWidthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraHeightTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraHeightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox58)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox62)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SakuraInfoPaddingNumeric)).EndInit();
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
        private CheckBox SakuraCkSkip;
        private Label SakuraDisplayLabel;
        private TrackBar SakuraDisplayTrackBar;
        private NumericUpDown SakuraDisplayNumeric;
        private ComboBox SakuraLayout;
        private Label SakuraLayoutLabel;
        private Label SakuraStyleLabel;
        private TrackBar SakuraStyleTrackBar;
        private TrackBar SakuraLayoutTrackBar;
        private Label SakuraUnsavedChanges;
        private PictureBoxWithInterpolationMode SakuraBox19;
        private PictureBoxWithInterpolationMode SakuraBox18;
        private PictureBoxWithInterpolationMode SakuraBox17;
        private PictureBoxWithInterpolationMode SakuraBox16;
        private PictureBoxWithInterpolationMode SakuraBox15;
        private PictureBoxWithInterpolationMode SakuraBox14;
        private PictureBoxWithInterpolationMode SakuraBox13;
        private PictureBoxWithInterpolationMode SakuraBox12;
        private PictureBoxWithInterpolationMode SakuraBox11;
        private PictureBoxWithInterpolationMode SakuraBox10;
        private PictureBoxWithInterpolationMode SakuraBox9;
        private PictureBoxWithInterpolationMode SakuraBox8;
        private PictureBoxWithInterpolationMode SakuraBox7;
        private PictureBoxWithInterpolationMode SakuraBox6;
        private PictureBoxWithInterpolationMode SakuraBox5;
        private PictureBoxWithInterpolationMode SakuraBox4;
        private PictureBoxWithInterpolationMode SakuraBox3;
        private PictureBoxWithInterpolationMode SakuraBox2;
        private PictureBoxWithInterpolationMode SakuraBox32;
        private PictureBoxWithInterpolationMode SakuraBox31;
        private PictureBoxWithInterpolationMode SakuraBox30;
        private PictureBoxWithInterpolationMode SakuraBox29;
        private PictureBoxWithInterpolationMode SakuraBox28;
        private PictureBoxWithInterpolationMode SakuraBox27;
        private PictureBoxWithInterpolationMode SakuraBox26;
        private PictureBoxWithInterpolationMode SakuraBox25;
        private PictureBoxWithInterpolationMode SakuraBox24;
        private PictureBoxWithInterpolationMode SakuraBox23;
        private PictureBoxWithInterpolationMode SakuraBox22;
        private PictureBoxWithInterpolationMode SakuraBox21;
        private PictureBoxWithInterpolationMode SakuraBox20;
        private PictureBoxWithInterpolationMode SakuraBox52;
        private PictureBoxWithInterpolationMode SakuraBox53;
        private PictureBoxWithInterpolationMode SakuraBox54;
        private PictureBoxWithInterpolationMode SakuraBox55;
        private PictureBoxWithInterpolationMode SakuraBox56;
        private PictureBoxWithInterpolationMode SakuraBox57;
        private PictureBoxWithInterpolationMode SakuraBox58;
        private PictureBoxWithInterpolationMode SakuraBox59;
        private PictureBoxWithInterpolationMode SakuraBox60;
        private PictureBoxWithInterpolationMode SakuraBox61;
        private PictureBoxWithInterpolationMode SakuraBox62;
        private PictureBoxWithInterpolationMode SakuraBox63;
        private PictureBoxWithInterpolationMode SakuraBox1;
        private PictureBoxWithInterpolationMode SakuraBox34;
        private PictureBoxWithInterpolationMode SakuraBox35;
        private PictureBoxWithInterpolationMode SakuraBox36;
        private PictureBoxWithInterpolationMode SakuraBox37;
        private PictureBoxWithInterpolationMode SakuraBox38;
        private PictureBoxWithInterpolationMode SakuraBox39;
        private PictureBoxWithInterpolationMode SakuraBox40;
        private PictureBoxWithInterpolationMode SakuraBox41;
        private PictureBoxWithInterpolationMode SakuraBox42;
        private PictureBoxWithInterpolationMode SakuraBox43;
        private PictureBoxWithInterpolationMode SakuraBox44;
        private PictureBoxWithInterpolationMode SakuraBox45;
        private PictureBoxWithInterpolationMode SakuraBox46;
        private PictureBoxWithInterpolationMode SakuraBox47;
        private PictureBoxWithInterpolationMode SakuraBox48;
        private PictureBoxWithInterpolationMode SakuraBox49;
        private PictureBoxWithInterpolationMode SakuraBox50;
        private PictureBoxWithInterpolationMode SakuraBox51;
        private PictureBoxWithInterpolationMode SakuraBox33;
        private Label SakuraText;
        private Label SakuraText1;
        private Label SakuraText15;
        private Label SakuraText16;
        private Label SakuraText17;
        private Label SakuraText18;
        private Label SakuraText19;
        private Label SakuraText20;
        private Label SakuraText21;
        private Label SakuraText22;
        private Label SakuraText23;
        private Label SakuraText31;
        private Label SakuraText30;
        private Label SakuraText29;
        private Label SakuraText28;
        private Label SakuraText27;
        private Label SakuraText26;
        private Label SakuraText25;
        private Label SakuraText24;
        private Label SakuraText4;
        private Label SakuraText3;
        private Label SakuraText2;
        private Label SakuraText59;
        private Label SakuraText60;
        private Label SakuraText61;
        private Label SakuraText62;
        private Label SakuraText63;
        private Label SakuraText5;
        private Label SakuraText6;
        private Label SakuraText7;
        private Label SakuraText8;
        private Label SakuraText9;
        private Label SakuraText10;
        private Label SakuraText11;
        private Label SakuraText12;
        private Label SakuraText13;
        private Label SakuraText14;
        private Label SakuraText47;
        private Label SakuraText48;
        private Label SakuraText49;
        private Label SakuraText50;
        private Label SakuraText51;
        private Label SakuraText52;
        private Label SakuraText53;
        private Label SakuraText54;
        private Label SakuraText55;
        private Label SakuraText56;
        private Label SakuraText57;
        private Label SakuraText58;
        private Label SakuraText39;
        private Label SakuraText40;
        private Label SakuraText41;
        private Label SakuraText42;
        private Label SakuraText43;
        private Label SakuraText44;
        private Label SakuraText45;
        private Label SakuraText46;
        private Label SakuraText32;
        private Label SakuraText33;
        private Label SakuraText34;
        private Label SakuraText35;
        private Label SakuraText36;
        private Label SakuraText37;
        private Label SakuraText38;
        private TrackBar SakuraBorderTrackBar;
        private NumericUpDown SakuraBorderNumeric;
        private Label SakuraBorderLabel;
        private TrackBar SakuraWidthTrackBar;
        private NumericUpDown SakuraWidthNumeric;
        private Label SakuraWidthLabel;
        private CheckBox SakuraCkVariableWidth;
        private CheckBox SakuraCkVariableHeight;
        private TrackBar SakuraHeightTrackBar;
        private NumericUpDown SakuraHeightNumeric;
        private Label SakuraHeightLabel;
        private ComboBox SakuraStyle;
        private Label SakuraInfoPaddingLabel;
        private NumericUpDown SakuraInfoPaddingNumeric;
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