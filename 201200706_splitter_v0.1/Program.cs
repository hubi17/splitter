using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _201200706_splitter_v0._1 {
    static class Program {
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

                switch (args[0]) {
                    case "-s":

                        MessageBox.Show("split");
                        // need object of formMain to call non static functions
                        formMain test = new formMain();
                        test.test();
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
