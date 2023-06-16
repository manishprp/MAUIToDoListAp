namespace ToDoList_App;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
#if ANDROID
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderline", (h, v) =>
        {
            h.PlatformView.BackgroundTintList =
                Android.Content.Res.ColorStateList.ValueOf(Android.Graphics.Color.Transparent);
        });
#endif
        MainPage = new NavigationPage(ServiceHelper.GetService<LoginPage>());
    }
}