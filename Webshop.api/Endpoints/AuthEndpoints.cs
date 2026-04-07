using System;
using System.Runtime.CompilerServices;
using Webshop.api.Services;

namespace Webshop.api.Endpoints;

public static class AuthEndpoints
{
    public static void MapAuthEndpoints(this WebApplication app)
    {
        AuthService authService = new AuthService();
        app.MapPost("/auth/register", () => authService.Register());
        app.MapPost("/auth/login", () => authService.Login());
        app.MapGet("/auth/profile", () => authService.Profile());
    }
}
