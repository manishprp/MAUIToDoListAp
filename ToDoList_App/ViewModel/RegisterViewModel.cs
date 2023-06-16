using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ToDoList_App
{
    public partial class RegisterViewModel : BaseViewModel
    {
        private RegisterModel _registerModel;

        [ObservableProperty]
        private string _name;

        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _password;

        [ObservableProperty]
        private string _confirmPassword;

        public RegisterViewModel()
        {
            _registerModel = new RegisterModel();
        }

        [RelayCommand]
        private void Reset()
        {
            Name = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
            ConfirmPassword = string.Empty;
        }

        [RelayCommand]
        private async void Register()
        {
            _registerModel.Name = Name;
            _registerModel.Email = Email;
            _registerModel.Password = Password;
            _registerModel.ConfirmPassword = ConfirmPassword;
            var res = _registerModel.PerformAction();
            if (res.IsSuccess)
                MoveToNextPage(PageEnum.LoginPage);
            MakeToast(res.Message);
        }

        [RelayCommand]
        private async void Login()
        {
            MoveToNextPage(PageEnum.LoginPage);

        }
    }
}