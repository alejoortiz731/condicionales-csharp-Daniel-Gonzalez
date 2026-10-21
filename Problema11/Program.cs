using System;

Semaforo estado = Semaforo.Rojo;

string instruccion = estado switch
{
    Semaforo.Rojo => "Deténgase",
    Semaforo.Amarillo => "Precaución, prepárese para detenerse",
    Semaforo.Verde => "Avance",
    _ => "Estado desconocido"
};

Console.WriteLine($"{estado} → {instruccion}");

enum Semaforo { Rojo, Amarillo, Verde }