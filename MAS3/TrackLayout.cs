namespace MAS3;

public abstract class TrackLayout
{
    private int _totalLengthMeters;

    public int TotalLengthMeters => _totalLengthMeters;

    protected TrackLayout(int totalLengthMeters)
    {
        if (totalLengthMeters <= 0)
            throw new ArgumentException("Length must be positive.");

        _totalLengthMeters = totalLengthMeters;
    }
}