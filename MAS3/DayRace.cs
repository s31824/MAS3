namespace MAS3;

public class DayRace : LightingCondition
{
    private string _sunGlareSeverity;

    public string SunGlareSeverity => _sunGlareSeverity;

    public DayRace(decimal trackTemperature, string sunGlareSeverity) : base(trackTemperature)
    {
        if (string.IsNullOrWhiteSpace(sunGlareSeverity))
            throw new ArgumentException("Glare severity must be specified.");

        _sunGlareSeverity = sunGlareSeverity;
    }
}