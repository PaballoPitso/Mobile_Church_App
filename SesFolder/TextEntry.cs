
using FutureState.AppCore.Data.Attributes;
using SQLite;

namespace projectChurch.SesFolder
{
    public class TextEntry
    {
        [SQLite.PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
