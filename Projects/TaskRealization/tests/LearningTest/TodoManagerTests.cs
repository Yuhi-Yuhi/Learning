using TodoApp;

namespace LearningTest;

public class TodoManagerTests
{
    private TodoManager _todoManager = new TodoManager();

    private TodoItem _todoItem;

    public TodoManagerTests()   // Constructor xUnit вместо SetUp, который в nUnit
    {
        string title = "One task"; //Random использовать 
        var id = _todoManager.AddTodoItem(title);
        _todoItem = new TodoItem()
        {
            Title = title,
            Id = id
        };
        //_todoItem.Id = id;   Тоже самое, что и с верху, просто другая запись 
        //_todoItem.Title = title;

    }

    [Fact]
    public void AddTodoTest()
    {
        //Assert
        var todoList = _todoManager.ViewTodoItems();
        var item = todoList.FirstOrDefault(i => i.Id.Equals(_todoItem.Id));

        Assert.NotNull(item);
        Assert.Equal(_todoItem.Id, item.Id);
        Assert.Equal(_todoItem.Title, item.Title);
        Assert.False(item.IsCompleted);
    }

    [Fact]
    public void ViewTodoItemsTest()
    {
        //Arrange
        string title2 = "Second task";
        
        //Act
        var id2 = _todoManager.AddTodoItem(title2);

        //Assert
        var todoList = _todoManager.ViewTodoItems();
        var item = todoList.FirstOrDefault(i => i.Id.Equals(_todoItem.Id));
        var item2 = todoList.FirstOrDefault(i => i.Id == id2);
        // Проверяет равенство ссылок, а не значений !
        //Assert.Contains(new TodoItem { Id = id1, Title = title1 }, todoList);
        //Assert.Contains(new TodoItem { Id = id2, Title = title2 }, todoList);

        Assert.NotNull(item);
        Assert.Equal(_todoItem.Id, item.Id);
        Assert.Equal(_todoItem.Title, item.Title);
        Assert.False(item.IsCompleted);

        Assert.NotNull(item2);
        Assert.Equal(id2, item2.Id);
        Assert.Equal(title2, item2.Title);
        Assert.False(item2.IsCompleted);
    }

    [Fact]
    public void MarkCompletedTest()
    {
        //Act
        var todoList = _todoManager.ViewTodoItems();
        _todoManager.MarkAsCompleted(_todoItem.Id);
        var item = todoList.FirstOrDefault(i => i.Id.Equals(_todoItem.Id));

        //Assert
        Assert.NotNull(item);
        Assert.True(item.IsCompleted);
    }

    [Fact]
    public void DeleteTodoItemTest()
    {
        //Act
        var todoList = _todoManager.ViewTodoItems();
        _todoManager.DeleteTodoItem(_todoItem.Id);
        var item = todoList.FirstOrDefault(i => i.Id.Equals(_todoItem.Id));

        //Assert
        Assert.Null(item);
    }
}
