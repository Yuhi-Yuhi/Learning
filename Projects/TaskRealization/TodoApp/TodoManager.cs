namespace TodoApp
{
    public class TodoManager
    {
        private List<TodoItem> _todoItems = new List<TodoItem>();
        private int _nextId = 1;

        public void AddTodoItem(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                Console.WriteLine("Task title can not be empty.");
                return;
            }

            _todoItems.Add(new TodoItem { Id = _nextId++, Title = title, IsCompleted = false });
            Console.WriteLine("Task was added successfully.");
        }

        public void ViewTodoItems()
        {
            if (_todoItems.Count == 0)
            {
                Console.WriteLine("The task list is empty.");
                return;
            }

            foreach (var item in _todoItems)
            {
                Console.WriteLine($"Id: {item.Id}. Title: {item.Title}. Completed: {item.IsCompleted}.");
            }
        }

        public void MarkAsCompleted(int id)
        {
            var item = _todoItems.FirstOrDefault(i => i.Id == id);

            if (item == null)
            {
                Console.WriteLine("Task not found!");
                return;
            }

            item.IsCompleted = true;
            Console.WriteLine("Task marked as completed!");
        }

        public void DeleteTodoItem(int id)
        {
            var item = _todoItems.FirstOrDefault(i => i.Id == id);

            if (item == null)
            {
                Console.WriteLine("Task not found!");
                return;
            }

            _todoItems.Remove(item);
            Console.WriteLine("Task deleted successfully!");
        }
    }
}
