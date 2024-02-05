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

    private static void FillListViewWithResults(ListView listview, List<string> result  )
    {
        foreach (string item in result)
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
       

        FillListViewWithResults(listViewForA, result );
    }

    

    private void ButtonB_Click(object sender, EventArgs e)
    {
        TextBox[] textBoxes = [textBoxB1, textBoxB2, textBoxB3, textBoxB4, textBoxB5, textBoxB6, textBoxB7, textBoxB8, textBoxB9];

        if (!TextboxValueExtractionTool.Extract(textBoxes, out int[] values))
            return;

        var result = _viewModel.ExecuteColumn(Columns.B, values);
        

        FillListViewWithResults(listViewForB, result);
    }

    private void ButtonC_Click(object sender, EventArgs e)
    {
        TextBox[] textBoxes = [textBoxC1, textBoxC2, textBoxC3, textBoxC4, textBoxC5, textBoxC6, textBoxC7, textBoxC8, textBoxC9];

        if (!TextboxValueExtractionTool.Extract(textBoxes, out int[] values))
            return;

        var result = _viewModel.ExecuteColumn(Columns.C, values);
        

        FillListViewWithResults(listViewForC, result);
    }

    private void ButtonD_Click(object sender, EventArgs e)
    {
        TextBox[] textBoxes = [textBoxD1, textBoxD2, textBoxD3, textBoxD4, textBoxD5, textBoxD6, textBoxD7, textBoxD8, textBoxD9];

        if (!TextboxValueExtractionTool.Extract(textBoxes, out int[] values))
            return;

        var result = _viewModel.ExecuteColumn(Columns.D, values);
        

        FillListViewWithResults(listViewForD, result);
    }

    private void ButtonE_Click(object sender, EventArgs e)
    {
        TextBox[] textBoxes = [textBoxE1, textBoxE2, textBoxE3, textBoxE4, textBoxE5, textBoxE6, textBoxE7, textBoxE8, textBoxE9];

        if (!TextboxValueExtractionTool.Extract(textBoxes, out int[] values))
            return;

        var result = _viewModel.ExecuteColumn(Columns.E, values);
        

        FillListViewWithResults(listViewForE, result);    
    }

    private void ButtonF_Click(object sender, EventArgs e)
    {
        TextBox[] textBoxes = [textBoxF1, textBoxF2, textBoxF3, textBoxF4, textBoxF5, textBoxF6, textBoxF7, textBoxF8, textBoxF9];

        if (!TextboxValueExtractionTool.Extract(textBoxes, out int[] values))
            return;

        var result = _viewModel.ExecuteColumn(Columns.F, values);
       

        FillListViewWithResults(listViewForF, result);          
    }

    private void ButtonExecuteAll_Click(object sender, EventArgs e)
    {

        for (int i = 0; i < 9; i++)
        {
            char columnChar = (char)('A' + i);
            string columnName = "listViewFor" + columnChar;

            
            TextBox[] textBoxes = Controls.OfType<TextBox>()
                                          .Where(tb => tb.Name.StartsWith("textBox" + columnChar))
                                          .OrderBy(tb => tb.Name)
                                          .ToArray();

            if (!TextboxValueExtractionTool.Extract(textBoxes, out int[] values))
                return;

            
            var result = _viewModel.ExecuteColumn((Columns)columnChar, values);

            
            FillListViewWithResults(listViewShowAll, result);
        }
        //ButtonA_Click(sender, e);
        //ButtonB_Click(sender, e);
        //ButtonC_Click(sender, e);
        //ButtonD_Click(sender, e);
        //ButtonE_Click(sender, e);
        //ButtonF_Click(sender, e);


    }
}