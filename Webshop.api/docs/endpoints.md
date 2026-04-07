IDENTITY (auth):
 - POST /auth/register (Guest)
 - POST /auth/login (Guest)
 - GET /auth/profile (User/Admin)

PRODUCTS (Catalog):
 - GET /products (Guest/User/Admin)
 - GET /products/{id} (Guest/User/Admin)
 - POST /products (admin)
 - PUT /products/{id} (Admin)
 - DELETE /products/{id} (Admin)

CART (Shopping Cart):
 - GET /cart (Guest/User)
 - POST /cart/items (Guest/User)
 - DELETE /cart/items/{id} (Guest/user)

ORDERS & PAYMENTS (Checkout):
 - POST /orders/checkout (User)
 - GET /orders (Admin)