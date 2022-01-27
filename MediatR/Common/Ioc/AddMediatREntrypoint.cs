namespace Common.Ioc;
public static class AddMediatREntrypoint
{
    public static IServiceCollection AddMediatRServiceCollection(this IServiceCollection service)
    {
        service.AddSingleton<IDataAccess, DataAccess>();
        service.AddMediatR(typeof(MediatREntrypoint).Assembly);
        return service;
    }
}
