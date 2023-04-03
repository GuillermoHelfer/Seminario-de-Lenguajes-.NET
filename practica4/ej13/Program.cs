string st, st1, st2, st3;

st = Console.ReadLine();
st1 = Console.ReadLine();
st2 = Console.ReadLine();
st3 = Console.ReadLine();
string st4 = Console.ReadLine();

if (st1 == null)
{
if (st2 == null)
{
st = st3;
}
else
{
st = st2;
}
}
else
{
st = st1;
}
if (st4 == null)
{
st4 = "valor por defecto";
}

st = st1 ?? st2 ?? st3;
st4 ??= "valor por defecto";