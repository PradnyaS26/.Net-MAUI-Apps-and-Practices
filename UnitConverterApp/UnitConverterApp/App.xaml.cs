﻿namespace UnitConverterApp;
using UnitConverterApp.MVVM.Views;
public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MenuView());
	}
}

