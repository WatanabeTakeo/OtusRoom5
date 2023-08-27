using System.Globalization;
using AuthorizationService.Application.Common.Interfaces;
using AuthorizationService.Application.TodoLists.Queries.ExportTodos;
using AuthorizationService.Infrastructure.Files.Maps;
using CsvHelper;

namespace AuthorizationService.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Context.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
