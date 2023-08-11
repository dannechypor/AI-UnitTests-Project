# UnitTestsAI

## Table of Contents
- [Description](#description)
- [Running Tests Locally](#running-tests-locally)
- [Tests Breakdown](#tests-breakdown)
  * [PlayerAnalyzerTests](#playeranalyzertests)
  * [ConvertStudentsTests](#convertstudentstests)

## Description

**UnitTestsAI** is a comprehensive testing solution, primarily focusing on analyzing player statistics and student performance. The first suite, `PlayerAnalyzerTests`, evaluates players based on their age, experience, and skill set. It offers a structured approach to determine scores for different player profiles like Normal, Junior, Senior, and even cases with multiple players. On the other hand, the `ConvertStudentsTests` suite is responsible for assessing students. It takes into account their age and grade, providing valuable metrics such as Honor Roll and Exceptional status.

The purpose of these tests is to ensure the reliability and robustness of the underlying algorithms and to detect and rectify any anomalies that might occur during the application's runtime. Both suites also include edge cases, like handling null or empty inputs, to ensure a thorough evaluation and error handling.

## Running Tests Locally

To run the tests locally, follow the steps below:

1. **Clone the Repository**: `git clone <repository-url>`
2. **Navigate to the project directory**: `cd path/to/UnitTestsAI.Tests`
3. **Restore NuGet Packages**: `dotnet restore`
4. **Run the Tests**: `dotnet test`

Ensure that you have the .NET SDK installed on your machine.

## Tests Breakdown

### PlayerAnalyzerTests

- **CalculateScore_NormalPlayer_ReturnsExpectedScore**: Evaluates the score of a normal player.
- **CalculateScore_JuniorPlayer_ReturnsExpectedScore**: Assesses the score of a junior player.
- **CalculateScore_SeniorPlayer_ReturnsExpectedScore**: Checks the score of a senior player.
- **CalculateScore_MultiplePlayers_ReturnsExpectedTotalScore**: Calculates the total score for multiple players.
- **CalculateScore_PlayerSkillsNull_ThrowsArgumentNullException**: Validates that an exception is thrown when player skills are null.
- **CalculateScore_EmptyArray_ReturnsZero**: Ensures that an empty player list results in a zero score.

### ConvertStudentsTests

- **HighAchiever_ReturnsHonorRoll**: Checks if a high achieving student is on the Honor Roll.
- **ExceptionalYoungHighAchiever_ReturnsExceptional**: Determines if a young high achiever is marked exceptional.
- **PassedStudent_ReturnsPassedTrue**: Validates if a student with a passing grade is marked passed.
- **FailedStudent_ReturnsPassedFalse**: Verifies if a student with a failing grade is marked as not passed.
- **EmptyArray_ReturnsEmptyArray**: Validates that an empty list of students results in an empty output.
- **NullInput_ThrowsException**: Validates that a null input throws an exception.

For any issues, questions, or contributions, feel free to open a pull request or issue on this repository.
