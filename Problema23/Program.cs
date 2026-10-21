using System;

string usuario = "aprendiz";
string clave = "Sena2026";

if (usuario != "aprendiz")
{
    Console.WriteLine("Usuario no encontrado");
}
else if (clave != "Sena2026")
{
    Console.WriteLine("Contraseña incorrecta");
}
else
{
    Console.WriteLine("Bienvenido");
}