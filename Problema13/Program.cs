using System;

string codigo = "CO";

string pais = codigo.ToUpper() switch
{
    "CO" => "Colombia",
    "MX" => "México",
    "AR" => "Argentina",
    "PE" => "Perú",
    "CL" => "Chile",
    _ => "País no registrado"
};

Console.WriteLine($"\"{codigo}\" → {pais}");