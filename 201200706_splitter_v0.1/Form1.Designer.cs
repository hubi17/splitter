namespace _201200706_splitter_v0._1 {
    partial class formMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tabctrlSelection = new System.Windows.Forms.TabControl();
            this.tabpageSplit = new System.Windows.Forms.TabPage();
            this.btnCancelSplit = new System.Windows.Forms.Button();
            this.gbxSizeParts = new System.Windows.Forms.GroupBox();
            this.nudSizeParts = new System.Windows.Forms.NumericUpDown();
            this.cbxPrefix = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.gbxSelectionSplit = new System.Windows.Forms.GroupBox();
            this.lblDestSplit = new System.Windows.Forms.Label();
            this.lblSrcSplit = new System.Windows.Forms.Label();
            this.btnOutputPathSplit = new System.Windows.Forms.Button();
            this.btnInputFileSplit = new System.Windows.Forms.Button();
            this.tbxOutputPathSplit = new System.Windows.Forms.TextBox();
            this.tbxInputFileSplit = new System.Windows.Forms.TextBox();
            this.gbxSplitType = new System.Windows.Forms.GroupBox();
            this.rbtnParts = new System.Windows.Forms.RadioButton();
            this.rbtnSize = new System.Windows.Forms.RadioButton();
            this.btnSplit = new System.Windows.Forms.Button();
            this.tabpageJoin = new System.Windows.Forms.TabPage();
            this.btnCancelJoin = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.gbxSelectionJoin = new System.Windows.Forms.GroupBox();
            this.lblDestJoin = new System.Windows.Forms.Label();
            this.lblSrcJoin = new System.Windows.Forms.Label();
            this.btnOutputPathJoin = new System.Windows.Forms.Button();
            this.btnInputFileJoin = new System.Windows.Forms.Button();
            this.tbxOutputPathJoin = new System.Windows.Forms.TextBox();
            this.tbxInputFileJoin = new System.Windows.Forms.TextBox();
            this.dirBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabctrlSelection.SuspendLayout();
            this.tabpageSplit.SuspendLayout();
            this.gbxSizeParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeParts)).BeginInit();
            this.gbxSelectionSplit.SuspendLayout();
            this.gbxSplitType.SuspendLayout();
            this.tabpageJoin.SuspendLayout();
            this.gbxSelectionJoin.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabctrlSelection
            // 
            this.tabctrlSelection.Controls.Add(this.tabpageSplit);
            this.tabctrlSelection.Controls.Add(this.tabpageJoin);
            this.tabctrlSelection.Location = new System.Drawing.Point(12, 27);
            this.tabctrlSelection.Name = "tabctrlSelection";
            this.tabctrlSelection.SelectedIndex = 0;
            this.tabctrlSelection.Size = new System.Drawing.Size(678, 317);
            this.tabctrlSelection.TabIndex = 0;
            // 
            // tabpageSplit
            // 
            this.tabpageSplit.Controls.Add(this.btnCancelSplit);
            this.tabpageSplit.Controls.Add(this.gbxSizeParts);
            this.tabpageSplit.Controls.Add(this.gbxSelectionSplit);
            this.tabpageSplit.Controls.Add(this.gbxSplitType);
            this.tabpageSplit.Controls.Add(this.btnSplit);
            this.tabpageSplit.Location = new System.Drawing.Point(4, 22);
            this.tabpageSplit.Name = "tabpageSplit";
            this.tabpageSplit.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageSplit.Size = new System.Drawing.Size(670, 291);
            this.tabpageSplit.TabIndex = 0;
            this.tabpageSplit.Text = "Split";
            this.tabpageSplit.UseVisualStyleBackColor = true;
            // 
            // btnCancelSplit
            // 
            this.btnCancelSplit.Location = new System.Drawing.Point(583, 247);
            this.btnCancelSplit.Name = "btnCancelSplit";
            this.btnCancelSplit.Size = new System.Drawing.Size(75, 23);
            this.btnCancelSplit.TabIndex = 10;
            this.btnCancelSplit.Text = "Cancel";
            this.btnCancelSplit.UseVisualStyleBackColor = true;
            this.btnCancelSplit.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbxSizeParts
            // 
            this.gbxSizeParts.Controls.Add(this.nudSizeParts);
            this.gbxSizeParts.Controls.Add(this.cbxPrefix);
            this.gbxSizeParts.Controls.Add(this.lblType);
            this.gbxSizeParts.Location = new System.Drawing.Point(6, 171);
            this.gbxSizeParts.Name = "gbxSizeParts";
            this.gbxSizeParts.Size = new System.Drawing.Size(658, 48);
            this.gbxSizeParts.TabIndex = 10;
            this.gbxSizeParts.TabStop = false;
            this.gbxSizeParts.Text = "Size";
            this.gbxSizeParts.Visible = false;
            // 
            // nudSizeParts
            // 
            this.nudSizeParts.Location = new System.Drawing.Point(135, 17);
            this.nudSizeParts.Maximum = new decimal(new int[] {
            1073741824,
            0,
            0,
            0});
            this.nudSizeParts.Name = "nudSizeParts";
            this.nudSizeParts.Size = new System.Drawing.Size(138, 20);
            this.nudSizeParts.TabIndex = 7;
            this.nudSizeParts.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // cbxPrefix
            // 
            this.cbxPrefix.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxPrefix.FormattingEnabled = true;
            this.cbxPrefix.Items.AddRange(new object[] {
            "Bytes",
            "KBytes",
            "MBytes"});
            this.cbxPrefix.Location = new System.Drawing.Point(279, 17);
            this.cbxPrefix.Name = "cbxPrefix";
            this.cbxPrefix.Size = new System.Drawing.Size(138, 21);
            this.cbxPrefix.TabIndex = 8;
            this.cbxPrefix.Text = "Bytes";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(6, 20);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(67, 13);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Split file size:";
            // 
            // gbxSelectionSplit
            // 
            this.gbxSelectionSplit.Controls.Add(this.lblDestSplit);
            this.gbxSelectionSplit.Controls.Add(this.lblSrcSplit);
            this.gbxSelectionSplit.Controls.Add(this.btnOutputPathSplit);
            this.gbxSelectionSplit.Controls.Add(this.btnInputFileSplit);
            this.gbxSelectionSplit.Controls.Add(this.tbxOutputPathSplit);
            this.gbxSelectionSplit.Controls.Add(this.tbxInputFileSplit);
            this.gbxSelectionSplit.Location = new System.Drawing.Point(6, 6);
            this.gbxSelectionSplit.Name = "gbxSelectionSplit";
            this.gbxSelectionSplit.Size = new System.Drawing.Size(658, 82);
            this.gbxSelectionSplit.TabIndex = 9;
            this.gbxSelectionSplit.TabStop = false;
            this.gbxSelectionSplit.Text = "File selection";
            // 
            // lblDestSplit
            // 
            this.lblDestSplit.AutoSize = true;
            this.lblDestSplit.Location = new System.Drawing.Point(6, 51);
            this.lblDestSplit.Name = "lblDestSplit";
            this.lblDestSplit.Size = new System.Drawing.Size(67, 13);
            this.lblDestSplit.TabIndex = 11;
            this.lblDestSplit.Text = "Output Path:";
            // 
            // lblSrcSplit
            // 
            this.lblSrcSplit.AutoSize = true;
            this.lblSrcSplit.Location = new System.Drawing.Point(6, 21);
            this.lblSrcSplit.Name = "lblSrcSplit";
            this.lblSrcSplit.Size = new System.Drawing.Size(63, 13);
            this.lblSrcSplit.TabIndex = 100;
            this.lblSrcSplit.Text = "Source File:";
            // 
            // btnOutputPathSplit
            // 
            this.btnOutputPathSplit.Location = new System.Drawing.Point(577, 46);
            this.btnOutputPathSplit.Name = "btnOutputPathSplit";
            this.btnOutputPathSplit.Size = new System.Drawing.Size(75, 23);
            this.btnOutputPathSplit.TabIndex = 4;
            this.btnOutputPathSplit.Text = "Destination";
            this.btnOutputPathSplit.UseVisualStyleBackColor = true;
            this.btnOutputPathSplit.Click += new System.EventHandler(this.btnOutputPath_Click);
            // 
            // btnInputFileSplit
            // 
            this.btnInputFileSplit.Location = new System.Drawing.Point(577, 16);
            this.btnInputFileSplit.Name = "btnInputFileSplit";
            this.btnInputFileSplit.Size = new System.Drawing.Size(75, 23);
            this.btnInputFileSplit.TabIndex = 2;
            this.btnInputFileSplit.Text = "Select File";
            this.btnInputFileSplit.UseVisualStyleBackColor = true;
            this.btnInputFileSplit.Click += new System.EventHandler(this.btnInputFile_Click);
            // 
            // tbxOutputPathSplit
            // 
            this.tbxOutputPathSplit.Location = new System.Drawing.Point(135, 48);
            this.tbxOutputPathSplit.Name = "tbxOutputPathSplit";
            this.tbxOutputPathSplit.Size = new System.Drawing.Size(436, 20);
            this.tbxOutputPathSplit.TabIndex = 3;
            this.tbxOutputPathSplit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxOutputPathSplit_KeyDown);
            // 
            // tbxInputFileSplit
            // 
            this.tbxInputFileSplit.Location = new System.Drawing.Point(135, 18);
            this.tbxInputFileSplit.Name = "tbxInputFileSplit";
            this.tbxInputFileSplit.Size = new System.Drawing.Size(436, 20);
            this.tbxInputFileSplit.TabIndex = 1;
            this.tbxInputFileSplit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxInputFileSplit_KeyDown);
            // 
            // gbxSplitType
            // 
            this.gbxSplitType.Controls.Add(this.rbtnParts);
            this.gbxSplitType.Controls.Add(this.rbtnSize);
            this.gbxSplitType.Location = new System.Drawing.Point(6, 94);
            this.gbxSplitType.Name = "gbxSplitType";
            this.gbxSplitType.Size = new System.Drawing.Size(658, 71);
            this.gbxSplitType.TabIndex = 8;
            this.gbxSplitType.TabStop = false;
            this.gbxSplitType.Text = "Split type";
            this.gbxSplitType.Visible = false;
            // 
            // rbtnParts
            // 
            this.rbtnParts.AutoSize = true;
            this.rbtnParts.Location = new System.Drawing.Point(6, 42);
            this.rbtnParts.Name = "rbtnParts";
            this.rbtnParts.Size = new System.Drawing.Size(100, 17);
            this.rbtnParts.TabIndex = 6;
            this.rbtnParts.Text = "Number of parts";
            this.rbtnParts.UseVisualStyleBackColor = true;
            this.rbtnParts.CheckedChanged += new System.EventHandler(this.rbtnParts_CheckedChanged);
            // 
            // rbtnSize
            // 
            this.rbtnSize.AutoSize = true;
            this.rbtnSize.Checked = true;
            this.rbtnSize.Location = new System.Drawing.Point(6, 19);
            this.rbtnSize.Name = "rbtnSize";
            this.rbtnSize.Size = new System.Drawing.Size(65, 17);
            this.rbtnSize.TabIndex = 5;
            this.rbtnSize.TabStop = true;
            this.rbtnSize.Text = "Part size";
            this.rbtnSize.UseVisualStyleBackColor = true;
            this.rbtnSize.CheckedChanged += new System.EventHandler(this.rbtnSize_CheckedChanged);
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(502, 247);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(75, 23);
            this.btnSplit.TabIndex = 9;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // tabpageJoin
            // 
            this.tabpageJoin.Controls.Add(this.btnCancelJoin);
            this.tabpageJoin.Controls.Add(this.btnJoin);
            this.tabpageJoin.Controls.Add(this.gbxSelectionJoin);
            this.tabpageJoin.Location = new System.Drawing.Point(4, 22);
            this.tabpageJoin.Name = "tabpageJoin";
            this.tabpageJoin.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageJoin.Size = new System.Drawing.Size(670, 291);
            this.tabpageJoin.TabIndex = 1;
            this.tabpageJoin.Text = "Join";
            this.tabpageJoin.UseVisualStyleBackColor = true;
            // 
            // btnCancelJoin
            // 
            this.btnCancelJoin.Location = new System.Drawing.Point(583, 247);
            this.btnCancelJoin.Name = "btnCancelJoin";
            this.btnCancelJoin.Size = new System.Drawing.Size(75, 23);
            this.btnCancelJoin.TabIndex = 12;
            this.btnCancelJoin.Text = "Cancel";
            this.btnCancelJoin.UseVisualStyleBackColor = true;
            this.btnCancelJoin.Click += new System.EventHandler(this.btnCancelJoin_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(502, 247);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(75, 23);
            this.btnJoin.TabIndex = 11;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // gbxSelectionJoin
            // 
            this.gbxSelectionJoin.Controls.Add(this.lblDestJoin);
            this.gbxSelectionJoin.Controls.Add(this.lblSrcJoin);
            this.gbxSelectionJoin.Controls.Add(this.btnOutputPathJoin);
            this.gbxSelectionJoin.Controls.Add(this.btnInputFileJoin);
            this.gbxSelectionJoin.Controls.Add(this.tbxOutputPathJoin);
            this.gbxSelectionJoin.Controls.Add(this.tbxInputFileJoin);
            this.gbxSelectionJoin.Location = new System.Drawing.Point(6, 6);
            this.gbxSelectionJoin.Name = "gbxSelectionJoin";
            this.gbxSelectionJoin.Size = new System.Drawing.Size(658, 82);
            this.gbxSelectionJoin.TabIndex = 10;
            this.gbxSelectionJoin.TabStop = false;
            this.gbxSelectionJoin.Text = "File selection";
            // 
            // lblDestJoin
            // 
            this.lblDestJoin.AutoSize = true;
            this.lblDestJoin.Location = new System.Drawing.Point(6, 51);
            this.lblDestJoin.Name = "lblDestJoin";
            this.lblDestJoin.Size = new System.Drawing.Size(67, 13);
            this.lblDestJoin.TabIndex = 11;
            this.lblDestJoin.Text = "Output Path:";
            // 
            // lblSrcJoin
            // 
            this.lblSrcJoin.AutoSize = true;
            this.lblSrcJoin.Location = new System.Drawing.Point(6, 21);
            this.lblSrcJoin.Name = "lblSrcJoin";
            this.lblSrcJoin.Size = new System.Drawing.Size(63, 13);
            this.lblSrcJoin.TabIndex = 100;
            this.lblSrcJoin.Text = "Source File:";
            // 
            // btnOutputPathJoin
            // 
            this.btnOutputPathJoin.Location = new System.Drawing.Point(577, 46);
            this.btnOutputPathJoin.Name = "btnOutputPathJoin";
            this.btnOutputPathJoin.Size = new System.Drawing.Size(75, 23);
            this.btnOutputPathJoin.TabIndex = 4;
            this.btnOutputPathJoin.Text = "Destination";
            this.btnOutputPathJoin.UseVisualStyleBackColor = true;
            this.btnOutputPathJoin.Click += new System.EventHandler(this.btnOutputPathJoin_Click);
            // 
            // btnInputFileJoin
            // 
            this.btnInputFileJoin.Location = new System.Drawing.Point(577, 16);
            this.btnInputFileJoin.Name = "btnInputFileJoin";
            this.btnInputFileJoin.Size = new System.Drawing.Size(75, 23);
            this.btnInputFileJoin.TabIndex = 2;
            this.btnInputFileJoin.Text = "Select File";
            this.btnInputFileJoin.UseVisualStyleBackColor = true;
            this.btnInputFileJoin.Click += new System.EventHandler(this.btnInputFileJoin_Click);
            // 
            // tbxOutputPathJoin
            // 
            this.tbxOutputPathJoin.Location = new System.Drawing.Point(135, 48);
            this.tbxOutputPathJoin.Name = "tbxOutputPathJoin";
            this.tbxOutputPathJoin.Size = new System.Drawing.Size(436, 20);
            this.tbxOutputPathJoin.TabIndex = 3;
            // 
            // tbxInputFileJoin
            // 
            this.tbxInputFileJoin.Location = new System.Drawing.Point(135, 18);
            this.tbxInputFileJoin.Name = "tbxInputFileJoin";
            this.tbxInputFileJoin.Size = new System.Drawing.Size(436, 20);
            this.tbxInputFileJoin.TabIndex = 1;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.SystemColors.Highlight;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(702, 24);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.splitToolStripMenuItem,
            this.joinToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // splitToolStripMenuItem
            // 
            this.splitToolStripMenuItem.Name = "splitToolStripMenuItem";
            this.splitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.splitToolStripMenuItem.Text = "&Split";
            this.splitToolStripMenuItem.Click += new System.EventHandler(this.splitToolStripMenuItem_Click);
            // 
            // joinToolStripMenuItem
            // 
            this.joinToolStripMenuItem.Name = "joinToolStripMenuItem";
            this.joinToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.joinToolStripMenuItem.Text = "&Join";
            this.joinToolStripMenuItem.Click += new System.EventHandler(this.joinToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 355);
            this.Controls.Add(this.tabctrlSelection);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "formMain";
            this.Text = "File Splitter";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.tabctrlSelection.ResumeLayout(false);
            this.tabpageSplit.ResumeLayout(false);
            this.gbxSizeParts.ResumeLayout(false);
            this.gbxSizeParts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeParts)).EndInit();
            this.gbxSelectionSplit.ResumeLayout(false);
            this.gbxSelectionSplit.PerformLayout();
            this.gbxSplitType.ResumeLayout(false);
            this.gbxSplitType.PerformLayout();
            this.tabpageJoin.ResumeLayout(false);
            this.gbxSelectionJoin.ResumeLayout(false);
            this.gbxSelectionJoin.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabctrlSelection;
        private System.Windows.Forms.TabPage tabpageSplit;
        private System.Windows.Forms.TabPage tabpageJoin;
        private System.Windows.Forms.FolderBrowserDialog dirBrowser;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.GroupBox gbxSplitType;
        private System.Windows.Forms.RadioButton rbtnParts;
        private System.Windows.Forms.RadioButton rbtnSize;
        private System.Windows.Forms.GroupBox gbxSelectionSplit;
        private System.Windows.Forms.Label lblDestSplit;
        private System.Windows.Forms.Label lblSrcSplit;
        private System.Windows.Forms.Button btnOutputPathSplit;
        private System.Windows.Forms.Button btnInputFileSplit;
        private System.Windows.Forms.TextBox tbxOutputPathSplit;
        private System.Windows.Forms.TextBox tbxInputFileSplit;
        private System.Windows.Forms.GroupBox gbxSizeParts;
        private System.Windows.Forms.Button btnCancelSplit;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbxPrefix;
        private System.Windows.Forms.NumericUpDown nudSizeParts;
        private System.Windows.Forms.GroupBox gbxSelectionJoin;
        private System.Windows.Forms.Label lblDestJoin;
        private System.Windows.Forms.Label lblSrcJoin;
        private System.Windows.Forms.Button btnOutputPathJoin;
        private System.Windows.Forms.Button btnInputFileJoin;
        private System.Windows.Forms.TextBox tbxOutputPathJoin;
        private System.Windows.Forms.TextBox tbxInputFileJoin;
        private System.Windows.Forms.ToolStripMenuItem splitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joinToolStripMenuItem;
        private System.Windows.Forms.Button btnCancelJoin;
        private System.Windows.Forms.Button btnJoin;
    }
}

