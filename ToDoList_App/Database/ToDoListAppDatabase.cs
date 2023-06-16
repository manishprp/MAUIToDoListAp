using SQLite;

namespace ToDoList_App
{
    public class ToDoListAppDatabase
    {
        private SQLiteAsyncConnection _database;
        private static ToDoListAppDatabase _instance;

        public ToDoListAppDatabase()
        {
        }

        public static ToDoListAppDatabase GetInstance()
        {
            if (_instance == null)
                _instance = new ToDoListAppDatabase();
            return _instance;
        }

        private async Task Init()
        {
            if (_database is not null)
                return;

            _database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            var result = await _database.CreateTableAsync<TaskTable>();
        }

        public async Task<List<T>> GetItemsAsync<T>() where T : new()
        {
            await Init();
            return await _database.Table<T>().ToListAsync();
        }

        public async Task<bool> InsertAllItemsAsync<T>(List<T> items) where T : new()
        {
            await Init();
            return await _database.InsertAllAsync(items) > 0;
        }

        public async Task<bool> InsertItemAsync<T>(T item) where T : new()
        {
            await Init();
            return await _database.InsertAsync(item) > 0;
        }

        public async Task<bool> DeleteItemAsync<T>(T item) where T : new()
        {
            await Init();
            return await _database.DeleteAsync(item) > 0;
        }
    }
}