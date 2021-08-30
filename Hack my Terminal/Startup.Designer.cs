
namespace Hack_my_Terminal
{
    partial class Startup
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
            this.Textbox_StringLenght = new System.Windows.Forms.TextBox();
            this.Textbox_AmountofString = new System.Windows.Forms.TextBox();
            this.Label_StringLenght = new System.Windows.Forms.Label();
            this.Label_AmountofStrings = new System.Windows.Forms.Label();
            this.Button_Next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Textbox_StringLenght
            // 
            this.Textbox_StringLenght.Location = new System.Drawing.Point(148, 41);
            this.Textbox_StringLenght.Name = "Textbox_StringLenght";
            this.Textbox_StringLenght.Size = new System.Drawing.Size(100, 20);
            this.Textbox_StringLenght.TabIndex = 0;
            // 
            // Textbox_AmountofString
            // 
            this.Textbox_AmountofString.Location = new System.Drawing.Point(148, 79);
            this.Textbox_AmountofString.Name = "Textbox_AmountofString";
            this.Textbox_AmountofString.Size = new System.Drawing.Size(100, 20);
            this.Textbox_AmountofString.TabIndex = 1;
            // 
            // Label_StringLenght
            // 
            this.Label_StringLenght.AutoSize = true;
            this.Label_StringLenght.Location = new System.Drawing.Point(52, 44);
            this.Label_StringLenght.Name = "Label_StringLenght";
            this.Label_StringLenght.Size = new System.Drawing.Size(90, 13);
            this.Label_StringLenght.TabIndex = 2;
            this.Label_StringLenght.Text = "Amount of Letters";
            // 
            // Label_AmountofStrings
            // 
            this.Label_AmountofStrings.AutoSize = true;
            this.Label_AmountofStrings.Location = new System.Drawing.Point(52, 82);
            this.Label_AmountofStrings.Name = "Label_AmountofStrings";
            this.Label_AmountofStrings.Size = new System.Drawing.Size(90, 13);
            this.Label_AmountofStrings.TabIndex = 3;
            this.Label_AmountofStrings.Text = "Amount of Strings";
            // 
            // Button_Next
            // 
            this.Button_Next.Location = new System.Drawing.Point(104, 116);
            this.Button_Next.Name = "Button_Next";
            this.Button_Next.Size = new System.Drawing.Size(75, 23);
            this.Button_Next.TabIndex = 4;
            this.Button_Next.Text = "Continue";
            this.Button_Next.UseVisualStyleBackColor = true;
            this.Button_Next.Click += new System.EventHandler(this.Button_Next_Click);
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 180);
            this.Controls.Add(this.Button_Next);
            this.Controls.Add(this.Label_AmountofStrings);
            this.Controls.Add(this.Label_StringLenght);
            this.Controls.Add(this.Textbox_AmountofString);
            this.Controls.Add(this.Textbox_StringLenght);
            this.Name = "Startup";
            this.Text = "Startup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Textbox_StringLenght;
        private System.Windows.Forms.TextBox Textbox_AmountofString;
        private System.Windows.Forms.Label Label_StringLenght;
        private System.Windows.Forms.Label Label_AmountofStrings;
        private System.Windows.Forms.Button Button_Next;
    }
}