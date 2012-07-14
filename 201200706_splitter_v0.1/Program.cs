using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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
                Console.WriteLine("This is from the main program");

                switch (args[0]) {
                    case "-s":

                        MessageBox.Show("split");
                        // need object of formMain to call non static functions
                        formMain test = new formMain();
                        //test.test();
                        break;

                    case "-j":

                        MessageBox.Show("join");
                        break;
                    default:
                 
                        MessageBox.Show("Usage:");
                        break;
                }
            }
        }
    }
}
