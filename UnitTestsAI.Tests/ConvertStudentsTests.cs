using UnitTestsAI.Models;
using UnitTestsAI.Services;

namespace UnitTestsAI.Tests;

public class ConvertStudentsTests
{
    private readonly StudentConverter _studentConverter;

    public ConvertStudentsTests()
    {
        _studentConverter = new StudentConverter();
    }
    
    [Test]
    public void HighAchiever_ReturnsHonorRoll()
    {
        // Arrange
        var students = new List<Student>
        {
            new Student { Age = 21, Grade = 91 }
        };

        // Act
        var result = _studentConverter.ConvertStudents(students);

        // Assert
        Assert.IsTrue(result[0].HonorRoll);
    }

    [Test]
    public void ExceptionalYoungHighAchiever_ReturnsExceptional()
    {
        // Arrange
        var students = new List<Student>
        {
            new Student { Age = 20, Grade = 91 }
        };

        // Act
        var result = _studentConverter.ConvertStudents(students);

        // Assert
        Assert.IsTrue(result[0].Exceptional);
    }

    [Test]
    public void PassedStudent_ReturnsPassedTrue()
    {
        // Arrange
        var students = new List<Student>
        {
            new Student { Age = 20, Grade = 71 }
        };

        // Act
        var result = _studentConverter.ConvertStudents(students);

        // Assert
        Assert.IsTrue(result[0].Passed);
    }

    [Test]
    public void FailedStudent_ReturnsPassedFalse()
    {
        // Arrange
        var students = new List<Student>
        {
            new Student { Age = 20, Grade = 70 }
        };

        // Act
        var result = _studentConverter.ConvertStudents(students);

        // Assert
        Assert.IsFalse(result[0].Passed);
    }
    
    [Test]
    public void EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        var students = new List<Student>();

        // Act
        var result = _studentConverter.ConvertStudents(students);

        // Assert
        Assert.IsEmpty(result);
    }

    [Test]
    public void NullInput_ThrowsException()
    {
        // Assert
        Assert.Throws<ArgumentNullException>(() => _studentConverter.ConvertStudents(null));
    }
}