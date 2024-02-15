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

    private void ButtonA_Click(object sender, EventArgs e)
    {
        TextBox[] textBoxes = [textBoxA1, textBoxA2, textBoxA3, textBoxA4, textBoxA5, textBoxA6, textBoxA7, textBoxA8, textBoxA9];


        if (!TextboxValueExtractionTool.Extract(textBoxes, out int[] values))
            return;

        var result = _viewModel.ExecuteColumn(Columns.A, values);

        listViewForA.Items.Clear();
        FillListViewWithResults(listViewForA, result);


        // List<string> listItemsA = new List<string>();

        //foreach (ListViewItem item in listViewForA.Items)
        //{
        //    listItemsA.Add(item.ToString());
        //}
        //List<ListViewItem> viewItemsA = new List<ListViewItem>();
        //viewItemsA.AddRange(listViewForA.Items.OfType<ListViewItem>());



    }



    private void ButtonB_Click(object sender, EventArgs e)
    {
        TextBox[] textBoxes = [textBoxB1, textBoxB2, textBoxB3, textBoxB4, textBoxB5, textBoxB6, textBoxB7, textBoxB8, textBoxB9];

        if (!TextboxValueExtractionTool.Extract(textBoxes, out int[] values))
            return;

        var result = _viewModel.ExecuteColumn(Columns.B, values);

        listViewForB.Items.Clear();
        FillListViewWithResults(listViewForB, result);
    }

    private void ButtonC_Click(object sender, EventArgs e)
    {
        TextBox[] textBoxes = [textBoxC1, textBoxC2, textBoxC3, textBoxC4, textBoxC5, textBoxC6, textBoxC7, textBoxC8, textBoxC9];

        if (!TextboxValueExtractionTool.Extract(textBoxes, out int[] values))
            return;

        var result = _viewModel.ExecuteColumn(Columns.C, values);

        listViewForC.Items.Clear();
        FillListViewWithResults(listViewForC, result);

    }

    private void ButtonD_Click(object sender, EventArgs e)
    {
        TextBox[] textBoxes = [textBoxD1, textBoxD2, textBoxD3, textBoxD4, textBoxD5, textBoxD6, textBoxD7, textBoxD8, textBoxD9];

        if (!TextboxValueExtractionTool.Extract(textBoxes, out int[] values))
            return;

        var result = _viewModel.ExecuteColumn(Columns.D, values);

        listViewForD.Items.Clear();
        FillListViewWithResults(listViewForD, result);
    }

    private void ButtonE_Click(object sender, EventArgs e)
    {
        TextBox[] textBoxes = [textBoxE1, textBoxE2, textBoxE3, textBoxE4, textBoxE5, textBoxE6, textBoxE7, textBoxE8, textBoxE9];

        if (!TextboxValueExtractionTool.Extract(textBoxes, out int[] values))
            return;

        var result = _viewModel.ExecuteColumn(Columns.E, values);

        listViewForE.Items.Clear();
        FillListViewWithResults(listViewForE, result);
    }

    private void ButtonF_Click(object sender, EventArgs e)
    {
        TextBox[] textBoxes = [textBoxF1, textBoxF2, textBoxF3, textBoxF4, textBoxF5, textBoxF6, textBoxF7, textBoxF8, textBoxF9];

        if (!TextboxValueExtractionTool.Extract(textBoxes, out int[] values))
            return;

        var result = _viewModel.ExecuteColumn(Columns.F, values);

        listViewForF.Items.Clear();
        FillListViewWithResults(listViewForF, result);
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