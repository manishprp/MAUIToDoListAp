using Mopups.Services;

namespace ToDoList_App;

public partial class AddNewTaskPage
{
    private AddNewTaskViewModelb _viewModel;

    public AddNewTaskPage(TaskDataModel taskDataModel)
    {
        InitializeComponent();
        _viewModel = new AddNewTaskViewModelb();
        BindingContext = _viewModel;
        _viewModel.TaskData = taskDataModel;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        MopupService.Instance.PopAsync();
    }
}