using System;

double estatura = 1.45;
int edad = 10;
bool conAcompañante = true;

bool puedeSubir = (estatura >= 1.40 && edad >= 12) || (estatura >= 1.40 && conAcompañante);

Console.WriteLine($"Estatura {estatura}, edad {edad}, acompañante: {conAcompañante} → {(puedeSubir ? "Puede subir" : "No puede subir")}");