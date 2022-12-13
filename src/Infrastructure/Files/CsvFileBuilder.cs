using System.Globalization;
using medeixeApi.Application.Common.Interfaces;
using medeixeApi.Application.TodoLists.Queries.ExportTodos;
using medeixeApi.Infrastructure.Files.Maps;
using CsvHelper;

namespace medeixeApi.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Configuration.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
