namespace TodoApp
{
    public class Program
    {
        public static void Main()
        {
            var manager = new TodoManager();

            while (true)
            {
                ShowMenu();
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Enter task title: ");
                        string title = Console.ReadLine();
                        manager.AddTodoItem(title);
                        break;
                    case "2":
                        manager.ViewTodoItems();
                        break;
                    case "3":
                        Console.Write("Enter task Id to mark as completed: ");
                        if (int.TryParse(Console.ReadLine(), out int idToMark))
                            manager.MarkAsCompleted(idToMark);
                        break;
                    case "4":
                        Console.Write("Enter task Id to delete: ");
                        if (int.TryParse(Console.ReadLine(), out int idToDelete))
                            manager.DeleteTodoItem(idToDelete);
                        break;
                    case "5":
                        Console.Write("Exiting program. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.WriteLine("Press Enter to return to the menu...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        private static void ShowMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add a new task");
            Console.WriteLine("2. View all tasks");
            Console.WriteLine("3. Mark task as completed");
            Console.WriteLine("4. Delete a task");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
        }
    }
}