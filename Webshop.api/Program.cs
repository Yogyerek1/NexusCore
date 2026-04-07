using Webshop.api.Endpoints;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapAuthEndpoints();
app.MapProductsEndpoints();
app.MapCartEndpoints();
app.MapOrdersEndpoints();

app.Run();
