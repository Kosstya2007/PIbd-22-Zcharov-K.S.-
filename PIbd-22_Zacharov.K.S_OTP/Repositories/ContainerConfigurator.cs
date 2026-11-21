using Autofac;

namespace Pibd_22_Zacharov.K.S_OTP;

public static class ContainerConfigurator
{
    public static IContainer Configure()
    {
        var builder = new ContainerBuilder();

        RegisterRepositories(builder);
        RegisterForms(builder);

        return builder.Build();
    }

    private static void RegisterRepositories(ContainerBuilder builder)
    {
        builder.RegisterType<FlightRepositoryStub>()
            .As<IFlightRepository>()
            .SingleInstance();

        builder.RegisterType<AircraftRepositoryStub>()
            .As<IAircraftRepository>()
            .SingleInstance();

        builder.RegisterType<FlightOperationRepositoryStub>()
            .As<IFlightOperationRepository>()
            .SingleInstance();

        builder.RegisterType<DailySalesRepositoryStub>()
            .As<IDailySalesRepository>()
            .SingleInstance();
    }

    private static void RegisterForms(ContainerBuilder builder)
    {
        builder.RegisterType<MainForm>().AsSelf();
        builder.RegisterType<FlightEditForm>().AsSelf();
        builder.RegisterType<FlightOperationEditForm>().AsSelf();
        builder.RegisterType<DailySalesReportForm>().AsSelf();
    }
}