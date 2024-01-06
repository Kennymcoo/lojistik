using abp.Business;
using System.Collections.Generic;

namespace abp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 1; i <= 9; i++)
            {
                TextBox textBox = Controls.Find("textBoxA" + i, true)[0] as TextBox;
                if (textBox != null)
                {
                    textBox.KeyPress += TextBoxA_KeyPress;
                }

            }

            for (int i = 1; i <= 9; i++)
            {
                TextBox textBox = Controls.Find("textBoxB" + i, true)[0] as TextBox;
                if (textBox != null)
                {
                    textBox.KeyPress += TextBoxB_KeyPress;
                }

            }

            for (int i = 1; i <= 9; i++)
            {
                TextBox textBox = Controls.Find("textBoxC" + i, true)[0] as TextBox;
                if (textBox != null)
                {
                    textBox.KeyPress += TextBoxC_KeyPress;
                }

            }

            for (int i = 1; i <= 9; i++)
            {
                TextBox textBox = Controls.Find("textBoxD" + i, true)[0] as TextBox;
                if (textBox != null)
                {
                    textBox.KeyPress += TextBoxD_KeyPress;
                }

            }

            for (int i = 1; i <= 9; i++)
            {
                TextBox textBox = Controls.Find("textBoxE" + i, true)[0] as TextBox;
                if (textBox != null)
                {
                    textBox.KeyPress += TextBoxE_KeyPress;
                }

            }

            for (int i = 1; i <= 9; i++)
            {
                TextBox textBox = Controls.Find("textBoxF" + i, true)[0] as TextBox;
                if (textBox != null)
                {
                    textBox.KeyPress += TextBoxF_KeyPress;
                }

            }

        }

        private void TextBoxA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void TextBoxB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void TextBoxC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void TextBoxD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void TextBoxE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void TextBoxF_KeyPress(object sender, KeyPressEventArgs e)
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

            //int[] tablo3 = { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            //int[] tablo6 = { 3, 0, 4, 10, 20, 35, 56, 84 };


            double[,] resultInA = new double[tablo3.Length, tablo6.Length];

            for (int i = 0; i < tablo3.Length; i++)
            {
                for (int x = 0; x < tablo6.Length; x++)
                {
                    resultInA[i, x] = (((tablo3[i] + tablo6[x] + beyazA1) * yes�lA + sar�A1 + sar�A2) + beyazA2 + mav�A + k�rm�z�A * s�yahA) * morA;
                }
            }

            listViewForA.Items.Clear();
            foreach (int sonucA in resultInA)
            {
                listViewForA.Items.Add(sonucA.ToString());
            }
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            int[] tablo4 = [8, 0, 6, 21, 56, 126];
            int[] tablo1 = [2, 0, 3, 6, 10, 15, 21, 28, 36];
            TextBox[] textBoxes = [textBoxB1, textBoxB2, textBoxB3, textBoxB4, textBoxB5, textBoxB6, textBoxB7, textBoxB8, textBoxB9];
            LogisticCalculation.Calculate(tablo4, tablo1, textBoxes, listViewForB, isForBandD: true);

            //int[] tablo4 = { 8, 0, 6, 21, 56, 126 };
            //int[] tablo1 = { 2, 0, 3, 6, 10, 15, 21, 28, 36 };



            //int beyazB1 = int.Parse(textBoxB1.Text);
            //int yes�lB = int.Parse(textBoxB2.Text);
            //int sar�B1 = int.Parse(textBoxB3.Text);
            //int sar�B2 = int.Parse(textBoxB4.Text);
            //int beyazB2 = int.Parse(textBoxB5.Text);
            //int mav�B = int.Parse(textBoxB6.Text);
            //int k�rm�z�B = int.Parse(textBoxB7.Text);
            //int s�yahB = int.Parse(textBoxB8.Text);
            //int morB = int.Parse(textBoxB9.Text);

            int minLength = Math.Min(tablo4.Length, tablo1.Length);

            //for (int i = 0; i < tablo4.Length; i++)
            //{
            //    for (int x = 0; x < tablo1.Length; x++)
            //    {
            //        double valueForB = (((tablo4[i] - tablo1[x] - beyazB1) * yes�lB + sar�B1 + sar�B2) + beyazB2 + mav�B + k�rm�z�B * s�yahB) * morB;
            //        if (uniqueValuesB.Add(valueForB) && valueForB <= 90 && valueForB >= -90)
            //        {

            double[,] resultInB = new double[tablo4.Length, tablo1.Length];

            for (int i = 0; i < tablo4.Length; i++)
            {
                for (int x = 0; x < tablo1.Length; x++)
                {
                    resultInB[i, x] = (((tablo4[i] - tablo1[x] - beyazB1) * yes�lB + sar�B1 + sar�B2) + beyazB2 + mav�B + k�rm�z�B * s�yahB) * morB;
                }
            }

            listViewForB.Items.Clear();
            foreach (int sonucB in resultInB)
            {
                listViewForB.Items.Add(sonucB.ToString());
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            int[] tablo5 = { 0, 0, 5, 15, 35, 70, 126 };
            int[] tablo2 = { 1, 0, 2, 3, 4, 5, 6, 7, 8, 9 };

            int minLength = Math.Min(tablo5.Length, tablo2.Length);


            int beyazC1 = int.Parse(textBoxC1.Text);
            int yes�lC = int.Parse(textBoxC2.Text);
            int sar�C1 = int.Parse(textBoxC3.Text);
            int sar�C2 = int.Parse(textBoxC4.Text);
            int beyazC2 = int.Parse(textBoxC5.Text);
            int mav�C = int.Parse(textBoxC6.Text);
            int k�rm�z�C = int.Parse(textBoxC7.Text);
            int s�yahC = int.Parse(textBoxC8.Text);
            int morC = int.Parse(textBoxC9.Text);

            double[,] resultInC = new double[tablo5.Length, tablo2.Length];

            for (int i = 0; i < tablo5.Length; i++)
            {
                for (int x = 0; x < tablo2.Length; x++)
                {
                    resultInC[i, x] = (((tablo5[i] + tablo2[x] + beyazC1) * yes�lC + sar�C1 + sar�C2) + beyazC2 + mav�C + k�rm�z�C * s�yahC) * morC;
                }
            }

            listViewForC.Items.Clear();
            foreach (int sonucC in resultInC)
            {
                listViewForC.Items.Add(sonucC.ToString());
            }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            int[] tablo6 = { 3, 0, 4, 10, 20, 35, 56, 84 };
            int[] tablo3 = { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 };


            int minLength = Math.Min(tablo3.Length, tablo6.Length);

            int beyazD1 = int.Parse(textBoxD1.Text);
            int yes�lD = int.Parse(textBoxD2.Text);
            int sar�D1 = int.Parse(textBoxD3.Text);
            int sar�D2 = int.Parse(textBoxD4.Text);
            int beyazD2 = int.Parse(textBoxD5.Text);
            int mav�D = int.Parse(textBoxD6.Text);
            int k�rm�z�D = int.Parse(textBoxD7.Text);
            int s�yahD = int.Parse(textBoxD8.Text);
            int morD = int.Parse(textBoxD9.Text);

            double[,] resultInD = new double[tablo3.Length, tablo6.Length];

            for (int i = 0; i < tablo3.Length; i++)
            {
                for (int x = 0; x < tablo6.Length; x++)
                {
                    resultInD[i, x] = (((tablo3[i] - tablo6[x] - beyazD1) * yes�lD + sar�D1 + sar�D2) + beyazD2 + mav�D + k�rm�z�D * s�yahD) * morD;
                }
            }

            listViewForD.Items.Clear();
            foreach (int sonucD in resultInD)
            {
                listViewForD.Items.Add(sonucD.ToString());
            }
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            int[] tablo1 = { 2, 0, 3, 6, 10, 15, 21, 28, 36 };
            int[] tablo4 = { 8, 0, 6, 21, 56, 126 };


            //int minLength = Math.Min(tablo1.Length, tablo4.Length);



            int beyazE1 = int.Parse(textBoxE1.Text);
            int yes�lE = int.Parse(textBoxE2.Text);
            int sar�E1 = int.Parse(textBoxE3.Text);
            int sar�E2 = int.Parse(textBoxE4.Text);
            int beyazE2 = int.Parse(textBoxE5.Text);
            int mav�E = int.Parse(textBoxE6.Text);
            int k�rm�z�E = int.Parse(textBoxE7.Text);
            int s�yahE = int.Parse(textBoxE8.Text);
            int morE = int.Parse(textBoxE9.Text);

            double[,] resultInE = new double[tablo1.Length, tablo4.Length];

            for (int i = 0; i < tablo1.Length; i++)
            {
                for (int x = 0; x < tablo4.Length; x++)
                {
                    resultInE[i, x] = (((tablo1[i]  + tablo4[x] + beyazE1) * yes�lE + sar�E1 + sar�E2) + beyazE2 + mav�E + k�rm�z�E * s�yahE) * morE;
                }
            }

            listViewForE.Items.Clear();
            foreach (int sonucE in resultInE)
            {
                listViewForE.Items.Add(sonucE.ToString());
            }
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            int[] tablo2 = { 1, 0, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] tablo5 = { 0, 0, 5, 15, 35, 70, 126 };


            int minLength = Math.Min(tablo2.Length, tablo5.Length);

            int beyazF1 = int.Parse(textBoxF1.Text);
            int yes�lF = int.Parse(textBoxF2.Text);
            int sar�F1 = int.Parse(textBoxF3.Text);
            int sar�F2 = int.Parse(textBoxF4.Text);
            int beyazF2 = int.Parse(textBoxF5.Text);
            int mav�F = int.Parse(textBoxF6.Text);
            int k�rm�z�F = int.Parse(textBoxF7.Text);
            int s�yahF = int.Parse(textBoxF8.Text);
            int morF = int.Parse(textBoxF9.Text);

            double[,] resultInF = new double[tablo2.Length, tablo5.Length];

            for (int i = 0; i < tablo2.Length; i++)
            {
                for (int x = 0; x < tablo5.Length; x++)
                {
                    resultInF[i, x] = (((tablo2[i] + tablo5[x] + beyazF1) * yes�lF + sar�F1 + sar�F2) + beyazF2 + mav�F + k�rm�z�F * s�yahF) * morF;
                }
            }

            listViewForF.Items.Clear();
            foreach (int sonucF in resultInF)
            {
                listViewForF.Items.Add(sonucF.ToString());
            }
        }


       







    }
}

