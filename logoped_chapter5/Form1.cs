using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logoped_chapter5
{
    public partial class frmLogopef : Form
    {
        public frmLogopef()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string text = rtxSource.Text;
            /*string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
                words[i] = words[i].Trim(',', '?', '.');*/

            string logopef = "";
            int len = text.Length;
            for (int i = 0; i < len; i++)
            {
                char ch = text[i];
                if (ch == 'Р')
                    continue;
                else if (ch == 'р')
                    continue;

                else if (ch == 'Д')
                    logopef += 'Ф';
                else if (ch == 'д')
                    logopef += 'ф';
                else
                    logopef += ch;
            }
            string zaika = "";
            string[] words = logopef.Split(' ');
            for (int i = 0; i < words.Length; i++)
                words[i] = words[i].Trim(',', '?', '.');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] += "-ка ";
                zaika += words[i];
                /*words[i] += "-ка ";
                logopef += words[i];*/
            }
            /*rtxTarget.AppendText(zaika);*/
            rtxTarget.AppendText(zaika);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtxTarget.Clear();
            rtxSource.Clear();
        }
    }
}
