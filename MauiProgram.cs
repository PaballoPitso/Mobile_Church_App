using Microsoft.Extensions.Logging;
using Syncfusion.Maui.PdfViewer;
using Syncfusion.Maui.Core.Hosting;

namespace projectChurch;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
        builder
           .UseMauiApp<App>()
           .ConfigureFonts(fonts =>
           {
               fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
               fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansbold");
           });

 

        return builder.Build();
    }
}
