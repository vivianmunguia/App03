static void func1(int arg1, int arg2)
{
    string resultado = (arg1 + arg2).ToString();
    Console.WriteLine(resultado);
}

static void func2(int arg1, int arg2)
{
    string resultado = (arg1 * arg2).ToString();
    Console.WriteLine(resultado);
}

MiDelegado f1 = func1;
MiDelegado f2 = func2;

MiDelegado f1f2 = f1 + f2;
int arg1 = 10;
int arg2 = 20;

Console.WriteLine("Se está ejecutando el primer delegate");
f1(arg1, arg2);

Console.WriteLine("Se está ejecutando el segundo delegate");
f2(arg1, arg2);

Console.WriteLine("Se están ejecutando el primer y segundo delegate al mismo tiempo");
f1f2(arg1, arg2);

//f1f2 = f1f2 - f2;
f1f2 -= f2;
Console.WriteLine("Ejecutando la concatenacion pero sin el f2");
f1f2(arg1, arg2);

public delegate void MiDelegado(int arg1, int arg2);