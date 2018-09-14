using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace traning_rubancev
{
    class Program
    {
        public static string[] readInput(string fileName)
        {
            StreamReader r = new StreamReader(fileName);
            string line = r.ReadToEnd();
            r.Close();

            string[] words = line.Split('\r');

            for (int i = 0; i < words.Length; i++)
                words[i] = words[i].Trim('"', '\n');

            return words;
        }
        static void Main(string[] args)
        {
            string filename = ("d:\\slovar.txt");
            string[] words = readInput(filename);
            /*char[] s;

            for (int i = 0; i < words.Length; i++)
            {
                s = words[i].ToCharArray();
                Array.Reverse(s);
                if (words[i] == new string(s))
                {
                    Console.Write(words[i] + " ");
                }
            }*/

            bool flag = true;
            /*StringBuilder sb = new StringBuilder();*/
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                int len = word.Length;
                flag = true;
                for (int j = 0; j < len / 2; j++)
                {
                    char ch1 = word[len - j - 1];
                    char ch2 = word[j];
                    if (ch1 != ch2)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                    Console.Write(word + " ");
            }

            Console.WriteLine("\ndone!");
            Console.ReadLine();
        }
    }
}
