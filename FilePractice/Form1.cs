using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilePractice
{
    public partial class Form1 : Form
    {

        public static System.IO.StreamWriter sw;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_showFile_Click(object sender, EventArgs e)
        {
            sw = System.IO.File.CreateText("FilePractice1.out");
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                string allText = sr.ReadToEnd();
               // this.rchTxBx_stringReader.Text = allText;

                string[] words = allText.Split();
                MessageBox.Show(words.Length + "");
                int count = 0;
                string longestWord = "";
                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = words[i].ToLower();
                    //rchTxBx_stringReader.Text += words[i] + "\n";
                    sw.Write(words[i] + " ");

                    if(words[i].Length > 3)
                    {
                        rchTxBx_stringReader.Text += words[i] + "\n";
                    }


                    if(words[i].Length > 0 && words[i][0] == 'a' ||
                        words[i][0] == 'e' || words[i][0] == 'i' ||
                        words[i][0] == 'o' || words[i][0] == 'u')
                    {
                        rchTxBx_stringReader.Text += "Vowel word \n";
                        rchTxBx_stringReader.Text += words[i] + "\n";
                    }
                    while(words[i].Length >= count)
                    {
                        longestWord = words[i];
                        count++;
                    }
                }
                rchTxBx_stringReader.Text +="This is the longest word: " +  longestWord + "\n";
            }
            sw.Close();
        }
    }
}
