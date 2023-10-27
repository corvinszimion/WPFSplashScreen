using System;
using System.Windows.Threading;
using System.Windows;

namespace WPFSplashScreen;

public class SplashScreenSettings
{
	private DispatcherTimer _timer;

	internal event EventHandler<SplashScreenSettings> DisplayDurationElapsed;
	public SplashScreenSettings(TimeSpan displayDuration, Window splashScreen, Window mainWindow)
	{
		DisplayDuration = displayDuration;
		SplashScreen = splashScreen;
		MainWindow = mainWindow;

		_timer = new DispatcherTimer();
		_timer.Interval = displayDuration;
		_timer.Tick += _timer_Tick;

		splashScreen.Show();
		_timer.Start();
	}
	public TimeSpan DisplayDuration { get; }
	public Window SplashScreen { get; }
	public Window MainWindow { get; }
	private void _timer_Tick(object sender, EventArgs e)
	{
		DisplayDurationElapsed?.Invoke(this, this);
	}
}
