using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RcvPayment {
    static class Program {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            bool param = false;
            if (args.Length > 0) {
                if (args[0].ToLower().Trim().CompareTo("private") == 0) {
                    Environment.SetEnvironmentVariable(
                        "UseLocalConfig", 
                        "yes", 
                        EnvironmentVariableTarget.Process);
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
