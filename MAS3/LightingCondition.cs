namespace MAS3;

public abstract class LightingCondition
{
    private decimal _trackTemperature;

    public decimal TrackTemperature => _trackTemperature;

    protected LightingCondition(decimal trackTemperature)
    {
        _trackTemperature = trackTemperature;
    }
}