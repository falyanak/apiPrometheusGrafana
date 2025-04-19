# Utilise l’image SDK dès le départ
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS dev
WORKDIR /app
EXPOSE 5000

COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o /app/publish

ENTRYPOINT ["dotnet", "/app/publish/PrometheusDemo.dll"]
