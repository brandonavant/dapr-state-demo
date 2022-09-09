# Build Image
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /source

COPY ["DaprStateDemo.Alpha.API/DaprStateDemo.Alpha.API.csproj", "DaprStateDemo.Alpha.API/"]
COPY ["DaprStateDemo.Alpha.sln", "./"]

RUN dotnet restore

COPY [".", "."]

RUN dotnet publish -c Debug -o /bin DaprStateDemo.Alpha.API/DaprStateDemo.Alpha.API.csproj

# Runtime Image
FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine
WORKDIR /app

COPY --from=build /bin .

ENV ASPNETCORE_ENVIRONMENT=Localhost
ENV ASPNETCORE_URLS=http://+:80

EXPOSE 80
ENTRYPOINT ["dotnet", "DaprStateDemo.Alpha.API.dll"]