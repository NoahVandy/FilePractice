//this is my own work
//Noah Vandervelden

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
            //making a new file
            sw = System.IO.File.CreateText("FilePractice1.out");
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                //this is making the thing that can read the words from the file
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                //this actually reads it to the end
                string allText = sr.ReadToEnd();
                allText = allText.ToLower();
                //this is making the words split up accoriding to white space
                string[] words = allText.Split();

                int count = 0;
                string longestWord = "";
                string firstWord = words[0];
                string lastWord = words[0];
                string mostVowels = words[0];

                int[] vowelCounter = new int[words.Length];
                //this is the loop that reads each word in the array
                for (int i = 0; i < words.Length; i++)
                {
                    int vowelCount = 0;

                    //this is writing the words to the file I made.
                    sw.Write(words[i] + " ");

                    //this is displaying the words to the text box
                    if(words[i].Length > 0)
                    {
                        rchTxBx_stringReader.Text += words[i] + "\n";
                    }


                    //this is checking for the longest word
                    while(words[i].Length >= count)
                    {
                        longestWord = words[i];
                        count++;
                    }
                    
                    //this is checking for the first and last word alphabetically
                    if( words[i].CompareTo(firstWord) < 0)
                    {
                        firstWord = words[i];
                    }
                    if(words[i].CompareTo(lastWord) > 0)
                    {
                        lastWord = words[i];
                    }

                    //this is checking for words that start with a vowel
                    for (int j = 0; j < words[i].Length; j++)
                    {
                        if (words[i][j] == 'a' ||
                        words[i][j] == 'e' || words[i][j] == 'i' ||
                        words[i][j] == 'o' || words[i][j] == 'u')
                        {
                            vowelCount++;
                            vowelCounter[i] = vowelCount;
                            if(vowelCounter[i] >= vowelCount)
                            {
                                mostVowels = words[i];
                            }
                        }
                    }
                    

                }
                //writing the longestword
                rchTxBx_stringReader.Text += "This is the longest word: " +  longestWord + "\n";
                rchTxBx_stringReader.Text += "This is the first word alphabetically: " + firstWord + "\n";
                rchTxBx_stringReader.Text += "This is the last word alphabetically: " + lastWord + "\n";
                rchTxBx_stringReader.Text += "This is the word with the most vowels: " + mostVowels + "\n";
            }
            sw.Close();
        }
    }
}
