﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Numeros positivos");
Console.WriteLine();

/*
 Leer un numero entero positivo y cuando sea negativo, el bucle debe parar.
Mostrar un mensaje que diga que ha introducido un numero negativo.
 */

int numero;

Console.Write("Introduzca un numero entero positivo: ");
numero=int.Parse(Console.ReadLine());

while(numero > 0)
{
    Console.Write("Introduzca un numero entero positivo: ");
    numero = int.Parse(Console.ReadLine());

}

Console.WriteLine("Ha introducido un numero negativo.");