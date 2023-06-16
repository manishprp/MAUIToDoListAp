using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Runtime.CompilerServices;

namespace ToDoList_App
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool _isNotBusy;

        private bool _isBusy;

        public bool IsBusy
        {
            get { return _isBusy; }
            set { _isBusy = value; IsNotBusy = !IsBusy; }
        }

        public void MakeToast(string message)
        {
            Toast.Make(message, CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
        }

        public event EventHandler<PageEnum> MoveToNext;

        public void MoveToNextPage(PageEnum enu)
        {
            MoveToNext?.Invoke(this, enu);
        }
    }
}