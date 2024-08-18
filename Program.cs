using App03;

var obj = new EventPublisher();
obj.valueChanged += delegate (string value)
{
    Console.WriteLine($"Se está disparando el evento handler 1{value}");
};

obj.valueChanged += new MiEventoHandler(obj_valueChanged1);
obj.valueChanged += new MiEventoHandler(obj_valueChanged2);

obj.miEvento += delegate (object sender, MiEventoArgs e)
{
    Console.WriteLine($"{sender.GetType()} la propiedad valor que cambió es {e.data}");
};

void obj_valueChanged1(string value)
{
    Console.WriteLine($"Se está disparando el evento handler 2 {value}");
}
void obj_valueChanged2(string value)
{
    Console.WriteLine($"Se está disparando el evento handler 3 {value}");
}

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