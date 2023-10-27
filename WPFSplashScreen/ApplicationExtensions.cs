using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFSplashScreen;

public static class ApplicationExtensions
{
	public static void UseSplashScreen(this Application application, SplashScreenSettings settings)
	{
		application.MainWindow = settings.MainWindow;
		settings.DisplayDurationElapsed += Settings_DisplayDurationElapsed;
	}

	private static void Settings_DisplayDurationElapsed(object? sender, SplashScreenSettings e)
	{
		e.SplashScreen.Close();
		e.MainWindow.Show();
	}
}
