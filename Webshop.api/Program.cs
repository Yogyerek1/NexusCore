using Webshop.api.Endpoints;
using Webshop.api.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<AuthService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapAuthEndpoints();
app.MapProductsEndpoints();
app.MapCartEndpoints();
app.MapOrdersEndpoints();

app.Run();
