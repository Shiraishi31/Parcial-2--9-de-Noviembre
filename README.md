# Parcial #3 — Herramientas de la Programación Aplicada III (.NET)

Universidad Tecnológica de Panamá · Facultad de Ingeniería en Sistemas Computacionales · Grupo 1IL133

Tres proyectos de consola en C# (.NET 10) dentro de una sola solución, `Parcial_3.slnx`.
Para correr uno: clic derecho en el proyecto → **Establecer como proyecto de inicio** → F5.

| Proyecto | Punto | Qué contiene |
| --- | --- | --- |
| `Punto1_Figuras` | 1 | Clase abstracta `Figura`, clases `Rectangulo`, `Cuadrado`, `Triangulo`, arreglo `Figura[]` y recorrido polimórfico |
| `Punto2_Json` | 2 | Serialización de un objeto a JSON con Newtonsoft.Json |
| `Punto3_LoginBCrypt` | 3 | Login con BCrypt.Net-Next y MySQL: registro (hash), inicio de sesión (`BCrypt.Verify`) e historial de intentos |
| `BaseDeDatos/` | 3 | Scripts de MySQL y el backup de la base |

## Cómo probar el punto 3

1. En MySQL Workbench restaura el backup: Server → Data Import → Import from Self-Contained File →
   `BaseDeDatos/LoginBCryptDB_backup.sql` → Start Import.
   (O ejecuta `BaseDeDatos/01_CrearBaseDeDatos.sql` para crear la base vacía.)
2. Ejecuta `BaseDeDatos/03_CrearUsuarioParcial.sql` (crea el usuario `parcial` que usa el programa).
3. En Visual Studio, establece `Punto3_LoginBCrypt` como proyecto de inicio y presiona F5.

Usuario de prueba: **admin** / **Admin123\***
