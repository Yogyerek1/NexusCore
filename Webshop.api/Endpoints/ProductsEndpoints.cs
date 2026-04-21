using System;
using Webshop.api.Services;

namespace Webshop.api.Endpoints;

public static class ProductsEndpoints
{
    public static void MapProductsEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/products", (ProductService productService) => productService.GetProducts());
        app.MapGet("/products/{id}", (int id, ProductService productService) => productService.GetProduct());

        app.MapPost("/products", (ProductService productService) => productService.NewProduct())
            .RequireAuthorization("AdminLevel");

        app.MapPut("/products/{id}", (int id, ProductService productService) => productService.UpdateProduct())
            .RequireAuthorization("AdminLevel");

        app.MapDelete("/products/{id}", (int id, ProductService productService) => productService.DeleteProduct())
            .RequireAuthorization("AdminLevel");
    }
}
