﻿using CommunityToolkit.Maui.Core;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

namespace ColorMaker
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder.UseMauiApp<App>().UseMauiCommunityToolkitCore().UseMauiCommunityToolkit();

            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });
            return builder.Build();
        }
    }
}