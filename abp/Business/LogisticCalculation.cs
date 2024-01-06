namespace abp.Business;

internal static class LogisticCalculation
{

    public static void Calculate(int[] firstTable, int[] secondTable, TextBox[] textBoxes, ListView resultListView, bool isForBandD)
    {      
        if (!ValidateTextboxes(textBoxes))
        {
            MessageBox.Show("Lütfen bütün kutuları doldurun");
            return;
        }

        int white1 = int.Parse(textBoxes[0].Text);
        int green1 = int.Parse(textBoxes[1].Text);
        int yellow1 = int.Parse(textBoxes[2].Text);
        int yellow2 = int.Parse(textBoxes[3].Text);
        int white2 = int.Parse(textBoxes[4].Text);
        int blue1 = int.Parse(textBoxes[5].Text);
        int red1 = int.Parse(textBoxes[6].Text);
        int black1 = int.Parse(textBoxes[7].Text);
        int purple1 = int.Parse(textBoxes[8].Text);

        HashSet<double> uniqueValuesA = [];
        resultListView.Items.Clear();

        for (int firstTableIndex = 0; firstTableIndex < firstTable.Length; firstTableIndex++)
        {
            for (int secondTableIndex = 0; secondTableIndex < secondTable.Length; secondTableIndex++)
            {
                double valueForA;
                if (isForBandD)
                {
                    valueForA = ((firstTable[firstTableIndex] - secondTable[secondTableIndex] - white1)
                        * green1 + yellow1 + yellow2 + white2 + blue1 + red1 * black1) * purple1;
                }
                else
                {
                    valueForA = ((firstTable[firstTableIndex] + secondTable[secondTableIndex] + white1)
                        * green1 + yellow1 + yellow2 + white2 + blue1 + red1 * black1) * purple1;
                }

                if (uniqueValuesA.Add(valueForA) && valueForA <= 90 && valueForA >= -90)
                {
                    resultListView.Items.Add(valueForA.ToString());
                }
            }
        }

    }

    private static bool ValidateTextboxes(TextBox[] textBoxes)
    {
        if (textBoxes.Length != 9)
            throw new Exception("Eksik textbox");


        foreach (TextBox box in textBoxes)
        {
            if (string.IsNullOrEmpty(box.Text))
                return false;
        }

        return true;
    }
}
