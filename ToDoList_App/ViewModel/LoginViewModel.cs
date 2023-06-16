using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ToDoList_App
{
    public partial class LoginViewModel : BaseViewModel
    {
        private LoginModel _loginModel;

        public LoginViewModel()
        {
            _loginModel = new LoginModel();
        }

        [ObservableProperty]
        private string _name;

        [ObservableProperty]
        private string _password;

        [RelayCommand]
        private void Reset()
        {
            Name = string.Empty;
            Password = string.Empty;
        }

        [RelayCommand]
        private async void Login()
        {
            _loginModel.Email = Name; _loginModel.Password = Password;
            var res = _loginModel.PerformAction();
            if (res.IsSuccess)
                MoveToNextPage(PageEnum.TodoTabbedPage);
            MakeToast(res.Message);
        }

        [RelayCommand]
        private async void Register()
        {
            MoveToNextPage(PageEnum.RegisterPage);
        }
    }
}