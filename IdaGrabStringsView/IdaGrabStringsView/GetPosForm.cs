using System;
using System.Windows.Forms;

namespace IdaGrabStringsView
{
    public partial class GetPosForm : Form
    {
        public GetPosForm(string cur_pos)
        {
            InitializeComponent();
            startBox.Text = cur_pos;
        }

        private bool ULongFromString(string str, out ulong result)
        {
            result = 0;
            try
            {
                result = Convert.ToUInt64(str, 10);
            }
            catch (Exception e0)
            {
                try
                {
                    result = Convert.ToUInt32(str, 16);
                }
                catch (Exception e1)
                {
                    return false;
                }
            }
            return true;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            ulong start, len;
            if (!ULongFromString(startBox.Text, out start))
            {
                MessageBox.Show("Invalid start position format");
                return;
            }
            if (!ULongFromString(lenBox.Text, out len))
            {
                MessageBox.Show("Invalid length format");
                return;
            }
            Console.WriteLine(start);
            Console.WriteLine(len);
            Application.Exit();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
