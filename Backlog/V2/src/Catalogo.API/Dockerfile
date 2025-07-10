FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app

COPY Catalogo.API.csproj ./Catalogo.API/
RUN dotnet restore ./Catalogo.API/Catalogo.API.csproj

COPY . ./Catalogo.API/
WORKDIR /app/Catalogo.API
RUN dotnet publish -c Release -o /out

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime
WORKDIR /app
COPY --from=build /out ./
ENTRYPOINT ["dotnet", "Catalogo.API.dll"]

