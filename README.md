## Descripción
SQLiteConsoleApp es una aplicación de consola en C# que utiliza SQLite como base de datos. Esta aplicación fue desarrollada como parte de un ejercicio técnico y está contenerizada utilizando Docker y Docker Compose.

## Estructura de Ramas (GitFlow)
Este proyecto sigue la metodología GitFlow, lo que significa que se utiliza una estructura de ramas para organizar el desarrollo:

- **main**: Contiene la versión estable lista para producción.
- **develop**: Contiene el código en desarrollo.
- **feature/nueva-funcionalidad**: Rama para desarrollar nuevas funcionalidades.
- **release/v1.0**: Rama usada para preparar la versión 1.0.

## Requisitos Previos
Antes de ejecutar la aplicación, asegúrate de tener instalados los siguientes requisitos:

- [.NET SDK 8.0](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/get-started)
- [Docker Compose](https://docs.docker.com/compose/install/)

## Clonar el Repositorio
Primero, clona el repositorio a tu máquina local:

## Clonar el Repositorio
Primero, clona el repositorio a tu máquina local:

```
git clone https://github.com/Jesús1620/SQLiteConsoleApp.git
cd SQLiteConsoleApp
```



## Instalación y Ejecución
Usando Docker
Construye la imagen de Docker:
```
docker build -t sqliteconsoleapp .
```
## Ejecuta la aplicación usando Docker Compose:
```
docker-compose up
```
## Sin Docker
Restaura las dependencias y construye la aplicación:
```
dotnet restore
dotnet build
```

## Ejecuta la aplicación:
```
dotnet run
```

## Estructura del Proyecto
El proyecto contiene los siguientes directorios y archivos clave:

- /src: Código fuente de la aplicación.
- Dockerfile: Archivo de configuración para construir la imagen de Docker.
- docker-compose.yml: Archivo para orquestar la ejecución de contenedores.
- README.md: Documentación del proyecto.





