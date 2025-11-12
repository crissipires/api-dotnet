# Base runtime .NET Core 3.1
FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Imagem de build .NET Core 3.1
FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copia apenas o csproj e restaura dependências
COPY ["heroku.api/heroku.api.csproj", "heroku.api/"]
RUN dotnet restore "./heroku.api/heroku.api.csproj"

# Copia o restante do código e faz o build
COPY . .
RUN dotnet build "heroku.api/heroku.api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "heroku.api/heroku.api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Runtime final
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "heroku.api.dll"]
