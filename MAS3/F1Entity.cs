namespace MAS3;

public class F1Entity
{
    private static readonly List<F1Entity> _extension = new List<F1Entity>();
    private RacingTeam _teamRole;
    private EngineSupplier _supplierRole;
    
    public static IReadOnlyList<F1Entity> GetExtension() => _extension.AsReadOnly();
    public RacingTeam TeamRole => _teamRole;
    public EngineSupplier SupplierRole => _supplierRole;
    
    public F1Entity(RacingTeam teamRole = null, EngineSupplier supplierRole = null)
    {
        if (teamRole == null && supplierRole == null)
            throw new ArgumentException("F1 Entity must have at least one valid role assigned.");

        _teamRole = teamRole;
        _supplierRole = supplierRole;
        
        _extension.Add(this);
    }
}
