# Microsservices

## Resources:

### Microsservice: Catalog.API:

- .NET 5
- JWT
- Auth
- MongoDB
- Docker 

### Microsservice: Basket.API:

- .NET 5
- JWT
- Auth
- Redis
- Docker


dotnet new sln -n Microsservices 
dotnet new webapi -o Catalogo.API --no-https  
dotnet sln Microsservices.sln add Projeto.API/Projeto.API.csproj

dotnet add package MongoDB.Driver
dotnet list package