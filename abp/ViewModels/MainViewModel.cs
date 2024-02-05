using abp.Models.Enums;
using abp.Tools;

namespace abp.ViewModels;

internal class MainViewModel
{
    internal List<string> ExecuteColumn(Columns column, int[] textboxValues)
    {
        int[] firstTable;
        int[] secondTable;
        bool isForBandD = false;

        switch (column)
        {
            default:
            case Columns.A:
                firstTable = [1, 0, 0, 0, 0, 0, 0, 0, 0, 0];
                secondTable = [3, 0, 4, 10, 20, 35, 56, 84];
                break;

            case Columns.B:
                firstTable = [8, 0, 6, 21, 56, 126];
                secondTable = [2, 0, 3, 6, 10, 15, 21, 28, 36];
                isForBandD = true;
                break;

            case Columns.C:
                firstTable = [0, 0, 5, 15, 35, 70, 126];
                secondTable = [1, 0, 2, 3, 4, 5, 6, 7, 8, 9 ];
                break;

            case Columns.D:
                firstTable = [ 3, 0, 4, 10, 20, 35, 56, 84 ];
                secondTable = [ 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 ];
                isForBandD = true;
                break;

            case Columns.E:
                firstTable = [ 2, 0, 3, 6, 10, 15, 21, 28, 36 ];
                secondTable = [ 8, 0, 6, 21, 56, 126 ];
                break;
                
            case Columns.F:
                firstTable = [ 1, 0, 2, 3, 4, 5, 6, 7, 8, 9 ];
                secondTable = [ 0, 0, 5, 15, 35, 70, 126 ];
                break;

        }

        return LogisticCalculationTool.Calculate(firstTable, secondTable, textboxValues, isForBandD);
    }
  



}
