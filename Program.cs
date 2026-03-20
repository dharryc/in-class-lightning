var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "That should have failed!");

app.Run();
