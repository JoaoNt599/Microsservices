FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app

COPY ./Discount.API/Discount.API.csproj ./Discount.API/
RUN dotnet restore ./Discount.API/Discount.API.csproj

COPY ./Discount.API ./Discount.API/

WORKDIR /app/Discount.API
RUN dotnet publish -c Release -o /out

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime
WORKDIR /app
COPY --from=build /out ./
ENTRYPOINT ["dotnet", "Discount.API.dll"]

