namespace MAS3;

public abstract class TeamMember
{
    private static readonly List<TeamMember> Extension = new List<TeamMember>();

    public static IReadOnlyList<TeamMember> GetExtension() => Extension.AsReadOnly();
    
    protected TeamMember()
    {
        Extension.Add(this);
    }
    
    public abstract decimal CalculateBonus();
}