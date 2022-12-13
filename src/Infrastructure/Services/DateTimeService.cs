using medeixeApi.Application.Common.Interfaces;

namespace medeixeApi.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
