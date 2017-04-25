using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdaGrabStringsView
{
    static class Program
    {
        private static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length < 2)
                return;

            if (args[0] == "0")
            {
                Application.Run(new GetPosForm(args[1]));
            }
            else if(args[0] == "1")
            {
                Application.Run(new GrabStringsForm(GetBytes(args[1])));
            }
        }
    }
}
