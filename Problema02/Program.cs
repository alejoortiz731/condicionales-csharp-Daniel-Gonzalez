using System;

double peso = 7; // Prueba con 0.5, 7, 25, -3
string tarifaTexto = "";

if (peso <= 0)
{
    tarifaTexto = "Peso inválido (Tarifa: $0)";
}
else if (peso < 1)
{
    tarifaTexto = "$8.000";
}
else if (peso < 5)
{
    tarifaTexto = "$15.000";
}
else if (peso < 20)
{
    tarifaTexto = "$32.000";
}
else
{
    tarifaTexto = "$60.000";
}

Console.WriteLine($"Peso: {peso} kg → Tarifa: {tarifaTexto}");