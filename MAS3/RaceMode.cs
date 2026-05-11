namespace MAS3;

public class RaceMode : EngineMode
{
    public override void ExecuteLap(PowerUnit context, int trackLengthKm)
    {
        context.IncreaseMileage(trackLengthKm);
        context.IncreaseTemperature(5.0m);
        context.ConsumeFuel(trackLengthKm * 1.0m);
    }
}