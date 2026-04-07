using System;

namespace Webshop.api.Endpoints;

public static class OrdersEndpoints
{
    public static void MapOrdersEndpoints(this WebApplication app)
    {
        app.MapPost("/orders/checkout", () => {});
        app.MapGet("/orders", () => {});
    }
}
