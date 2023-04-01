int? num = 0;
int? suma = 0;
Boolean valid = true;
while (num.HasValue)
{
    Console.WriteLine("ingrese un numero");
    try
    {
        num = int.Parse(Console.ReadLine());
        suma += num;
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message + "ingresar numeros solamente");
    }
    finally
    {
        Console.WriteLine("suma = " + suma);
    }
}

