var builder = WebApplication.CreateBuilder(args);
//add services to container
 builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});
 
var app = builder.Build();

//configure http requuset pipeline
app.MapCarter();
app.Run();
                                         