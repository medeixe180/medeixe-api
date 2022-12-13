namespace medeixeApi.Domain.Entities;

internal class OcurrenceAttendEvent : BaseEvent
{
    public OcurrenceAttendEvent(Occurrence occurrence)
    {
        Occurrence = occurrence;
    }

    public Occurrence Occurrence { get; }
}