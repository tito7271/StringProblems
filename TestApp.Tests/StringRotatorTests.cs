using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;
        int position = 1;

        // Act
        string result = StringRotator.RotateRight(input, position);

        // Assert
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        string input = "hello";
        int position = 0;
        string expected = "hello";

        // Act
        string result = StringRotator.RotateRight(input, position);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        string input = "hello";
        int position = 3;
        string expected = "llohe";

        // Act
        string result = StringRotator.RotateRight(input, position);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        string input = "hello";
        int position = -3;
        string expected = "llohe";

        // Act
        string result = StringRotator.RotateRight(input, position);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        string input = "hello";
        int position = 7;
        string expected = "lohel";

        // Act
        string result = StringRotator.RotateRight(input, position);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
