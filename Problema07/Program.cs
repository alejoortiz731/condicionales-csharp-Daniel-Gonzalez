using System;

int numero = -5;

string signo = numero > 0 ? "Positivo" : (numero < 0 ? "Negativo" : "Cero");
Console.WriteLine($"{numero} → {signo}");