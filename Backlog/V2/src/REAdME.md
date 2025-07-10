# Microsservices

## Resources:

### Microsservice: Catalog.API:

- .NET 
- Logging
- Swagger
- JWT
- Auth
- Validators
- MongoDB
- Docker 

### Microsservice: Basket.API:

- .NET 
- Swagger
- JWT
- Auth
- Redis
- Docker

### Microsservice: Discount.API:

- .NET
- Swagger
- JWT
- Auth
- PostgreSQL
- Docker

### Microsservice: Discount.Grpc

- .NET
- Auth
- PostgreSQL
- gRPC: Google Remote Procedure Call
- Docker

### (Next Stage):

- Order.API
- Payment.API
- Notification.API
- Delivery.API
- Customers.API




dotnet new sln -n Microsservices 

dotnet new webapi -o Project.API --no-https  
dotnet new grpc -n GrpcServiceExample

dotnet sln Microsservices.sln add Project.API/Project.API.csproj
