namespace ToDoList_App;

public partial class LoginPage : ContentPage
{
    private LoginViewModel _loginViewModel;

    public LoginPage()
    {
        InitializeComponent();
        _loginViewModel = (LoginViewModel)BindingContext;
        _loginViewModel.MoveToNext += LoginViewModel_MoveToNext;
    }

    private async void LoginViewModel_MoveToNext(object sender, PageEnum e)
    {
        if (e == PageEnum.TodoTabbedPage)
            await Navigation.PushAsync(ServiceHelper.GetService<TodoTabbedPage>());
        else
            await Navigation.PushAsync(ServiceHelper.GetService<RegisterPage>());
        Navigation.RemovePage(this);

    }
}