## Piedra, papel y tijeras

Este proyecto se trata del mismo.

Esta Kata esta pensada para convertir pruebas que se realizaron a mano a pruebas usando xUnit.

Se garantiza que el código funciona y las pruebas manuales son correctas. 

Tareas:

- Convertir las pruebas manuales a automáticas.

- Revisar el código fuente para ver si se puede refactorizar o mejorar. Por cada mejora se recomienda correr las pruebas para verificar que el código siga funcionando.

- Haz cambios en el código para que falle, revisa que las pruebas realizadas indiquen que fallo.

- Refactoriza las pruebas. Revisa la documentación de xUnit para ver si hay forma de hacer las mismas pruebas, pero con menos código.

## Comandos

### Correr el proyecto

Al correr el proyecto se observan las pruebas realizadas sin usar xUnit

``
dotnet run --project .\RockPaperScissors\RockPaperScissors.csproj
``

### Correr los test

Para correr los test realizados en xUnit.
Estas son las pruebas que se deben completar.

``
dotnet test --logger "console;verbosity=detailed"
``