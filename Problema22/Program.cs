using System;

int numero1 = 12;
int numero2 = 0;
char operador = '/';

if (operador == '+')
{
    int resultado = numero1 + numero2;
    Console.WriteLine($"{numero1} + {numero2} = {resultado}");
}
else if (operador == '-')
{
    int resultado = numero1 - numero2;
    Console.WriteLine($"{numero1} - {numero2} = {resultado}");
}
else if (operador == '*')
{
    int resultado = numero1 * numero2;
    Console.WriteLine($"{numero1} * {numero2} = {resultado}");
}
else if (operador == '/')
{
    if (numero2 == 0)
    {
        Console.WriteLine("No se puede dividir entre cero");
    }
    else
    {
        double resultado = (double)numero1 / numero2;
        Console.WriteLine($"{numero1} / {numero2} = {resultado}");
    }
}
else
{
    Console.WriteLine("Operador no soportado");
}