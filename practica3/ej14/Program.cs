using System.Text;

Stack<int> pila = new Stack<int>();

int aux = int.Parse(args[0]);
int cociente = int.MaxValue;

pila.Push(aux);
while (cociente >= 2)
{
    cociente = aux / 2;
    aux /= 2;
    pila.Push(cociente);
}

StringBuilder st = new StringBuilder();
while (pila.Count() != 0)
{
    st.Append((pila.Pop() % 2));
}

Console.WriteLine(st);

