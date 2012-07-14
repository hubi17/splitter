using System;
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

            // check that the user clicked ok in the file browser dialog
            if (vResult == DialogResult.OK) {

                tbxInputFileSplit.Text = openFile.FileName;
                gSrcSelected = true;
            } else {

                if (tbxInputFileSplit.Text == "") {

                    gSrcSelected = false;
                }
            }

            // if both an input file and an output directory have been specified show the splitType group box
            if (gSrcSelected && gDestSelected) {

                gbxSplitType.Visible = true;
            } else {

                gbxSplitType.Visible = false;
            }
        }

        private void btnOutputPath_Click(object sender, EventArgs e) {

            DialogResult vResult = dirBrowser.ShowDialog();

            gDestSelected = false;

            // check that the user clicked ok in the folder browser dialog
            if (vResult == DialogResult.OK) {

                tbxOutputPathSplit.Text = dirBrowser.SelectedPath;
                gDestSelected = true;
            } else {

                if (tbxOutputPathSplit.Text == "") {

                    gDestSelected = false;
                }
            }

            // if both an input file and an output directory have been specified show the splitType group box
            if (gSrcSelected && gDestSelected) {

                gbxSplitType.Visible = true;
                gbxSizeParts.Visible = true;
            } else {

                gbxSplitType.Visible = false;
                gbxSizeParts.Visible = false;
            }
        }

        private void btnSplit_Click(object sender, EventArgs e) {

            FileInfo vFI;
            long vSplitCount;
            long vSplitSize;
            int vFileLength;
            int vError;

            // check that an input file and an output directory have values in them
            if (tbxInputFileSplit.Text != "" && tbxOutputPathSplit.Text != "") {

                // if the specified input file exists get info on the file and calculate
                // vSplitCount = number of splits required
                // vSplitSize = size of the individual split file
                if (File.Exists(tbxInputFileSplit.Text)) {

                    vFI = new FileInfo(tbxInputFileSplit.Text);
                    vFileLength = (int) vFI.Length;

                    if (rbtnParts.Checked) {
                        // Split count given

                        vSplitCount = (long) nudSizeParts.Value;

                        // if only 1 split number was selected, there is no need to split
                        if (vSplitCount > 1) {

                            vSplitSize = vFileLength / vSplitCount;

                            // if not evenly divisible increase vSplitSize
                            if (vFileLength % vSplitCount != 0) {

                                vSplitSize++;
                            }

                            vError = splitFile(tbxInputFileSplit.Text, tbxOutputPathSplit.Text, vSplitSize, vSplitCount, false);
                        } else {

                            vError = -4;
                        }
                    } else {
                        // Else size option must be selected

                        // calculate the correct size depending on the specified value
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
                                break;
                        }

                        // make sure there is no division by zero
                        if (vSplitSize > 0) {

                            vSplitCount = vFileLength / vSplitSize;

                            // if not divisible need extra file
                            if (vFileLength % vSplitSize != 0) {

                                vSplitCount++;
                            }

                            vError = splitFile(tbxInputFileSplit.Text, tbxOutputPathSplit.Text, vSplitSize, vSplitCount, true);
                        } else {
                            // wrong split size given
                            vError = -3;
                        }
                    }

                    // check if any errors occured
                    switch (vError) {

                        case -4:

                            MessageBox.Show("Invalid number of parts.\nPlease select at least 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case -3:

                            MessageBox.Show("Invalid split size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case -2:

                            MessageBox.Show("Incorrect output path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbxOutputPathSplit.Focus();
                            break;
                        case -1:

                            MessageBox.Show("Incorrect input file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbxInputFileSplit.Focus();
                            break;
                        case 0:

                            MessageBox.Show("Successfully split file.");
                            clearSplit();
                            break;
                    }
                } else {

                    MessageBox.Show("Incorrect input file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxInputFileSplit.Focus();
                }
            }
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

            clearSplit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {

            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {

            MessageBox.Show("File splitter & joiner\nby Daniel Auhuber\n2012", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tbxInputFileSplit_KeyDown(object sender, KeyEventArgs e) {

            // if return is pressed and source file field is not empty advance to output path
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

            // if return is pressed and output path field is not empty show split type options
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

        /*
         * Method to split a given file by either size or number of parts and output to a given directory.
         * params:
         *          string pSrc         - the source file to be split
         *          string pDest        - the destination folder of parts output
         *          long pSplitSize     - the size of the individual parts
         *          long pSplitCount    - the number of parts to be created
         *          bool pSplitBySize   - set to true if max file size of individual parts is given
         * returns:
         *          int rReturn
         *               0  - if successfully split the file
         *              -1  - if the input file was not specified correctly
         *              -2  - if the output path was not specified correctly
         *              -3  - if split size is too small for header and data
         */
        private int splitFile(string pSrc, string pDest, long pSplitSize, long pSplitCount, bool pSplitBySize) {

            FileStream vFS;
            BinaryWriter vBW;
            BinaryReader vBR;
            FileInfo vFI;
            DirectoryInfo vDI;

            // store return value of method
            int vReturn = 0;
            // path to source file
            string vSrc = pSrc;
            // output directory
            string vDest = pDest;
            // path and filename of each part file
            string vOutputFile;
            // file name of selected input file
            string vFileName;

            // total length of header
            int vHeaderLength;
            // identifier for part files
            string vType = "div";
            // length of the original file
            int vFileLength;
            // number of current part
            int vDivOffset;
            // name of the first part file
            string vDivFirstName;

            // array to hold input file after it has been read by binary reader
            byte[] vSplits;
            // iterator over the vSplits array to remember current position in array
            int vSplitsIterator = 0;

            vDI = new DirectoryInfo(vDest);

            // ensure that output directory exists
            if (vDI.Exists) {

                if (File.Exists(vSrc)) {

                    vFI = new FileInfo(vSrc);

                    // get the file name
                    vFileName = vFI.Name;
                    vFS = new FileStream(vSrc, FileMode.Open, FileAccess.Read);

                    // get the file length
                    vFileLength = (int) vFI.Length;

                    vSplits = new byte[vFileLength];

                    // read selected input file into byte array for splitting
                    vBR = new BinaryReader(vFS);
                    vSplits = vBR.ReadBytes(Convert.ToInt32(vFileLength));
                    vBR.Close();

                    // set name of first div
                    vDivFirstName = vFileName + 1.ToString("D4");

                    // vHeaderLength is calculated using:
                    //      sizeof(int)                     for the int that represents vHeaderLength
                    //      string.Length + sizeof(byte)    for the size prefix of the string binary writer writes
                    //      sizeof(int)                     for the int that represents vFileLength
                    //      sizeof(int)                     for the int that represents pSplitCount
                    //      sizeof(int)                     for the int that represents vDivOffset
                    //      string.Length + sizeof(byte)    for the size prefix of the string binary writer writes
                    //      string.Length + sizeof(byte)    for the size prefix of the string binary writer writes
                    vHeaderLength = sizeof(int)
                        + vType.Length + sizeof(byte)
                        + sizeof(int)
                        + sizeof(int)
                        + sizeof(int)
                        + vDivFirstName.Length + sizeof(byte)
                        + vFileName.Length + sizeof(byte);

                    // if splitting by size, recalculate split size by taking header length into consideration
                    if (pSplitBySize) {

                        // remove vHeaderLength from pSplitSize and recalculate pSplitCount
                        pSplitSize -= vHeaderLength;
                        pSplitCount = vFileLength / pSplitSize;

                        // if not divisible need extra file
                        if (vFileLength % pSplitSize != 0) {

                            pSplitCount++;
                        }
                    }

                    // check that the splitsize is greater than length of the header, otherwise no data can be writen to the files
                    if (pSplitSize > vHeaderLength) {

                        // iterate over the number of part files
                        for (int i = 1; i <= pSplitCount; i++) {

                            vDivOffset = i;
                            vOutputFile = vDest + "\\" + vFileName + vDivOffset.ToString("D4");

                            vFS = new FileStream(vOutputFile, FileMode.OpenOrCreate, FileAccess.Write);
                            vBW = new BinaryWriter(vFS);

                            // write header into file
                            vBW.Write(vHeaderLength);
                            vBW.Write(vType);
                            vBW.Write(vFileLength);
                            vBW.Write((int) pSplitCount);
                            vBW.Write(vDivOffset);
                            vBW.Write(vDivFirstName);
                            vBW.Write(vFileName);

                            // iterate over the length of each part file
                            for (int j = 0; j < pSplitSize; j++) {

                                // write actual data into file
                                if (vSplitsIterator < vSplits.Length) {

                                    // if more data is available write to file
                                    vBW.Write(vSplits[vSplitsIterator]);
                                    vSplitsIterator++;
                                } else {

                                    // else close file and end loop early
                                    vBW.Close();
                                    break;
                                }
                            }

                            vBW.Close();
                        }
                    } else {

                        // invalid size specified
                        vReturn = -3;
                    }
                } else {

                    // incorrect input file
                    vReturn = -1;
                }
            } else {

                // incorrect output path
                vReturn = -2;
            }

            // if file was successfully split
            if (vReturn == 0) {

                // delete file
                if (File.Exists(pSrc)) {

                    File.Delete(pSrc);
                }
            }

            return vReturn;
        }

        private void splitToolStripMenuItem_Click(object sender, EventArgs e) {

            // if corresponding menu item is clicked show tab page
            tabctrlSelection.SelectedTab = tabpageSplit;
        }

        private void joinToolStripMenuItem_Click(object sender, EventArgs e) {

            // if corresponding menu item is clicked show tab page
            tabctrlSelection.SelectedTab = tabpageJoin;
        }

        private void btnInputFileJoin_Click(object sender, EventArgs e) {

            DialogResult vResult = openFile.ShowDialog();

            // if the user clicked ok on the source file selection add selected file path to text field
            if (vResult == DialogResult.OK) {

                tbxInputFileJoin.Text = openFile.FileName;
            }
        }

        private void btnOutputPathJoin_Click(object sender, EventArgs e) {

            DialogResult vResult = dirBrowser.ShowDialog();

            // if the user clicked ok on the output path selection add selected path to text field
            if (vResult == DialogResult.OK) {

                tbxOutputPathJoin.Text = dirBrowser.SelectedPath;
            }
        }

        private void btnJoin_Click(object sender, EventArgs e) {

            int vError;

            // check that an input file and an output directory have values in them
            if (tbxInputFileJoin.Text != "" && tbxOutputPathJoin.Text != "") {
                
                vError = joinFiles(tbxInputFileJoin.Text, tbxOutputPathJoin.Text);

                // check whether any errors occured
                switch (vError) {

                    case 0:
                        MessageBox.Show("Successfully joined files.");
                        break;
                    case -1:
                        MessageBox.Show("Missing part file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }

            
        }

        /*
         * Method to join part files. Only one part file needs to be specified along with the target output directory.
         * params:
         *          string pSrc     - the path of the selected part file
         *          string pDest    - the path to the output directory
         * returns:
         *           0  - if the join was successful
         *          -1  - if a part file was missing
         */
        private int joinFiles(string pSrc, string pDest) {

            FileStream vFS;
            BinaryWriter vBW;
            BinaryReader vBR;
            FileInfo vFI;

            int vReturn = 0;
            string vSrc = pSrc;
            string vDest = pDest;
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
            // vSplitLength is the total length of split file
            int vSplitLength;
            byte[] vBuffer;
            byte[] vCombine;
            int vCombineIterator = 0;

            // check that given part file exists
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
                    
                    // check that current part file is available
                    if (File.Exists(vCurrentFile)) {

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

                        // copy each byte in the buffer to the combine buffer to restore file
                        for (int j = 0; j < vBuffer.Length; j++) {

                            vCombine[vCombineIterator] = vBuffer[j];
                            vCombineIterator++;
                        }
                    } else {

                        vReturn = -1;
                        break;
                    }
                }

                // no errors occured
                if (vReturn == 0) {

                    // create output file
                    vFS = new FileStream(vDest + "\\" + vName, FileMode.Create, FileAccess.Write);
                    vBW = new BinaryWriter(vFS);

                    // write individual bytes of all combined files to output file
                    for (int i = 0; i < vCombine.Length; i++) {

                        vBW.Write(vCombine[i]);
                    }
                    vBW.Close();
                }
            }

            return vReturn;
        }

        private void clearSplit() {

            // reset fields
            gbxSplitType.Visible = false;
            gbxSizeParts.Visible = false;
            gDestSelected = false;
            gSrcSelected = false;
            tbxInputFileSplit.Clear();
            tbxOutputPathSplit.Clear();
        }

        private void clearJoin() {

            // reset fields
            tbxInputFileJoin.Clear();
            tbxOutputPathJoin.Clear();
        }

        private void btnCancelJoin_Click(object sender, EventArgs e) {

            clearJoin();
        }
    }
}
