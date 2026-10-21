using System;

object dato = "SENA"; // Prueba con 42, 3.14, true, etc.

string descripcion = dato switch
{
    string s => $"Texto de {s.Length} caracteres",
    int i => $"Entero: {i}",
    double d => $"Decimal: {d}",
    bool b => $"Booleano: {b}",
    _ => "Tipo no reconocido"
};

Console.WriteLine(descripcion); 