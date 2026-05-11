namespace MAS3;

public class RacingDriver : IDriver
{
    private int _superLicensePoints;

    public int SuperLicensePoints => _superLicensePoints;

    public RacingDriver(int superLicensePoints)
    {
        _superLicensePoints = superLicensePoints;
    }

    public void DriveCar()
    {
        Console.WriteLine("Racing in Grand Prix.");
    }
}