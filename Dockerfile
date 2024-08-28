# Fase de construcción
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copia el archivo .csproj y restaura dependencias
COPY SQLiteConsoleApp.csproj ./
RUN dotnet restore

# Copia el resto de los archivos y compila la aplicación
COPY . ./
RUN dotnet publish SQLiteConsoleApp.csproj -c Release -o out

# Fase de ejecución
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .

# Comando de entrada
ENTRYPOINT ["dotnet", "SQLiteConsoleApp.dll"]
