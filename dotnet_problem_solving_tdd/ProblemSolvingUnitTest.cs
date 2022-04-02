using System;
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

    #region Rotate Array K times
    [Fact]
    public void RotateArray_Should_Be_The_Same_When_Array_Contains_Only_Zeror_Or_One_Element()
    {
        // Arrange
        var arrayToRotate = new int[] { 1 };
        uint rotateTimes = 3;
        var expectedResult = arrayToRotate;

        // Act
        var result = _problemSolving.RotateArray(arrayToRotate, (int)rotateTimes);

        // Assert
        Assert.Equal(expectedResult, arrayToRotate);
    }

    [Fact]
    public void RotateArray_Should_Be_The_Same_When_RotateTimes_Is_Zero()
    {
        // Arrange
        var arrayToRotate = new int[] { 1 };
        uint rotateTimes = 0;
        var expectedResult = arrayToRotate;

        // Act
        var result = _problemSolving.RotateArray(arrayToRotate, (int)rotateTimes);

        // Assert
        Assert.Equal(expectedResult, arrayToRotate);
    }

    [Fact]
    public void RotateArray_Should_Be_The_Same_When_RotateTimes_Equals_ArrayLength()
    {
        // Arrange
        var arrayToRotate = new int[] { 1, 2, 3, 4 }; // Length + 1 = 4
        uint rotateTimes = 4;
        var expectedResult = arrayToRotate;

        // Act
        var result = _problemSolving.RotateArray(arrayToRotate, (int)rotateTimes);

        // Assert
        Assert.Equal(expectedResult, arrayToRotate);
    }

    [Fact]
    public void RotateArray_Should_Rotate_Array_3times()
    {
        // Arrange
        var arrayToRotate = new int[4] { 1, 2, 3, 4 };
        uint rotateTimes = 3;
        var expectedResult = new int[4] { 2, 3, 4, 1 }; // [1,2,3,4] => [4,1,2,3] => [3,4,1,2] => [2,3,4,1]

        // Act
        var result = _problemSolving.RotateArray(arrayToRotate, (int)rotateTimes);

        // Assert
        Assert.Equal(expectedResult, result);
    }
    #endregion Rotate Array K times

    #region Get Frog Jumps
    [Fact]
    public void GetFrogJums_Should_Return_Zero_When_From_Equals_To()
    {
        // Arrange
        var from = 10;
        var to = from;
        var distance = 30;
        var expectedResult = 0; // 0 Jumps

        // Act
        var result = _problemSolving.GetFrogJumps(from, to, distance);

        // Assert
        Assert.Equal(expectedResult, result);
    }

     [Fact]
    public void GetFrogJums_Should_Return_Jumps()
    {
        // Arrange
        var from = 10;
        var to = 85;
        var distance = 30;
        var expectedResult = 3; // 3 Jumbs, 10+30 = 40 ==> 10+30+30 = 70 ==> 10+30+30+30 = 100  which gives 2.5 then needs 3 Jumps

        // Act
        var result = _problemSolving.GetFrogJumps(from, to, distance);

        // Assert
        Assert.Equal(expectedResult, result);
    }
    #endregion Get Frog Jumps
}