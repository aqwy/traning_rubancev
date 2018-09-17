using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace litoreya_chapter8
{
    public partial class Form1 : Form
    {
        const string lit1 = "БВГДЖЗКЛМН";
        const string lit2 = "ПРСТФХЦЧШЩ";
        ArrayList direct = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }
        public void getYo()
        {
            foreach (string words in direct)
            {
                int len = words.Length;
                for (int i = 0; i < len; i++)
                {
                    char ch = words[i];
                    if (ch == 'ё' || ch == 'Ё')
                    {
                        rtbOutput.AppendText(words + '\n');
                        break;
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string text = rtbInput.Text;
            string litorea = "";
            int len = text.Length;
            for (int i = 0; i < len; i++)
            {
                char ch = text[i];
                ch = char.ToUpper(ch);
                int n = lit1.IndexOf(ch);
                if (n > -1)
                    litorea += lit2[n];
                else
                {
                    n = lit2.IndexOf(ch);
                    if (n > -1)
                        litorea += lit1[n];
                    else
                        litorea = litorea + ch;
                }
            }
            rtbOutput.AppendText(litorea);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbInput.Clear();
            rtbOutput.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFD.FilterIndex = 1;
            openFD.RestoreDirectory = true;

            if (openFD.ShowDialog() == DialogResult.OK)
            {
                StreamReader r = new StreamReader(openFD.FileName);
                string s = null;
                while ((s = r.ReadLine()) != null)
                {
                    direct.Add(s);
                }
                r.Close();
                r = null;
            }
            getYo();
        }
    }
}
