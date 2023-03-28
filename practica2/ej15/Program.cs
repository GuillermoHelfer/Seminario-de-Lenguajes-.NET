using System.Net;
int Fib(int n)
{
    if (n == 0)
        return 0;
    if (n <= 2)
        return 1;
    return Fib(n-1) + Fib (n-2);
}

Console.WriteLine("ingrese un numero n para calcular su termino fibonacci");
int key = int.Parse(Console.ReadLine());

Console.WriteLine("el termino fibonacci de: " + key + "es = " + Fib(key));