using Mopups.Services;

namespace ToDoList_App;

public partial class TodoMainPage : ContentPage
{
    private TodoViewModel _viewModel;

    public TodoMainPage()
    {
        InitializeComponent();

        //_viewModel = (TodoViewModel)
        BindingContext = App.Current.MainPage.Handler.MauiContext.Services.GetService<TodoViewModel>();
        _viewModel = (TodoViewModel)BindingContext;
        //_viewModel.AddNewTask += ViewModel_AddNewTask;
        //_viewModel.MoveToNext += ViewModel_MoveToNext;
    }

    //private async void ViewModel_MoveToNext(object sender, PageEnum e)
    //{
    //    if (e == PageEnum.ViewTask)
    //    {
    //        await MopupService.Instance.PushAsync(new AddNewTaskPage(_viewModel.TaskDataModelToView));
    //    }
    //}

    //private async void ViewModel_AddNewTask(object sender, EventArgs e)
    //{
    //    await MopupService.Instance.PushAsync(new AddNewTaskPage(null));
    //}
}