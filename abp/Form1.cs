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
            int yesýlA = int.Parse(textBoxA2.Text);
            int sarýA1 = int.Parse(textBoxA3.Text);
            int sarýA2 = int.Parse(textBoxA4.Text);
            int beyazA2 = int.Parse(textBoxA5.Text);
            int mavýA = int.Parse(textBoxA6.Text);
            int kýrmýzýA = int.Parse(textBoxA7.Text);
            int sýyahA = int.Parse(textBoxA8.Text);
            int morA = int.Parse(textBoxA9.Text);

            double[,] resultInA = new double[tablo3.Length, tablo6.Length];

            HashSet<double> uniqueValuesA = new HashSet<double>();
            listViewForA.Items.Clear();

            for (int i = 0; i < tablo3.Length; i++)
            {
                for (int x = 0; x < tablo6.Length; x++)
                {
                    double valueForA = (((tablo3[i] + tablo6[x] + beyazA1) * yesýlA + sarýA1 + sarýA2) + beyazA2 + mavýA + kýrmýzýA * sýyahA) * morA;

                    
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
            int yesýlB = int.Parse(textBoxB2.Text);
            int sarýB1 = int.Parse(textBoxB3.Text);
            int sarýB2 = int.Parse(textBoxB4.Text);
            int beyazB2 = int.Parse(textBoxB5.Text);
            int mavýB = int.Parse(textBoxB6.Text);
            int kýrmýzýB = int.Parse(textBoxB7.Text);
            int sýyahB = int.Parse(textBoxB8.Text);
            int morB = int.Parse(textBoxB9.Text);

            double[,] resultInB = new double[tablo4.Length, tablo1.Length];
            HashSet<double> uniqueValuesB = new HashSet<double>();
            listViewForB.Items.Clear();

            for (int i = 0; i < tablo4.Length; i++)
            {
                for (int x = 0; x < tablo1.Length; x++)
                {
                    double valueForB = (((tablo4[i] - tablo1[x] - beyazB1) * yesýlB + sarýB1 + sarýB2) + beyazB2 + mavýB + kýrmýzýB * sýyahB) * morB;
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
            int yesýlC = int.Parse(textBoxC2.Text);
            int sarýC1 = int.Parse(textBoxC3.Text);
            int sarýC2 = int.Parse(textBoxC4.Text);
            int beyazC2 = int.Parse(textBoxC5.Text);
            int mavýC = int.Parse(textBoxC6.Text);
            int kýrmýzýC = int.Parse(textBoxC7.Text);
            int sýyahC = int.Parse(textBoxC8.Text);
            int morC = int.Parse(textBoxC9.Text);

            double[,] resultInC = new double[tablo5.Length, tablo2.Length];
            HashSet<double> uniqueValuesC = new HashSet<double>();
            listViewForC.Items.Clear();

            for (int i = 0; i < tablo5.Length; i++)
            {
                for (int x = 0; x < tablo2.Length; x++)
                {
                    double valueForC = (((tablo5[i] + tablo2[x] + beyazC1) * yesýlC + sarýC1 + sarýC2) + beyazC2 + mavýC + kýrmýzýC * sýyahC) * morC;
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
            int yesýlD = int.Parse(textBoxD2.Text);
            int sarýD1 = int.Parse(textBoxD3.Text);
            int sarýD2 = int.Parse(textBoxD4.Text);
            int beyazD2 = int.Parse(textBoxD5.Text);
            int mavýD = int.Parse(textBoxD6.Text);
            int kýrmýzýD = int.Parse(textBoxD7.Text);
            int sýyahD = int.Parse(textBoxD8.Text);
            int morD = int.Parse(textBoxD9.Text);

            double[,] resultInD = new double[tablo6.Length, tablo3.Length];
            HashSet<double> uniqueValuesD = new HashSet<double>();
            listViewForD.Items.Clear();

            for (int i = 0; i < tablo6.Length; i++)
            {
                for (int x = 0; x < tablo3.Length; x++)
                {
                    double valueForD = (((tablo6[i] - tablo3[x] - beyazD1) * yesýlD + sarýD1 + sarýD2) + beyazD2 + mavýD + kýrmýzýD * sýyahD) * morD;
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
            int yesýlE = int.Parse(textBoxE2.Text);
            int sarýE1 = int.Parse(textBoxE3.Text);
            int sarýE2 = int.Parse(textBoxE4.Text);
            int beyazE2 = int.Parse(textBoxE5.Text);
            int mavýE = int.Parse(textBoxE6.Text);
            int kýrmýzýE = int.Parse(textBoxE7.Text);
            int sýyahE = int.Parse(textBoxE8.Text);
            int morE = int.Parse(textBoxE9.Text);

            double[,] resultInE = new double[tablo1.Length, tablo4.Length];
            HashSet<double> uniqueValuesE = new HashSet<double>();
            listViewForE.Items.Clear();

            for (int i = 0; i < tablo1.Length; i++)
            {
                for (int x = 0; x < tablo4.Length; x++)
                {
                    double valueForE = (((tablo1[i]  + tablo4[x] + beyazE1) * yesýlE + sarýE1 + sarýE2) + beyazE2 + mavýE + kýrmýzýE * sýyahE) * morE;
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
            int yesýlF = int.Parse(textBoxF2.Text);
            int sarýF1 = int.Parse(textBoxF3.Text);
            int sarýF2 = int.Parse(textBoxF4.Text);
            int beyazF2 = int.Parse(textBoxF5.Text);
            int mavýF = int.Parse(textBoxF6.Text);
            int kýrmýzýF = int.Parse(textBoxF7.Text);
            int sýyahF = int.Parse(textBoxF8.Text);
            int morF = int.Parse(textBoxF9.Text);

            double[,] resultInF = new double[tablo2.Length, tablo5.Length];
            HashSet<double> uniqueValuesF = new HashSet<double>();
            listViewForF.Items.Clear();

            for (int i = 0; i < tablo2.Length; i++)
            {
                for (int x = 0; x < tablo5.Length; x++)
                {
                    double valueForF = (((tablo2[i] + tablo5[x] + beyazF1) * yesýlF + sarýF1 + sarýF2) + beyazF2 + mavýF + kýrmýzýF * sýyahF) * morF;
                    if (uniqueValuesF.Add(valueForF) && valueForF <= 90 && valueForF >= -90)
                    {
                        
                        listViewForF.Items.Add(valueForF.ToString());
                    }
                }
            }

            
          
        }


       







    }
}

