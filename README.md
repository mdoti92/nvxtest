# nvxtest
Ejercicio práctico de NVX Software

## Herramientas utiliadas
- IDE: Rider de JetBrains
- .NET 8

## Conceptos buscados
- Instalación Swagger para .NET 8
- Configurar endpoint en la Api Minimal de .NET 8
- Nombre y versión a usar en NuGet de MsTest

## Decisiones
- Se creo una Api para disponibilizar dos endpoints aparte del Hello Word por defecto, un endpoint para encriptar y otro para desencriptar
- Se creo un proyecto Core que es el responsable de las reglas de negocio
- Se crearon tres proyectos mas uno por cada algoritmo a ejecutar, esto hace que si mañana un algoritmo se modifica no es necesario cambiar todo.
- Se asume que el ciclo de las vocales era tanto para minúsculas como mayúsculas.

## Tiempos
- Setup (1 hora)
	- Crear repositorio
	- Instalar .NET 8
	- Crear solución
	- Instalar Swagger
	- Probar
- Desarrollo (4 horas)
	- Implementación de UnitTest en Core
	- Refactor de todos los metodos
	- Extracción de algoritmos a otros proyectos
	- Extracción de Tests a otros proyectos