namespace MAS3;

public class RacingTeam
{
    private string _name;
    
    public string Name => _name;

    public RacingTeam(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Team name cannot be empty.");
            
        _name = name;
    }
}