using AuthService.Application.Common.Mappings;
using AuthService.Domain.Entities;

namespace AuthService.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; init; }

    public bool Done { get; init; }
}
