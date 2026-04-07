using Webshop.api.Endpoints;
using Webshop.api.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<AuthService>();
var app = builder.Build();

app.MapAuthEndpoints();
app.MapProductsEndpoints();
app.MapCartEndpoints();
app.MapOrdersEndpoints();

app.Run();
