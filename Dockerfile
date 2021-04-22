#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["StockSystem.API/StockSystem.API.csproj", "StockSystem.API/"]
COPY ["StockSystem.Infra/StockSystem.Infra.csproj", "StockSystem.Infra/"]
COPY ["StockSystem.Domain/StockSystem.Domain.csproj", "StockSystem.Domain/"]
COPY ["StockSystem.Infra.Data/StockSystem.Infra.Data.csproj", "StockSystem.Infra.Data/"]
COPY ["StockSystem.Service/StockSystem.Service.csproj", "StockSystem.Service/"]
COPY ["StockSystem.Infra.Common/StockSystem.Infra.Common.csproj", "StockSystem.Infra.Common/"]
RUN dotnet restore "StockSystem.API/StockSystem.API.csproj"
COPY . .
WORKDIR "/src/StockSystem.API"
RUN dotnet build "StockSystem.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "StockSystem.API.csproj" -c Release -o /app/publish
COPY "StockSystem.API/StockSystem.API.xml" /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StockSystem.API.dll"]