using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace IdaGrabStringsView
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length > 0)
            {
                Application.Run(new GetPosForm(args[0]));
            }
            else 
            {
                List<byte[]> bytes_list = new List<byte[]>();
                List<int> bytes_sizes = new List<int>();
                long reads = 0;
                using (Stream stdin = Console.OpenStandardInput())
                {
                    byte[] buffer = new byte[2048];
                    int bytes;
                    while ((bytes = stdin.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        bytes_list.Add(buffer);
                        bytes_sizes.Add(bytes);
                        reads += bytes;
                        buffer = new byte[2048];
                    }
                }
                byte[] buf = new byte[reads];
                for (int i = 0, j = 0; i < bytes_list.Count; ++i)
                {
                    for (int k = 0; k < bytes_sizes[i] && j < reads; ++k)
                    {
                        buf[j++] = bytes_list[i][k];
                    }
                }
                
                Application.Run(new GrabStringsForm(buf));
            }
        }
    }
}
