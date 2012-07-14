using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace _201200706_splitter_v0._1 {
    static class Program {

        // allow attaching of console to current program
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        private const int ATTACH_PARENT_PROCESS = -1;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {

            FileInfo vFI;
            int vFileLength;
            int vError = 0;
            string vSrc;
            string vDest;
            long vSplitSize;
            long vSplitCount;
            bool vSplitBySize;
            string vHelpMessage = "Usage:\n-s src-file dest-dir [splitsize | splitcount] [true - split by size in bytes | false - split by parts]\n-j srv-file dest-dir";

            if (args.Length == 0) {

                // no args given, start gui
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new formMain());
                
            } else {

                // cmd stuff
                // attach to the parent process via AttachConsole SDK call
                AttachConsole(ATTACH_PARENT_PROCESS);
                Console.WriteLine();

                // need object of formMain to call non static functions
                formMain main = new formMain();

                switch (args[0]) {
                    case "-s":

                        Console.WriteLine("Split selected.");

                        if (args.Length == 5) {

                            vSrc = args[1];
                            vDest = args[2];

                            vSplitBySize = Convert.ToBoolean(args[4]);
                            
                            vFI = new FileInfo(vSrc);
                            vFileLength = (int) vFI.Length;

                            if (vSplitBySize) {
                                // split by size

                                vSplitSize = Convert.ToInt64(args[3]);

                                // make sure there is no division by zero
                                if (vSplitSize > 0) {

                                    vSplitCount = vFileLength / vSplitSize;

                                    // if not divisible need extra file
                                    if (vFileLength % vSplitSize != 0) {

                                        vSplitCount++;
                                    }

                                    vError = main.splitFile(vSrc, vDest, vSplitSize, vSplitCount, vSplitBySize);
                                }

                            } else {
                                // split by number of parts

                                vSplitCount = Convert.ToInt64(args[3]);
                                
                                if (vSplitCount > 1) {

                                    vSplitSize = vFileLength / vSplitCount;

                                    // if not evenly divisible increase vSplitSize
                                    if (vFileLength % vSplitCount != 0) {

                                        vSplitSize++;
                                    }

                                    vError = main.splitFile(vSrc, vDest, vSplitSize, vSplitCount, vSplitBySize);
                                }

                            }

                            // check if any errors occured
                            switch (vError) {

                                case -4:

                                    Console.WriteLine("Invalid number of parts.\nPlease select at least 2.");
                                    break;
                                case -3:

                                    Console.WriteLine("Invalid split size.");
                                    break;
                                case -2:

                                    Console.WriteLine("Incorrect output path.");
                                    break;
                                case -1:

                                    Console.WriteLine("Incorrect input file.");
                                    break;
                                case 0:

                                    Console.WriteLine("Successfully split file.");
                                    break;
                            }

                            
                        } else {

                            Console.WriteLine("Wrong number of arguments");
                            Console.WriteLine(vHelpMessage);
                        }

                        break;

                    case "-j":

                        Console.WriteLine("Join selected.");

                        if (args.Length == 3) {

                            vSrc = args[1];
                            vDest = args[2];

                            vError = main.joinFiles(vSrc, vDest);

                            // check whether any errors occured
                            switch (vError) {

                                case 0:

                                    Console.WriteLine("Successfully joined files.");
                                    break;
                                case -1:

                                    Console.WriteLine("Missing part file.", "Error");
                                    break;
                            }
                        } else {

                            Console.WriteLine("Wrong number of arguments");
                            Console.WriteLine(vHelpMessage);
                        }

                        break;
                    default:

                        Console.WriteLine(vHelpMessage);
                        break;
                }
            }
        }
    }
}
