namespace MAS3;

public class EngineSupplier
{
    private string _model;
    
    public string Model => _model;

    public EngineSupplier(string model)
    {
        if (string.IsNullOrWhiteSpace(model))
            throw new ArgumentException("Engine model cannot be empty.");
            
        _model = model;
    }
}