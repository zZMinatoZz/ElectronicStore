FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG configuration=Release
WORKDIR /src
COPY ["Services/Catalog/Calalog.API/Calalog.API.csproj", "Services/Catalog/Calalog.API/"]
COPY ["BuildingBlocks/BuildingBlocks/BuildingBlocks.csproj", "/BuildingBlocks/BuildingBlocks/"]
RUN dotnet restore "./Services/Catalog/Calalog.API/./Calalog.API.csproj"
COPY . .
WORKDIR "/src/Services/Catalog/Calalog.API"
RUN dotnet build "./Calalog.API.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "./Calalog.API.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Calalog.API.dll"]
