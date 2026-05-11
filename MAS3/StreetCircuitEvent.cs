namespace MAS3;

public class StreetCircuitEvent : GrandPrixEvent
{
    private decimal _publicRoadRatio;

    public decimal PublicRoadRatio => _publicRoadRatio;

    public StreetCircuitEvent(string eventName, LightingCondition lighting, decimal publicRoadRatio) 
        : base(eventName, lighting)
    {
        _publicRoadRatio = publicRoadRatio;
    }
}