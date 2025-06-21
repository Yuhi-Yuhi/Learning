using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;

namespace TodoApp
{
    public class TodoManager
    {
        private List<TodoItem> _todoItems = new List<TodoItem>();
        private int _nextId = 0;

        public int AddTodoItem(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Task title can not be empty.");
            }

            _nextId++;
            _todoItems.Add(new TodoItem { Id = _nextId, Title = title, IsCompleted = false });
            return _nextId;
        }

        public List<TodoItem> ViewTodoItems() //Сохранение в файлик //1 "One task" false   JSON
        {
            //string jsonPath = Path.Combine(Path.GetTempPath(), "todoItems.json");
            //string json = JsonSerializer.Serialize(_todoItems);

            //File.WriteAllText(jsonPath, json);

            return _todoItems;
        }

        public bool MarkAsCompleted(int id)
        {
            var item = _todoItems.FirstOrDefault(i => i.Id == id);

            if (item == null)
            {
                return false;
            }

            item.IsCompleted = true;
            return true;
        }

        public bool DeleteTodoItem(int id)
        {
            var item = _todoItems.FirstOrDefault(i => i.Id == id);

            if (item == null)
            {
                return false;
            }

            _todoItems.Remove(item);
            return true;
        }
    }
}
