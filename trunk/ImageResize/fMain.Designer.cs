namespace WindowsFormsApplication1
{
    partial class TfMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TfMain));
            this.lFiles = new System.Windows.Forms.Label();
            this.lvFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.chRatio = new System.Windows.Forms.ColumnHeader();
            this.chRotate = new System.Windows.Forms.ColumnHeader();
            this.cmFiles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmViewFull = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRotate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRotateCW = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRotateCCW = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmRotateNone = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmMark = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMarkChecked = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMarkUnchecked = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmClear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.odImages = new System.Windows.Forms.OpenFileDialog();
            this.lMaxSize = new System.Windows.Forms.Label();
            this.numMaxSize = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pbFiles = new System.Windows.Forms.ToolStripProgressBar();
            this.bConvert = new System.Windows.Forms.Button();
            this.lDestPath = new System.Windows.Forms.Label();
            this.eDestPath = new System.Windows.Forms.TextBox();
            this.bBrowsePath = new System.Windows.Forms.Button();
            this.fdPath = new System.Windows.Forms.FolderBrowserDialog();
            this.cbWatermark = new System.Windows.Forms.CheckBox();
            this.lWatermarkText = new System.Windows.Forms.Label();
            this.eWatermarkText = new System.Windows.Forms.TextBox();
            this.lOpacity = new System.Windows.Forms.Label();
            this.numOpacity = new System.Windows.Forms.NumericUpDown();
            this.lCount = new System.Windows.Forms.Label();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.lCustomName = new System.Windows.Forms.Label();
            this.eCustomName = new System.Windows.Forms.TextBox();
            this.numCustomNumber = new System.Windows.Forms.NumericUpDown();
            this.lSize = new System.Windows.Forms.Label();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.lHint1 = new System.Windows.Forms.Label();
            this.cbOverwrite = new System.Windows.Forms.CheckBox();
            this.lHint2 = new System.Windows.Forms.Label();
            this.lHint3 = new System.Windows.Forms.Label();
            this.lHint4 = new System.Windows.Forms.Label();
            this.lColour = new System.Windows.Forms.Label();
            this.pColour = new System.Windows.Forms.Panel();
            this.cdWatermark = new System.Windows.Forms.ColorDialog();
            this.cmFiles.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxSize)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCustomNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // lFiles
            // 
            this.lFiles.AutoSize = true;
            this.lFiles.Location = new System.Drawing.Point(9, 30);
            this.lFiles.Name = "lFiles";
            this.lFiles.Size = new System.Drawing.Size(31, 13);
            this.lFiles.TabIndex = 0;
            this.lFiles.Text = "Files:";
            // 
            // lvFiles
            // 
            this.lvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFiles.CheckBoxes = true;
            this.lvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.chRatio,
            this.chRotate});
            this.lvFiles.ContextMenuStrip = this.cmFiles;
            this.lvFiles.FullRowSelect = true;
            this.lvFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvFiles.HideSelection = false;
            this.lvFiles.Location = new System.Drawing.Point(12, 46);
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(759, 208);
            this.lvFiles.TabIndex = 1;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.View = System.Windows.Forms.View.Details;
            this.lvFiles.SelectedIndexChanged += new System.EventHandler(this.lvFiles_SelectedIndexChanged);
            this.lvFiles.DoubleClick += new System.EventHandler(this.lvFiles_DoubleClick);
            this.lvFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvFiles_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 350;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Size";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "DateTime";
            this.columnHeader3.Width = 150;
            // 
            // chRatio
            // 
            this.chRatio.Text = "Ratio";
            // 
            // chRotate
            // 
            this.chRotate.Text = "Rotate";
            // 
            // cmFiles
            // 
            this.cmFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmViewFull,
            this.tsmRotate,
            this.toolStripMenuItem3,
            this.tsmMark,
            this.toolStripMenuItem4,
            this.tsmClear,
            this.tsmRemove});
            this.cmFiles.Name = "cmFiles";
            this.cmFiles.Size = new System.Drawing.Size(194, 126);
            this.cmFiles.Opening += new System.ComponentModel.CancelEventHandler(this.cmFiles_Opening);
            // 
            // tsmViewFull
            // 
            this.tsmViewFull.Name = "tsmViewFull";
            this.tsmViewFull.Size = new System.Drawing.Size(193, 22);
            this.tsmViewFull.Text = "View Full Image";
            this.tsmViewFull.Click += new System.EventHandler(this.tsmViewFull_Click);
            // 
            // tsmRotate
            // 
            this.tsmRotate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRotateCW,
            this.tsmRotateCCW,
            this.toolStripMenuItem2,
            this.tsmRotateNone});
            this.tsmRotate.Name = "tsmRotate";
            this.tsmRotate.Size = new System.Drawing.Size(193, 22);
            this.tsmRotate.Text = "Rotate";
            // 
            // tsmRotateCW
            // 
            this.tsmRotateCW.Name = "tsmRotateCW";
            this.tsmRotateCW.Size = new System.Drawing.Size(175, 22);
            this.tsmRotateCW.Text = "Clockwise";
            this.tsmRotateCW.Click += new System.EventHandler(this.tsmRotateCW_Click);
            // 
            // tsmRotateCCW
            // 
            this.tsmRotateCCW.Name = "tsmRotateCCW";
            this.tsmRotateCCW.Size = new System.Drawing.Size(175, 22);
            this.tsmRotateCCW.Text = "Counter-Clockwise";
            this.tsmRotateCCW.Click += new System.EventHandler(this.tsmRotateCCW_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(172, 6);
            // 
            // tsmRotateNone
            // 
            this.tsmRotateNone.Name = "tsmRotateNone";
            this.tsmRotateNone.Size = new System.Drawing.Size(175, 22);
            this.tsmRotateNone.Text = "None";
            this.tsmRotateNone.Click += new System.EventHandler(this.tsmRotateNone_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(190, 6);
            // 
            // tsmMark
            // 
            this.tsmMark.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMarkChecked,
            this.tsmMarkUnchecked});
            this.tsmMark.Name = "tsmMark";
            this.tsmMark.Size = new System.Drawing.Size(193, 22);
            this.tsmMark.Text = "Mark Images";
            // 
            // tsmMarkChecked
            // 
            this.tsmMarkChecked.Name = "tsmMarkChecked";
            this.tsmMarkChecked.Size = new System.Drawing.Size(133, 22);
            this.tsmMarkChecked.Text = "Checked";
            this.tsmMarkChecked.Click += new System.EventHandler(this.tsmMarkChecked_Click);
            // 
            // tsmMarkUnchecked
            // 
            this.tsmMarkUnchecked.Name = "tsmMarkUnchecked";
            this.tsmMarkUnchecked.Size = new System.Drawing.Size(133, 22);
            this.tsmMarkUnchecked.Text = "Unchecked";
            this.tsmMarkUnchecked.Click += new System.EventHandler(this.tsmMarkUnchecked_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(190, 6);
            // 
            // tsmClear
            // 
            this.tsmClear.Name = "tsmClear";
            this.tsmClear.Size = new System.Drawing.Size(193, 22);
            this.tsmClear.Text = "Clear List";
            this.tsmClear.Click += new System.EventHandler(this.mClear_Click);
            // 
            // tsmRemove
            // 
            this.tsmRemove.Name = "tsmRemove";
            this.tsmRemove.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.tsmRemove.Size = new System.Drawing.Size(193, 22);
            this.tsmRemove.Text = "Remove From List";
            this.tsmRemove.Click += new System.EventHandler(this.tsmRemove_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFile,
            this.mHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mFile
            // 
            this.mFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mOpen,
            this.mClear,
            this.toolStripMenuItem1,
            this.mExit});
            this.mFile.Name = "mFile";
            this.mFile.Size = new System.Drawing.Size(37, 20);
            this.mFile.Text = "File";
            // 
            // mOpen
            // 
            this.mOpen.Name = "mOpen";
            this.mOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mOpen.Size = new System.Drawing.Size(146, 22);
            this.mOpen.Text = "Open";
            this.mOpen.Click += new System.EventHandler(this.mOpen_Click);
            // 
            // mClear
            // 
            this.mClear.Name = "mClear";
            this.mClear.Size = new System.Drawing.Size(146, 22);
            this.mClear.Text = "Clear List";
            this.mClear.Click += new System.EventHandler(this.mClear_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 6);
            // 
            // mExit
            // 
            this.mExit.Name = "mExit";
            this.mExit.Size = new System.Drawing.Size(146, 22);
            this.mExit.Text = "Exit";
            this.mExit.Click += new System.EventHandler(this.mExit_Click);
            // 
            // mHelp
            // 
            this.mHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAbout});
            this.mHelp.Name = "mHelp";
            this.mHelp.Size = new System.Drawing.Size(44, 20);
            this.mHelp.Text = "Help";
            // 
            // mAbout
            // 
            this.mAbout.Name = "mAbout";
            this.mAbout.Size = new System.Drawing.Size(152, 22);
            this.mAbout.Text = "About ...";
            this.mAbout.Click += new System.EventHandler(this.mAbout_Click);
            // 
            // odImages
            // 
            this.odImages.Filter = "JPEG files|*.jpg;*.jpeg|All files\"|*.*";
            this.odImages.Multiselect = true;
            this.odImages.Title = "Select image files";
            // 
            // lMaxSize
            // 
            this.lMaxSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lMaxSize.AutoSize = true;
            this.lMaxSize.Location = new System.Drawing.Point(12, 257);
            this.lMaxSize.Name = "lMaxSize";
            this.lMaxSize.Size = new System.Drawing.Size(53, 13);
            this.lMaxSize.TabIndex = 2;
            this.lMaxSize.Text = "Max Size:";
            // 
            // numMaxSize
            // 
            this.numMaxSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numMaxSize.Location = new System.Drawing.Point(15, 273);
            this.numMaxSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMaxSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMaxSize.Name = "numMaxSize";
            this.numMaxSize.Size = new System.Drawing.Size(60, 20);
            this.numMaxSize.TabIndex = 3;
            this.numMaxSize.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pbFiles});
            this.statusStrip1.Location = new System.Drawing.Point(0, 422);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(783, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pbFiles
            // 
            this.pbFiles.Name = "pbFiles";
            this.pbFiles.Size = new System.Drawing.Size(200, 16);
            this.pbFiles.Visible = false;
            // 
            // bConvert
            // 
            this.bConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bConvert.Location = new System.Drawing.Point(696, 390);
            this.bConvert.Name = "bConvert";
            this.bConvert.Size = new System.Drawing.Size(75, 23);
            this.bConvert.TabIndex = 19;
            this.bConvert.Text = "Convert";
            this.bConvert.UseVisualStyleBackColor = true;
            this.bConvert.Click += new System.EventHandler(this.bConvert_Click);
            // 
            // lDestPath
            // 
            this.lDestPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lDestPath.AutoSize = true;
            this.lDestPath.Location = new System.Drawing.Point(86, 257);
            this.lDestPath.Name = "lDestPath";
            this.lDestPath.Size = new System.Drawing.Size(67, 13);
            this.lDestPath.TabIndex = 4;
            this.lDestPath.Text = "Output Path:";
            // 
            // eDestPath
            // 
            this.eDestPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.eDestPath.Location = new System.Drawing.Point(89, 273);
            this.eDestPath.Name = "eDestPath";
            this.eDestPath.ReadOnly = true;
            this.eDestPath.Size = new System.Drawing.Size(250, 20);
            this.eDestPath.TabIndex = 5;
            this.eDestPath.DoubleClick += new System.EventHandler(this.eDestPath_DoubleClick);
            // 
            // bBrowsePath
            // 
            this.bBrowsePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bBrowsePath.Location = new System.Drawing.Point(345, 273);
            this.bBrowsePath.Name = "bBrowsePath";
            this.bBrowsePath.Size = new System.Drawing.Size(30, 20);
            this.bBrowsePath.TabIndex = 6;
            this.bBrowsePath.Text = "...";
            this.bBrowsePath.UseVisualStyleBackColor = true;
            this.bBrowsePath.Click += new System.EventHandler(this.bBrowsePath_Click);
            // 
            // cbWatermark
            // 
            this.cbWatermark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbWatermark.AutoSize = true;
            this.cbWatermark.Checked = true;
            this.cbWatermark.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWatermark.Location = new System.Drawing.Point(15, 345);
            this.cbWatermark.Name = "cbWatermark";
            this.cbWatermark.Size = new System.Drawing.Size(100, 17);
            this.cbWatermark.TabIndex = 10;
            this.cbWatermark.Text = "Add Watermark";
            this.cbWatermark.UseVisualStyleBackColor = true;
            this.cbWatermark.CheckedChanged += new System.EventHandler(this.cbWatermark_CheckedChanged);
            // 
            // lWatermarkText
            // 
            this.lWatermarkText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lWatermarkText.AutoSize = true;
            this.lWatermarkText.Location = new System.Drawing.Point(12, 374);
            this.lWatermarkText.Name = "lWatermarkText";
            this.lWatermarkText.Size = new System.Drawing.Size(31, 13);
            this.lWatermarkText.TabIndex = 11;
            this.lWatermarkText.Tag = "1";
            this.lWatermarkText.Text = "Text:";
            // 
            // eWatermarkText
            // 
            this.eWatermarkText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.eWatermarkText.Location = new System.Drawing.Point(15, 390);
            this.eWatermarkText.Name = "eWatermarkText";
            this.eWatermarkText.Size = new System.Drawing.Size(240, 20);
            this.eWatermarkText.TabIndex = 12;
            this.eWatermarkText.Tag = "1";
            // 
            // lOpacity
            // 
            this.lOpacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lOpacity.AutoSize = true;
            this.lOpacity.Location = new System.Drawing.Point(272, 374);
            this.lOpacity.Name = "lOpacity";
            this.lOpacity.Size = new System.Drawing.Size(46, 13);
            this.lOpacity.TabIndex = 13;
            this.lOpacity.Tag = "1";
            this.lOpacity.Text = "Opacity:";
            // 
            // numOpacity
            // 
            this.numOpacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numOpacity.Location = new System.Drawing.Point(275, 390);
            this.numOpacity.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numOpacity.Name = "numOpacity";
            this.numOpacity.Size = new System.Drawing.Size(61, 20);
            this.numOpacity.TabIndex = 14;
            this.numOpacity.Tag = "1";
            this.numOpacity.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // lCount
            // 
            this.lCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lCount.AutoSize = true;
            this.lCount.Location = new System.Drawing.Point(425, 374);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(38, 13);
            this.lCount.TabIndex = 15;
            this.lCount.Tag = "1";
            this.lCount.Text = "Count:";
            // 
            // numCount
            // 
            this.numCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numCount.Location = new System.Drawing.Point(428, 390);
            this.numCount.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(53, 20);
            this.numCount.TabIndex = 16;
            this.numCount.Tag = "1";
            this.numCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lCustomName
            // 
            this.lCustomName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lCustomName.AutoSize = true;
            this.lCustomName.Location = new System.Drawing.Point(389, 257);
            this.lCustomName.Name = "lCustomName";
            this.lCustomName.Size = new System.Drawing.Size(76, 13);
            this.lCustomName.TabIndex = 7;
            this.lCustomName.Tag = "";
            this.lCustomName.Text = "Custom Name:";
            // 
            // eCustomName
            // 
            this.eCustomName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.eCustomName.Location = new System.Drawing.Point(392, 272);
            this.eCustomName.Name = "eCustomName";
            this.eCustomName.Size = new System.Drawing.Size(100, 20);
            this.eCustomName.TabIndex = 8;
            this.eCustomName.Tag = "";
            // 
            // numCustomNumber
            // 
            this.numCustomNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numCustomNumber.Location = new System.Drawing.Point(498, 272);
            this.numCustomNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCustomNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCustomNumber.Name = "numCustomNumber";
            this.numCustomNumber.Size = new System.Drawing.Size(49, 20);
            this.numCustomNumber.TabIndex = 9;
            this.numCustomNumber.Tag = "";
            this.numCustomNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lSize
            // 
            this.lSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lSize.AutoSize = true;
            this.lSize.Location = new System.Drawing.Point(499, 374);
            this.lSize.Name = "lSize";
            this.lSize.Size = new System.Drawing.Size(30, 13);
            this.lSize.TabIndex = 17;
            this.lSize.Tag = "1";
            this.lSize.Text = "Size:";
            // 
            // numSize
            // 
            this.numSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numSize.Location = new System.Drawing.Point(502, 390);
            this.numSize.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(46, 20);
            this.numSize.TabIndex = 18;
            this.numSize.Tag = "1";
            this.numSize.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // pbPreview
            // 
            this.pbPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPreview.Location = new System.Drawing.Point(628, 260);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(143, 124);
            this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPreview.TabIndex = 20;
            this.pbPreview.TabStop = false;
            // 
            // lHint1
            // 
            this.lHint1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lHint1.AutoSize = true;
            this.lHint1.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHint1.Location = new System.Drawing.Point(390, 298);
            this.lHint1.Name = "lHint1";
            this.lHint1.Size = new System.Drawing.Size(179, 12);
            this.lHint1.TabIndex = 21;
            this.lHint1.Text = "{C} - sequential number from starting value";
            // 
            // cbOverwrite
            // 
            this.cbOverwrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbOverwrite.AutoSize = true;
            this.cbOverwrite.Location = new System.Drawing.Point(193, 296);
            this.cbOverwrite.Name = "cbOverwrite";
            this.cbOverwrite.Size = new System.Drawing.Size(146, 17);
            this.cbOverwrite.TabIndex = 22;
            this.cbOverwrite.Text = "Overwrite destination files";
            this.cbOverwrite.UseVisualStyleBackColor = true;
            // 
            // lHint2
            // 
            this.lHint2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lHint2.AutoSize = true;
            this.lHint2.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHint2.Location = new System.Drawing.Point(390, 310);
            this.lHint2.Name = "lHint2";
            this.lHint2.Size = new System.Drawing.Size(77, 12);
            this.lHint2.TabIndex = 23;
            this.lHint2.Text = "{D} - today\'s date";
            // 
            // lHint3
            // 
            this.lHint3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lHint3.AutoSize = true;
            this.lHint3.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHint3.Location = new System.Drawing.Point(390, 322);
            this.lHint3.Name = "lHint3";
            this.lHint3.Size = new System.Drawing.Size(73, 12);
            this.lHint3.TabIndex = 24;
            this.lHint3.Text = "{T} - current time";
            // 
            // lHint4
            // 
            this.lHint4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lHint4.AutoSize = true;
            this.lHint4.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHint4.Location = new System.Drawing.Point(390, 334);
            this.lHint4.Name = "lHint4";
            this.lHint4.Size = new System.Drawing.Size(94, 12);
            this.lHint4.TabIndex = 25;
            this.lHint4.Text = "{N} - original file name";
            // 
            // lColour
            // 
            this.lColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lColour.AutoSize = true;
            this.lColour.Location = new System.Drawing.Point(353, 376);
            this.lColour.Name = "lColour";
            this.lColour.Size = new System.Drawing.Size(40, 13);
            this.lColour.TabIndex = 26;
            this.lColour.Tag = "1";
            this.lColour.Text = "Colour:";
            // 
            // pColour
            // 
            this.pColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pColour.BackColor = System.Drawing.Color.White;
            this.pColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour.Location = new System.Drawing.Point(355, 390);
            this.pColour.Name = "pColour";
            this.pColour.Size = new System.Drawing.Size(49, 20);
            this.pColour.TabIndex = 27;
            this.pColour.Tag = "1";
            this.pColour.Click += new System.EventHandler(this.pColour_Click);
            // 
            // TfMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 444);
            this.Controls.Add(this.pColour);
            this.Controls.Add(this.lColour);
            this.Controls.Add(this.pbPreview);
            this.Controls.Add(this.cbOverwrite);
            this.Controls.Add(this.lHint4);
            this.Controls.Add(this.numSize);
            this.Controls.Add(this.lHint3);
            this.Controls.Add(this.lHint1);
            this.Controls.Add(this.lHint2);
            this.Controls.Add(this.lSize);
            this.Controls.Add(this.numCount);
            this.Controls.Add(this.eCustomName);
            this.Controls.Add(this.numCustomNumber);
            this.Controls.Add(this.lCount);
            this.Controls.Add(this.lCustomName);
            this.Controls.Add(this.numOpacity);
            this.Controls.Add(this.lOpacity);
            this.Controls.Add(this.eWatermarkText);
            this.Controls.Add(this.lWatermarkText);
            this.Controls.Add(this.cbWatermark);
            this.Controls.Add(this.bConvert);
            this.Controls.Add(this.bBrowsePath);
            this.Controls.Add(this.eDestPath);
            this.Controls.Add(this.lDestPath);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lvFiles);
            this.Controls.Add(this.numMaxSize);
            this.Controls.Add(this.lMaxSize);
            this.Controls.Add(this.lFiles);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TfMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Manipulation";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
            this.cmFiles.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxSize)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOpacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCustomNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lFiles;
        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mFile;
        private System.Windows.Forms.ToolStripMenuItem mOpen;
        private System.Windows.Forms.ToolStripMenuItem mClear;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mExit;
        private System.Windows.Forms.OpenFileDialog odImages;
        private System.Windows.Forms.Label lMaxSize;
        private System.Windows.Forms.NumericUpDown numMaxSize;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar pbFiles;
        private System.Windows.Forms.Button bConvert;
        private System.Windows.Forms.Label lDestPath;
        private System.Windows.Forms.TextBox eDestPath;
        private System.Windows.Forms.Button bBrowsePath;
        private System.Windows.Forms.FolderBrowserDialog fdPath;
        private System.Windows.Forms.CheckBox cbWatermark;
        private System.Windows.Forms.Label lWatermarkText;
        private System.Windows.Forms.TextBox eWatermarkText;
        private System.Windows.Forms.Label lOpacity;
        private System.Windows.Forms.NumericUpDown numOpacity;
        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.Label lCustomName;
        private System.Windows.Forms.TextBox eCustomName;
        private System.Windows.Forms.NumericUpDown numCustomNumber;
        private System.Windows.Forms.Label lSize;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.ColumnHeader chRatio;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.ContextMenuStrip cmFiles;
        private System.Windows.Forms.ToolStripMenuItem tsmRotate;
        private System.Windows.Forms.ToolStripMenuItem tsmRotateCW;
        private System.Windows.Forms.ToolStripMenuItem tsmRotateCCW;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmRotateNone;
        private System.Windows.Forms.ColumnHeader chRotate;
        private System.Windows.Forms.ToolStripMenuItem tsmRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmMark;
        private System.Windows.Forms.ToolStripMenuItem tsmMarkChecked;
        private System.Windows.Forms.ToolStripMenuItem tsmMarkUnchecked;
        private System.Windows.Forms.Label lHint1;
        private System.Windows.Forms.CheckBox cbOverwrite;
        private System.Windows.Forms.ToolStripMenuItem tsmClear;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem tsmViewFull;
        private System.Windows.Forms.Label lHint2;
        private System.Windows.Forms.Label lHint3;
        private System.Windows.Forms.Label lHint4;
        private System.Windows.Forms.Label lColour;
        private System.Windows.Forms.Panel pColour;
        private System.Windows.Forms.ColorDialog cdWatermark;
        private System.Windows.Forms.ToolStripMenuItem mHelp;
        private System.Windows.Forms.ToolStripMenuItem mAbout;
    }
}

