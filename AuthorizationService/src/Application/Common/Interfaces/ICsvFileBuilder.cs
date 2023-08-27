using AuthorizationService.Application.TodoLists.Queries.ExportTodos;

namespace AuthorizationService.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
