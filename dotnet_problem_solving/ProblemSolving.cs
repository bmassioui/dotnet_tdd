using dotnet_problem_solving.Extensions;

namespace dotnet_problem_solving;

/// <summary>
/// Problem Solution
/// </summary>
public class ProblemSolving
{
    #region Get Longest Binary Gap
    /// <summary>
    /// Get Longest Binary Gap
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public int GetLongestBinaryGap(uint number)
    {
        var numberAsBinary = number.ToBinary();

        if (numberAsBinary.Equals("0")) return 1;

        if (!numberAsBinary.Contains("0")) return 0;

        if (!numberAsBinary.Contains("0")) return 0;

        var numberAsBinaryGaps = numberAsBinary.Split(new Char[] { '1' }, StringSplitOptions.RemoveEmptyEntries);

        return numberAsBinaryGaps.Max(gap => gap.Length);
    }
    #endregion Get Longest Binary Gap

    #region Get Unpaired element
    public int GetUnpairedElement(int[] oddArray)
    {
        if (oddArray.Length == default) return oddArray[0];

        return Array.Find(oddArray, element => oddArray.Count(e => e == element) % 2 != 0);
    }
    #endregion Get Unpaired element
}
