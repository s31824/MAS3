namespace MAS3;

public class NightRace : LightingCondition
{
    private int _floodlightCount;

    public int FloodlightCount => _floodlightCount;

    public NightRace(decimal trackTemperature, int floodlightCount) : base(trackTemperature)
    {
        _floodlightCount = floodlightCount;
    }
}