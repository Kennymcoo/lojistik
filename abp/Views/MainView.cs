using abp.Models.Enums;
using abp.Tools;
using abp.ViewModels;
using abp.Views;

namespace abp;

public partial class MainView : Form
{
    private readonly MainViewModel _viewModel;

    public MainView()
    {
        InitializeComponent();
        _viewModel = new MainViewModel();
    }

    private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != '.'))
        {
            e.Handled = true;
        }
    }

    private static void FillListViewWithResults(ListView listview, List<string> result)
    {
        foreach (string item in result)
        {
            listview.Items.Add(item);
        }


    }
    private static void FillListViewWithItems(ListView listview, List<string> listItems)
    {
        foreach (string item in listItems)
        {
            listview.Items.Add(item);
        }


    }

    private void ProcessAndDisplaySum(TextBox inputTextBox)
    {
        if (int.TryParse(inputTextBox.Text, out int number))
        {
            
            var digits = inputTextBox.Text.Select(digit => int.Parse(digit.ToString())).ToArray();

          
        }
     
    }

    private void ButtonA_Click(object sender, EventArgs e)
    {
        TextBox[] textBoxes = { textBoxA1, textBoxA2, textBoxA3, textBoxA4, textBoxA5, textBoxA6, textBoxA7, textBoxA8, textBoxA9 };

        if (!TextboxValueExtractionTool.Extract(textBoxes, out int[] values))
            return;

        int[] digitsA1 = null;
        int[] digitsA2 = null;

        if (textBoxAResult1.Text.Contains(",") || int.TryParse(textBoxAResult1.Text, out int _))
        {
            digitsA1 = textBoxAResult1.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();
        }

        // textBoxAResult2 için dönüþüm
        if (textBoxAResult2.Text.Contains(",") || int.TryParse(textBoxAResult2.Text, out int _))
        {
            digitsA2 = textBoxAResult2.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();
        }

        if (digitsA1 == null && digitsA2 == null)
        {
            var result = _viewModel.ExecuteColumn(Columns.A, values);

            listViewForA.Items.Clear();
            FillListViewWithResults(listViewForA, result);
        }
        else
        {
            foreach (var digitA1 in digitsA1)
            {
                foreach (var digitA2 in digitsA2)
                {
                    var calculationResult = ((digitA1 - digitA2 - int.Parse(textBoxA1.Text)) * int.Parse(textBoxA2.Text) + int.Parse(textBoxA3.Text) + int.Parse(textBoxA4.Text) + int.Parse(textBoxA5.Text) + int.Parse(textBoxA6.Text) + int.Parse(textBoxA7.Text) * int.Parse(textBoxA8.Text)) + int.Parse(textBoxA9.Text);
                    

                    
                    listViewForA.Items.Add(calculationResult.ToString());
                }
            }

        }
    }




    private void ButtonB_Click(object sender, EventArgs e)
    {
        TextBox[] textBoxes = [textBoxB1, textBoxB2, textBoxB3, textBoxB4, textBoxB5, textBoxB6, textBoxB7, textBoxB8, textBoxB9];

        if (!TextboxValueExtractionTool.Extract(textBoxes, out int[] values))
            return;


        int[] digitsB1 = null;
        int[] digitsB2 = null;

        if (textBoxBResult1.Text.Contains(",") || int.TryParse(textBoxBResult1.Text, out int _))
        {
            digitsB1 = textBoxBResult1.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();
        }

        // textBoxAResult2 için dönüþüm
        if (textBoxBResult2.Text.Contains(",") || int.TryParse(textBoxBResult2.Text, out int _))
        {
            digitsB2 = textBoxBResult2.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();
        }

        if (digitsB1 == null && digitsB2 == null)
        {
            var result = _viewModel.ExecuteColumn(Columns.B, values);

            listViewForB.Items.Clear();
            FillListViewWithResults(listViewForB, result);
        }
        else
        {
            foreach (var digitB1 in digitsB1)
            {
                foreach (var digitB2 in digitsB2)
                {
                    var calculationResult = ((digitB1 - digitB2 - int.Parse(textBoxB1.Text)) * int.Parse(textBoxB2.Text) + int.Parse(textBoxB3.Text) + int.Parse(textBoxB4.Text) + int.Parse(textBoxB5.Text) + int.Parse(textBoxB6.Text) + int.Parse(textBoxB7.Text) * int.Parse(textBoxB8.Text)) + int.Parse(textBoxB9.Text);



                    listViewForB.Items.Add(calculationResult.ToString());
                }
            }

        }

    }

    private void ButtonC_Click(object sender, EventArgs e)
    {
        TextBox[] textBoxes = [textBoxC1, textBoxC2, textBoxC3, textBoxC4, textBoxC5, textBoxC6, textBoxC7, textBoxC8, textBoxC9];

        if (!TextboxValueExtractionTool.Extract(textBoxes, out int[] values))
            return;

        int[] digitsC1 = null;
        int[] digitsC2 = null;

        if (textBoxCResult1.Text.Contains(",") || int.TryParse(textBoxCResult1.Text, out int _))
        {
            digitsC1 = textBoxCResult1.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();
        }

        
        if (textBoxCResult2.Text.Contains(",") || int.TryParse(textBoxCResult2.Text, out int _))
        {
            digitsC2 = textBoxCResult2.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();
        }

        if (digitsC1 == null && digitsC2 == null)
        {
            var result = _viewModel.ExecuteColumn(Columns.C, values);

            listViewForB.Items.Clear();
            FillListViewWithResults(listViewForC, result);
        }
        else
        {
            foreach (var digitC1 in digitsC1)
            {
                foreach (var digitC2 in digitsC2)
                {
                    var calculationResult = ((digitC1 - digitC2 - int.Parse(textBoxC1.Text)) * int.Parse(textBoxC2.Text) + int.Parse(textBoxC3.Text) + int.Parse(textBoxC4.Text) + int.Parse(textBoxC5.Text) + int.Parse(textBoxC6.Text) + int.Parse(textBoxC7.Text) * int.Parse(textBoxC8.Text)) + int.Parse(textBoxC9.Text);



                    listViewForC.Items.Add(calculationResult.ToString());
                }
            }

        }

    }

    private void ButtonD_Click(object sender, EventArgs e)
    {
        TextBox[] textBoxes = [textBoxD1, textBoxD2, textBoxD3, textBoxD4, textBoxD5, textBoxD6, textBoxD7, textBoxD8, textBoxD9];

        if (!TextboxValueExtractionTool.Extract(textBoxes, out int[] values))
            return;


        int[] digitsD1 = null;
        int[] digitsD2 = null;

        if (textBoxDResult1.Text.Contains(",") || int.TryParse(textBoxDResult1.Text, out int _))
        {
            digitsD1 = textBoxDResult1.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();
        }


        if (textBoxDResult2.Text.Contains(",") || int.TryParse(textBoxDResult2.Text, out int _))
        {
            digitsD2 = textBoxDResult2.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();
        }

        if (digitsD1 == null && digitsD2 == null)
        {
            var result = _viewModel.ExecuteColumn(Columns.D, values);

            listViewForD.Items.Clear();
            FillListViewWithResults(listViewForD, result);
        }
        else
        {
            foreach (var digitD1 in digitsD1)
            {
                foreach (var digitD2 in digitsD2)
                {
                    var calculationResult = ((digitD1 - digitD2 - int.Parse(textBoxD1.Text)) * int.Parse(textBoxD2.Text) + int.Parse(textBoxD3.Text) + int.Parse(textBoxD4.Text) + int.Parse(textBoxD5.Text) + int.Parse(textBoxD6.Text) + int.Parse(textBoxD7.Text) * int.Parse(textBoxD8.Text)) + int.Parse(textBoxD9.Text);



                    listViewForD.Items.Add(calculationResult.ToString());
                }
            }

        }
    }

    private void ButtonE_Click(object sender, EventArgs e)
    {
        TextBox[] textBoxes = [textBoxE1, textBoxE2, textBoxE3, textBoxE4, textBoxE5, textBoxE6, textBoxE7, textBoxE8, textBoxE9];

        if (!TextboxValueExtractionTool.Extract(textBoxes, out int[] values))
            return;


        int[] digitsE1 = null;
        int[] digitsE2 = null;

        if (textBoxEResult1.Text.Contains(",") || int.TryParse(textBoxEResult1.Text, out int _))
        {
            digitsE1 = textBoxEResult1.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();
        }


        if (textBoxEResult2.Text.Contains(",") || int.TryParse(textBoxEResult2.Text, out int _))
        {
            digitsE2 = textBoxEResult2.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();
        }

        if (digitsE1 == null && digitsE2 == null)
        {
            var result = _viewModel.ExecuteColumn(Columns.E, values);

            listViewForE.Items.Clear();
            FillListViewWithResults(listViewForE, result);
        }
        else
        {
            foreach (var digitE1 in digitsE1)
            {
                foreach (var digitE2 in digitsE2)
                {
                    var calculationResult = ((digitE1 - digitE2 - int.Parse(textBoxE1.Text)) * int.Parse(textBoxE2.Text) + int.Parse(textBoxE3.Text) + int.Parse(textBoxE4.Text) + int.Parse(textBoxE5.Text) + int.Parse(textBoxE6.Text) + int.Parse(textBoxE7.Text) * int.Parse(textBoxE8.Text)) + int.Parse(textBoxE9.Text);



                    listViewForE.Items.Add(calculationResult.ToString());
                }
            }

        }
    }

    private void ButtonF_Click(object sender, EventArgs e)
    {
        TextBox[] textBoxes = [textBoxF1, textBoxF2, textBoxF3, textBoxF4, textBoxF5, textBoxF6, textBoxF7, textBoxF8, textBoxF9];

        if (!TextboxValueExtractionTool.Extract(textBoxes, out int[] values))
            return;


        int[] digitsF1 = null;
        int[] digitsF2 = null;

        if (textBoxFResult1.Text.Contains(",") || int.TryParse(textBoxFResult1.Text, out int _))
        {
            digitsF1 = textBoxFResult1.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();
        }


        if (textBoxFResult2.Text.Contains(",") || int.TryParse(textBoxFResult2.Text, out int _))
        {
            digitsF2 = textBoxFResult2.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();
        }

        if (digitsF1 == null && digitsF2 == null)
        {
            var result = _viewModel.ExecuteColumn(Columns.F, values);

            listViewForF.Items.Clear();
            FillListViewWithResults(listViewForF, result);
        }
        else
        {
            foreach (var digitF1 in digitsF1)
            {
                foreach (var digitF2 in digitsF2)
                {
                    var calculationResult = ((digitF1 - digitF2 - int.Parse(textBoxF1.Text)) * int.Parse(textBoxF2.Text) + int.Parse(textBoxF3.Text) + int.Parse(textBoxF4.Text) + int.Parse(textBoxF5.Text) + int.Parse(textBoxF6.Text) + int.Parse(textBoxF7.Text) * int.Parse(textBoxF8.Text)) + int.Parse(textBoxF9.Text);



                    listViewForF.Items.Add(calculationResult.ToString());
                }
            }

        }
    }
    private bool AreAllItemsUnique(params string[] items)
    {
        HashSet<string> uniqueItems = new HashSet<string>();
        foreach (string item in items)
        {
            if (!uniqueItems.Add(item))
            {
                return false;
            }
        }
        return true;
    }

    private void ButtonExecuteAll_Click(object sender, EventArgs e)
    {
        ButtonA_Click(sender, e);
        ButtonB_Click(sender, e);
        ButtonC_Click(sender, e);
        ButtonD_Click(sender, e);
        ButtonE_Click(sender, e);
        ButtonF_Click(sender, e);


        List<string> listItemsA = new List<string>();
        foreach (ListViewItem item in listViewForA.Items)
        {
            listItemsA.Add(item.ToString());
        }

        List<string> listItemsB = new List<string>();
        foreach (ListViewItem item in listViewForB.Items)
        {
            listItemsB.Add(item.ToString());
        }

        List<string> listItemsC = new List<string>();
        foreach (ListViewItem item in listViewForC.Items)
        {
            listItemsC.Add(item.ToString());
        }

        List<string> listItemsD = new List<string>();
        foreach (ListViewItem item in listViewForD.Items)
        {
            listItemsD.Add(item.ToString());
        }

        List<string> listItemsE = new List<string>();
        foreach (ListViewItem item in listViewForE.Items)
        {
            listItemsE.Add(item.ToString());
        }

        List<string> listItemsF = new List<string>();
        foreach (ListViewItem item in listViewForF.Items)
        {
            listItemsF.Add(item.ToString());
        }

        List<string> result = new List<string>();

        foreach (string itemA in listItemsA)
        {
            foreach (string itemB in listItemsB)
            {
                foreach (string itemC in listItemsC)
                {
                    foreach (string itemD in listItemsD)
                    {
                        foreach (string itemE in listItemsE)
                        {
                            foreach (string itemF in listItemsF)
                            {
                                // Check if all items in the combination are unique
                                if (AreAllItemsUnique(itemA, itemB, itemC, itemD, itemE, itemF))
                                {
                                    result.Add($"{itemA}, {itemB}, {itemC}, {itemD}, {itemE}, {itemF}");
                                }
                            }
                        }
                    }
                }
            }
        }

        FillListViewWithResults(listViewShowAll, result);

        // Helper method to check if a combination is unique





    }

   
}