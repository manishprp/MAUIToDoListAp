namespace ToDoList_App;

public partial class RegisterPage : ContentPage
{
    private RegisterViewModel _registerViewModel;

    public RegisterPage()
    {
        InitializeComponent();
        _registerViewModel = (RegisterViewModel)BindingContext;
        _registerViewModel.MoveToNext += RegisterViewModel_MoveToNext;
    }

    private async void RegisterViewModel_MoveToNext(object sender, PageEnum e)
    {
        if (e == PageEnum.LoginPage)
            await Navigation.PushAsync(ServiceHelper.GetService<LoginPage>());
        Navigation.RemovePage(this);
    }
}