﻿MiDelegado d1 = (x) => x * x;
Console.WriteLine($"El resultado es {d1(5)}");

d1 = (x) => x * 10;
Console.WriteLine($"El resultado de multiplicar por 10 {d1(7)}");

MiDelegado2 d2 = (x, y) =>
{
    Console.WriteLine($"Imprimiendo el valor de {x}");
    Console.WriteLine($"Imprimiendo el valor de {y}");
};

BooleanoDelegado d3 = (x) => x > 10;
Console.WriteLine($"El resultado si el numero es mayor que 10 {d3(11)}");
Console.WriteLine($"El resultado si el numero es menor que 10 {d3(7)}");

public delegate int MiDelegado(int x);
public delegate void MiDelegado2(int x, string s);
public delegate bool BooleanoDelegado(int x);