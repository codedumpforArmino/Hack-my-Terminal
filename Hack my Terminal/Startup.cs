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
    public partial class Startup : Form
    {
        public static int StringLenght;
        public static int WordAmount;

        public Startup()
        {
            InitializeComponent();
        }

        private void Button_Next_Click(object sender, EventArgs e)
        {
            StringLenght = Convert.ToInt32(Textbox_StringLenght.Text);
            WordAmount = Convert.ToInt32(Textbox_AmountofString.Text);

            Form1 F1 = new Form1();
            this.Hide();
            F1.ShowDialog();
            this.Close();
        }
    }
}
