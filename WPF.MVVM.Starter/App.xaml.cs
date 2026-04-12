using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Windows;
using WPF.MVVM.Starter.Infrastructure;
using WPF.MVVM.Starter.Infrastructure.Configuration;
using WPF.MVVM.Starter.Views;

namespace WPF.MVVM.Starter
{
    public partial class App : Application
    {
        private readonly IHost _host;

        public App()
        {
            RegisterGlobalExceptionHandlers();

            _host = Host.CreateDefaultBuilder()
                        .ConfigureServices((context, services) =>
                        {
                            services.AddConfiguration(context.Configuration);
                            services.AddApplicationServices();
                        }).Build();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            try
            {
                await _host.StartAsync();

                SetGlobalThemeMode(ThemeMode.System);

                var mainWindow = _host.Services.GetRequiredService<MainWindow>();
                mainWindow.Show();
            }
            catch (Exception ex)
            {
                LogException(ex, "App failed to start.");
                MessageBox.Show(ex.Message, ex.Source);
                Shutdown();
            }

            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            try
            {
                _host.StopAsync().GetAwaiter().GetResult();
            }
            finally
            {
                _host.Dispose();
            }

            base.OnExit(e);
        }

        private void RegisterGlobalExceptionHandlers()
        {
            // UI Thread (WPF)
            DispatcherUnhandledException += (s, e) =>
            {
                LogException(e.Exception, "An unhandled exception occurred.");
                e.Handled = true;
            };

            // Non-UI Threads (General .NET)
            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
            {
                LogException(e.ExceptionObject as Exception, "An AppDomain unhandled exception occurred.");
            };

            // Unawaited Tasks (Async)
            TaskScheduler.UnobservedTaskException += (s, e) =>
            {
                LogException(e.Exception, "An unobserved Task exception occurred.");
                e.SetObserved();
            };
        }

        private void LogException(Exception? ex = null, string? message = null)
        {
            if (_host == null)
            {
                Debug.WriteLine($"CRITICAL (No Host): {message} {ex}");
                return;
            }

            var logger = _host.Services.GetService<ILogger<App>>();
            logger?.LogCritical(ex, message);
        }

        private void SetGlobalThemeMode(ThemeMode themeMode)
        {
            Current.ThemeMode = themeMode;
        }
    }
}
