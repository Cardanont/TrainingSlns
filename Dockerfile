FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

WORKDIR /src

COPY . .

WORKDIR /src/OptcgExplorer

RUN dotnet restore OptcgExplorer.Web/OptcgExplorer.Web.csproj

RUN dotnet publish OptcgExplorer.Web/OptcgExplorer.Web.csproj -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:10.0

WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 8080

ENV ASPNETCORE_URLS=http://+:8080

ENTRYPOINT ["dotnet", "OptcgExplorer.Web.dll"]