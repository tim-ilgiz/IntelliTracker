#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-alpine AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine AS build
WORKDIR /src
COPY ["AuthService/WebApi/AuthServer.csproj", "AuthService/WebApi/"]
COPY ["AuthService/Infrastructure/Infrastructure.csproj", "AuthService/Infrastructure/"]
COPY ["AuthService/Service/Service.csproj", "AuthService/Service/"]
COPY ["AuthService/Persistence/Persistence.csproj", "AuthService/Persistence/"]
COPY ["AuthService/Domain/Domain.csproj", "AuthService/Domain/"]
RUN dotnet restore "AuthService/WebApi/AuthServer.csproj"
COPY . .
WORKDIR "/src/AuthService/WebApi"
RUN dotnet build "AuthServer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AuthServer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AuthServer.dll"]