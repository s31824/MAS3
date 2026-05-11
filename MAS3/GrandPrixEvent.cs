namespace MAS3;

public abstract class GrandPrixEvent
{
    private string _eventName;
    private LightingCondition _lighting;

    public string EventName => _eventName;
    public LightingCondition Lighting => _lighting;

    protected GrandPrixEvent(string eventName, LightingCondition lighting)
    {
        if (string.IsNullOrWhiteSpace(eventName))
            throw new ArgumentException("Event name cannot be empty.");

        _eventName = eventName;
        _lighting = lighting ?? throw new ArgumentNullException(nameof(lighting));
    }
}