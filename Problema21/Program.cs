using System;

int cantidad = 3;
string mensaje = $"Tienes {cantidad} {(cantidad == 1 ? "articulo" : "articulos")} en tu carrito.";

Console.WriteLine(mensaje);