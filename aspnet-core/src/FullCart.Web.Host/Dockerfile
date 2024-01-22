FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/FullCart.Web.Host/FullCart.Web.Host.csproj", "src/FullCart.Web.Host/"]
COPY ["src/FullCart.Web.Core/FullCart.Web.Core.csproj", "src/FullCart.Web.Core/"]
COPY ["src/FullCart.Application/FullCart.Application.csproj", "src/FullCart.Application/"]
COPY ["src/FullCart.Core/FullCart.Core.csproj", "src/FullCart.Core/"]
COPY ["src/FullCart.EntityFrameworkCore/FullCart.EntityFrameworkCore.csproj", "src/FullCart.EntityFrameworkCore/"]
WORKDIR "/src/src/FullCart.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/FullCart.Web.Host", "src/FullCart.Web.Host"]
COPY ["src/FullCart.Web.Core", "src/FullCart.Web.Core"]
COPY ["src/FullCart.Application", "src/FullCart.Application"]
COPY ["src/FullCart.Core", "src/FullCart.Core"]
COPY ["src/FullCart.EntityFrameworkCore", "src/FullCart.EntityFrameworkCore"]
WORKDIR "/src/src/FullCart.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "FullCart.Web.Host.dll"]
