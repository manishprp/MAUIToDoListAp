using SQLite;

namespace ToDoList_App
{
    [Table("TaskTable")]
    public class TaskTable
    {
        [Column("Id"), AutoIncrement, PrimaryKey]
        public int ID { get; set; }

        [Column("TaskName")]
        public string TaskName { get; set; }

        [Column("TaskDescription")]
        public string TaskDescription { get; set; }

        [Column("CreatedDate")]
        public DateTime CreatedDate { get; set; }
    }
}