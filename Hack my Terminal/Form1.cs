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
        string[] Valid_Words = new string [17]  {
        "VICTIMS",
        "DEALING",
        "REALIZE",
        "DECLINE",
        "REFUSES",
        "SEALING",
        "VEGGIES",
        "FISHING",
        "FEARING",
        "RATIONS",
        "PILLOWS",
        "DOLLARS",
        "HEALING",
        "REMAINS",
        "COUSINS",
        "HELPING",
        "OFFLINE"
        };

        bool[] isValid = new bool [17] { 
        true,
        true,
        true,
        true,
        true,
        true,
        true,
        true,
        true,
        true,
        true,
        true,
        true,
        true,
        true,
        true,
        true
        };

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //initialize hard coded variables
            System.Object[] ItemObject = new System.Object[17];
            for (int i = 0; i < 17; i++)
            {
                ItemObject[i] = Valid_Words[i];
            }
            ListBox_ValidWords.Items.AddRange(ItemObject);
        }

        //missing error if textbox_correctletters is empty
        private void ListBox_ValidWords_DoubleClick_1(object sender, EventArgs e)
        {
            
            int similarity;
            string SelectedWord = Convert.ToString(ListBox_ValidWords.SelectedItem);
            int CorrectLetters = Convert.ToInt32(TextBox_CorrectLetters.Text);
            int RemovedWords = 0;

            if (CorrectLetters != 7)
            {
                for (int x = 0; x < 17; x++)
                {
                    similarity = 0; //reset similarity for each
                                    //check similarity
                    if (isValid[x] == true)
                    {
                        for (int indexLetter = 0; indexLetter < 7; indexLetter++)
                        {
                            if (Valid_Words[x][indexLetter] == SelectedWord[indexLetter]) //compare each letter with all words
                                similarity++;
                        }
                        if (similarity != CorrectLetters)
                        {
                            ListBox_ValidWords.Items.RemoveAt(x - RemovedWords);
                            isValid[x] = false;
                            RemovedWords++;
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Correct word was guessed");
            }
            //add remove thing
        }

        
    }
}
