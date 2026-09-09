
using SQLite;


namespace projectChurch.SesFolder
{
   public class DataServ

    {
        private readonly SQLiteAsyncConnection _connection;

        public  DataServ(string dbPath)
        {
            _connection = new SQLiteAsyncConnection(dbPath);
            _connection.CreateTableAsync<TextEntry>().Wait();
        }
        public Task<int> SaveEntryAsync(TextEntry entry)
        {
            return _connection.InsertAsync(entry);
        }

        public Task<List<TextEntry>> GetEntriesAsync()
        {
            return _connection.Table<TextEntry>().ToListAsync();
        }

        public Task<int> DeleteHighlightedTextAsync(TextEntry entry)
        {
            return _connection.DeleteAsync(entry);
        }
    }


}
