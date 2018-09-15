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
        public void serchMommys()
        {
            foreach (string words in dict)
            {
                int len = words.Length;
                if (len % 2 != 0 || len > 8)
                    continue;
                bool flag = true;
                for (int i = 0; i < len / 2; i++)
                {
                    char ch1 = words[len / 2 + i];
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
        public void serchCPal()
        {
            foreach (string words in dict)
            {
                int len = words.Length;
                bool flag = true;
                if (len < 3)
                    continue;
                for (int i = 0; i < len/2; i++)
                {
                    char ch1 = words[i + 1];
                    char ch2 = words[len - (i + 1)];
                    if(ch1!=ch2)
                    {
                        for (int j = 0; j < len/2; j++)
                        {
                            ch1 = words[j];
                            ch2 = words[len - (j + 2)];
                            if(ch1!=ch2)
                            {
                                flag = false;
                                break;
                            }
                        }
                        break;
                    }
                }
                if (flag)
                    lstRes.Items.Add(words);


                /*int len = words.Length;
                bool flag = true;
                if (len < 3)
                    continue;
                for (int i = 0; i < len / 2; i++)
                {
                    char ch1 = words[len - i - 2];
                    char ch2 = words[i];
                    char ch3 = words[i + 1];
                    char ch4 = words[len - i - (i + 1)];
                    if (ch2 == ch1 || ch3 == ch4)
                    {
                        continue;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                    lstRes.Items.Add(words);*/

                /*while(dict != null)
                {
                    int ch1, ch2;
                    for (int i = 0; i < len/2; i++)
                    {
                        ch1 = words[len - i - 2];
                        ch2 = words[i];
                        if (ch1 != ch2)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        lstRes.Items.Add(words);
                        break;
                    }
                    else
                    {
                        for (int i = 0; i < len/2; i++)
                        {
                            ch1 = words[len - i - 1];
                            ch2 = words[i + 1];
                            if (ch1 != ch2)
                            {
                                flag = false;
                                break;
                            }
                        }
                    }
                    if (flag)
                    {
                        lstRes.Items.Add(words);
                        break;
                    }
                    break;
                }*/
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
            sfd.FileName = "momys";
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

        private void lstRes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btmLepet_Click(object sender, EventArgs e)
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
            serchMommys();
        }

        private void btmCklPol_Click(object sender, EventArgs e)
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
            serchCPal();
        }
    }
}
