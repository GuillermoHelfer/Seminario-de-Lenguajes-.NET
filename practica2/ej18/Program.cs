
int a = 4;
int b = 3;
Console.WriteLine("A = " + a + ", B = " + b);
Swap(ref a,ref b);
Console.WriteLine("A = " + a + ", B = " + b);



void Swap (ref int a, ref int b)
{
    var i = a;
    a = b;
    b = i;
}