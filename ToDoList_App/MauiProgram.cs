using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Mopups.Hosting;
using Mopups.Interfaces;
using Mopups.Services;

namespace ToDoList_App;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureMopups()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        #region Views

        builder.Services.AddTransient<TodoMainPage>();
        builder.Services.AddTransient<TodoTabbedPage>();
        builder.Services.AddTransient<AddNewTaskPage>();
        builder.Services.AddTransient<LoginPage>();
        builder.Services.AddTransient<RegisterPage>();

        #endregion Views

        #region ViewModels

        builder.Services.AddTransient<TodoViewModel>();
        builder.Services.AddTransient<AddNewTaskViewModelb>();
        builder.Services.AddTransient<LoginViewModel>();
        builder.Services.AddTransient<OngoingTasksViewModel>();
        builder.Services.AddTransient<RegisterViewModel>();
        builder.Services.AddTransient<TodoViewModel>();

        #endregion ViewModels

        #region Models

        builder.Services.AddTransient<AddNewTaskModel>();
        builder.Services.AddTransient<LoginModel>();
        builder.Services.AddTransient<OngoingTasksModel>();
        builder.Services.AddTransient<RegisterModel>();
        builder.Services.AddTransient<TodoModel>();

        #endregion Models

        #region OtherUsefulClassesDependencies

        builder.Services.AddSingleton<IPopupNavigation>(MopupService.Instance);
        builder.Services.AddSingleton<ToDoListAppDatabase>();
        builder.Services.AddSingleton<TodoStartedRepo>();
        builder.Services.AddSingleton<NavigationPage>();

        #endregion OtherUsefulClassesDependencies

        var app = builder.Build();
        ServiceHelper.Initialize(app.Services);
        return app;
    }
}