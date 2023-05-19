var lista = new List<object> { "hola", 7, 'A' };
string st = Get<string>(lista, 0);
int i = Get<int>(lista, 1);
char c = Get<char>(lista, 2);
Console.WriteLine($"{st} {i} {c}");

T Get <T> (List<object> lo, int pos) where T: IComparable
{
    return (T)lo.ElementAt(pos);
}