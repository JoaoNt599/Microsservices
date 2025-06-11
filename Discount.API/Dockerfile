FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Discount.API/Discount.API.csproj", "Discount.API/"]
RUN dotnet restore "Discout.API/Discount.API.csproj"
COPY . .
WORKDIR "/src/Discount.API"
RUN dotnet build "Discount.API.csproj" -c Release -o /app/build

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Discount.API.dll"]