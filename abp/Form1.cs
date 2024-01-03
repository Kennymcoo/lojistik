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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TextBoxB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TextBoxC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TextBoxD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TextBoxE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TextBoxF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            int[] tablo3 = {1,0,0,0,0,0,0,0,0,0 };
            int[] tablo6 = { 3, 0, 4, 10, 20, 35, 56, 84 };

            int minLength = Math.Min(tablo3.Length, tablo6.Length);

            int beyazA1 = textBoxA1.Text.Length;
            int yesýlA = textBoxA2.Text.Length;
            int sarýA1 = textBoxA3.Text.Length;
            int sarýA2 = textBoxA4.Text.Length;
            int beyazA2 = textBoxA5.Text.Length;
            int mavýA = textBoxA6.Text.Length;
            int kýrmýzýA = textBoxA7.Text.Length;
            int sýyahA = textBoxA8.Text.Length;
            int morA = textBoxA9.Text.Length;

            int[,] resultInA = new int[tablo3.Length, tablo6.Length];
            // int[] resultIntable;

            for (int i = 0; i < tablo3.Length; i++)
            {
                for (int x = 0; x < tablo6.Length; x++)
                {



                    resultInA[i, x] = (((tablo3[i] + tablo6[x] + beyazA1) * yesýlA + sarýA1 + sarýA2) + beyazA2 + mavýA + kýrmýzýA * (-1 * sýyahA)) * morA;
                        
                    
                }
            }

            //for (int i = 0; i < minLength; i++)
            //{
            //    resultInA[i] = (((tablo3[i] + tablo6[i] + beyazA1)* yesýlA+sarýA1+sarýA2)+beyazA2+mavýA+kýrmýzýA * (-1*sýyahA))*morA;
            //}

            listViewForA.Items.Clear();
            foreach (int sonucA in resultInA) 
            {
                listViewForA.Items.Add(sonucA.ToString());
            }

            
            

            
        }
    }
}
