using medeixeApi.Application.Common.Mappings;
using medeixeApi.Domain.Entities;

namespace medeixeApi.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
