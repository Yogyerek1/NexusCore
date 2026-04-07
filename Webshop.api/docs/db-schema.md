Users:
 - Id
 - Username
 - Email
 - Password (hashed)
 - Role

Products:
 - Id
 - Name
 - Description
 - Price
 - StockQuantity
 - DiscountPercentage
 - PurchasePrice

Orders:
 - Id
 - UserId (foreign key with Users[id])
 - OrderDate
 - TotalAmount
 - Status

OrderItems:
 - Id
 - OrderId
 - ProductId
 - Quantity
 - Price