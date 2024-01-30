        ConfigureServices((context, services) =>
        {
            // Views and ViewModels
//{[{
            services.AddTransient<SettingsViewModel>();
            services.AddTransient<SettingsPage>();
//}]}
