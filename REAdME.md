# Microsservices

## Resources:

### Microsservice: Catalog.API:

- .NET 
- Swagger
- JWT
- Auth
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




dotnet new sln -n Microsservices 

dotnet new webapi -o Catalogo.API --no-https  
dotnet new grpc -n GrpcServiceExample

dotnet sln Microsservices.sln add Projeto.API/Projeto.API.csproj
