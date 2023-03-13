int a;
int b;

a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());

if ((b != 0) && (a/b > 5))
{
    Console.WriteLine(a/b);
}

Console.ReadKey(true);