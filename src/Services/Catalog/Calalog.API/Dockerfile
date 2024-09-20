FROM mcr.microsoft.com/dotnet/aspnet:8.0-nanoserver-1809 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

ENV ASPNETCORE_URLS=http://+:8080

FROM mcr.microsoft.com/dotnet/sdk:8.0-nanoserver-1809 AS build
ARG configuration=Release
WORKDIR /src
COPY ["src/Services/Catalog/Calalog.API/Calalog.API.csproj", "src/Services/Catalog/Calalog.API/"]
RUN dotnet restore "src\Services\Catalog\Calalog.API\Calalog.API.csproj"
COPY . .
WORKDIR "/src/src/Services/Catalog/Calalog.API"
RUN dotnet build "Calalog.API.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "Calalog.API.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Calalog.API.dll"]
