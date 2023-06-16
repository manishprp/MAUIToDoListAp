using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace ToDoList_App
{
    public partial class OngoingTasksViewModel : BaseViewModel
    {
        private OngoingTasksModel _model;

        [ObservableProperty]
        private ObservableCollection<TaskDataModel> _ongoingTasks;

        public OngoingTasksViewModel()
        {
            _model = new OngoingTasksModel();
            SetupData();
        }

        private void SetupData()
        {
            OngoingTasks = new ObservableCollection<TaskDataModel>();
            OngoingTasks.Add(new TaskDataModel
            {
                ImageSource = "undone",
                TaskDescription = "This is the task you will perform at this time",
                TaskName = "Task 1",
                IsDone = false,
                TaskDate = DateTime.Now,
            });
            OngoingTasks.Add(new TaskDataModel
            {
                ImageSource = "undone",
                TaskDescription = "This is the task you will perform at this time",
                TaskName = "Task 2",
                IsDone = false,
                TaskDate = DateTime.Now,
            });
            OngoingTasks.Add(new TaskDataModel
            {
                ImageSource = "undone",
                TaskDescription = "This is the task you will perform at this time",
                TaskName = "Task 3",
                IsDone = false,
                TaskDate = DateTime.Now,
            });
            OngoingTasks.Add(new TaskDataModel
            {
                ImageSource = "undone",
                TaskDescription = "This is the task you will perform at this time",
                TaskName = "Task 4",
                IsDone = false,
                TaskDate = DateTime.Now,
            });
            OngoingTasks.Add(new TaskDataModel
            {
                ImageSource = "undone",
                TaskDescription = "This is the task you will perform at this time",
                TaskName = "Task 5",
                IsDone = false,
                TaskDate = DateTime.Now,
            });
            OngoingTasks.Add(new TaskDataModel
            {
                ImageSource = "undone",
                TaskDescription = "This is the task you will perform at this time",
                TaskName = "Task 6",
                IsDone = false,
                TaskDate = DateTime.Now,
            });
            OngoingTasks.Add(new TaskDataModel
            {
                ImageSource = "undone",
                TaskDescription = "This is the task you will perform at this time",
                TaskName = "Task 7",
                IsDone = false,
                TaskDate = DateTime.Now,
            });
            OngoingTasks.Add(new TaskDataModel
            {
                ImageSource = "undone",
                TaskDescription = "This is the task you will perform at this time",
                TaskName = "Task 8",
                IsDone = false,
                TaskDate = DateTime.Now,
            });
            OngoingTasks.Add(new TaskDataModel
            {
                ImageSource = "undone",
                TaskDescription = "This is the task you will perform at this time",
                TaskName = "Task 9",
                IsDone = false,
                TaskDate = DateTime.Now,
            });
            OngoingTasks.Add(new TaskDataModel
            {
                ImageSource = "undone",
                TaskDescription = "This is the task you will perform at this time",
                TaskName = "Task 10",
                IsDone = false,
                TaskDate = DateTime.Now,
            });
        }
    }
}