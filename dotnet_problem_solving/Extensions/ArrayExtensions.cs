namespace dotnet_problem_solving.Extensions;

public static class ArrayExtensions
{
    /// <summary>
    /// Concat 2 Arrays
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T[] Concat<T>(this T[] x, T[] y)
    {
        if (x == null) throw new ArgumentNullException("x");
        if (y == null) throw new ArgumentNullException("y");
        int oldLen = x.Length;
        Array.Resize<T>(ref x, x.Length + y.Length);
        Array.Copy(y, 0, x, oldLen, y.Length);
        return x;
    }
}
