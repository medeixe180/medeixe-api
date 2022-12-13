using medeixeApi.Application.Common.Exceptions;
using medeixeApi.Application.TodoItems.Commands.CreateTodoItem;
using medeixeApi.Application.TodoItems.Commands.DeleteTodoItem;
using medeixeApi.Application.TodoLists.Commands.CreateTodoList;
using medeixeApi.Domain.Entities;
using FluentAssertions;
using NUnit.Framework;

namespace medeixeApi.Application.IntegrationTests.TodoItems.Commands;

using static Testing;

public class DeleteTodoItemTests : BaseTestFixture
{
    [Test]
    public async Task ShouldRequireValidTodoItemId()
    {
        var command = new DeleteTodoItemCommand(99);

        await FluentActions.Invoking(() =>
            SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Test]
    public async Task ShouldDeleteTodoItem()
    {
        var listId = await SendAsync(new CreateTodoListCommand
        {
            Title = "New List"
        });

        var itemId = await SendAsync(new CreateTodoItemCommand
        {
            ListId = listId,
            Title = "New Item"
        });

        await SendAsync(new DeleteTodoItemCommand(itemId));

        var item = await FindAsync<TodoItem>(itemId);

        item.Should().BeNull();
    }
}
