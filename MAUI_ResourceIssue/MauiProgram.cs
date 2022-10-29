using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using System;

namespace MauiAppResourceIssue000;

public static class MauiProgram
{
    public static IServiceProvider ServiceProvider => serviceProvider;

    static IServiceProvider serviceProvider;

    public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddTransient<MainPage>();

        var app = builder.Build();
        serviceProvider = app.Services;

        return app;
    }
}
