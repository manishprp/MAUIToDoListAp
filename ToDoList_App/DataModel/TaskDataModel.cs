using CommunityToolkit.Mvvm.ComponentModel;

namespace ToDoList_App
{
    public partial class TaskDataModel : ObservableObject
    {
        [ObservableProperty]
        private string _taskDescription;

        [ObservableProperty]
        private string _imageSource;

        [ObservableProperty]
        private DateTime _taskDate;

        public string TaskName { get; set; }
        private bool _isDone;

        public bool IsDone
        { get { return _isDone; } set { _isDone = value; SetData(); } }

        private void SetData()
        {
            ImageSource = IsDone ? "check" : "undone";
        }
    }
}