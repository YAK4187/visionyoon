
namespace DOT_Number_Reading
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnJobChange = new MetroFramework.Controls.MetroButton();
            this.btnSnapshot = new MetroFramework.Controls.MetroButton();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnLog = new MetroFramework.Controls.MetroButton();
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.btnJobfile2 = new MetroFramework.Controls.MetroButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabInspec = new MetroFramework.Controls.MetroTabPage();
            this.upDownParameter = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new MetroFramework.Controls.MetroButton();
            this.lblEdit = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblPLC = new System.Windows.Forms.Label();
            this.lblVision = new System.Windows.Forms.Label();
            this.lblWriteDOT = new System.Windows.Forms.Label();
            this.pnlVision = new MetroFramework.Controls.MetroPanel();
            this.btnVisionStart = new MetroFramework.Controls.MetroButton();
            this.btnVisionEnd = new MetroFramework.Controls.MetroButton();
            this.btnVisionHeart = new MetroFramework.Controls.MetroButton();
            this.lblVisionEnd = new System.Windows.Forms.Label();
            this.btnVisionReady = new MetroFramework.Controls.MetroButton();
            this.lblVisionStart = new System.Windows.Forms.Label();
            this.lblVisionHeart = new System.Windows.Forms.Label();
            this.lblVisionReady = new System.Windows.Forms.Label();
            this.pnlPLC = new MetroFramework.Controls.MetroPanel();
            this.btnPLCHeart = new MetroFramework.Controls.MetroButton();
            this.btnPLCReady = new MetroFramework.Controls.MetroButton();
            this.lblPLCEnd = new System.Windows.Forms.Label();
            this.btnPLCStart = new MetroFramework.Controls.MetroButton();
            this.btnPLCEnd = new MetroFramework.Controls.MetroButton();
            this.lblPLCStart = new System.Windows.Forms.Label();
            this.lblPLCHeart = new System.Windows.Forms.Label();
            this.lblPLCReady = new System.Windows.Forms.Label();
            this.txtWriteDOT = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.progressSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.pnlDOT = new MetroFramework.Controls.MetroPanel();
            this.txtDOT = new System.Windows.Forms.TextBox();
            this.lblDOT = new System.Windows.Forms.Label();
            this.pnlVIN = new MetroFramework.Controls.MetroPanel();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.lblVIN = new System.Windows.Forms.Label();
            this.tabHistory = new MetroFramework.Controls.MetroTabPage();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnJobfile3 = new MetroFramework.Controls.MetroButton();
            this.btnJobfile1 = new MetroFramework.Controls.MetroButton();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPolestar = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabInspec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownParameter)).BeginInit();
            this.pnlVision.SuspendLayout();
            this.pnlPLC.SuspendLayout();
            this.pnlDOT.SuspendLayout();
            this.pnlVIN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJobChange
            // 
            this.btnJobChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.btnJobChange.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnJobChange.ForeColor = System.Drawing.Color.White;
            this.btnJobChange.Location = new System.Drawing.Point(1099, 520);
            this.btnJobChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJobChange.Name = "btnJobChange";
            this.btnJobChange.Size = new System.Drawing.Size(193, 94);
            this.btnJobChange.TabIndex = 0;
            this.btnJobChange.Text = "CHANGE JOB FILE";
            this.btnJobChange.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnJobChange.UseCustomBackColor = true;
            this.btnJobChange.UseCustomForeColor = true;
            this.btnJobChange.UseSelectable = true;
            this.btnJobChange.Click += new System.EventHandler(this.btnJobChange_Click);
            // 
            // btnSnapshot
            // 
            this.btnSnapshot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.btnSnapshot.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSnapshot.ForeColor = System.Drawing.Color.White;
            this.btnSnapshot.Location = new System.Drawing.Point(1099, 248);
            this.btnSnapshot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSnapshot.Name = "btnSnapshot";
            this.btnSnapshot.Size = new System.Drawing.Size(193, 94);
            this.btnSnapshot.TabIndex = 1;
            this.btnSnapshot.Text = "SNAPSHOT";
            this.btnSnapshot.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSnapshot.UseCustomBackColor = true;
            this.btnSnapshot.UseCustomForeColor = true;
            this.btnSnapshot.UseSelectable = true;
            this.btnSnapshot.Click += new System.EventHandler(this.btnSnapshot_Click);
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImage.ErrorImage = null;
            this.pbImage.InitialImage = null;
            this.pbImage.Location = new System.Drawing.Point(19, 248);
            this.pbImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(1002, 806);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.btnLog.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLog.ForeColor = System.Drawing.Color.White;
            this.btnLog.Location = new System.Drawing.Point(1099, 385);
            this.btnLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(193, 94);
            this.btnLog.TabIndex = 23;
            this.btnLog.Text = "LOG";
            this.btnLog.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLog.UseCustomBackColor = true;
            this.btnLog.UseCustomForeColor = true;
            this.btnLog.UseSelectable = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSubmit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(567, 1102);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 36);
            this.btnSubmit.TabIndex = 25;
            this.btnSubmit.Text = "확인";
            this.btnSubmit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSubmit.UseCustomBackColor = true;
            this.btnSubmit.UseCustomForeColor = true;
            this.btnSubmit.UseSelectable = true;
            // 
            // btnJobfile2
            // 
            this.btnJobfile2.BackColor = System.Drawing.Color.Gray;
            this.btnJobfile2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnJobfile2.ForeColor = System.Drawing.Color.Black;
            this.btnJobfile2.Location = new System.Drawing.Point(1542, 6);
            this.btnJobfile2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJobfile2.Name = "btnJobfile2";
            this.btnJobfile2.Size = new System.Drawing.Size(105, 42);
            this.btnJobfile2.TabIndex = 16;
            this.btnJobfile2.Text = "JOB2";
            this.btnJobfile2.UseCustomBackColor = true;
            this.btnJobfile2.UseCustomForeColor = true;
            this.btnJobfile2.UseSelectable = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(610, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(721, 85);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "TIRE DOT NUMBER READING";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabInspec);
            this.tabControl.Controls.Add(this.tabHistory);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.tabControl.Location = new System.Drawing.Point(21, 75);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(2207, 1219);
            this.tabControl.TabIndex = 28;
            this.tabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabControl.UseSelectable = true;
            // 
            // tabInspec
            // 
            this.tabInspec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabInspec.Controls.Add(this.upDownParameter);
            this.tabInspec.Controls.Add(this.btnOK);
            this.tabInspec.Controls.Add(this.lblEdit);
            this.tabInspec.Controls.Add(this.lblProgress);
            this.tabInspec.Controls.Add(this.lblPLC);
            this.tabInspec.Controls.Add(this.lblVision);
            this.tabInspec.Controls.Add(this.lblWriteDOT);
            this.tabInspec.Controls.Add(this.pnlVision);
            this.tabInspec.Controls.Add(this.btnLog);
            this.tabInspec.Controls.Add(this.btnSnapshot);
            this.tabInspec.Controls.Add(this.btnJobChange);
            this.tabInspec.Controls.Add(this.btnSubmit);
            this.tabInspec.Controls.Add(this.pnlPLC);
            this.tabInspec.Controls.Add(this.txtWriteDOT);
            this.tabInspec.Controls.Add(this.txtLog);
            this.tabInspec.Controls.Add(this.progressSpinner);
            this.tabInspec.Controls.Add(this.pnlDOT);
            this.tabInspec.Controls.Add(this.pnlVIN);
            this.tabInspec.Controls.Add(this.pbImage);
            this.tabInspec.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabInspec.ForeColor = System.Drawing.Color.DimGray;
            this.tabInspec.HorizontalScrollbarBarColor = true;
            this.tabInspec.HorizontalScrollbarHighlightOnWheel = false;
            this.tabInspec.HorizontalScrollbarSize = 10;
            this.tabInspec.Location = new System.Drawing.Point(4, 38);
            this.tabInspec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabInspec.Name = "tabInspec";
            this.tabInspec.Size = new System.Drawing.Size(2199, 1177);
            this.tabInspec.TabIndex = 0;
            this.tabInspec.Text = "INSPECTION";
            this.tabInspec.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabInspec.VerticalScrollbarBarColor = true;
            this.tabInspec.VerticalScrollbarHighlightOnWheel = false;
            this.tabInspec.VerticalScrollbarSize = 10;
            // 
            // upDownParameter
            // 
            this.upDownParameter.BackColor = System.Drawing.SystemColors.Control;
            this.upDownParameter.DecimalPlaces = 2;
            this.upDownParameter.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDownParameter.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.upDownParameter.Location = new System.Drawing.Point(1622, 1101);
            this.upDownParameter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.upDownParameter.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            131072});
            this.upDownParameter.Name = "upDownParameter";
            this.upDownParameter.Size = new System.Drawing.Size(114, 34);
            this.upDownParameter.TabIndex = 46;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.DarkOrange;
            this.btnOK.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(1765, 1102);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 36);
            this.btnOK.TabIndex = 45;
            this.btnOK.Text = "확인";
            this.btnOK.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnOK.UseCustomBackColor = true;
            this.btnOK.UseCustomForeColor = true;
            this.btnOK.UseSelectable = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.lblEdit.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.ForeColor = System.Drawing.Color.White;
            this.lblEdit.Location = new System.Drawing.Point(1400, 1102);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(244, 30);
            this.lblEdit.TabIndex = 43;
            this.lblEdit.Text = "Confidence Threshold:";
            this.lblEdit.Visible = false;
            // 
            // lblProgress
            // 
            this.lblProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.lblProgress.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.ForeColor = System.Drawing.Color.White;
            this.lblProgress.Location = new System.Drawing.Point(1093, 1012);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(200, 42);
            this.lblProgress.TabIndex = 41;
            this.lblProgress.Text = "검사 진행 중...";
            this.lblProgress.Visible = false;
            // 
            // lblPLC
            // 
            this.lblPLC.AutoSize = true;
            this.lblPLC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.lblPLC.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPLC.ForeColor = System.Drawing.Color.White;
            this.lblPLC.Location = new System.Drawing.Point(1530, 198);
            this.lblPLC.Name = "lblPLC";
            this.lblPLC.Size = new System.Drawing.Size(69, 41);
            this.lblPLC.TabIndex = 40;
            this.lblPLC.Text = "PLC";
            // 
            // lblVision
            // 
            this.lblVision.AutoSize = true;
            this.lblVision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.lblVision.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVision.ForeColor = System.Drawing.Color.White;
            this.lblVision.Location = new System.Drawing.Point(1880, 198);
            this.lblVision.Name = "lblVision";
            this.lblVision.Size = new System.Drawing.Size(122, 41);
            this.lblVision.TabIndex = 40;
            this.lblVision.Text = "VISION";
            // 
            // lblWriteDOT
            // 
            this.lblWriteDOT.AutoSize = true;
            this.lblWriteDOT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.lblWriteDOT.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWriteDOT.ForeColor = System.Drawing.Color.White;
            this.lblWriteDOT.Location = new System.Drawing.Point(23, 1105);
            this.lblWriteDOT.Name = "lblWriteDOT";
            this.lblWriteDOT.Size = new System.Drawing.Size(209, 30);
            this.lblWriteDOT.TabIndex = 29;
            this.lblWriteDOT.Text = "DOT Manual Input:";
            // 
            // pnlVision
            // 
            this.pnlVision.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlVision.Controls.Add(this.btnVisionStart);
            this.pnlVision.Controls.Add(this.btnVisionEnd);
            this.pnlVision.Controls.Add(this.btnVisionHeart);
            this.pnlVision.Controls.Add(this.lblVisionEnd);
            this.pnlVision.Controls.Add(this.btnVisionReady);
            this.pnlVision.Controls.Add(this.lblVisionStart);
            this.pnlVision.Controls.Add(this.lblVisionHeart);
            this.pnlVision.Controls.Add(this.lblVisionReady);
            this.pnlVision.HorizontalScrollbarBarColor = true;
            this.pnlVision.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlVision.HorizontalScrollbarSize = 12;
            this.pnlVision.Location = new System.Drawing.Point(1765, 248);
            this.pnlVision.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlVision.Name = "pnlVision";
            this.pnlVision.Size = new System.Drawing.Size(336, 429);
            this.pnlVision.TabIndex = 39;
            this.pnlVision.UseCustomBackColor = true;
            this.pnlVision.UseCustomForeColor = true;
            this.pnlVision.VerticalScrollbarBarColor = true;
            this.pnlVision.VerticalScrollbarHighlightOnWheel = false;
            this.pnlVision.VerticalScrollbarSize = 11;
            // 
            // btnVisionStart
            // 
            this.btnVisionStart.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnVisionStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVisionStart.BackgroundImage")));
            this.btnVisionStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVisionStart.Location = new System.Drawing.Point(47, 222);
            this.btnVisionStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVisionStart.Name = "btnVisionStart";
            this.btnVisionStart.Size = new System.Drawing.Size(90, 80);
            this.btnVisionStart.TabIndex = 46;
            this.btnVisionStart.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnVisionStart.UseCustomBackColor = true;
            this.btnVisionStart.UseCustomForeColor = true;
            this.btnVisionStart.UseSelectable = true;
            // 
            // btnVisionEnd
            // 
            this.btnVisionEnd.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnVisionEnd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVisionEnd.BackgroundImage")));
            this.btnVisionEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVisionEnd.Location = new System.Drawing.Point(47, 308);
            this.btnVisionEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVisionEnd.Name = "btnVisionEnd";
            this.btnVisionEnd.Size = new System.Drawing.Size(90, 80);
            this.btnVisionEnd.TabIndex = 47;
            this.btnVisionEnd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnVisionEnd.UseCustomBackColor = true;
            this.btnVisionEnd.UseCustomForeColor = true;
            this.btnVisionEnd.UseSelectable = true;
            // 
            // btnVisionHeart
            // 
            this.btnVisionHeart.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnVisionHeart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVisionHeart.BackgroundImage")));
            this.btnVisionHeart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVisionHeart.Location = new System.Drawing.Point(47, 52);
            this.btnVisionHeart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVisionHeart.Name = "btnVisionHeart";
            this.btnVisionHeart.Size = new System.Drawing.Size(90, 80);
            this.btnVisionHeart.TabIndex = 38;
            this.btnVisionHeart.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnVisionHeart.UseCustomBackColor = true;
            this.btnVisionHeart.UseCustomForeColor = true;
            this.btnVisionHeart.UseSelectable = true;
            // 
            // lblVisionEnd
            // 
            this.lblVisionEnd.BackColor = System.Drawing.Color.SeaGreen;
            this.lblVisionEnd.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisionEnd.ForeColor = System.Drawing.Color.White;
            this.lblVisionEnd.Location = new System.Drawing.Point(201, 328);
            this.lblVisionEnd.Name = "lblVisionEnd";
            this.lblVisionEnd.Size = new System.Drawing.Size(63, 39);
            this.lblVisionEnd.TabIndex = 45;
            this.lblVisionEnd.Text = "END";
            this.lblVisionEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVisionReady
            // 
            this.btnVisionReady.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnVisionReady.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVisionReady.BackgroundImage")));
            this.btnVisionReady.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVisionReady.Location = new System.Drawing.Point(47, 138);
            this.btnVisionReady.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVisionReady.Name = "btnVisionReady";
            this.btnVisionReady.Size = new System.Drawing.Size(90, 80);
            this.btnVisionReady.TabIndex = 41;
            this.btnVisionReady.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnVisionReady.UseCustomBackColor = true;
            this.btnVisionReady.UseCustomForeColor = true;
            this.btnVisionReady.UseSelectable = true;
            // 
            // lblVisionStart
            // 
            this.lblVisionStart.BackColor = System.Drawing.Color.SeaGreen;
            this.lblVisionStart.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisionStart.ForeColor = System.Drawing.Color.White;
            this.lblVisionStart.Location = new System.Drawing.Point(182, 250);
            this.lblVisionStart.Name = "lblVisionStart";
            this.lblVisionStart.Size = new System.Drawing.Size(86, 36);
            this.lblVisionStart.TabIndex = 44;
            this.lblVisionStart.Text = "START";
            this.lblVisionStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVisionHeart
            // 
            this.lblVisionHeart.BackColor = System.Drawing.Color.SeaGreen;
            this.lblVisionHeart.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisionHeart.ForeColor = System.Drawing.Color.White;
            this.lblVisionHeart.Location = new System.Drawing.Point(160, 72);
            this.lblVisionHeart.Name = "lblVisionHeart";
            this.lblVisionHeart.Size = new System.Drawing.Size(134, 40);
            this.lblVisionHeart.TabIndex = 42;
            this.lblVisionHeart.Text = "HEARTBEAT";
            this.lblVisionHeart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVisionReady
            // 
            this.lblVisionReady.BackColor = System.Drawing.Color.SeaGreen;
            this.lblVisionReady.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisionReady.ForeColor = System.Drawing.Color.White;
            this.lblVisionReady.Location = new System.Drawing.Point(182, 164);
            this.lblVisionReady.Name = "lblVisionReady";
            this.lblVisionReady.Size = new System.Drawing.Size(82, 35);
            this.lblVisionReady.TabIndex = 43;
            this.lblVisionReady.Text = "READY";
            this.lblVisionReady.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPLC
            // 
            this.pnlPLC.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlPLC.Controls.Add(this.btnPLCHeart);
            this.pnlPLC.Controls.Add(this.btnPLCReady);
            this.pnlPLC.Controls.Add(this.lblPLCEnd);
            this.pnlPLC.Controls.Add(this.btnPLCStart);
            this.pnlPLC.Controls.Add(this.btnPLCEnd);
            this.pnlPLC.Controls.Add(this.lblPLCStart);
            this.pnlPLC.Controls.Add(this.lblPLCHeart);
            this.pnlPLC.Controls.Add(this.lblPLCReady);
            this.pnlPLC.HorizontalScrollbarBarColor = true;
            this.pnlPLC.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlPLC.HorizontalScrollbarSize = 12;
            this.pnlPLC.Location = new System.Drawing.Point(1400, 248);
            this.pnlPLC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlPLC.Name = "pnlPLC";
            this.pnlPLC.Size = new System.Drawing.Size(336, 429);
            this.pnlPLC.TabIndex = 26;
            this.pnlPLC.UseCustomBackColor = true;
            this.pnlPLC.UseCustomForeColor = true;
            this.pnlPLC.VerticalScrollbarBarColor = true;
            this.pnlPLC.VerticalScrollbarHighlightOnWheel = false;
            this.pnlPLC.VerticalScrollbarSize = 11;
            // 
            // btnPLCHeart
            // 
            this.btnPLCHeart.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPLCHeart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPLCHeart.BackgroundImage")));
            this.btnPLCHeart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPLCHeart.Location = new System.Drawing.Point(53, 52);
            this.btnPLCHeart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPLCHeart.Name = "btnPLCHeart";
            this.btnPLCHeart.Size = new System.Drawing.Size(90, 80);
            this.btnPLCHeart.TabIndex = 24;
            this.btnPLCHeart.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnPLCHeart.UseCustomBackColor = true;
            this.btnPLCHeart.UseCustomForeColor = true;
            this.btnPLCHeart.UseSelectable = true;
            // 
            // btnPLCReady
            // 
            this.btnPLCReady.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPLCReady.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPLCReady.BackgroundImage")));
            this.btnPLCReady.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPLCReady.Location = new System.Drawing.Point(53, 138);
            this.btnPLCReady.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPLCReady.Name = "btnPLCReady";
            this.btnPLCReady.Size = new System.Drawing.Size(90, 80);
            this.btnPLCReady.TabIndex = 29;
            this.btnPLCReady.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnPLCReady.UseCustomBackColor = true;
            this.btnPLCReady.UseCustomForeColor = true;
            this.btnPLCReady.UseSelectable = true;
            // 
            // lblPLCEnd
            // 
            this.lblPLCEnd.BackColor = System.Drawing.Color.SeaGreen;
            this.lblPLCEnd.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPLCEnd.ForeColor = System.Drawing.Color.White;
            this.lblPLCEnd.Location = new System.Drawing.Point(207, 328);
            this.lblPLCEnd.Name = "lblPLCEnd";
            this.lblPLCEnd.Size = new System.Drawing.Size(63, 39);
            this.lblPLCEnd.TabIndex = 37;
            this.lblPLCEnd.Text = "END";
            this.lblPLCEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPLCStart
            // 
            this.btnPLCStart.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPLCStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPLCStart.BackgroundImage")));
            this.btnPLCStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPLCStart.Location = new System.Drawing.Point(53, 222);
            this.btnPLCStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPLCStart.Name = "btnPLCStart";
            this.btnPLCStart.Size = new System.Drawing.Size(90, 80);
            this.btnPLCStart.TabIndex = 32;
            this.btnPLCStart.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnPLCStart.UseCustomBackColor = true;
            this.btnPLCStart.UseCustomForeColor = true;
            this.btnPLCStart.UseSelectable = true;
            // 
            // btnPLCEnd
            // 
            this.btnPLCEnd.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPLCEnd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPLCEnd.BackgroundImage")));
            this.btnPLCEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPLCEnd.Location = new System.Drawing.Point(53, 308);
            this.btnPLCEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPLCEnd.Name = "btnPLCEnd";
            this.btnPLCEnd.Size = new System.Drawing.Size(90, 80);
            this.btnPLCEnd.TabIndex = 33;
            this.btnPLCEnd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnPLCEnd.UseCustomBackColor = true;
            this.btnPLCEnd.UseCustomForeColor = true;
            this.btnPLCEnd.UseSelectable = true;
            // 
            // lblPLCStart
            // 
            this.lblPLCStart.BackColor = System.Drawing.Color.SeaGreen;
            this.lblPLCStart.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPLCStart.ForeColor = System.Drawing.Color.White;
            this.lblPLCStart.Location = new System.Drawing.Point(187, 250);
            this.lblPLCStart.Name = "lblPLCStart";
            this.lblPLCStart.Size = new System.Drawing.Size(86, 36);
            this.lblPLCStart.TabIndex = 36;
            this.lblPLCStart.Text = "START";
            this.lblPLCStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPLCHeart
            // 
            this.lblPLCHeart.BackColor = System.Drawing.Color.SeaGreen;
            this.lblPLCHeart.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPLCHeart.ForeColor = System.Drawing.Color.White;
            this.lblPLCHeart.Location = new System.Drawing.Point(166, 72);
            this.lblPLCHeart.Name = "lblPLCHeart";
            this.lblPLCHeart.Size = new System.Drawing.Size(134, 40);
            this.lblPLCHeart.TabIndex = 34;
            this.lblPLCHeart.Text = "HEARTBEAT";
            this.lblPLCHeart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPLCReady
            // 
            this.lblPLCReady.BackColor = System.Drawing.Color.SeaGreen;
            this.lblPLCReady.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPLCReady.ForeColor = System.Drawing.Color.White;
            this.lblPLCReady.Location = new System.Drawing.Point(187, 164);
            this.lblPLCReady.Name = "lblPLCReady";
            this.lblPLCReady.Size = new System.Drawing.Size(82, 35);
            this.lblPLCReady.TabIndex = 35;
            this.lblPLCReady.Text = "READY";
            this.lblPLCReady.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWriteDOT
            // 
            this.txtWriteDOT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtWriteDOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWriteDOT.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWriteDOT.ForeColor = System.Drawing.Color.DimGray;
            this.txtWriteDOT.Location = new System.Drawing.Point(215, 1102);
            this.txtWriteDOT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWriteDOT.Name = "txtWriteDOT";
            this.txtWriteDOT.Size = new System.Drawing.Size(323, 34);
            this.txtWriteDOT.TabIndex = 4;
            this.txtWriteDOT.Text = "타이어 DOT 번호를 입력하세요";
            this.txtWriteDOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWriteDOT.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtWriteDOT_MouseClick);
            this.txtWriteDOT.MouseLeave += new System.EventHandler(this.txtWriteDOT_Leave);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.txtLog.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(1400, 718);
            this.txtLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(700, 345);
            this.txtLog.TabIndex = 12;
            this.txtLog.Visible = false;
            // 
            // progressSpinner
            // 
            this.progressSpinner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.progressSpinner.Location = new System.Drawing.Point(1098, 718);
            this.progressSpinner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressSpinner.Maximum = 100;
            this.progressSpinner.Name = "progressSpinner";
            this.progressSpinner.Size = new System.Drawing.Size(193, 215);
            this.progressSpinner.TabIndex = 27;
            this.progressSpinner.UseCustomBackColor = true;
            this.progressSpinner.UseCustomForeColor = true;
            this.progressSpinner.UseSelectable = true;
            this.progressSpinner.Visible = false;
            // 
            // pnlDOT
            // 
            this.pnlDOT.BackColor = System.Drawing.Color.MediumPurple;
            this.pnlDOT.Controls.Add(this.txtDOT);
            this.pnlDOT.Controls.Add(this.lblDOT);
            this.pnlDOT.HorizontalScrollbarBarColor = true;
            this.pnlDOT.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDOT.HorizontalScrollbarSize = 12;
            this.pnlDOT.Location = new System.Drawing.Point(1098, 44);
            this.pnlDOT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlDOT.Name = "pnlDOT";
            this.pnlDOT.Size = new System.Drawing.Size(1002, 138);
            this.pnlDOT.TabIndex = 24;
            this.pnlDOT.UseCustomBackColor = true;
            this.pnlDOT.UseCustomForeColor = true;
            this.pnlDOT.VerticalScrollbarBarColor = true;
            this.pnlDOT.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDOT.VerticalScrollbarSize = 11;
            // 
            // txtDOT
            // 
            this.txtDOT.BackColor = System.Drawing.Color.White;
            this.txtDOT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDOT.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOT.ForeColor = System.Drawing.Color.Purple;
            this.txtDOT.Location = new System.Drawing.Point(377, 36);
            this.txtDOT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDOT.Name = "txtDOT";
            this.txtDOT.ReadOnly = true;
            this.txtDOT.Size = new System.Drawing.Size(410, 62);
            this.txtDOT.TabIndex = 5;
            this.txtDOT.Text = "7G3AU2R0121";
            this.txtDOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDOT
            // 
            this.lblDOT.AutoSize = true;
            this.lblDOT.BackColor = System.Drawing.Color.MediumPurple;
            this.lblDOT.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOT.ForeColor = System.Drawing.Color.White;
            this.lblDOT.Location = new System.Drawing.Point(227, 36);
            this.lblDOT.Name = "lblDOT";
            this.lblDOT.Size = new System.Drawing.Size(124, 62);
            this.lblDOT.TabIndex = 3;
            this.lblDOT.Text = "DOT";
            // 
            // pnlVIN
            // 
            this.pnlVIN.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlVIN.Controls.Add(this.txtVIN);
            this.pnlVIN.Controls.Add(this.lblVIN);
            this.pnlVIN.HorizontalScrollbarBarColor = true;
            this.pnlVIN.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlVIN.HorizontalScrollbarSize = 12;
            this.pnlVIN.Location = new System.Drawing.Point(19, 44);
            this.pnlVIN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlVIN.Name = "pnlVIN";
            this.pnlVIN.Size = new System.Drawing.Size(1002, 138);
            this.pnlVIN.TabIndex = 23;
            this.pnlVIN.UseCustomBackColor = true;
            this.pnlVIN.UseCustomForeColor = true;
            this.pnlVIN.VerticalScrollbarBarColor = true;
            this.pnlVIN.VerticalScrollbarHighlightOnWheel = false;
            this.pnlVIN.VerticalScrollbarSize = 11;
            // 
            // txtVIN
            // 
            this.txtVIN.BackColor = System.Drawing.Color.White;
            this.txtVIN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVIN.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVIN.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtVIN.Location = new System.Drawing.Point(291, 36);
            this.txtVIN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.ReadOnly = true;
            this.txtVIN.Size = new System.Drawing.Size(542, 62);
            this.txtVIN.TabIndex = 4;
            this.txtVIN.Text = "KNME5C25P99000000";
            this.txtVIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVIN
            // 
            this.lblVIN.AutoSize = true;
            this.lblVIN.BackColor = System.Drawing.Color.SteelBlue;
            this.lblVIN.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVIN.ForeColor = System.Drawing.Color.White;
            this.lblVIN.Location = new System.Drawing.Point(154, 36);
            this.lblVIN.Name = "lblVIN";
            this.lblVIN.Size = new System.Drawing.Size(110, 62);
            this.lblVIN.TabIndex = 3;
            this.lblVIN.Text = "VIN";
            // 
            // tabHistory
            // 
            this.tabHistory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabHistory.ForeColor = System.Drawing.Color.White;
            this.tabHistory.HorizontalScrollbarBarColor = true;
            this.tabHistory.HorizontalScrollbarHighlightOnWheel = false;
            this.tabHistory.HorizontalScrollbarSize = 10;
            this.tabHistory.Location = new System.Drawing.Point(4, 38);
            this.tabHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Size = new System.Drawing.Size(2199, 1177);
            this.tabHistory.TabIndex = 1;
            this.tabHistory.Text = "HISTORY";
            this.tabHistory.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabHistory.VerticalScrollbarBarColor = true;
            this.tabHistory.VerticalScrollbarHighlightOnWheel = false;
            this.tabHistory.VerticalScrollbarSize = 10;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.ErrorImage = null;
            this.pbLogo.InitialImage = null;
            this.pbLogo.Location = new System.Drawing.Point(3, 6);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(314, 75);
            this.pbLogo.TabIndex = 26;
            this.pbLogo.TabStop = false;
            // 
            // btnJobfile3
            // 
            this.btnJobfile3.BackColor = System.Drawing.Color.Gray;
            this.btnJobfile3.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnJobfile3.ForeColor = System.Drawing.Color.Black;
            this.btnJobfile3.Location = new System.Drawing.Point(1654, 6);
            this.btnJobfile3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJobfile3.Name = "btnJobfile3";
            this.btnJobfile3.Size = new System.Drawing.Size(107, 42);
            this.btnJobfile3.TabIndex = 29;
            this.btnJobfile3.Text = "JOB3";
            this.btnJobfile3.UseCustomBackColor = true;
            this.btnJobfile3.UseCustomForeColor = true;
            this.btnJobfile3.UseSelectable = true;
            // 
            // btnJobfile1
            // 
            this.btnJobfile1.BackColor = System.Drawing.Color.Gray;
            this.btnJobfile1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnJobfile1.ForeColor = System.Drawing.Color.Black;
            this.btnJobfile1.Location = new System.Drawing.Point(1430, 6);
            this.btnJobfile1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJobfile1.Name = "btnJobfile1";
            this.btnJobfile1.Size = new System.Drawing.Size(105, 42);
            this.btnJobfile1.TabIndex = 30;
            this.btnJobfile1.Text = "JOB1";
            this.btnJobfile1.UseCustomBackColor = true;
            this.btnJobfile1.UseCustomForeColor = true;
            this.btnJobfile1.UseSelectable = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(2013, 6);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(81, 75);
            this.btnLogin.TabIndex = 31;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPolestar
            // 
            this.lblPolestar.Font = new System.Drawing.Font("Segoe UI", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolestar.ForeColor = System.Drawing.Color.Gold;
            this.lblPolestar.Location = new System.Drawing.Point(351, 6);
            this.lblPolestar.Name = "lblPolestar";
            this.lblPolestar.Size = new System.Drawing.Size(299, 85);
            this.lblPolestar.TabIndex = 32;
            this.lblPolestar.Text = "POLESTAR";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Visible = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2249, 1314);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnJobfile1);
            this.Controls.Add(this.btnJobfile3);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnJobfile2);
            this.Controls.Add(this.lblPolestar);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(21, 75, 21, 20);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabInspec.ResumeLayout(false);
            this.tabInspec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownParameter)).EndInit();
            this.pnlVision.ResumeLayout(false);
            this.pnlPLC.ResumeLayout(false);
            this.pnlDOT.ResumeLayout(false);
            this.pnlDOT.PerformLayout();
            this.pnlVIN.ResumeLayout(false);
            this.pnlVIN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnJobChange;
        private MetroFramework.Controls.MetroButton btnSnapshot;
        private System.Windows.Forms.PictureBox pbImage;
        private MetroFramework.Controls.MetroButton btnPLCStart;
        private MetroFramework.Controls.MetroButton btnPLCReady;
        private MetroFramework.Controls.MetroButton btnPLCHeart;
        private MetroFramework.Controls.MetroButton btnLog;
        private MetroFramework.Controls.MetroButton btnSubmit;
        private MetroFramework.Controls.MetroButton btnJobfile2;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblTitle;
        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage tabInspec;
        private MetroFramework.Controls.MetroTabPage tabHistory;
        private MetroFramework.Controls.MetroPanel pnlVIN;
        private System.Windows.Forms.Label lblVIN;
        private MetroFramework.Controls.MetroPanel pnlDOT;
        private System.Windows.Forms.TextBox txtDOT;
        private System.Windows.Forms.Label lblDOT;
        private System.Windows.Forms.TextBox txtVIN;
        private MetroFramework.Controls.MetroProgressSpinner progressSpinner;
        private System.Windows.Forms.Label lblVision;
        private MetroFramework.Controls.MetroPanel pnlVision;
        private MetroFramework.Controls.MetroPanel pnlPLC;
        private System.Windows.Forms.Label lblPLCEnd;
        private System.Windows.Forms.Label lblPLCStart;
        private System.Windows.Forms.Label lblPLCReady;
        private System.Windows.Forms.Label lblPLCHeart;
        private MetroFramework.Controls.MetroButton btnPLCEnd;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtWriteDOT;
        private System.Windows.Forms.Label lblWriteDOT;
        private System.Windows.Forms.Label lblPLC;
        private System.Windows.Forms.Label lblProgress;
        private MetroFramework.Controls.MetroButton btnJobfile3;
        private MetroFramework.Controls.MetroButton btnJobfile1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblEdit;
        private MetroFramework.Controls.MetroButton btnOK;
        private System.Windows.Forms.NumericUpDown upDownParameter;
        private MetroFramework.Controls.MetroButton btnVisionHeart;
        private System.Windows.Forms.Label lblVisionEnd;
        private MetroFramework.Controls.MetroButton btnVisionReady;
        private System.Windows.Forms.Label lblVisionStart;
        private System.Windows.Forms.Label lblVisionHeart;
        private System.Windows.Forms.Label lblVisionReady;
        private MetroFramework.Controls.MetroButton btnVisionStart;
        private MetroFramework.Controls.MetroButton btnVisionEnd;
        private System.Windows.Forms.Label lblPolestar;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

