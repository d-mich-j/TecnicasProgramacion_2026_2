using SistemaGestionGimnasio.Modelo;
using SistemaGestionGimnasio.Servicios;
using SistemaGestionGimnasio.Gestores;

Console.WriteLine("Sistema de gestion de usuario");

//Crear usuario

Console.WriteLine("Ingresa el nombre del usuario:");
string nombreUsuario = Console.ReadLine() ??"";
Console.WriteLine("Ingresa la edad del usuario:");
int  edadUsuario = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Ingresa el objetivo del usuario:");
string objetivoUsuario = Console.ReadLine() ?? "";
Usuario usuario = new Usuario(nombreUsuario, edadUsuario, objetivoUsuario);

//Crear Entrenador

Console.WriteLine("Ingresa el nombre del entrenador:");
string nombreEntrenador = Console.ReadLine() ?? "";
Console.WriteLine("Ingresa la edad del entrenador:");
string  especialidadEntrenador = Console.ReadLine() ?? "";
Entrenador entrenador = new Entrenador (nombreEntrenador, especialidadEntrenador);

//Crear usuario

Console.WriteLine("Ingresa el nombre de la rutina:");
string nombreRutina = Console.ReadLine() ?? "";
Console.WriteLine("Ingresa la duracion de la rutina:");
int  duracionRutina = int.Parse(Console.ReadLine() ?? "");
Rutina rutina = new Rutina(nombreRutina, duracionRutina);

//Agregar ejercicios a rutina

Console.WriteLine("Cuantos ejercicios tendra la rutina:");






