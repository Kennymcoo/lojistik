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
            int[] tablo3 = { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] tablo6 = { 3, 0, 4, 10, 20, 35, 56, 84 };

            int minLength = Math.Min(tablo3.Length, tablo6.Length);

            int beyazA1 = int.Parse(textBoxA1.Text);
            int yes�lA = int.Parse(textBoxA2.Text);
            int sar�A1 = int.Parse(textBoxA3.Text);
            int sar�A2 = int.Parse(textBoxA4.Text);
            int beyazA2 = int.Parse(textBoxA5.Text);
            int mav�A = int.Parse(textBoxA6.Text);
            int k�rm�z�A = int.Parse(textBoxA7.Text);
            int s�yahA = int.Parse(textBoxA8.Text);
            int morA = int.Parse(textBoxA9.Text);

            double[,] resultInA = new double[tablo3.Length, tablo6.Length];

            HashSet<double> uniqueValuesA = new HashSet<double>();
            listViewForA.Items.Clear();

            for (int i = 0; i < tablo3.Length; i++)
            {
                for (int x = 0; x < tablo6.Length; x++)
                {
                    double valueForA = (((tablo3[i] + tablo6[x] + beyazA1) * yes�lA + sar�A1 + sar�A2) + beyazA2 + mav�A + k�rm�z�A * s�yahA) * morA;

                    
                    if (uniqueValuesA.Add(valueForA) && valueForA <= 90 && valueForA >=-90)
                    {
                        
                        listViewForA.Items.Add(valueForA.ToString());
                        
                    }
                }
            }
            

        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            int[] tablo4 = { 8, 0, 6, 21, 56, 126 };
            int[] tablo1 = { 2, 0, 3, 6, 10, 15, 21, 28, 36 };

            int minLength = Math.Min(tablo4.Length, tablo1.Length);

            int beyazB1 = int.Parse(textBoxB1.Text);
            int yes�lB = int.Parse(textBoxB2.Text);
            int sar�B1 = int.Parse(textBoxB3.Text);
            int sar�B2 = int.Parse(textBoxB4.Text);
            int beyazB2 = int.Parse(textBoxB5.Text);
            int mav�B = int.Parse(textBoxB6.Text);
            int k�rm�z�B = int.Parse(textBoxB7.Text);
            int s�yahB = int.Parse(textBoxB8.Text);
            int morB = int.Parse(textBoxB9.Text);

            double[,] resultInB = new double[tablo4.Length, tablo1.Length];
            HashSet<double> uniqueValuesB = new HashSet<double>();
            listViewForB.Items.Clear();

            for (int i = 0; i < tablo4.Length; i++)
            {
                for (int x = 0; x < tablo1.Length; x++)
                {
                    double valueForB = (((tablo4[i] - tablo1[x] - beyazB1) * yes�lB + sar�B1 + sar�B2) + beyazB2 + mav�B + k�rm�z�B * s�yahB) * morB;
                    if (uniqueValuesB.Add(valueForB) && valueForB <= 90 && valueForB >= -90)
                    {
                        
                        listViewForB.Items.Add(valueForB.ToString());
                    }
                }
            }
            //listViewForB.Items.Clear();

          
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
            HashSet<double> uniqueValuesC = new HashSet<double>();
            listViewForC.Items.Clear();

            for (int i = 0; i < tablo5.Length; i++)
            {
                for (int x = 0; x < tablo2.Length; x++)
                {
                    double valueForC = (((tablo5[i] + tablo2[x] + beyazC1) * yes�lC + sar�C1 + sar�C2) + beyazC2 + mav�C + k�rm�z�C * s�yahC) * morC;
                    if (uniqueValuesC.Add(valueForC) && valueForC <= 90 && valueForC >= -90)
                    {
                        
                        listViewForC.Items.Add(valueForC.ToString());
                    }
                }
            }

            //listViewForC.Items.Clear();
          
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            int[] tablo6 = { 3, 0, 4, 10, 20, 35, 56, 84 };
            int[] tablo3 = { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 };


            int minLength = Math.Min(tablo6.Length, tablo3.Length);

            int beyazD1 = int.Parse(textBoxD1.Text);
            int yes�lD = int.Parse(textBoxD2.Text);
            int sar�D1 = int.Parse(textBoxD3.Text);
            int sar�D2 = int.Parse(textBoxD4.Text);
            int beyazD2 = int.Parse(textBoxD5.Text);
            int mav�D = int.Parse(textBoxD6.Text);
            int k�rm�z�D = int.Parse(textBoxD7.Text);
            int s�yahD = int.Parse(textBoxD8.Text);
            int morD = int.Parse(textBoxD9.Text);

            double[,] resultInD = new double[tablo6.Length, tablo3.Length];
            HashSet<double> uniqueValuesD = new HashSet<double>();
            listViewForD.Items.Clear();

            for (int i = 0; i < tablo6.Length; i++)
            {
                for (int x = 0; x < tablo3.Length; x++)
                {
                    double valueForD = (((tablo6[i] - tablo3[x] - beyazD1) * yes�lD + sar�D1 + sar�D2) + beyazD2 + mav�D + k�rm�z�D * s�yahD) * morD;
                    if (uniqueValuesD.Add(valueForD) && valueForD <= 90 && valueForD >= -90)
                    {
                        
                        listViewForD.Items.Add(valueForD.ToString());
                    }
                }
            }

           
            
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            int[] tablo1 = { 2, 0, 3, 6, 10, 15, 21, 28, 36 };
            int[] tablo4 = { 8, 0, 6, 21, 56, 126 };


            int minLength = Math.Min(tablo1.Length, tablo4.Length);


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
            HashSet<double> uniqueValuesE = new HashSet<double>();
            listViewForE.Items.Clear();

            for (int i = 0; i < tablo1.Length; i++)
            {
                for (int x = 0; x < tablo4.Length; x++)
                {
                    double valueForE = (((tablo1[i]  + tablo4[x] + beyazE1) * yes�lE + sar�E1 + sar�E2) + beyazE2 + mav�E + k�rm�z�E * s�yahE) * morE;
                    if (uniqueValuesE.Add(valueForE) && valueForE <= 90 && valueForE >= -90)
                    {
                        
                        listViewForE.Items.Add(valueForE.ToString());
                    }
                }
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
            HashSet<double> uniqueValuesF = new HashSet<double>();
            listViewForF.Items.Clear();

            for (int i = 0; i < tablo2.Length; i++)
            {
                for (int x = 0; x < tablo5.Length; x++)
                {
                    double valueForF = (((tablo2[i] + tablo5[x] + beyazF1) * yes�lF + sar�F1 + sar�F2) + beyazF2 + mav�F + k�rm�z�F * s�yahF) * morF;
                    if (uniqueValuesF.Add(valueForF) && valueForF <= 90 && valueForF >= -90)
                    {
                        
                        listViewForF.Items.Add(valueForF.ToString());
                    }
                }
            }

            
          
        }


       







    }
}

