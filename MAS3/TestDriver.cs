namespace MAS3;

public class TestDriver : FullTimeEmployee, IDriver
{
    private string _testTrack;

    public string TestTrack => _testTrack;

    public TestDriver(decimal salary, DateTime hireDate, string testTrack) : base(salary, hireDate)
    {
        _testTrack = testTrack;
    }

    public void DriveCar()
    {
        Console.WriteLine("Driving the car during aerodynamic track tests.");
    }
}