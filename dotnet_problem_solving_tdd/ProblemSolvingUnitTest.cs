using dotnet_problem_solving;
using Xunit;

namespace dotnet_problem_solving_tdd;

public class ProblemSolvingUnitTest
{
    private readonly ProblemSolving _problemSolving;

    public ProblemSolvingUnitTest()
    {
        _problemSolving = new ProblemSolving();
    }

    #region Get Longest Binary Gap
    [Fact]
    public void GetLongestBinaryGap_Should_Return_One_When_Number_Is_Zero()
    {
        // Arrange
        uint number = 0;
        var expectedResult = 1;

        // Act
        var result = _problemSolving.GetLongestBinaryGap(number);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void GetLongestBinaryGap_Should_Return_Zero_When_Binary_has_No_Gap()
    {
        // Arrange
        uint number = 1;
        var expectedResult = 0;

        // Act
        var result = _problemSolving.GetLongestBinaryGap(number);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void GetLongestBinaryGap_Should_Return_Longest_Gap_In_Binary()
    {
        // Arrange
        uint number = 529;
        var expectedResult = 4; // 529 to binary is "1000010001", so the longest gap is 4 "0000"

        // Act
        var result = _problemSolving.GetLongestBinaryGap(number);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    #endregion Get Longest Binary Gap
}