var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;

string? url = configuration.GetValue<string>("ServerUrl");
if(url == null)
{
    Console.WriteLine("ServerUrl is not set in appsettings.json");
    return;
}
builder.WebHost.UseUrls(url);

var app = builder.Build();

app.MapControllers();

app.Run();