using App03;

var obj = new EventPublisher();
obj.valueChanged += delegate (string value)
{
    Console.WriteLine($"El valor de la propiedad cambió {value}");
};
//obj.valueChanged += new MiEventoHandler(obj_valueChanged);

//void obj_valueChanged(string value)
//{
//    Console.WriteLine($"El valor de la propiedad cambió {value}");
//}

string str;

do
{
    Console.WriteLine("Ingrese un valor");
    str = Console.ReadLine()!;
    if (!str.Equals("salir"))
    {
        obj.Val = str;
    }
} while (!str.Equals("salir"));

Console.WriteLine("Culminó el programa porque escribió 'Salir'");

public delegate void MiEventoHandler(string value);