using UnitTestsAI.Models;
using UnitTestsAI.Services;

namespace UnitTestsAI.Tests;

public class PlayerAnalyzerTests
{
    [Test]
    public void CalculateScore_NormalPlayer_ReturnsExpectedScore()
    {
        // Arrange
        var playerAnalyzer = new PlayerAnalyzer();
        var players = new List<Player>
        {
            new Player { Age = 25, Experience = 5, Skills = new List<int> { 2, 2, 2 } }
        };

        // Act
        var result = playerAnalyzer.CalculateScore(players);

        // Assert
        Assert.AreEqual(250, result);
    }

    [Test]
    public void CalculateScore_JuniorPlayer_ReturnsExpectedScore()
    {
        // Arrange
        var playerAnalyzer = new PlayerAnalyzer();
        var players = new List<Player>
        {
            new Player { Age = 15, Experience = 3, Skills = new List<int> { 3, 3, 3 } }
        };

        // Act
        var result = playerAnalyzer.CalculateScore(players);

        // Assert
        Assert.AreEqual(67.5, result);
    }

    [Test]
    public void CalculateScore_SeniorPlayer_ReturnsExpectedScore()
    {
        // Arrange
        var playerAnalyzer = new PlayerAnalyzer();
        var players = new List<Player>
        {
            new Player { Age = 35, Experience = 15, Skills = new List<int> { 4, 4, 4 } }
        };

        // Act
        var result = playerAnalyzer.CalculateScore(players);

        // Assert
        Assert.AreEqual(2520, result);
    }

    [Test]
    public void CalculateScore_MultiplePlayers_ReturnsExpectedTotalScore()
    {
        // Arrange
        var playerAnalyzer = new PlayerAnalyzer();
        var players = new List<Player>
        {
            new Player { Age = 25, Experience = 5, Skills = new List<int> { 2, 2, 2 } },
            new Player { Age = 15, Experience = 3, Skills = new List<int> { 3, 3, 3 } },
            new Player { Age = 35, Experience = 15, Skills = new List<int> { 4, 4, 4 } }
        };

        // Act
        var result = playerAnalyzer.CalculateScore(players);

        // Assert
        Assert.AreEqual(250 + 67.5 + 2520, result);
    }
    
    [Test]
    public void CalculateScore_PlayerSkillsNull_ThrowsArgumentNullException()
    {
        // Arrange
        var playerAnalyzer = new PlayerAnalyzer();
        var players = new List<Player>
        {
            new Player { Age = 25, Experience = 5, Skills = null }
        };

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => playerAnalyzer.CalculateScore(players));
    }

    [Test]
    public void CalculateScore_EmptyArray_ReturnsZero()
    {
        // Arrange
        var playerAnalyzer = new PlayerAnalyzer();
        var players = new List<Player>();

        // Act
        var result = playerAnalyzer.CalculateScore(players);

        // Assert
        Assert.AreEqual(0, result);
    }
}