# GraphQL2-API
Este repositorio contiene una API GraphQL llamada GraphQL2, que ofrece consultas para obtener información sobre series específicas, todas las series disponibles y detalles sobre plataformas de streaming.
# Estructura del Proyecto
El proyecto está organizado de la siguiente manera:

* GraphAPI: Esta carpeta contiene los archivos relacionados con la configuración y la lógica de la API GraphQL.
* GraphAPI.csproj: Archivo de proyecto de la API GraphQL2, que define las dependencias y la configuración del proyecto.
* Queries: Esta carpeta contiene las consultas GraphQL y sus correspondientes resolvers.
  * SerieQuery.cs: Archivo que define las consultas GraphQL relacionadas con las series de televisión.
* Models: Esta carpeta contiene las clases de modelo utilizadas para representar los datos de las series y las plataformas de streaming.
  * Platform.cs: Clase que define la estructura de una plataforma de streaming.
  * Serie.cs: Clase que define la estructura de una serie de televisión.

# Funcionalidades
La API GraphQL2 proporciona las siguientes funcionalidades:

* Obtener Serie por ID: Permite recuperar información detallada sobre una serie de televisión específica proporcionando su ID.
* Obtener Todas las Series: Devuelve una lista de todas las series de televisión disponibles, junto con detalles como el nombre, la fecha de lanzamiento y las plataformas de streaming asociadas.
