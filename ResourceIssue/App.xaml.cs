using Microsoft.Maui.Controls;

namespace MauiAppResourceIssue000;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
