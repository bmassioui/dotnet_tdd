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

    #region Rotate Array K times
    /// <summary>
    /// Rotate an Array K times - by moving last to first
    /// array = [1,2,3,4]
    /// 3 time
    /// [1,2,3,4] => [4,1,2,3] -- 1
    /// [4,1,2,3] => [3,4,1,2] -- 2
    /// [3,4,1,2] => [2,3,4,1] -- 3
    /// </summary>
    /// <param name="arrayToRotate"></param>
    /// <param name="rotateTimes"></param>
    /// <returns></returns>
    public int[] RotateArray(int[] arrayToRotate, int rotateTimes)
    {
        if (arrayToRotate.Length == default || arrayToRotate.Length == 1) return arrayToRotate;

        if (rotateTimes == default) return arrayToRotate;

        if (arrayToRotate.Length == rotateTimes) return arrayToRotate;

        var sliceToRotate = arrayToRotate[^rotateTimes..];
        var sliceToKeep = arrayToRotate[..^rotateTimes];

        return sliceToRotate.Concat(sliceToKeep);
    }
    #endregion Rotate Array K times

    #region Get Frog Jumps
    /// <summary>
    /// Calculate Number of Jumps that the frog should do to move from Position `From` to the Position `To`
    /// </summary>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <param name="distance"></param>
    /// <returns></returns>
    public int GetFrogJumps(int from, int to, int distance)
    {
        if (from == to) return 0;

        var jumps = (decimal)(to - from) / distance;

        return (int)Math.Ceiling(jumps);
    }
    #endregion Get Frog Jumps
}
