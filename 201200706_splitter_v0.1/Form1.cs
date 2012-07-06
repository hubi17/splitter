﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace _201200706_splitter_v0._1 {
    public partial class formMain : Form {

        bool vSrcSelected = false;
        bool vDestSelected = false;

        public formMain() {
            InitializeComponent();
        }

        private void formMain_Load(object sender, EventArgs e) {

        }

        private void btnInputFile_Click(object sender, EventArgs e) {

            DialogResult vResult = openFile.ShowDialog();

            if (vResult == DialogResult.OK) {

                tbxInputFileSplit.Text = openFile.FileName;
                vSrcSelected = true;
            } else {

                if (tbxInputFileSplit.Text == "") {

                    vSrcSelected = false;
                }
            }

            if (vSrcSelected && vDestSelected) {

                gbxSplitType.Visible = true;
            } else {

                gbxSplitType.Visible = false;
            }
        }

        private void btnOutputPath_Click(object sender, EventArgs e) {

            DialogResult vResult = dirBrowser.ShowDialog();

            if (vResult == DialogResult.OK) {

                tbxOutputPathSplit.Text = dirBrowser.SelectedPath;
                vDestSelected = true;
            } else {

                if (tbxOutputPathSplit.Text == "") {

                    vDestSelected = false;
                }
            }

            if (vSrcSelected && vDestSelected) {

                gbxSplitType.Visible = true;
            } else {

                gbxSplitType.Visible = false;
            }
        }

        private void bgWorkerStatus_DoWork(object sender, DoWorkEventArgs e) {

            for (int i = 1; i <= 100; i++) {
                
                // do work
                Thread.Sleep(100);

                // report status
                bgWorkerStatus.ReportProgress(i);
            }
        }

        private void btnSplit_Click(object sender, EventArgs e) {

            // start the background worker
            bgWorkerStatus.RunWorkerAsync();

            // make progress bar visible
            progressBarStatus.Visible = true;
        }

        private void bgWorkerStatus_ProgressChanged(object sender, ProgressChangedEventArgs e) {

            // change the value of the progress bar to background worker progress
            progressBarStatus.Value = e.ProgressPercentage;
        }

        private void rbtnParts_CheckedChanged(object sender, EventArgs e) {

            gbxSizeParts.Text = "Number of parts";
            gbxSizeParts.Visible = true;
            lblType.Text = "Enter number of parts:";
        }

        private void rbtnSize_CheckedChanged(object sender, EventArgs e) {

            gbxSizeParts.Text = "Part size";
            gbxSizeParts.Visible = true;
            lblType.Text = "Enter split file size:";
        }

        private void btnCancel_Click(object sender, EventArgs e) {

            gbxSplitType.Visible = false;
            gbxSizeParts.Visible = false;
            vDestSelected = false;
            vSrcSelected = false;
            tbxInputFileSplit.Clear();
            tbxOutputPathSplit.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {

            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {

            MessageBox.Show("File Splitter by Daniel Auhuber");
        }
    }
}