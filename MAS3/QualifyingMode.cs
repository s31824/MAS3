namespace MAS3;

public class QualifyingMode : EngineMode
{
    public override void ExecuteLap(PowerUnit context, int trackLengthKm)
    {
        context.IncreaseMileage(trackLengthKm);
        context.IncreaseTemperature(15.5m);
        context.ConsumeFuel(trackLengthKm * 1.8m);
    }
}