namespace abp.Tools;

internal static class TextboxValueExtractionTool
{
    internal static bool Extract(TextBox[] textBoxes, out int[] result)
    {
        if (textBoxes.Length != 9)
            throw new Exception("9 adet textbox girilmedi");
 
        result = new int[textBoxes.Length];
        for (int index = 0; index < textBoxes.Length; index++) 
        {
            TextBox box = textBoxes[index];
            if (box.Text.Length == 0)
            {
                MessageBox.Show("Lütfen bütün kutuları doldurun");
                return false;
            }

            if(!int.TryParse(box.Text, out int intValue))
            {
                MessageBox.Show("Lütfen bütün kutuları doldurun");
                return false;
            }

            result[index] = intValue;
        }

        return true;
    }
}
