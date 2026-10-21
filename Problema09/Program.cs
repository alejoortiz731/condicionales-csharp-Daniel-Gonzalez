using System;

int anio = 2024;
bool esBisiesto = (anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0);

Console.WriteLine($"{anio} → {(esBisiesto ? "Bisiesto" : "No bisiesto")}");