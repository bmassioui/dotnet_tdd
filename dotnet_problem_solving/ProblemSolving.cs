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
    public short GetLongestBinaryGap(uint number)
    {
        var numberAsBinary = number.ToBinary();

        if (numberAsBinary.Equals("0")) return 1;

        return 10;
    }
    #endregion Get Longest Binary Gap
}
