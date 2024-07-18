using System;
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

            for (int i = 0; i < args.Length; i++) {
                if (args[i] == "--port" && i + 1 < args.Length) {
                    Settings.Port = args[i + 1];
                    break;
                }
            }

            form1 = new Form1();
            Application.Run(form1);
        }
        public static Form1 form1;
    }
}
