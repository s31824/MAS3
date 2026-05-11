namespace MAS3;

public class SafetyCarMode : EngineMode
{
    public override void ExecuteLap(PowerUnit context, int trackLengthKm)
    {
        context.IncreaseMileage(trackLengthKm);
        context.DecreaseTemperature(10.0m);
        context.ConsumeFuel(trackLengthKm * 0.4m);
    }
}