using System.Collections.Generic;

namespace medeixeApi.Domain.Entities;

public class Occurrence : BaseAuditableEntity
{
    public string? Latitude { get; set; }
    public string? Longitude { get; set; }
    public AgressionType AgressionType { get; set; }
    public DateTime DataHora { get; set; }
    public PriorityLevel PriorityLevel {get;set;}
    private bool _attended;
    public bool Attended
    {
        get => _attended;
        set
        {
            if (value == true && _attended == false)
            {
                AddDomainEvent(new OcurrenceAttendEvent(this));
            }
            _attended = value;
        }
    }
    public Victim? Victim { get; set; }
}