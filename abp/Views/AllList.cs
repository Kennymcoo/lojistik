using abp.Models.Enums;
using abp.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abp.Views
{
    public partial class AllList : Form
    {
        public AllList()
        {
            InitializeComponent();
           
        }
        private ListView listViewForAllCombinations;
        private static void FillListViewWithResults(ListView listview, List<string> results)
        {
            foreach (string item in results)
            {
                listview.Items.Add(item);
            }
        }



        private void ButtonForAll_Click(object sender, EventArgs e)
        {
          

            //List<string> allResults = new List<string>();

            //foreach (Columns column in Enum.GetValues(typeof(Columns)))
            //{
            //   // var result = _viewModel.ExecuteColumn(column, values);
            //    allResults.AddRange(result);
            //}

            //// Display all results in the new ListView
            //FillListViewWithResults(listViewForAllCombinations, allResults);
        }
    }
}
