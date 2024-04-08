using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server {
    static class Program {

        /*
         *                         _                  _                 
         *                        | |                | |                
         *  __ ___      ____ _  __| | __ _ _ __   ___| |__  _   _ _ __  
         * / _` \ \ /\ / / _` |/ _` |/ _` | '_ \ / __| '_ \| | | | '_ \ 
         *| (_| |\ V  V / (_| | (_| | (_| | | | | (__| | | | |_| | | | |
         * \__, | \_/\_/ \__, |\__,_|\__,_|_| |_|\___|_| |_|\__,_|_| |_|
         *    | |           | |                                         
         *    |_|           |_|                                         
         * 
         */
        [STAThread]
        static void Main(string[] args) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool PortArgs = false;
            for (int i = 0; i < args.Length; i++) {
                if (args[i] == "--port" && i + 1 < args.Length) {
                    Properties.Settings.Default.Ports = args[i + 1];
                    Properties.Settings.Default.Save();
                    PortArgs = true;
                    break;
                }
            }

            form1 = new Form1(PortArgs);
            Application.Run(form1);
        }
        public static Form1 form1;
    }
}
