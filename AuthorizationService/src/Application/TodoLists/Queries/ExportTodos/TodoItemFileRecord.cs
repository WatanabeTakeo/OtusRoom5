using AuthorizationService.Application.Common.Mappings;
using AuthorizationService.Domain.Entities;

namespace AuthorizationService.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; init; }

    public bool Done { get; init; }
}
