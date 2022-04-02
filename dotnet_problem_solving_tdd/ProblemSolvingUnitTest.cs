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

    #region Get Unpaired element
    [Fact]
    public void GetUnpairedElement_Should_Return_1st_Element_When_Array_Has_Only_1element()
    {
        // Arrange
        var oddArray = new int[] { 1 };
        var expectedResult = 1;

        // Act
        var result = _problemSolving.GetUnpairedElement(oddArray);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void GetUnpairedElement_Should_Return_Element_That_Has_Zero_Occurence()
    {
        // Arrange
        var oddArray = new int[] { 9, 3, 9, 3, 9, 7, 9 };
        var expectedResult = 7;

        // Act
        var result = _problemSolving.GetUnpairedElement(oddArray);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void GetUnpairedElement_Should_Return_Unpaired_Element()
    {
        // Arrange
        var oddArray = new int[] { 9, 3, 9, 3, 9, 7, 9, 3, 7 };
        var expectedResult = 3;

        // Act
        var result = _problemSolving.GetUnpairedElement(oddArray);

        // Assert
        Assert.Equal(expectedResult, result);
    }
    #endregion Get Unpaired element
}