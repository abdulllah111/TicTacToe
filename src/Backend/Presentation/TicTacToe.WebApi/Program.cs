using System.Reflection;
using TicTacToe.App;
using TicTacToe.App.Interfaces;
using TicTacToe.Persistense.Npsql;
using MediatR;

var builder = WebApplication.CreateBuilder(args);
RegisterServices(builder.Services);

using (var scope = builder.Services.BuildServiceProvider().CreateScope())
{
    var serviceProvider = scope.ServiceProvider;
    try
    {
        var context = serviceProvider.GetRequiredService<AppDbContext>();
        DbInitializer.Initialize(context);
    }
    catch (Exception ex)
    {
        throw ex;
    }
}

var app = builder.Build();

Configure(app);

app.MapGet("/", () => "Hello World!");


app.Run();


void RegisterServices(IServiceCollection services)
{
    services.AddApplication();
    services.AddPersistence(builder.Configuration);
    services.AddSwaggerGen();
    services.AddControllers();

    services.AddCors(option =>
    {
        option.AddPolicy("AllowAll", policy =>
        {
            policy.AllowAnyHeader();
            policy.AllowAnyMethod();
            policy.AllowAnyOrigin();
        });
    });
    
}

void Configure(WebApplication app)
{

    if (app.Environment.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }

    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseRouting();
    app.UseHttpsRedirection();
    app.UseCors("AllowAll");

    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
    });
}