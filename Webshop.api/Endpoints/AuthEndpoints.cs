using System;

namespace Webshop.api.Endpoints;

public static class AuthEndpoints
{
    public static void MapAuthEndpoints(this WebApplication app)
    {
        app.MapPost("/auth/register", () => {});
        app.MapPost("/auth/login", () => {});
        app.MapGet("/auth/profile", () => {});
    }
}
