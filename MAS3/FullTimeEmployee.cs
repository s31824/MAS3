namespace MAS3;

public class FullTimeEmployee
{
    private decimal _salary;
    private DateTime _hireDate;

    public decimal Salary => _salary;
    public DateTime HireDate => _hireDate;

    public FullTimeEmployee(decimal salary, DateTime hireDate)
    {
        _salary = salary;
        _hireDate = hireDate;
    }
}