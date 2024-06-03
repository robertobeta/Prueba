# Utiliza la imagen de SDK de .NET 6 para compilar y construir la aplicación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Establecer la variable de entorno para el modo de desarrollo
ENV ASPNETCORE_ENVIRONMENT=Development

# Copia csproj y restaura las dependencias
COPY *.csproj ./
RUN dotnet restore

# Copia los archivos del proyecto y construye la aplicación
COPY . ./
RUN dotnet publish -c Release -o out

# Genera la imagen final
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/out .

# Configura el comando para ejecutar la aplicación
ENTRYPOINT ["dotnet", "SISPO-API.dll"]
