# Build Image
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /source

COPY ["DaprStateDemo.Beta.API/DaprStateDemo.Beta.API.csproj", "DaprStateDemo.Beta.API/"]
COPY ["DaprStateDemo.Beta.sln", "./"]

RUN dotnet restore

COPY [".", "."]

RUN dotnet publish -c Debug -o /bin DaprStateDemo.Beta.API/DaprStateDemo.Beta.API.csproj

# Runtime Image
FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine
WORKDIR /app

COPY --from=build /bin .

ENV ASPNETCORE_ENVIRONMENT=Localhost
ENV ASPNETCORE_URLS=http://+:80

EXPOSE 80
ENTRYPOINT ["dotnet", "DaprStateDemo.Beta.API.dll"]