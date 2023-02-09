using Example.API.Services;
using FastEndpoints;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddFastEndpoints();
builder.Services.AddScoped<IUserService, UserService>();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.UseAuthorization();
app.UseFastEndpoints();

app.Run();