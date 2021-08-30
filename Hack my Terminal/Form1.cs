using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hack_my_Terminal
{
    public partial class Form1 : Form
    {
        string[] Valid_Words = new string[Startup.WordAmount];
        bool[] isValid = new bool[Startup.WordAmount];
        int WordCount = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //initialize hard coded variables
            /*
            System.Object[] ItemObject = new System.Object[17];
            for (int i = 0; i < 17; i++)
            {
                ItemObject[i] = Valid_Words[i];
            }
            ListBox_ValidWords.Items.AddRange(ItemObject);
            */

            for (int i = 0; i < Startup.WordAmount; i++)
            {
                isValid[i] = true;
            }
        }

        //missing error if textbox_correctletters is empty
        private void ListBox_ValidWords_DoubleClick_1(object sender, EventArgs e)
        {
            //implement error trapping if TextBox_correctletters is empty
            int similarity;
            string SelectedWord = Convert.ToString(ListBox_ValidWords.SelectedItem);
            int CorrectLetters = Convert.ToInt32(TextBox_CorrectLetters.Text);
            int RemovedWords = 0;

            if (CorrectLetters != Startup.StringLenght)
            {
                if (WordCount == Startup.WordAmount) //trapping error for if there are difference in the amount of words in the terminal vs the one in the listbox 
                {
                    for (int x = 0; x < Startup.WordAmount; x++) //check all words
                    {
                        similarity = 0; //reset similarity for each
                        if (isValid[x] == true) //will only compare values if they are valid
                        {
                            for (int indexLetter = 0; indexLetter < Startup.StringLenght; indexLetter++)
                            {
                                if (Valid_Words[x][indexLetter] == SelectedWord[indexLetter]) //compare each letter with valid words
                                    similarity++;
                            }
                            if (similarity != CorrectLetters)
                            {
                                ListBox_ValidWords.Items.Remove(Valid_Words[x]); //no more RemoveAt, we already have exact string
                                isValid[x] = false;
                                RemovedWords++;
                            }
                            else
                                MessageBox.Show("Correct word was guessed");
                        }
                    }
                }
                else
                    MessageBox.Show("The number of words in the list does not match the Number of words in the terminal.");

            }
            
        }

        private void Button_AddWord_Click(object sender, EventArgs e)
        {
            Valid_Words[WordCount] = Convert.ToString(TextBox_AddWord.Text);
            if (Valid_Words[WordCount].Length == Startup.StringLenght) //trapping error if string lenght is less than number of needed letters
            {
                ListBox_ValidWords.Items.Add(TextBox_AddWord.Text);
                WordCount++;
            }
            else
                MessageBox.Show("Your words does not match the number of letters it has.");
        }
    }
}
