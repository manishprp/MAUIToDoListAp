using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ToDoList_App
{
    public partial class AddNewTaskViewModelb : BaseViewModel
    {
        private TaskDataModel _taskData;

        public TaskDataModel TaskData
        { get { return _taskData; } set { _taskData = value; SetupData(); } }

        private bool _isEditVisible;

        public bool IsEditVisible
        { get { return _isEditVisible; } set { _isEditVisible = value; OnPropertyChanged(); IsUpdateVisible = !IsEditVisible; } }

        [ObservableProperty]
        private bool _isUpdateVisible;

        [ObservableProperty]
        private string _buttontitle;

        [ObservableProperty]
        private bool _isDataEnabled;

        private void SetupData()
        {
            if (TaskData == null)
            {
                IsDataEnabled = true;
                IsEditVisible = false;
                Buttontitle = "Add New Task";
            }
            else
            {
                IsDataEnabled = false;
                IsEditVisible = true;
                Buttontitle = "Update Task";
                TaskName = TaskData.TaskName;
                TaskDescription = TaskData.TaskDescription;
                TaskDate = TaskData.TaskDate;
            }
        }

        [ObservableProperty]
        private string _taskName;

        [ObservableProperty]
        private string _taskDescription;

        [ObservableProperty]
        private DateTime _taskDate;

        [RelayCommand]
        private void AddNewTask()
        {
        }

        [RelayCommand]
        private void UpdateTask()
        {
        }

        [RelayCommand]
        private void EditTask()
        {
            IsDataEnabled = true;
            IsEditVisible = false;
        }

        [RelayCommand]
        private void DeleteTask()
        {
        }
    }
}