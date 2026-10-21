using System;

bool tieneEmpleo = true;
decimal ingreso = 3000000;
string resultado;

if (!tieneEmpleo)
{
    resultado = "Crédito rechazado";
}
else if (ingreso >= 2500000)
{
    resultado = "Crédito alto aprobado";
}
else
{
    resultado = "Crédito básico aprobado";
}

Console.WriteLine(resultado);