namespace MAS3;

public class Mechanic : TeamMember
{
    private int _overtimeHours;
    private decimal _hourlyRate;
    
    public int OvertimeHours => _overtimeHours;
    public decimal HourlyRate => _hourlyRate;

    public Mechanic(int overtimeHours, decimal hourlyRate)
    {
        _overtimeHours = overtimeHours;
        _hourlyRate = hourlyRate;
    }

    public override decimal CalculateBonus()
    {
       return _hourlyRate * _overtimeHours * 1.5m;
    }
    
    public decimal CalculateBonus(decimal hazardPayBonus)
    {
        return (_overtimeHours * _hourlyRate * 1.5m) + hazardPayBonus;
    }
}