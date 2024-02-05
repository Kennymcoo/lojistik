namespace abp.Tools;

internal static class LogisticCalculationTool
{

    public static List<string> Calculate(int[] firstTable, int[] secondTable, int[] intValues, bool isForBandD)
    {
        int white1 = intValues[0];
        int green1 = intValues[1];
        int yellow1 = intValues[2];
        int yellow2 = intValues[3];
        int white2 = intValues[4];
        int blue1 = intValues[5];
        int red1 = intValues[6];
        int black1 = intValues[7];
        int purple1 = intValues[8];

        HashSet<double> uniqueValuesA = [];
        List<string> result = [];

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
                    result.Add($"{valueForA} ( Birinci sütün {firstTableIndex}, İkinci sutün {secondTableIndex})");
                }
            }
        }

        return result;
    }
}
