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

namespace eratosfen_chapter14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void sieve(int maxVal)
        {
            BitArray btArr = new BitArray(maxVal + 1);
            btArr.SetAll(true);
            for (int i = 2; i <= Math.Sqrt(maxVal); ++i)
                if (btArr.Get(i))
                    for (int j = 2 * i; j <= maxVal; j += i)
                        btArr.Set(j, false);

            for (int i = 2; i <= maxVal; i++)
                if (btArr.Get(i))
                    listBox1.Items.Add(i);
            listBox1.TopIndex = listBox1.Items.Count - 27;
            listBox1.Items.Add("");
        }
        public void primes(int start, int end)
        {
            for (int i = start; i <= end; ++i)
            {
                bool flag = true;
                for (int j = 2; j <= Math.Sqrt(i); ++j)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                    listBox1.Items.Add(i);
            }
            listBox1.TopIndex = listBox1.Items.Count - 27;
            listBox1.Items.Add("");
        }
        List<int> primeList(int end)
        {
            int[] chetverki = new int[4];
            List<int> lst = new List<int>();
            lst.Add(2);
            bool flag;
            int num = 3;
            int max = 10;
            int count = 0;
            while (num <= end)
            {
                flag = true;
                foreach (int prime in lst)
                {
                    if (num > max)
                    {
                        max += 10;
                        count = 0;
                    }
                    if (num % prime == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    lst.Add(num);
                    if (count < 4 && num <= max)
                        chetverki[count++] = num;
                }
                if (count == 4)
                {
                    int i = 0;
                    while (i != count)
                    {
                        lstBoxChetverki.Items.Add(chetverki[i++]);
                    }
                }
                num += 2;
            }
            return lst;
        }
        public void findPerfectNums(int max)
        {
            for (int i = 12; i < max; i++)
            {
                if (checkPerf(i))
                    listBox1.Items.Add(i);
            }
        }
        public bool checkPerf(int num)
        {
            int val = 0;
            for (int i = num / 2; i >= 1; i = (i / 2))
            {
                if (num % i == 0)
                {
                    val += i;
                    i++;
                }
                if (val > num)
                    return false;
                if (val == num && i == 2)
                    return true;
                if (i == 2)
                    return false;
            }
            return false;
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            int number = 1000000000;
            sieve(number);
        }

        private void btnPrime_Click(object sender, EventArgs e)
        {
            int number1 = (int)udNumber.Value;
            int number2 = (int)udNumber2.Value;
            primes(number1, number2);
        }

        private void btnLst_Click(object sender, EventArgs e)
        {
            int number2 = (int)udNumber2.Value;
            List<int> lst = primeList(number2);
            listBox1.BeginUpdate();

            foreach (int prime in lst)
                listBox1.Items.Add(prime);

            listBox1.EndUpdate();
            listBox1.TopIndex = listBox1.Items.Count - 27;
            listBox1.Items.Add("");
        }

        private void btnPerfectNums_Click(object sender, EventArgs e)
        {
            int maxNum = 10000;
            findPerfectNums(maxNum);
        }
    }
}
