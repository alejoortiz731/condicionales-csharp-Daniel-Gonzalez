using System;

char letra = 'e';
char letraMinuscula = char.ToLower(letra);
string resultado;

if (!char.IsLetter(letra))
{
    resultado = "No es una letra";
}
else if ("aeiou".Contains(letraMinuscula))
{
    resultado = "Es vocal";
}
else
{
    resultado = "Es consonante";
}

Console.WriteLine($"'{letra}' → {resultado}");