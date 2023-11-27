FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["NVXTest.Api/NVXTest.Api.csproj", "NVXTest.Api/"]
RUN dotnet restore "NVXTest.Api/NVXTest.Api.csproj"
COPY . .
WORKDIR "/src/NVXTest.Api"
RUN dotnet build "NVXTest.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NVXTest.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NVXTest.Api.dll"]
