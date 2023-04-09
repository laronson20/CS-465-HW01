namespace RobotTest;

public class RobotMoveSquareTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AssignmentExampleTest()
    {
        // Arrange
        var robot = new SquareRobot();
        var commands = new int[] { 4, 4, 3, 2, 2, 3 };

        // Act
        var result = robot.Move(commands);

        // Assert
        Assert.IsTrue(result);
    }

    //Please keep in mind I don't actually know how to do this
    [Test]
    public void PracticeTest()
    {
        var robot2 = new SquareRobot();
        var commands2 = new int[] {3, 2, 2, 3, 4, 4};

        var result2 = robot2.Move(commands2);

        Assert.IsTrue(result2);
    }
}