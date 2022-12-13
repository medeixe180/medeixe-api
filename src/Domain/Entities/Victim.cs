namespace medeixeApi.Domain.Entities;

public class Victim : BaseAuditableEntity
{
    public string? CellPhone { get; set; }
    public string? Name { get; set; }
    public bool ProtectiveMeasure { get; set; }
    public string? Email { get; set; }
    public string? Addres { get; set; }
    public ICollection<Occurrence>? Occurrences {get; set;}
}
