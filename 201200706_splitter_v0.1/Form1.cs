﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace _201200706_splitter_v0._1 {
    public partial class formMain : Form {

        bool gSrcSelected = false;
        bool gDestSelected = false;

        public formMain() {
            InitializeComponent();
        }

        private void formMain_Load(object sender, EventArgs e) {

        }

        private void btnInputFile_Click(object sender, EventArgs e) {

            DialogResult vResult = openFile.ShowDialog();

            gSrcSelected = false;

            if (vResult == DialogResult.OK) {

                tbxInputFileSplit.Text = openFile.FileName;
                gSrcSelected = true;
            } else {

                if (tbxInputFileSplit.Text == "") {

                    gSrcSelected = false;
                }
            }

            if (gSrcSelected && gDestSelected) {

                gbxSplitType.Visible = true;
            } else {

                gbxSplitType.Visible = false;
            }
        }

        private void btnOutputPath_Click(object sender, EventArgs e) {

            DialogResult vResult = dirBrowser.ShowDialog();

            gDestSelected = false;

            if (vResult == DialogResult.OK) {

                tbxOutputPathSplit.Text = dirBrowser.SelectedPath;
                gDestSelected = true;
            } else {

                if (tbxOutputPathSplit.Text == "") {

                    gDestSelected = false;
                }
            }

            if (gSrcSelected && gDestSelected) {

                gbxSplitType.Visible = true;
                gbxSizeParts.Visible = true;
            } else {

                gbxSplitType.Visible = false;
                gbxSizeParts.Visible = false;
            }
        }

        private void bgWorkerStatus_DoWork(object sender, DoWorkEventArgs e) {

            for (int i = 1; i <= 100; i++) {
                
                if (bgWorkerStatus.CancellationPending) {

                    e.Cancel = true;
                } else {

                    // do work
                    Thread.Sleep(100);
                    // report status
                    bgWorkerStatus.ReportProgress(i);
                }
            }
        }

        private void btnSplit_Click(object sender, EventArgs e) {

            /*
            if (!bgWorkerStatus.IsBusy) {

                // start the background worker
                bgWorkerStatus.RunWorkerAsync();

                // make progress bar visible
                progressBarStatus.Visible = true;
            }
            */

            splitFile();
        }

        private void bgWorkerStatus_ProgressChanged(object sender, ProgressChangedEventArgs e) {

            // change the value of the progress bar to background worker progress
            progressBarStatus.Value = e.ProgressPercentage;
        }

        private void rbtnParts_CheckedChanged(object sender, EventArgs e) {

            gbxSizeParts.Text = "Parts";
            gbxSizeParts.Visible = true;
            lblType.Text = "Number of parts:";
            cbxPrefix.Visible = false;

            // set default value for number of parts selector
            nudSizeParts.Value = 10;
        }

        private void rbtnSize_CheckedChanged(object sender, EventArgs e) {

            gbxSizeParts.Text = "Size";
            gbxSizeParts.Visible = true;
            lblType.Text = "Split file size:";
            cbxPrefix.Visible = true;

            // set default value for file size selector
            nudSizeParts.Value = 1024;
            cbxPrefix.Text = "Byte";
        }

        private void btnCancel_Click(object sender, EventArgs e) {

            gbxSplitType.Visible = false;
            gbxSizeParts.Visible = false;
            gDestSelected = false;
            gSrcSelected = false;
            tbxInputFileSplit.Clear();
            tbxOutputPathSplit.Clear();

            bgWorkerStatus.CancelAsync();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {

            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {

            MessageBox.Show("File splitter & joiner\nby Daniel Auhuber\n2012", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bgWorkerStatus_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {

            if (e.Cancelled) {

                progressBarStatus.Value = 0;
                progressBarStatus.Visible = false;
                MessageBox.Show("Canceled");
            } else {

                progressBarStatus.Value = 0;
                progressBarStatus.Visible = false;
                MessageBox.Show("Done");
            }
        }

        private void tbxInputFileSplit_KeyDown(object sender, KeyEventArgs e) {

            if (e.KeyCode == Keys.Return) {

                if (tbxInputFileSplit.Text != "") {

                    gSrcSelected = true;
                    tbxOutputPathSplit.Focus();
                }

                if (gSrcSelected && gDestSelected) {

                    gbxSplitType.Visible = true;
                } else {

                    gbxSplitType.Visible = false;
                }
            }
        }

        private void tbxOutputPathSplit_KeyDown(object sender, KeyEventArgs e) {

            if (e.KeyCode == Keys.Return) {

                if (tbxOutputPathSplit.Text != "") {

                    gDestSelected = true;
                }

                if (gSrcSelected && gDestSelected) {

                    gbxSplitType.Visible = true;
                } else {

                    gbxSplitType.Visible = false;
                }
            }
        }

        private void splitFile() {

            FileStream vFS;
            BinaryWriter vBW;
            BinaryReader vBR;
            FileInfo vFI;
            DirectoryInfo vDI;

            string vSrc;
            string vDest;
            string vOutputFile;
            string vFileName;

            int vHeaderLength;
            string vHeader;
            string vType = "div";
            int vFileLength;
            int vDivCount;
            int vDivOffset;
            string vDivFirstName;

            // use 8 byte long split file sizes
            long vSplitSize;
            byte[] vSplits;
            long vSplitCount = 0;
            int vSplitsIterator = 0;

            if (tbxOutputPathSplit.Text != "") {

                vDest = tbxOutputPathSplit.Text;
                vDI = new DirectoryInfo(vDest);

                if (tbxInputFileSplit.Text != "") {

                    vSrc = tbxInputFileSplit.Text;

                    if (vDI.Exists) {

                        if (File.Exists(vSrc)) {

                            vFI = new FileInfo(vSrc);

                            vFileName = vFI.Name;
                            vFS = new FileStream(vSrc, FileMode.Open, FileAccess.Read);

                            if (rbtnParts.Checked) {
                                // Split count given

                                vSplitCount = (long) nudSizeParts.Value;
                                vFileLength = (int) vFI.Length;
                                vSplitSize = vFileLength / vSplitCount;

                                // if not evenly divisible increase vSplitSize
                                if (vFileLength % vSplitCount != 0) {

                                    vSplitSize++;
                                }

                                vDivCount = (int) vSplitCount;
                            } else {
                                // Else size option must be selected

                                switch (cbxPrefix.Text) {

                                    case "Bytes":
                                        vSplitSize = (long) nudSizeParts.Value;
                                        break;
                                    case "KBytes":
                                        vSplitSize = (long) nudSizeParts.Value * 1024;
                                        break;
                                    case "MBytes":
                                        vSplitSize = (long) nudSizeParts.Value * 1024 * 1024;
                                        break;
                                    default:
                                        vSplitSize = 0;
                                        // error, invalid size
                                        break;
                                }

                                vFileLength = (int) vFI.Length;
                                vSplitCount = vFileLength / vSplitSize;

                                // if not divisible need extra file
                                if (vFileLength % vSplitSize != 0) {

                                    vSplitCount++;
                                }

                                vDivCount = (int) vSplitCount;
                            }

                            vSplits = new byte[vFileLength];

                            // read selected input file into byte array for splitting
                            vBR = new BinaryReader(vFS);
                            vSplits = vBR.ReadBytes(Convert.ToInt32(vFileLength));
                            vBR.Close();

                            // set name of first div
                            vDivFirstName = vFileName + 1.ToString("D4");

                            for (int i = 1; i <= vSplitCount; i++) {

                                vDivOffset = i;
                                vOutputFile = vDest + "\\" + vFileName + i.ToString("D4");

                                // construct header for div files
                                vHeader = vType
                                        + vFileLength
                                        + vDivCount
                                        + vDivOffset
                                        //+ vDivFirstLength
                                        + vDivFirstName
                                        //+ vNameLength
                                        + vFileName;
                                vHeaderLength = vHeader.Length;

                                vFS = new FileStream(vOutputFile, FileMode.OpenOrCreate, FileAccess.Write);
                                vBW = new BinaryWriter(vFS);

                                vBW.Write(vHeaderLength);
                                vBW.Write(vType);
                                vBW.Write(vFileLength);
                                vBW.Write(vDivCount);
                                vBW.Write(vDivOffset);
                                vBW.Write(vDivFirstName);
                                vBW.Write(vFileName);

                                for (int j = 0; j < vSplitSize; j++) {

                                    if (vSplitsIterator < vSplits.Length) {

                                        vBW.Write(vSplits[vSplitsIterator]);
                                        vSplitsIterator++;
                                    } else {

                                        vBW.Close();
                                        break;
                                    }
                                }

                                vBW.Close();
                            }
                        } else {

                            MessageBox.Show("Incorrect input file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbxInputFileSplit.Focus();
                        }
                    } else {

                        MessageBox.Show("Incorrect output path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbxOutputPathSplit.Focus();
                    }
                } else {

                    MessageBox.Show("No input file selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxInputFileSplit.Focus();
                }
            } else {

                MessageBox.Show("Output path cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxOutputPathSplit.Focus();
            }

            MessageBox.Show("Done");
        }

        private void splitToolStripMenuItem_Click(object sender, EventArgs e) {

            tabctrlSelection.SelectedTab = tabpageSplit;
        }

        private void joinToolStripMenuItem_Click(object sender, EventArgs e) {

            tabctrlSelection.SelectedTab = tabpageJoin;
        }

        private void btnInputFileJoin_Click(object sender, EventArgs e) {

            DialogResult vResult = openFile.ShowDialog();

            gSrcSelected = false;

            if (vResult == DialogResult.OK) {

                tbxInputFileJoin.Text = openFile.FileName;
                gSrcSelected = true;
            } else {

                if (tbxInputFileJoin.Text == "") {

                    gSrcSelected = false;
                }
            }
        }

        private void btnOutputPathJoin_Click(object sender, EventArgs e) {

            DialogResult vResult = dirBrowser.ShowDialog();

            gDestSelected = false;

            if (vResult == DialogResult.OK) {

                tbxOutputPathJoin.Text = dirBrowser.SelectedPath;
                gDestSelected = true;
            } else {

                if (tbxOutputPathJoin.Text == "") {

                    gDestSelected = false;
                }
            }
        }

        private void btnJoin_Click(object sender, EventArgs e) {

            joinFiles();
        }

        private void joinFiles() {

            FileStream vFS;
            BinaryWriter vBW;
            BinaryReader vBR;
            FileInfo vFI;

            string vSrc;
            string vDest;
            string vCurrentDir;
            string vCurrentFile;

            int vHeaderLength;
            string vType;
            long vFileLength;
            long vDivCount;
            int vDivOffset;
            string vDivFirstName;
            string vName;

            // vSplitSize is the net length of individual split files data
            int vSplitSize;
            byte[] vCombine;
            // vSplitLength is the total length of split file
            int vSplitLength;
            byte[] vBuffer;
            int vCombineIterator = 0;

            if (tbxInputFileJoin.Text != "") {
                
                vSrc = tbxInputFileJoin.Text;

                if (tbxOutputPathJoin.Text != "") {

                    vDest = tbxOutputPathJoin.Text;

                    if (File.Exists(vSrc)) {
                        
                        vFI = new FileInfo(vSrc);
                        vFS = new FileStream(vSrc, FileMode.Open, FileAccess.Read);
                        vBR = new BinaryReader(vFS);

                        // read info of selected input file
                        vHeaderLength = vBR.ReadInt32();
                        vType = vBR.ReadString();
                        vFileLength = vBR.ReadInt32();
                        vDivCount = vBR.ReadInt32();
                        vDivOffset = vBR.ReadInt32();
                        vDivFirstName = vBR.ReadString();
                        vName = vBR.ReadString();

                        vBR.Close();

                        vSplitLength = (int) vFI.Length;
                        vSplitSize = vSplitLength - vHeaderLength;
                        vCurrentDir = vFI.DirectoryName;

                        // byte array to combine split parts
                        vCombine = new byte[vFileLength];

                        for (int i = 1; i <= vDivCount; i++) {

                            vCurrentFile = vCurrentDir + "\\" + vName + i.ToString("D4");
                            vFI = new FileInfo(vCurrentFile);
                            vFS = new FileStream(vCurrentFile, FileMode.Open, FileAccess.Read);
                            vBR = new BinaryReader(vFS);

                            // read info of div file
                            vHeaderLength = vBR.ReadInt32();
                            vType = vBR.ReadString();
                            vFileLength = vBR.ReadInt32();
                            vDivCount = vBR.ReadInt32();
                            vDivOffset = vBR.ReadInt32();
                            vDivFirstName = vBR.ReadString();
                            vName = vBR.ReadString();

                            vSplitLength = (int) vFI.Length;
                            vSplitSize = vSplitLength - vHeaderLength;
                            // buffer for reading indivual split files data
                            vBuffer = new byte[vSplitSize];

                            vBuffer = vBR.ReadBytes(vSplitSize);
                            vBR.Close();

                            for (int j = 0; j < vBuffer.Length; j++) {

                                vCombine[vCombineIterator] = vBuffer[j];
                                vCombineIterator++;
                            }
                        }

                        vFS = new FileStream(vDest + "\\" + vName, FileMode.Create, FileAccess.Write);
                        vBW = new BinaryWriter(vFS);

                        for (int i = 0; i < vCombine.Length; i++) {

                            vBW.Write(vCombine[i]);
                        }
                        vBW.Close();

                        MessageBox.Show("Done");
                    }
                }
            }
        }
    }
}
