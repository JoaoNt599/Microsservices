# 1 - Build
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY Microservice.csproj .
COPY . .
RUN dotnet publish -c release -o /app

# 2 - Runtime
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "Microservice.dll"]