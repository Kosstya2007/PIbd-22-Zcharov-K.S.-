using Autofac;
using Pibd_22_Zacharov.K.S_OTP;


namespace Pibd_22_Zacharov.K.S_OTP;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();

        var container = ContainerConfigurator.Configure();
        using var scope = container.BeginLifetimeScope();

        Application.Run(scope.Resolve<MainForm>());
    }
}