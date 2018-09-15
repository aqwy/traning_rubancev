using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace palindroms_chapter1
{
    public partial class Form1 : Form
    {
        ArrayList dict = new ArrayList();
        public void serchPalindroms()
        {
            foreach (string words in dict)
            {
                int len = words.Length;
                bool flag = true;
                for (int i = 0; i < len / 2; i++)
                {
                    char ch1 = words[len - i - 1];
                    char ch2 = words[i];
                    if (ch1 != ch2)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                    lstRes.Items.Add(words);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDictLoad_Click(object sender, EventArgs e)
        {
            dict.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader r = new StreamReader(ofd.FileName);
                string s = null;
                while ((s = r.ReadLine()) != null)
                {
                    dict.Add(s);
                }
                r.Close();
                r = null;
            }
            serchPalindroms();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstRes.Items.Clear();
        }

        private void btnSaveRes_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt";
            sfd.FileName = "Palindroms";
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                string s = null;
                for (int i = 0; i < lstRes.Items.Count; i++)
                {
                    s = (string)lstRes.Items[i];
                    sw.WriteLine(s);
                }
                sw.Close();
                sw = null;

                MessageBox.Show("file " + sfd.FileName + " saved!");
            }
        }
    }
}
