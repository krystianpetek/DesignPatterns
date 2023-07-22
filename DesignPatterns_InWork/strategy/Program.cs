using strategy.EventParsers;
using strategy.Interfaces;
using System.Reflection;

namespace strategy;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddSwaggerGen();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddControllers();

        //builder.Services.AddScoped<FirstParseStrategy>();
        //builder.Services.AddScoped<SecondParseStrategy>();
        //builder.Services.AddScoped<ThirdParseStrategy>();

        var assemblies = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(type => type.GetInterfaces().Any(i => i == typeof(IParseEventStrategy)))
            .ToList();

        assemblies.ForEach((Type type) =>
        {
            builder.Services.AddScoped(type);
        });        

        builder.Services.AddScoped<Func<IEvents,IParseEventStrategy>>(serviceProvider => (@event) =>
        {
            return @event switch
            {
                IEvents.FirstEvent => serviceProvider.GetRequiredService<FirstParseStrategy>(),
                IEvents.SecondEvent => serviceProvider.GetRequiredService<SecondParseStrategy>(),
                IEvents.ThirdEvent => serviceProvider.GetRequiredService<ThirdParseStrategy>(),
                _ => throw new NotImplementedException(),
            };
        });

        var app = builder.Build();
        app.UseSwagger();
        app.UseSwaggerUI();
        app.UseHttpsRedirection();
        app.MapControllers();

        app.Run();
    }
}
