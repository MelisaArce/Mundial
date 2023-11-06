# Fixture Digital de Torneo de Fútbol

Este es un proyecto de aplicación de escritorio desarrollado en C# que utiliza una base de datos en SQL Server. La aplicación simula el torneo mundial de futbol Qatar 2022 y calcula qué equipos pasan de fase en fase, desde grupos hasta la final, considerando diversas variables.

## Funcionalidades

La aplicación ofrece las siguientes funcionalidades:

- **Fase de Grupos:** Permite la creación de grupos y la asignación de equipos a cada grupo. Calcula los resultados de los partidos y determina los equipos clasificados a la siguiente fase.

- **Fases Eliminatorias:** Implementa rondas de eliminación directa desde los octavos de final hasta la final. Calcula los enfrentamientos basados en los resultados de la fase de grupos y determina los equipos que avanzan en cada etapa.

- **Variables Consideradas:** La aplicación tiene en cuenta diversos factores como puntajes, diferencia de goles, goles a favor, entre otros, para determinar qué equipos avanzan en cada fase.

## Requisitos de la Aplicación

Para ejecutar la aplicación, se requiere:

- **Entorno de Desarrollo Integrado (IDE):** Se recomienda Visual Studio o cualquier IDE compatible con C#.
- **Microsoft SQL Server:** Se necesita una instancia de SQL Server para la gestión y acceso a la base de datos.

## Configuración de la Base de Datos

La aplicación utiliza una base de datos en SQL Server para almacenar la información del torneo. Asegúrate de tener la base de datos correctamente configurada antes de ejecutar la aplicación.

1. **Creación de la Base de Datos:** Ejecutar el script SQL provisto (`script_creacion_base_datos.sql`) para crear la estructura de la base de datos y tablas necesarias.

2. **Conexión a la Base de Datos:** En la aplicación, configura la cadena de conexión en el archivo `app.config` para que la aplicación pueda acceder a la base de datos.

## Ejecución del Proyecto

1. Abre el proyecto en tu entorno de desarrollo.
2. Compila y ejecuta la aplicación.
3. Sigue las instrucciones proporcionadas por la interfaz de la aplicación para simular un torneo y ver los equipos que avanzan en cada fase.
