int n;
int digito;

Console.WriteLine("Ingrese un numero entero");
n = int.Parse(Console.ReadLine()) * 365;

while (n > 0)
{
    digito = n % 10;
    Console.WriteLine(digito);
    n /= 10;
}

Console.ReadKey(true);