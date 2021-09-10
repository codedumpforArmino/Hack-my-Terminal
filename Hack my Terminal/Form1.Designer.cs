
namespace Hack_my_Terminal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListBox_ValidWords = new System.Windows.Forms.ListBox();
            this.TextBox_AddWord = new System.Windows.Forms.TextBox();
            this.TextBox_CorrectLetters = new System.Windows.Forms.TextBox();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.Label_CorrectLetters = new System.Windows.Forms.Label();
            this.Label_Word = new System.Windows.Forms.Label();
            this.Button_AddWord = new System.Windows.Forms.Button();
            this.Button_Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBox_ValidWords
            // 
            this.ListBox_ValidWords.FormattingEnabled = true;
            this.ListBox_ValidWords.Location = new System.Drawing.Point(167, 35);
            this.ListBox_ValidWords.Name = "ListBox_ValidWords";
            this.ListBox_ValidWords.Size = new System.Drawing.Size(145, 355);
            this.ListBox_ValidWords.TabIndex = 0;
            this.ListBox_ValidWords.DoubleClick += new System.EventHandler(this.ListBox_ValidWords_DoubleClick_1);
            // 
            // TextBox_AddWord
            // 
            this.TextBox_AddWord.Location = new System.Drawing.Point(31, 54);
            this.TextBox_AddWord.Name = "TextBox_AddWord";
            this.TextBox_AddWord.Size = new System.Drawing.Size(100, 20);
            this.TextBox_AddWord.TabIndex = 1;
            // 
            // TextBox_CorrectLetters
            // 
            this.TextBox_CorrectLetters.Location = new System.Drawing.Point(31, 141);
            this.TextBox_CorrectLetters.Name = "TextBox_CorrectLetters";
            this.TextBox_CorrectLetters.Size = new System.Drawing.Size(100, 20);
            this.TextBox_CorrectLetters.TabIndex = 2;
            // 
            // Button_Clear
            // 
            this.Button_Clear.Location = new System.Drawing.Point(202, 396);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(75, 23);
            this.Button_Clear.TabIndex = 3;
            this.Button_Clear.Text = "Clear";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // Label_CorrectLetters
            // 
            this.Label_CorrectLetters.AutoSize = true;
            this.Label_CorrectLetters.Location = new System.Drawing.Point(28, 125);
            this.Label_CorrectLetters.Name = "Label_CorrectLetters";
            this.Label_CorrectLetters.Size = new System.Drawing.Size(76, 13);
            this.Label_CorrectLetters.TabIndex = 4;
            this.Label_CorrectLetters.Text = "Correct Letters";
            // 
            // Label_Word
            // 
            this.Label_Word.AutoSize = true;
            this.Label_Word.Location = new System.Drawing.Point(28, 38);
            this.Label_Word.Name = "Label_Word";
            this.Label_Word.Size = new System.Drawing.Size(33, 13);
            this.Label_Word.TabIndex = 5;
            this.Label_Word.Text = "Word";
            // 
            // Button_AddWord
            // 
            this.Button_AddWord.Location = new System.Drawing.Point(41, 80);
            this.Button_AddWord.Name = "Button_AddWord";
            this.Button_AddWord.Size = new System.Drawing.Size(75, 23);
            this.Button_AddWord.TabIndex = 6;
            this.Button_AddWord.Text = "Add word";
            this.Button_AddWord.UseVisualStyleBackColor = true;
            this.Button_AddWord.Click += new System.EventHandler(this.Button_AddWord_Click);
            // 
            // Button_Reset
            // 
            this.Button_Reset.Location = new System.Drawing.Point(41, 396);
            this.Button_Reset.Name = "Button_Reset";
            this.Button_Reset.Size = new System.Drawing.Size(75, 23);
            this.Button_Reset.TabIndex = 7;
            this.Button_Reset.Text = "Reset";
            this.Button_Reset.UseVisualStyleBackColor = true;
            this.Button_Reset.Click += new System.EventHandler(this.Button_Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 450);
            this.Controls.Add(this.Button_Reset);
            this.Controls.Add(this.Button_AddWord);
            this.Controls.Add(this.Label_Word);
            this.Controls.Add(this.Label_CorrectLetters);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.TextBox_CorrectLetters);
            this.Controls.Add(this.TextBox_AddWord);
            this.Controls.Add(this.ListBox_ValidWords);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox_ValidWords;
        private System.Windows.Forms.TextBox TextBox_AddWord;
        private System.Windows.Forms.TextBox TextBox_CorrectLetters;
        private System.Windows.Forms.Button Button_Clear;
        private System.Windows.Forms.Label Label_CorrectLetters;
        private System.Windows.Forms.Label Label_Word;
        private System.Windows.Forms.Button Button_AddWord;
        private System.Windows.Forms.Button Button_Reset;
    }
}

