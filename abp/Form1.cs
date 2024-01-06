using abp.Business;
using System.Collections.Generic;

namespace abp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();       
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        
        private void buttonExecute_Click(object sender, EventArgs e)
        {
            int[] tablo3 = [1, 0, 0, 0, 0, 0, 0, 0, 0, 0];
            int[] tablo6 = [3, 0, 4, 10, 20, 35, 56, 84];
            TextBox[] textBoxes = [textBoxA1, textBoxA2, textBoxA3, textBoxA4, textBoxA5, textBoxA6, textBoxA7, textBoxA8, textBoxA9];
            LogisticCalculation.Calculate(tablo3, tablo6, textBoxes, listViewForA, isForBandD: false);
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            int[] tablo4 = [8, 0, 6, 21, 56, 126];
            int[] tablo1 = [2, 0, 3, 6, 10, 15, 21, 28, 36];
            TextBox[] textBoxes = [textBoxB1, textBoxB2, textBoxB3, textBoxB4, textBoxB5, textBoxB6, textBoxB7, textBoxB8, textBoxB9];
            LogisticCalculation.Calculate(tablo4, tablo1, textBoxes, listViewForB, isForBandD: true);

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            int[] tablo5 = { 0, 0, 5, 15, 35, 70, 126 };
            int[] tablo2 = { 1, 0, 2, 3, 4, 5, 6, 7, 8, 9 };
            TextBox[] textBoxes = [textBoxC1, textBoxC2, textBoxC3, textBoxC4, textBoxC5, textBoxC6, textBoxC7, textBoxC8, textBoxC9];
            LogisticCalculation.Calculate(tablo5, tablo2, textBoxes, listViewForC, isForBandD: false);

        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            int[] tablo6 = { 3, 0, 4, 10, 20, 35, 56, 84 };
            int[] tablo3 = { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            TextBox[] textBoxes = [textBoxD1, textBoxD2, textBoxD3, textBoxD4, textBoxD5, textBoxD6, textBoxD7, textBoxD8, textBoxD9];
            LogisticCalculation.Calculate(tablo6, tablo3, textBoxes, listViewForD, isForBandD: true);
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            int[] tablo1 = { 2, 0, 3, 6, 10, 15, 21, 28, 36 };
            int[] tablo4 = { 8, 0, 6, 21, 56, 126 };
            TextBox[] textBoxes = [textBoxE1, textBoxE2, textBoxE3, textBoxE4, textBoxE5, textBoxE6, textBoxE7, textBoxE8, textBoxE9];
            LogisticCalculation.Calculate(tablo1, tablo4, textBoxes, listViewForE, isForBandD: false);
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            int[] tablo2 = { 1, 0, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] tablo5 = { 0, 0, 5, 15, 35, 70, 126 };
            TextBox[] textBoxes = [textBoxF1, textBoxF2, textBoxF3, textBoxF4, textBoxF5, textBoxF6, textBoxF7, textBoxF8, textBoxF9];
            LogisticCalculation.Calculate(tablo2, tablo5, textBoxes, listViewForF, isForBandD: false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonExecute_Click(null,null);
            buttonB_Click(null, null);
            buttonC_Click(null, null);
            buttonD_Click(null, null);
            buttonE_Click(null, null);
            buttonF_Click(null, null);
        }
    }
}

