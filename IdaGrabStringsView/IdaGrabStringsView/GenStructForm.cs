using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdaGrabStringsView
{
    public partial class GenStructForm : Form
    {
        private string code;

        public GenStructForm(string s)
        {
            InitializeComponent();
            code = s;
        }

        private void GenStructForm_Load(object sender, EventArgs e)
        {
            codeBox.Text = code;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog1.FileName, codeBox.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Save file error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
