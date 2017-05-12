using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace IdaGrabStringsView
{
    public partial class GrabStringsForm : Form
    {
        private byte[] buf;
        private List<String> strings_list = new List<String>();
        private List<long> strings_indexes = new List<long>();

        public GrabStringsForm(byte[] data)
        {
            InitializeComponent();
            buf = data;
        }

        private static bool[] printables_ASCII = { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        private static bool[] printables_extASCII = { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true };
        private static bool[] printables_alnumASCII = { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, false, false, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        private static bool[] printables_notNUL = { false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true };

        private void grabStringsBtn_Click(object sender, EventArgs e)
        {
            strings_list.Clear();
            strings_indexes.Clear();

            bool[] printables = null;
            if (asciiBox.Checked)
                printables = printables_ASCII;
            else if (extAsciiBox.Checked)
                printables = printables_extASCII;
            else if (alphanumAsciiBox.Checked)
                printables = printables_alnumASCII;
            else if (notNulBox.Checked)
                printables = printables_notNUL;

            long min = (long)strMinimumBox.Value;

            long str_idx = -1;
            String str = "";
            for (long i = 0; i < buf.Length; ++i)
            {
                byte b = buf[i];
                if (printables[b])
                {
                    if (str_idx == -1)
                        str_idx = i;
                    str += (char)b;
                }
                else if (str_idx != -1)
                {
                    if (i - str_idx >= min)
                    {
                        strings_list.Add(str);
                        strings_indexes.Add(str_idx);
                    }
                    str_idx = -1;
                    str = "";
                }
            }
            if(str_idx != -1 && buf.Length - str_idx >= min)
            {
                strings_list.Add(str);
                strings_indexes.Add(str_idx);
            }

            dataGridView1.Rows.Clear();
            
            for (int i = 0; i < strings_list.Count; ++i)
            {
                dataGridView1.Rows.Add(Convert.ToString(strings_indexes[i], 16), strings_list[i].ToString());
            }
        }

        private string ToDeclaration(string str, HashSet<string> fields)
        {
            string decl = "";
            int len = str.Length < 16 ? str.Length : 16;
            for (int i = 0; i < len; ++i)
            {
                if (printables_alnumASCII[str[i]])
                    decl += str[i];
                else decl += "_";
            }
            if (decl[0] >= '0' && decl[0] <= '9')
                decl = "N" + decl;
            if (fields.Contains(decl))
            {
                string nid = decl + "_1";
                int i = 1;
                while (fields.Contains(nid))
                    nid = decl + "_" + (++i);
                decl = nid;
            }
            fields.Add(decl);
            decl += ";";
            while (decl.Length < 18)
                decl += " ";
            return "char " + decl;
        }

        private void genStructBtn_Click(object sender, EventArgs e)
        {
            HashSet<string> fields = new HashSet<string>();
            string code = "struct MY_IDA_STRUCT {" + Environment.NewLine;
            long last_idx = -1;

            for(int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                long idx = long.Parse((string)dataGridView1.Rows[i].Cells[0].Value, System.Globalization.NumberStyles.HexNumber);
                if (last_idx +1 != idx)
                {
                    code += "                  char _padd" + (last_idx +1) + "[" + (idx - last_idx -1) + "];" + Environment.NewLine;
                }

                string off = "/* " + idx + " " + dataGridView1.Rows[i].Cells[0].Value + " */";
                while (off.Length < 18)
                    off += " ";
                code += off;
                code += ToDeclaration((string)dataGridView1.Rows[i].Cells[1].Value, fields);
                code += " // " + (string)dataGridView1.Rows[i].Cells[1].Value + "\n" + Environment.NewLine;

                last_idx = idx;
            }
            code += "};";
            new GenStructForm(code).Show();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllBytes(saveFileDialog1.FileName, buf);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Save file error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
