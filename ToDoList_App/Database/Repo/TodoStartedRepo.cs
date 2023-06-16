using SQLite;

namespace ToDoList_App
{
    public class TodoStartedRepo
    {
        private ToDoListAppDatabase _toDoListAppDatabase;

        public TodoStartedRepo(ToDoListAppDatabase toDoListAppDatabase)
        {
            _toDoListAppDatabase = toDoListAppDatabase;
        }

        public async Task<bool> StoreAllTasks(List<TaskTable> TaskList)
        {
            return await _toDoListAppDatabase.InsertAllItemsAsync(TaskList);
        }

        public async Task<List<TaskTable>> GetAllTasks()
        {
            return await _toDoListAppDatabase.GetItemsAsync<TaskTable>();
        }
    }
}