using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using System;

namespace MauiAppResourceIssue000;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		button0.Text = (string)Application.Current.Resources["TextInResources"]; // <-- work as expected
		button0.BackgroundColor = (Color)Application.Current.Resources["Yellow100Accent"]; // <-- throw an exception, KeyNotFound
	}
}

