using System;

string comando = "play";

string mensaje = comando.ToLower() switch
{
    "play" => "Reproduciendo...",
    "pause" => "En pausa",
    "stop" => "Detenido",
    "next" => "Siguiente canción",
    _ => "Comando no reconocido"
};

Console.WriteLine(mensaje);