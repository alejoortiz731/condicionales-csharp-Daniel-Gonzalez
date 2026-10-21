using System;

double peso = 70;
double estatura = 1.75;
double imc = peso / (estatura * estatura);

string categoria = imc switch
{
    < 18.5 => "Bajo peso",
    >= 18.5 and < 25 => "Peso normal",
    >= 25 and < 30 => "Sobrepeso",
    _ => "Obesidad"
};

Console.WriteLine($"IMC: {imc:F1} - {categoria}");