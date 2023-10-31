# WPFSplashScreen

This class library can be used to display a splash screen before the start of a WPF a application.
Currently only .NET 7 or higher is supported.

- <a href="https://www.nuget.org/packages/WPFSplashScreen">NuGet Package</a>

# TLDR: How to use it
1. Download the latest version of this library
`NuGet\Install-Package WPFSplashScreen`
3. Create a window which you want to be your splash screen (I recommend styling the window a bit, see <a href="https://github.com/corvinszimion/WPFSplashScreenDemo">WPFSplashScreenDemo</a> for reference)
4. Set the `StartupUri` in the `App.xaml` to your splash screen
5. Override the `OnStartup` method in your `App.xaml`'s code behind
6. Create `SplashScreenSettings`
```csharp
var settings = new SplashScreenSettings(TimeSpan.FromSeconds(5), new CustomSplashScreenA(), new MainWindow());
```
7. Call the `UseSplashScreen` extension method passing in the `SplashScreensettings`
```csharp
protected override void OnStartup(StartupEventArgs e)
{
	base.OnStartup(e);

	var settings = new SplashScreenSettings(TimeSpan.FromSeconds(5), new CustomSplashScreenA(), new MainWindow());
	this.UseSplashScreen(settings);
}
```
9. Done
