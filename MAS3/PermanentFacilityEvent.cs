namespace MAS3;

public class PermanentFacilityEvent : GrandPrixEvent
{
    private int _grandstandCapacity;

    public int GrandstandCapacity => _grandstandCapacity;

    public PermanentFacilityEvent(string eventName, LightingCondition lighting, int grandstandCapacity) 
        : base(eventName, lighting)
    {
        _grandstandCapacity = grandstandCapacity;
    }
}