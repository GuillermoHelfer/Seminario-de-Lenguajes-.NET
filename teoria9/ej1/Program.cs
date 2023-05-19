int a = 17;
int b = 23;
Swap<int>(ref a, ref b);
Console.WriteLine($"a={a} y b={b}");
string st1 = "hola";
string st2 = "mundo";
Swap<String>(ref st1, ref st2);


void Swap<T> (ref T a, ref T b)
{
    T aux;
    aux = a;
    a = b;
    b = aux;
}