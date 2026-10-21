using System;

string jugador1 = "piedra";
string jugador2 = "papel";

string resultado = (jugador1, jugador2) switch
{
    ("piedra", "tijera") or ("tijera", "papel") or ("papel", "piedra") => "Gana el jugador 1",
    ("tijera", "piedra") or ("papel", "tijera") or ("piedra", "papel") => "Gana el jugador 2",
    _ when jugador1 == jugador2 => "Empate",
    _ => "Jugada inválida"
};

Console.WriteLine($"({jugador1}, {jugador2}) → {resultado}");