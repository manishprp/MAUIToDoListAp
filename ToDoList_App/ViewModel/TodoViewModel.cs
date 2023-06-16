using CommunityToolkit.Maui.Core.Extensions;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mopups.Services;
using System;
using System.Collections.ObjectModel;

namespace ToDoList_App
{
    public partial class TodoViewModel : BaseViewModel
    {
        [ObservableProperty]
        private ObservableCollection<TaskDataModel> _tasks;

        public TaskDataModel TaskDataModelToView { get; set; }

        public event EventHandler AddNewTask;

        private TodoModel _todoModel;

        public TodoViewModel(TodoModel todoModel)
        {
            _todoModel = todoModel;

            GetData();
        }

        private async void GetData()
        {
            var res = await _todoModel.performAction();
            if (res.IsSuccess)
                Tasks = _todoModel.TaskDataList.ToObservableCollection();
            MakeToast(res.Message);
        }

        [RelayCommand]
        private void Check(object item)
        {
            TaskDataModel model = (TaskDataModel)item;
            model.IsDone = !model.IsDone;
        }

        [RelayCommand]
        private async void ViewTask(object taask)
        {
            TaskDataModelToView = (TaskDataModel)taask;
            await MopupService.Instance.PushAsync(new AddNewTaskPage(TaskDataModelToView));
        }

        [RelayCommand]
        private async void AddTask()
        {
            await MopupService.Instance.PushAsync(new AddNewTaskPage(null));
        }
    }
}