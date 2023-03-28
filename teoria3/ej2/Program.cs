List<int> lista = new List<int>() { 10, 20, 30, 40 };
lista.Remove(30);
for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine(lista[i]);
}