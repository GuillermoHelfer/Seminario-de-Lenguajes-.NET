for (Meses m = Meses.Diciembre; m >= Meses.Enero; m--)
{
    Console.WriteLine(m);
}

Console.WriteLine("ingrese un texto");
string key = Console.ReadLine();


Boolean includes = false;
for (Meses m = Meses.Diciembre; m >= Meses.Enero; m--)
{
    if(m.ToString() == key)
        includes = true;
}

Console.WriteLine("incluye = " + includes);
Console.ReadKey(true);

enum Meses {
    Enero, Febrero, Marzo, Abril, Mayo, Junio,
    Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre
}