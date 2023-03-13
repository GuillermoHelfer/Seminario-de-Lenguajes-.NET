String st;

Console.WriteLine("Ingrese una cadena");
st = Console.ReadLine();

Boolean coinciden = true;
int x = 0;
int y = st.Length - 1;

while (coinciden && x<y)
{
    coinciden = st[x].Equals(st[y]);
    x++;
    y--;
}

if (coinciden)
{
    Console.WriteLine("Es simetrica");
}
else
{
    Console.WriteLine("No es simetrica");
}

Console.ReadKey(true);