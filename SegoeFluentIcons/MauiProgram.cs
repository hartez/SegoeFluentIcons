namespace SegoeFluentIcons;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Segoe Fluent Icons.ttf", "SegoeFluentIcons");
                fonts.AddFont("Segoe-UI-Variable-Static-Text.ttf", "Segoe");
            });

		return builder.Build();
	}
}
