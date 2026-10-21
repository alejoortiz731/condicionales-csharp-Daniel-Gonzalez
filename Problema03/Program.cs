using System;

int opcion = 2; // Prueba con 1, 2, 3, 4 o 9

switch (opcion)
{
    case 1:
        Console.WriteLine("Entrada: 1 → Ha seleccionado: Consultar saldo");
        break;
    case 2:
        Console.WriteLine("Entrada: 2 → Ha seleccionado: Retirar");
        break;
    case 3:
        Console.WriteLine("Entrada: 3 → Ha seleccionado: Depositar");
        break;
    case 4:
        Console.WriteLine("Entrada: 4 → Ha seleccionado: Salir");
        break;
    default:
        Console.WriteLine($"Entrada: {opcion} → Opción no válida");
        break;
}