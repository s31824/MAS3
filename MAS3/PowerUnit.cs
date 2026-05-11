namespace MAS3;

public class PowerUnit
{
    private string _serialNumber;
    private EngineMode _currentMode;
    private int _totalMileageKm;
    private decimal _temperature;
    private decimal _fuelRemaining;

    public string SerialNumber => _serialNumber;
    public EngineMode CurrentMode => _currentMode;
    public int TotalMileageKm => _totalMileageKm;
    public decimal Temperature => _temperature;
    public decimal FuelRemaining => _fuelRemaining;

    public PowerUnit(string serialNumber, EngineMode initialMode, decimal initialFuel)
    {
        if (string.IsNullOrWhiteSpace(serialNumber))
            throw new ArgumentException("Serial number cannot be empty.");

        _serialNumber = serialNumber;
        _currentMode = initialMode ?? throw new ArgumentNullException(nameof(initialMode));
        _fuelRemaining = initialFuel;
        _totalMileageKm = 0;
        _temperature = 90.0m;
    }

    public void SwitchMode(EngineMode newMode)
    {
        _currentMode = newMode ?? throw new ArgumentNullException(nameof(newMode));
    }

    public void RunLap(int trackLengthKm)
    {
        if (_fuelRemaining <= 0)
            throw new InvalidOperationException("Engine shut down: Out of fuel.");

        if (_temperature > 130.0m)
            throw new InvalidOperationException("Engine failure: Critical overheating.");

        _currentMode.ExecuteLap(this, trackLengthKm);
    }

    public void IncreaseMileage(int km)
    {
        if (km < 0) throw new ArgumentException("Distance cannot be negative.");
        _totalMileageKm += km;
    }

    public void IncreaseTemperature(decimal amount)
    {
        if (amount < 0) throw new ArgumentException("Amount cannot be negative.");
        _temperature += amount;
    }

    public void DecreaseTemperature(decimal amount)
    {
        if (amount < 0) throw new ArgumentException("Amount cannot be negative.");
        _temperature = Math.Max(80.0m, _temperature - amount);
    }

    public void ConsumeFuel(decimal amount)
    {
        if (amount < 0) throw new ArgumentException("Amount cannot be negative.");
        _fuelRemaining = Math.Max(0m, _fuelRemaining - amount);
    }
}