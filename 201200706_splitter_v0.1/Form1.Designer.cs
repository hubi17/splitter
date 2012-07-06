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
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxSizeParts = new System.Windows.Forms.GroupBox();
            this.lblType = new System.Windows.Forms.Label();
            this.gbxSelection = new System.Windows.Forms.GroupBox();
            this.lblDest = new System.Windows.Forms.Label();
            this.lblSrc = new System.Windows.Forms.Label();
            this.btnOutputPath = new System.Windows.Forms.Button();
            this.btnInputFile = new System.Windows.Forms.Button();
            this.tbxOutputPathSplit = new System.Windows.Forms.TextBox();
            this.tbxInputFileSplit = new System.Windows.Forms.TextBox();
            this.gbxSplitType = new System.Windows.Forms.GroupBox();
            this.rbtnParts = new System.Windows.Forms.RadioButton();
            this.rbtnSize = new System.Windows.Forms.RadioButton();
            this.btnSplit = new System.Windows.Forms.Button();
            this.tabpageJoin = new System.Windows.Forms.TabPage();
            this.dirBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.progressBarStatus = new System.Windows.Forms.ProgressBar();
            this.bgWorkerStatus = new System.ComponentModel.BackgroundWorker();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabctrlSelection.SuspendLayout();
            this.tabpageSplit.SuspendLayout();
            this.gbxSizeParts.SuspendLayout();
            this.gbxSelection.SuspendLayout();
            this.gbxSplitType.SuspendLayout();
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
            this.tabpageSplit.Controls.Add(this.btnCancel);
            this.tabpageSplit.Controls.Add(this.gbxSizeParts);
            this.tabpageSplit.Controls.Add(this.gbxSelection);
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
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(157, 247);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbxSizeParts
            // 
            this.gbxSizeParts.Controls.Add(this.lblType);
            this.gbxSizeParts.Location = new System.Drawing.Point(6, 171);
            this.gbxSizeParts.Name = "gbxSizeParts";
            this.gbxSizeParts.Size = new System.Drawing.Size(658, 48);
            this.gbxSizeParts.TabIndex = 10;
            this.gbxSizeParts.TabStop = false;
            this.gbxSizeParts.Visible = false;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(6, 16);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(35, 13);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "label1";
            // 
            // gbxSelection
            // 
            this.gbxSelection.Controls.Add(this.lblDest);
            this.gbxSelection.Controls.Add(this.lblSrc);
            this.gbxSelection.Controls.Add(this.btnOutputPath);
            this.gbxSelection.Controls.Add(this.btnInputFile);
            this.gbxSelection.Controls.Add(this.tbxOutputPathSplit);
            this.gbxSelection.Controls.Add(this.tbxInputFileSplit);
            this.gbxSelection.Location = new System.Drawing.Point(6, 6);
            this.gbxSelection.Name = "gbxSelection";
            this.gbxSelection.Size = new System.Drawing.Size(658, 82);
            this.gbxSelection.TabIndex = 9;
            this.gbxSelection.TabStop = false;
            this.gbxSelection.Text = "File selection";
            // 
            // lblDest
            // 
            this.lblDest.AutoSize = true;
            this.lblDest.Location = new System.Drawing.Point(6, 51);
            this.lblDest.Name = "lblDest";
            this.lblDest.Size = new System.Drawing.Size(67, 13);
            this.lblDest.TabIndex = 11;
            this.lblDest.Text = "Output Path:";
            // 
            // lblSrc
            // 
            this.lblSrc.AutoSize = true;
            this.lblSrc.Location = new System.Drawing.Point(6, 21);
            this.lblSrc.Name = "lblSrc";
            this.lblSrc.Size = new System.Drawing.Size(63, 13);
            this.lblSrc.TabIndex = 10;
            this.lblSrc.Text = "Source File:";
            // 
            // btnOutputPath
            // 
            this.btnOutputPath.Location = new System.Drawing.Point(577, 46);
            this.btnOutputPath.Name = "btnOutputPath";
            this.btnOutputPath.Size = new System.Drawing.Size(75, 23);
            this.btnOutputPath.TabIndex = 9;
            this.btnOutputPath.Text = "Destination";
            this.btnOutputPath.UseVisualStyleBackColor = true;
            this.btnOutputPath.Click += new System.EventHandler(this.btnOutputPath_Click);
            // 
            // btnInputFile
            // 
            this.btnInputFile.Location = new System.Drawing.Point(577, 16);
            this.btnInputFile.Name = "btnInputFile";
            this.btnInputFile.Size = new System.Drawing.Size(75, 23);
            this.btnInputFile.TabIndex = 8;
            this.btnInputFile.Text = "Select File";
            this.btnInputFile.UseVisualStyleBackColor = true;
            this.btnInputFile.Click += new System.EventHandler(this.btnInputFile_Click);
            // 
            // tbxOutputPathSplit
            // 
            this.tbxOutputPathSplit.Location = new System.Drawing.Point(135, 48);
            this.tbxOutputPathSplit.Name = "tbxOutputPathSplit";
            this.tbxOutputPathSplit.Size = new System.Drawing.Size(436, 20);
            this.tbxOutputPathSplit.TabIndex = 7;
            // 
            // tbxInputFileSplit
            // 
            this.tbxInputFileSplit.Location = new System.Drawing.Point(135, 18);
            this.tbxInputFileSplit.Name = "tbxInputFileSplit";
            this.tbxInputFileSplit.Size = new System.Drawing.Size(436, 20);
            this.tbxInputFileSplit.TabIndex = 6;
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
            this.rbtnParts.TabIndex = 4;
            this.rbtnParts.TabStop = true;
            this.rbtnParts.Text = "Number of parts";
            this.rbtnParts.UseVisualStyleBackColor = true;
            this.rbtnParts.CheckedChanged += new System.EventHandler(this.rbtnParts_CheckedChanged);
            // 
            // rbtnSize
            // 
            this.rbtnSize.AutoSize = true;
            this.rbtnSize.Location = new System.Drawing.Point(6, 19);
            this.rbtnSize.Name = "rbtnSize";
            this.rbtnSize.Size = new System.Drawing.Size(65, 17);
            this.rbtnSize.TabIndex = 3;
            this.rbtnSize.TabStop = true;
            this.rbtnSize.Text = "Part size";
            this.rbtnSize.UseVisualStyleBackColor = true;
            this.rbtnSize.CheckedChanged += new System.EventHandler(this.rbtnSize_CheckedChanged);
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(51, 247);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(75, 23);
            this.btnSplit.TabIndex = 6;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // tabpageJoin
            // 
            this.tabpageJoin.Location = new System.Drawing.Point(4, 22);
            this.tabpageJoin.Name = "tabpageJoin";
            this.tabpageJoin.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageJoin.Size = new System.Drawing.Size(481, 291);
            this.tabpageJoin.TabIndex = 1;
            this.tabpageJoin.Text = "Join";
            this.tabpageJoin.UseVisualStyleBackColor = true;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // progressBarStatus
            // 
            this.progressBarStatus.Location = new System.Drawing.Point(12, 350);
            this.progressBarStatus.Name = "progressBarStatus";
            this.progressBarStatus.Size = new System.Drawing.Size(678, 23);
            this.progressBarStatus.TabIndex = 1;
            this.progressBarStatus.Visible = false;
            // 
            // bgWorkerStatus
            // 
            this.bgWorkerStatus.WorkerReportsProgress = true;
            this.bgWorkerStatus.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerStatus_DoWork);
            this.bgWorkerStatus.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorkerStatus_ProgressChanged);
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
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
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
            this.ClientSize = new System.Drawing.Size(702, 387);
            this.Controls.Add(this.progressBarStatus);
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
            this.gbxSelection.ResumeLayout(false);
            this.gbxSelection.PerformLayout();
            this.gbxSplitType.ResumeLayout(false);
            this.gbxSplitType.PerformLayout();
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
        private System.Windows.Forms.ProgressBar progressBarStatus;
        private System.ComponentModel.BackgroundWorker bgWorkerStatus;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.GroupBox gbxSplitType;
        private System.Windows.Forms.RadioButton rbtnParts;
        private System.Windows.Forms.RadioButton rbtnSize;
        private System.Windows.Forms.GroupBox gbxSelection;
        private System.Windows.Forms.Label lblDest;
        private System.Windows.Forms.Label lblSrc;
        private System.Windows.Forms.Button btnOutputPath;
        private System.Windows.Forms.Button btnInputFile;
        private System.Windows.Forms.TextBox tbxOutputPathSplit;
        private System.Windows.Forms.TextBox tbxInputFileSplit;
        private System.Windows.Forms.GroupBox gbxSizeParts;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblType;
    }
}

