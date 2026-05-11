namespace MAS3;

public class Engineer : TeamMember
{
    private decimal _baseSalary;
    
    public decimal BaseSalary => _baseSalary;
    
    public Engineer(decimal baseSalary)
    {
        _baseSalary = baseSalary;
    }

    public override decimal CalculateBonus()
    {
        return _baseSalary * 0.2m;
    }
    
    public decimal CalculateBonus(decimal successMultiplier) 
    {
        return CalculateBonus() * successMultiplier;
    }
    
    public decimal CalculateBonus(decimal successMultiplier, bool isChampionshipWon)
    {
        decimal bonus = CalculateBonus(successMultiplier);
        return isChampionshipWon ? bonus * 2 : bonus;
    }
}