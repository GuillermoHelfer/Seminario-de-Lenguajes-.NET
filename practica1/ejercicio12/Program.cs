int entero;

Console.WriteLine("Ingrese un numero entero");
entero = int.Parse(Console.ReadLine());
for(int i=entero; i>0; i--)
{
    if(entero % i == 0)
    {
        Console.WriteLine(i);
    }
}

Console.ReadKey(true);