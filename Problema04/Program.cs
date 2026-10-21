using System;

int nivelBateria = 10; // Prueba con 10 u 80

if (nivelBateria < 15)
{
    Console.WriteLine("Batería baja: conecte el cargador");
}

Console.WriteLine($"Nivel actual: {nivelBateria} %");