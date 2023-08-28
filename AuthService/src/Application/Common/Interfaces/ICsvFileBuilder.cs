using AuthService.Application.TodoLists.Queries.ExportTodos;

namespace AuthService.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
