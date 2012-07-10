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
                //Console.WriteLine("enter args");
                MessageBox.Show(args[0]);
            }
        }
    }
}
