using medeixeApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace medeixeApi.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }
    DbSet<TodoItem> TodoItems { get; }
    DbSet<Victim> Victims { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
