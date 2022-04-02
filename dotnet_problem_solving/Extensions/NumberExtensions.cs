namespace dotnet_problem_solving.Extensions;

/// <summary>
/// NUmber extensions
/// </summary>
public static class NumberExtensions
{
    public static string ToBinary(this uint numberToConvert)
    {
        if(numberToConvert == 0) return "0";

        return Convert.ToString(numberToConvert, 2);
    }
}
