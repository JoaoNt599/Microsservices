FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app

COPY ../Basket.API/Basket.API.csproj ./Basket.API/
COPY ../Discount.Grpc/Discount.Grpc.csproj ./Discount.Grpc/

RUN dotnet restore ./Basket.API/Basket.API.csproj

COPY ../Basket.API ./Basket.API/
COPY ../Discount.Grpc ./Discount.Grpc/

WORKDIR /app/Basket.API
RUN dotnet publish -c Release -o /out

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime
WORKDIR /app
COPY --from=build /out ./
ENTRYPOINT ["dotnet", "Basket.API.dll"]
